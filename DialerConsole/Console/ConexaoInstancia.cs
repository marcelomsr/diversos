using Dialer4COMLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Timers;
using System.Windows.Forms;

namespace Console
{
    class ConexaoInstancia
    {
        public delegate string AutenticacaoHandler();

        public delegate void DesconexaoHandler(ConexaoInstancia conexao);
        public event DesconexaoHandler AoDesconectar;

        static Dictionary<char, string> _atalhos = new Dictionary<char, string>
        {
            { 'A', "ajuda" },
            { 'C', "listar config" },
            { 'P', "listar pabx" },
            { 'S', "listar sessoes" },
            { 'V', "versao" }
        };

        private const int TENTATIVAS_RECONEXAO_AUTOMATICA = 60;

        private static int _conexao_id = 0;

        private int _id;
        private InstanciaItem _instancia;
        private string _nme_login;
        private bool _conectada;
        private RichTextBox _txt_comando;
        private RichTextBox _txt_resultado;
        private TabPage _tabpage;
        
        private string _nme_arquivo_comandos = "DialerConsole{0}.txt";

        private event AutenticacaoHandler _ao_autenticar_handler;

        private Dialer4COM _biblioteca;
        private bool _superadmin;

        private const int _QTD_MINUTOS_EXECUTAR_COMANDO_MANTER_CONEXAO = 3;
        System.Timers.Timer _timer_manter_conexao = new System.Timers.Timer();
        private static int _conexoes_abertas;

        public ConexaoInstancia(InstanciaItem instancia, bool superadmin, AutenticacaoHandler ao_autenticar_handler)
        {
            _id = ++_conexao_id;
            _instancia = instancia;
            _superadmin = superadmin;
            _ao_autenticar_handler = ao_autenticar_handler;

            _nme_arquivo_comandos = String.Format(_nme_arquivo_comandos, _instancia.id);

            conectar();

            criar_componentes();

            carregar_comandos_anteriores();

            _timer_manter_conexao.Interval = _QTD_MINUTOS_EXECUTAR_COMANDO_MANTER_CONEXAO * 60 * 1000;
            _timer_manter_conexao.Elapsed += _timer_manter_conexao_Elapsed;
            _timer_manter_conexao.Enabled = true;
            _timer_manter_conexao.Start();
        }

        public int id
        {
            get { return _id; }
        }

        public InstanciaItem instancia
        {
            get { return _instancia; }
        }

        public TabPage tabpage
        {
            get { return _tabpage; }
        }

        public bool conectada
        {
            get { return _conectada; }
        }

        public int obter_erro()
        {
            return _biblioteca.ObterCdgErro();
        }

        public string obter_descricao_erro()
        {
            return String.Format("{0} [{1}]", _biblioteca.ObterDscErro(), _biblioteca.ObterCdgErro());
        }

        public void alterar_instancia(InstanciaItem instancia)
        {
            if (_instancia == instancia)
                return;

            _instancia = instancia;

            definir_nome_aba();

            desconectar();
            conectar();
        }

        public void reconectar()
        {
            conectar();
        }

        private void conectar()
        {
            string caminho_log = 
                Configuracoes.Instance.registrar_log_dialer4COM ? System.IO.Path.Combine(Application.StartupPath, "log") : "";

            _biblioteca = new Dialer4COM(caminho_log);
            _biblioteca.AoDiscadorDesconectado += new DiscadorDesconectadoHandler(tratar_desconexao_instancia);

            if (_instancia.exigir_autenticacao)
            {
                _nme_login = _ao_autenticar_handler();

                if (_nme_login == null)
                    return;
            }

            if (_superadmin || !_instancia.exigir_autenticacao)
            {
                _conectada = _biblioteca.Conectar(_instancia.ip, _instancia.porta, "superadmin", "nimdarepus");
            }
            else
            {
                _conectada = _biblioteca.Conectar(_instancia.ip, _instancia.porta, _nme_login, "sesadmsystem");
            }
                        
            definir_situacao_txt_comando();
        }

        private void desconectar()
        {
            _conectada = !_biblioteca.Desconectar();

            _biblioteca.Dispose();

            definir_situacao_txt_comando();
        }

        private void carregar_comandos_anteriores()
        {
            try
            {
                _txt_comando.Text = File.ReadAllText(String.Format("{0}\\{1}", Path.GetTempPath(), _nme_arquivo_comandos));
            }
            catch (Exception) { }
        }

        private void tratar_desconexao_instancia()
        {
            _conectada = false;

            definir_situacao_txt_comando();

            tentar_reconectar();

            if (!_conectada && AoDesconectar != null)
                AoDesconectar(this);
        }

        private void tentar_reconectar()
        {
            int qtd_tentativas = 0;
            float intervalo_tempo_reconexao = 1;

            while (!_conectada && qtd_tentativas < TENTATIVAS_RECONEXAO_AUTOMATICA)
            {
                qtd_tentativas++;

                System.Threading.Thread.Sleep((int) intervalo_tempo_reconexao * 1000);
                conectar();

                // A cada nova tentativa frustrada de conexão, aumenta o intervalo para início da nova tentativa.
                intervalo_tempo_reconexao *= 1.05f;
            }
        }

        private void enviar_comando(string comando)
        {
            comando = comando.Trim();

            _txt_resultado.AppendText(String.Format("-----> {0} (executado às {1:T}) <-----\n\n", comando, DateTime.Now));

            DateTime inicio = DateTime.Now;

            bool resultado = _biblioteca.Comando_EnviarComandoConsole(comando);

            TimeSpan duracao = DateTime.Now - inicio;

            formatar_retorno( resultado );

            if (Configuracoes.Instance.medir_tempo_resposta)               
                _txt_resultado.AppendText(String.Format("Comando retornado em {0:00} ms.\n\n", duracao.TotalMilliseconds));

            // Move a barra de rolagem para o final do campo.
            _txt_resultado.ScrollToCaret();
        }

        private void formatar_retorno(bool resultado)
        {
            if (!resultado)
            {
                _txt_resultado.AppendText(String.Format("Erro: [{0}] {1}\n\n", _biblioteca.ObterCdgErro(), _biblioteca.ObterDscErro()));
                return;
            }

            // Se não tem lista de retorno...
            if (_biblioteca.Comando_ObterQtdColunas() == 0)
            {
                _txt_resultado.AppendText("Comando executado com sucesso.\n\n");
                return;
            }

            _biblioteca.Comando_lstPrimeiro();

            // Tamanho sugerido para alocação inicial de memória. Quanto mais próximo do tamanho final utilizado, mais rápido são as concatenações.
            int tamanho_sugerido = _biblioteca.Comando_ObterQtdLinhas() * _biblioteca.Comando_ObterQtdColunas() * 20;

            StringBuilder texto = new StringBuilder(tamanho_sugerido);

            // Cabeçalho
            int qtd_colunas = _biblioteca.Comando_ObterQtdColunas();

            int[] tamanho_colunas = new int[qtd_colunas];
            for (int i = 0; i < qtd_colunas; ++i)
            {
                string nme_coluna =
                    (!Configuracoes.Instance.mostrar_identificacao_colunas) ? _biblioteca.Comando_ObterDscColunaPeloNumero(i + 1) : _biblioteca.Comando_ObterNmeColunaPeloNumero(i + 1);

                int tamanho_coluna = Math.Max( _biblioteca.Comando_ObterTamColunaPeloNumero(i + 1), nme_coluna.Length );

                texto.Append(String.Format("{0, -" + tamanho_coluna.ToString() + "} ", nme_coluna));

                tamanho_colunas[i] = tamanho_coluna;
            }

            texto.Append("\n");

            for (int i = 0; i < qtd_colunas; ++i)
            {
                texto.Append('-', tamanho_colunas[i]);
                texto.Append(" ");
            }

            texto.Append("\n");

            // Corpo
            int qtd_linhas = _biblioteca.Comando_ObterQtdLinhas();

            for (int i = 0; i < qtd_linhas; ++i)
            {
                for (int j = 0; j < qtd_colunas; ++j)
                {
                    int tamanho_coluna = tamanho_colunas[j];
                    string valor = _biblioteca.Comando_ObterColunaPeloNumero(j + 1);

                    texto.Append(String.Format("{0, -" + tamanho_coluna.ToString() + "} ", valor.Substring(0, Math.Min(valor.Length, tamanho_coluna))));
                }

                texto.Append("\n");

                _biblioteca.Comando_lstProximo();
            }

            texto.Append("\n");

            texto.Append(String.Format("{0} linha(s) retornada(s).\n\n", qtd_linhas));

            _txt_resultado.AppendText(texto.ToString());
        }

        private void limpar_resultados()
        {
            _txt_resultado.Clear();
        }

        private void mostrar_procura()
        {
            FindDialog find = FindDialog.CreateFindDialog(_txt_resultado);
            find.Show();
        }

        private void criar_componentes()
        {
            // txt_comando_template
            _txt_comando = new RichTextBox();
            _txt_comando.BackColor = System.Drawing.SystemColors.Window;
            _txt_comando.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            _txt_comando.Dock = System.Windows.Forms.DockStyle.Fill;
            _txt_comando.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _txt_comando.Location = new System.Drawing.Point(0, 0);
            _txt_comando.Margin = new System.Windows.Forms.Padding(0);
            _txt_comando.Size = new System.Drawing.Size(1, 1);
            _txt_comando.TabIndex = 0;
            _txt_comando.Text = "";
            _txt_comando.WordWrap = false;
            _txt_comando.ShortcutsEnabled = true;
            _txt_comando.DetectUrls = false;

            _txt_comando.KeyDown += new KeyEventHandler(this.txt_comando_KeyDown);
            _txt_comando.EnabledChanged += new EventHandler((object sender, EventArgs e) => _txt_comando.Focus());
            _txt_comando.VisibleChanged += new EventHandler((object sender, EventArgs e) => _txt_comando.Focus());
            _txt_comando.TextChanged += new EventHandler(this.txt_comando_TextChanged);

            // txt_resultado_template
            _txt_resultado = new RichTextBox();
            _txt_resultado.BackColor = System.Drawing.SystemColors.Window;
            _txt_resultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            _txt_resultado.Dock = System.Windows.Forms.DockStyle.Fill;
            _txt_resultado.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            _txt_resultado.Location = new System.Drawing.Point(0, 0);
            _txt_resultado.Margin = new System.Windows.Forms.Padding(0);
            _txt_resultado.Size = new System.Drawing.Size(1, 1);
            _txt_resultado.TabIndex = 1;
            _txt_resultado.Text = "";
            _txt_resultado.WordWrap = false;
            _txt_resultado.ShortcutsEnabled = true;
            _txt_resultado.DetectUrls = false;
            _txt_resultado.ReadOnly = true;

            _txt_resultado.KeyDown += new KeyEventHandler(this.txt_resultado_KeyDown);

            criar_menu_atalhos();

            // spt_conexao_template
            SplitContainer spt_conexao = new SplitContainer();
            spt_conexao.Dock = System.Windows.Forms.DockStyle.Fill;
            spt_conexao.Location = new System.Drawing.Point(0, 0);
            spt_conexao.Margin = new System.Windows.Forms.Padding(0);
            spt_conexao.Orientation = System.Windows.Forms.Orientation.Horizontal;

            // spt_conexao_template.Panel1
            spt_conexao.Panel1.Controls.Add(_txt_comando);

            // spt_conexao_template.Panel2
            spt_conexao.Panel2.Controls.Add(_txt_resultado);
            spt_conexao.Size = new System.Drawing.Size(1, 383);
            spt_conexao.SplitterDistance = 70;
            spt_conexao.TabIndex = 2;

            // pnl_conexao_template
            Panel pnl_conexao = new Panel();
            pnl_conexao.BackColor = System.Drawing.Color.WhiteSmoke;
            pnl_conexao.Controls.Add(spt_conexao);
            pnl_conexao.Dock = System.Windows.Forms.DockStyle.Fill;
            pnl_conexao.Location = new System.Drawing.Point(0, 0);
            pnl_conexao.Size = new System.Drawing.Size(1, 383);
            pnl_conexao.TabIndex = 2;

            // tabPage
            _tabpage = new TabPage(_instancia.nome);
            _tabpage.Controls.Add(pnl_conexao);
            _tabpage.Location = new System.Drawing.Point(4, 22);
            _tabpage.Size = new System.Drawing.Size(1, 1);
            _tabpage.TabIndex = _id;
            _tabpage.UseVisualStyleBackColor = true;
            _tabpage.Tag = this;

            _tabpage.Disposed += delegate(object sender, EventArgs e)
            {
                desconectar();
            };

            definir_nome_aba();
        }

        private void criar_menu_atalhos()
        {
            ContextMenuStrip context = new ContextMenuStrip();
            
            foreach (KeyValuePair<char, string> atalho in ConexaoInstancia._atalhos)
            {
                ToolStripMenuItem btn_atalho = new ToolStripMenuItem();
                btn_atalho.Text = atalho.Value;
                btn_atalho.ToolTipText = String.Format("{0} (Ctrl + Shift + {1})", atalho.Value, atalho.Key);
                btn_atalho.Click += delegate(object sender, EventArgs e)
                {
                    enviar_comando((sender as ToolStripMenuItem).Text);
                };

                context.Items.Add(btn_atalho);
            }

            context.Items.Add(new ToolStripSeparator());

            ToolStripMenuItem btn_procurar = new ToolStripMenuItem();
            btn_procurar.Text = "Procurar";
            btn_procurar.ToolTipText = String.Format("Procurar (Ctrl + F)");
            btn_procurar.Click += delegate(object sender, EventArgs e)
            {
                mostrar_procura();
            };

            context.Items.Add(btn_procurar);

            ToolStripMenuItem btn_limpar = new ToolStripMenuItem();
            btn_limpar.Text = "Limpar resultados";
            btn_limpar.ToolTipText = String.Format("Limpar resultados (Ctrl + R)");
            btn_limpar.Click += delegate(object sender, EventArgs e)
            {
                limpar_resultados();
            };

            context.Items.Add(btn_limpar);

            _txt_resultado.ContextMenuStrip = context;
            _txt_comando.ContextMenuStrip = context;
        }

        private void definir_nome_aba()
        {
            string superadmin = _superadmin ? " (S)" : "";

            _tabpage.Text = _instancia.nome + superadmin;
            _tabpage.ToolTipText = _instancia.nome + superadmin;
        }

        public void executar_comando_selecionado()
        {
            string[] comandos = _txt_comando.SelectedText.Replace("\n", "").Split(';');

            foreach (string comando in comandos)
            {
                if (comando.Trim() == String.Empty)
                    continue;

                enviar_comando(comando);
            }
        }

        private void txt_comando_KeyDown(object sender, KeyEventArgs e)
        {
            definir_atalhos_comuns(e);

            //
            if (e.Control && !e.Shift && e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                executar_comando_selecionado();
            }

            // Remove a formatação do texto que será "colado" no componente.
            if (e.Control && !e.Shift && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;

                _txt_comando.Paste(DataFormats.GetFormat(DataFormats.Text));
            }
        }

        private void txt_comando_TextChanged(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText(String.Format("{0}\\{1}", Path.GetTempPath(), _nme_arquivo_comandos), _txt_comando.Text);
            }
            catch (Exception) { }
        }

        private void txt_resultado_KeyDown(object sender, KeyEventArgs e)
        {
            definir_atalhos_comuns(e);
        }

        private void definir_situacao_txt_comando()
        {
            // Trecho necessário para que seja possível que as threads que não são responsáveis pelo controle
            // dos componente visuais possam alterá-los.
            if (_txt_comando != null && _txt_comando.InvokeRequired)
            {
                _txt_comando.Invoke((MethodInvoker)(() => { definir_situacao_txt_comando(); }));
                return;
            }

            if (_txt_comando != null)
                _txt_comando.Enabled = _conectada;
        }

        private void _timer_manter_conexao_Elapsed(object sender, ElapsedEventArgs e)
        {
            // Envia um comando simples para manter a conexão com o discador.
            _biblioteca.Comando_EnviarComandoConsole("versao");
        }

        public static bool existe_conexao_aberta()
        {
            return _conexoes_abertas > 0;
        }

        private void definir_atalhos_comuns(KeyEventArgs e)
        {
            if (e.Control)
            {
                // Atalhos de comandos
                if (e.Shift && _atalhos.ContainsKey((char)e.KeyValue))
                {
                    e.SuppressKeyPress = true;
                    enviar_comando(_atalhos[(char)e.KeyValue]);

                    return;
                }

                switch (e.KeyCode)
                {
                    // Limpar resultados
                    case Keys.R:
                    {
                        e.SuppressKeyPress = true;
                        
                        limpar_resultados();
                        break;
                    }

                    // Procurar
                    case Keys.F:
                    {
                        e.SuppressKeyPress = true;

                        mostrar_procura();
                        break;
                    }
                }

                return;
            }
        }
    }
}

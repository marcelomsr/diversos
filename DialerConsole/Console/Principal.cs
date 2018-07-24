using Console.DB;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Timers;
using System.Windows.Forms;

namespace Console
{
    internal partial class Principal : Form
    {
        private string _nme_login_autenticacao_cache;
        private System.Timers.Timer _timer_repetir_ultimo_comando;

        public Principal()
        {
            InitializeComponent();

            this.Text += " " + Versao.ToString();

            _nme_login_autenticacao_cache = null;
            _timer_repetir_ultimo_comando = new System.Timers.Timer();

            // Remove a aba de template
            tab_principal.TabPages.Clear();

            atualizar_campos_outra_instancia();

            listar_instancias();

            _timer_repetir_ultimo_comando.Interval = 60 * 1000;
            _timer_repetir_ultimo_comando.Elapsed += timer_repetir_ultimo_comando_Elapsed;
        }

        private void listar_instancias()
        {
            lst_instancias.ValueMember = "id";
            lst_instancias.DisplayMember = "nome";

            lst_instancias.Items.Clear();

            lst_instancias.Items.Add(InstanciaItem.CriarPersonalizada("localhost", 9001, false));

            try
            {
                using (Conexao conexao = new Conexao(Credencial.ObterCredencial()))
                {
                    using (OdbcDataReader dr = conexao.executar_select(
                        "SELECT cdg_instancia, nme_instancia, dsc_ip, nmr_porta_ip FROM cct.cct_instancia WHERE tpo_instancia = 'D' ORDER BY nme_instancia"))
                    {
                        while (dr.Read())
                        {
                            string endereco_ip = dr.GetString(2);
                            string nome_instancia = dr.GetString(1);

                            lst_instancias.Items.Add(new InstanciaItem(dr.GetInt16(0), nome_instancia, endereco_ip, dr.GetInt16(3), true));
                        }
                    }
                }
            }
            catch (OdbcException)
            {
                MessageBox.Show("Não foi possível obter as instâncias cadastradas.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void criar_conexao_instancia(InstanciaItem instancia, bool superadmin)
        {
            ConexaoInstancia conexao = new ConexaoInstancia(instancia, superadmin, autenticar_usuario);
            conexao.AoDesconectar += new ConexaoInstancia.DesconexaoHandler(tratar_desconexao_instancia);

            if (!conexao.conectada)
            {
                if (conexao.obter_erro() > 0)
                {
                    MessageBox.Show("Não foi possível conectar na instância desejada.\n" + conexao.obter_descricao_erro(), "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                return;
            }

            tab_principal.TabPages.Add(conexao.tabpage);
            tab_principal.SelectTab(conexao.tabpage);
        }

        private string autenticar_usuario()
        {
            if (_nme_login_autenticacao_cache != null)
                return _nme_login_autenticacao_cache;

            using (Login login = new Login())
            {
                DialogResult resultado = login.ShowDialog();

                if (resultado != DialogResult.OK)
                    return null;

                string nme_login = login.obter_nme_login();

                if (login.lembrar_usuario())
                    _nme_login_autenticacao_cache = nme_login;

                return nme_login;
            }
        }

        private void tratar_desconexao_instancia(ConexaoInstancia conexao)
        {
            DialogResult resultado = MessageBox.Show("Não foi possível reconectar automaticamente.!\nDeseja conectar agora?", conexao.instancia.nome,
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                conexao.reconectar();

                if (!conexao.conectada)
                {
                    MessageBox.Show("Não foi possível reconectar na instância desejada.", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }
            }
        }

        private void alterar_conexao_instancia(TabPage tabpage, InstanciaItem instancia)
        {
            if (tabpage.Tag == null)
                return;

            ConexaoInstancia conexao = (tabpage.Tag as ConexaoInstancia);

            conexao.alterar_instancia(instancia);

            if (!conexao.conectada)
            {
                MessageBox.Show("Não foi possível conectar na instância desejada.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
        }

        private void atualizar_campos_outra_instancia()
        {
            lst_instancias.Enabled = !chk_outra_instancia.Checked;
            txt_endereco_ip.Enabled = chk_outra_instancia.Checked;
            txt_porta.Enabled = chk_outra_instancia.Checked;

            if (chk_outra_instancia.Checked)
            {
                txt_endereco_ip.Focus();
                lst_instancias.SelectedItem = null;
            }
            else
            {
                lst_instancias.Focus();
                txt_endereco_ip.Clear();
                txt_porta.Clear();
            }
        }

        #region Eventos Winforms

        private void tab_principal_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                for (int i = 0; i < tab_principal.TabCount; ++i)
                {
                    System.Drawing.Rectangle r = tab_principal.GetTabRect(i);

                    if (r.Contains(e.Location))
                    {
                        ContextMenu cm = new ContextMenu();

                        TabPage tabpage = tab_principal.TabPages[i];

                        ConexaoInstancia conexao = (tabpage.Tag as ConexaoInstancia);

                        MenuItem item1 = new MenuItem("Fechar", delegate(object sender2, EventArgs ea)
                        {
                            TabPage self = ((sender2 as MenuItem).Tag as TabPage);

                            tab_principal.TabPages.Remove(self);
                            self.Dispose();
                        });

                        item1.Tag = tabpage;
                        cm.MenuItems.Add(item1);

                        if (!conexao.conectada)
                        {
                            MenuItem item2 = new MenuItem("Reconectar", delegate(object sender2, EventArgs ea)
                            {
                                TabPage self = ((sender2 as MenuItem).Tag as TabPage);

                                (self.Tag as ConexaoInstancia).reconectar();
                            });

                            item2.Tag = tabpage;
                            cm.MenuItems.Add(item2);
                        }

                        System.Drawing.Point location =
                            new System.Drawing.Point(e.Location.X + tab_principal.Location.X + lst_instancias.Width, e.Location.Y + tab_principal.Location.Y);

                        cm.Show(this, location);

                        break;
                    }
                }
            }
        }

        private void chk_outra_instancia_CheckedChanged(object sender, EventArgs e)
        {
            atualizar_campos_outra_instancia();
        }

        private void lst_instancias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tab_principal.SelectedTab == null)
                return;

            InstanciaItem instancia_selecionada = lst_instancias.SelectedItem as InstanciaItem;

            if (instancia_selecionada == null)
                return;

            alterar_conexao_instancia(tab_principal.SelectedTab, instancia_selecionada);
        }

        private void tab_principal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tab_principal.SelectedTab == null)
                return;

            lst_instancias.SelectedItem = (tab_principal.SelectedTab.Tag as ConexaoInstancia).instancia;
        }

        private void btn_abrir_conexao_Click(object sender, EventArgs e)
        {
            // Se necessário cria a instância personalizada
            if (chk_outra_instancia.Checked)
            {
                if (txt_endereco_ip.Text.Trim() == "" || txt_porta.Text.Trim() == "")
                {
                    MessageBox.Show("Informe corretamente o endereço IP e porta.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                InstanciaItem nova_instancia = InstanciaItem.CriarPersonalizada(txt_endereco_ip.Text, Convert.ToInt32(txt_porta.Text), true);
                lst_instancias.Items.Add(nova_instancia);
                lst_instancias.SetSelected(lst_instancias.Items.Count - 1, true);

                chk_outra_instancia.Checked = false;
            }

            if (lst_instancias.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma instância.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            criar_conexao_instancia(
                lst_instancias.SelectedItem as InstanciaItem, Configuracoes.Instance.usar_modo_superadministrador);
        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            // Trecho necessário para que seja possível que as threads que não são responsáveis pelo controle
            // dos componente visuais possam alterá-los.
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)(() =>
                {
                    btn_executar_Click(sender, e);
                }));

                return;
            }

            if (tab_principal.SelectedTab == null)
            {
                MessageBox.Show("Abra uma conexão para executar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            (tab_principal.SelectedTab.Tag as ConexaoInstancia).executar_comando_selecionado();
        }

        private void txt_porta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btn_configuracoes_ButtonClick(object sender, EventArgs e)
        {
            btn_configuracoes.ShowDropDown();
        }

        private void btn_abrir_como_superadmin_CheckStateChanged(object sender, EventArgs e)
        {
            Configuracoes.Instance.usar_modo_superadministrador = btn_abrir_como_superadmin.Checked;
        }

        private void btn_registrar_log_dialer4com_CheckStateChanged(object sender, EventArgs e)
        {
            Configuracoes.Instance.registrar_log_dialer4COM = btn_registrar_log_dialer4com.Checked;
        }

        private void btn_mostrar_nome_colunas_CheckStateChanged(object sender, EventArgs e)
        {
            Configuracoes.Instance.mostrar_identificacao_colunas = btn_mostrar_identificacao_colunas.Checked;
        }

        private void btn_medir_tempo_resposta_CheckStateChanged(object sender, EventArgs e)
        {
            Configuracoes.Instance.medir_tempo_resposta = btn_medir_tempo_resposta.Checked;
        }

        private void btn_repetir_ultimo_comando_CheckStateChanged(object sender, EventArgs e)
        {
            Configuracoes.Instance.repetir_ultimo_comando =
                _timer_repetir_ultimo_comando.Enabled = btn_repetir_ultimo_comando.Checked;

            if (_timer_repetir_ultimo_comando.Enabled)
            {
                _timer_repetir_ultimo_comando.Start();
            }
        }

        private void timer_repetir_ultimo_comando_Elapsed(object sender, ElapsedEventArgs e)
        {
            btn_executar_Click(null, null);
        }

        private void btn_cada_5_minutos_CheckStateChanged(object sender, EventArgs e)
        {
            definir_tempo_repetir_ultimo_comando(60 * 5, btn_cada_5_minutos.CheckState);

            // Se esse botão for checkado, desmarca os outros.
            btn_cada_1_minuto.CheckState = CheckState.Unchecked;
            btn_cada_30_segundos.CheckState = CheckState.Unchecked;
            btn_cada_10_segundos.CheckState = CheckState.Unchecked;
            btn_cada_5_segundos.CheckState = CheckState.Unchecked;
            btn_cada_2_segundos.CheckState = CheckState.Unchecked;
        }

        private void btn_cada_1_minuto_CheckStateChanged(object sender, EventArgs e)
        {
            definir_tempo_repetir_ultimo_comando(60, btn_cada_1_minuto.CheckState);

            // Se esse botão for checkado, desmarca os outros.
            btn_cada_5_minutos.CheckState = CheckState.Unchecked;
            btn_cada_30_segundos.CheckState = CheckState.Unchecked;
            btn_cada_10_segundos.CheckState = CheckState.Unchecked;
            btn_cada_5_segundos.CheckState = CheckState.Unchecked;
            btn_cada_2_segundos.CheckState = CheckState.Unchecked;
        }

        private void btn_cada_30_segundos_CheckStateChanged(object sender, EventArgs e)
        {
            definir_tempo_repetir_ultimo_comando(30, btn_cada_30_segundos.CheckState);

            // Se esse botão for checkado, desmarca os outros.
            btn_cada_5_minutos.CheckState = CheckState.Unchecked;
            btn_cada_1_minuto.CheckState = CheckState.Unchecked;
            btn_cada_10_segundos.CheckState = CheckState.Unchecked;
            btn_cada_5_segundos.CheckState = CheckState.Unchecked;
            btn_cada_2_segundos.CheckState = CheckState.Unchecked;
        }

        private void btn_cada_10_segundos_CheckStateChanged(object sender, EventArgs e)
        {
            definir_tempo_repetir_ultimo_comando(10, btn_cada_10_segundos.CheckState);

            // Se esse botão for checkado, desmarca os outros.
            btn_cada_5_minutos.CheckState = CheckState.Unchecked;
            btn_cada_1_minuto.CheckState = CheckState.Unchecked;
            btn_cada_30_segundos.CheckState = CheckState.Unchecked;
            btn_cada_5_segundos.CheckState = CheckState.Unchecked;
            btn_cada_2_segundos.CheckState = CheckState.Unchecked;
        }

        private void btn_cada_5_segundos_CheckStateChanged(object sender, EventArgs e)
        {
            definir_tempo_repetir_ultimo_comando(5, btn_cada_5_segundos.CheckState);

            // Se esse botão for checkado, desmarca os outros.
            btn_cada_5_minutos.CheckState = CheckState.Unchecked;
            btn_cada_1_minuto.CheckState = CheckState.Unchecked;
            btn_cada_30_segundos.CheckState = CheckState.Unchecked;
            btn_cada_10_segundos.CheckState = CheckState.Unchecked;
            btn_cada_2_segundos.CheckState = CheckState.Unchecked;
        }

        private void btn_cada_2_segundos_CheckStateChanged(object sender, EventArgs e)
        {
            definir_tempo_repetir_ultimo_comando(2, btn_cada_2_segundos.CheckState);

            // Se esse botão for checkado, desmarca os outros.
            btn_cada_5_minutos.CheckState = CheckState.Unchecked;
            btn_cada_1_minuto.CheckState = CheckState.Unchecked;
            btn_cada_30_segundos.CheckState = CheckState.Unchecked;
            btn_cada_10_segundos.CheckState = CheckState.Unchecked;
            btn_cada_5_segundos.CheckState = CheckState.Unchecked;
        }

        private void definir_tempo_repetir_ultimo_comando(int segundos, CheckState check_state)
        {
            if (!ConexaoInstancia.existe_conexao_aberta())
                return;

            _timer_repetir_ultimo_comando.Interval = segundos * 1000;
            btn_repetir_ultimo_comando.CheckState = check_state;
        }

        #endregion
    }
}

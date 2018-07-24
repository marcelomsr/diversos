using System;
using System.Windows.Forms;

namespace Console
{
    internal partial class FindDialog : Form
    {
        private int _qtd_ocorrencias_encontradas = 0;
        private int _indice_ocorrencia_atual = 0;

        private RichTextBox _richtextbox;

        private static FindDialog _instance = null;

        public static FindDialog CreateFindDialog(RichTextBox richtextbox)
        {
            if (_instance == null)
                _instance = new FindDialog(richtextbox);

            return _instance;
        }

        private FindDialog(RichTextBox richtextbox)
        {
            InitializeComponent();

            _richtextbox = richtextbox;
            txt_texto_procurado.Focus();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void txt_texto_procurado_TextChanged(object sender, EventArgs e)
        {
            if (_qtd_ocorrencias_encontradas > 0)
                limpar_realcamentos();
        }

        private void txt_texto_procurado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_procurar.PerformClick();
        }

        private void btn_procurar_Click(object sender, EventArgs e)
        {
            realcar_todas_ocorrencias(txt_texto_procurado.Text);
        }

        private void FindDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            limpar_realcamentos();

            _instance = null;
        }

        private void realcar_todas_ocorrencias(string texto)
        {
            int posicao_inicio_procura = 0, indice_ocorrencia = 0, posicao_atual = 0;
            int posicao_incio_ocorrencia_atual = 0;

            _qtd_ocorrencias_encontradas = 0;

            while ((posicao_atual = _richtextbox.Text.IndexOf(texto, posicao_inicio_procura, StringComparison.CurrentCultureIgnoreCase)) != -1)
            {
                if (_indice_ocorrencia_atual == indice_ocorrencia)
                {
                    posicao_incio_ocorrencia_atual = posicao_atual;
                }
                else
                {
                    _richtextbox.Select(posicao_atual, texto.Length);
                    _richtextbox.SelectionBackColor = System.Drawing.Color.Gainsboro;
                }

                posicao_inicio_procura = posicao_atual + texto.Length;

                indice_ocorrencia++;
                _qtd_ocorrencias_encontradas++;
            }

            if (_qtd_ocorrencias_encontradas > 0)
            {
                _richtextbox.Select(posicao_incio_ocorrencia_atual, texto.Length);
                _richtextbox.SelectionBackColor = System.Drawing.Color.Orange;
                _richtextbox.Focus();

                _indice_ocorrencia_atual = (_indice_ocorrencia_atual + 1) % _qtd_ocorrencias_encontradas;
            }

            txt_texto_procurado.Focus();
        }

        private void limpar_realcamentos()
        {
            _qtd_ocorrencias_encontradas = 0;
            _indice_ocorrencia_atual = 0;

            while (_richtextbox.CanUndo)
            {
                _richtextbox.Undo();
                _richtextbox.ClearUndo();
            }

            int inicio_selecao_atual = _richtextbox.SelectionStart;

            _richtextbox.Select(0, _richtextbox.Text.Length);
            _richtextbox.SelectionBackColor = System.Drawing.Color.White;

            _richtextbox.SelectionStart = inicio_selecao_atual;
            _richtextbox.SelectionLength = 0;
        }
    }
}

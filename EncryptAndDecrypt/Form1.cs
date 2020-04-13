using MyLibrary;
using System;
using System.Windows.Forms;

namespace EncryptAndDecrypt
{
    public partial class Form1 : Form
    {
        static readonly string PasswordHash = "P@@Sw0rd";
        static readonly string SaltKey = "S@LT&KEY";
        static readonly string VIKey = "@1B2c3D4e5F6g7H8";

        public Form1()
        {
            InitializeComponent();

            string criptada = "";
            string decriptada = "";

            SimpleFunctions.EncryptString("teste", PasswordHash, SaltKey, VIKey, ref criptada);
            SimpleFunctions.DecryptString(criptada, PasswordHash, SaltKey, VIKey, ref decriptada);
        }

        private void btn_encripta_Click(object sender, EventArgs e)
        {
            SimpleFunctions.EncryptFile(txt_arquivo_entrada.Text, txt_arquivo_destino.Text, SaltKey);
        }

        private void btn_decripta_Click(object sender, EventArgs e)
        {
            SimpleFunctions.DecryptFile(txt_arquivo_entrada.Text, txt_arquivo_destino.Text, SaltKey);
        }

        private void btn_source_file_Click(object sender, EventArgs e)
        {
            if (open_file_dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txt_arquivo_entrada.Text = open_file_dialog.FileName;
                txt_arquivo_destino.Text = open_file_dialog.FileName;
            }
        }
    }
}
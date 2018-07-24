using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.Odbc;
using Console.DB;

namespace Console
{
    internal partial class Login : Form
    {
        private struct Usuario
        {
            public string tpo_autenticacao;
            public string dsc_senha_criptografada;
            public string dsc_chave;
        };

        private struct LDAPAutenticacaoConfig
        {
            public string dsc_ip_ldap;
            public string dsc_arvore_ldap;
            public int nmr_porta_ldap;
        };

        public Login()
        {
            InitializeComponent();

            // Define o login padrão como o usuário logado no sistema operacional.
            txt_usuario.Text = Environment.UserName;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch(keyData)
            {
                case Keys.Escape:
                {
                    this.Close();
                    break;
                }

                case Keys.Enter:
                {
                    btn_conectar.PerformClick();
                    break;
                }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        public string obter_nme_login()
        {
            return txt_usuario.Text;
        }

        public bool lembrar_usuario()
        {
            return ckb_lembreme.Checked;
        }

        private void btn_conectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validar_senha(txt_usuario.Text, txt_senha.Text))
                    throw new Exception("Usuário ou senha inválida!");

                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool validar_senha(string nme_login, string dsc_senha)
        {
            Usuario? usuario = obter_usuario(nme_login.ToUpper());

            if (usuario == null)
                throw new Exception("Usuário ou senha inválida!");

            switch (usuario.Value.tpo_autenticacao)
            {
                case "L":
                {
                    LDAPAutenticacaoConfig? ldap_autenticacao_config = ObterConfiguracaoAutenticacaoLDAP();

                    if (ldap_autenticacao_config == null)
                        throw new Exception("Configuração para autenticação LDAP não encontrada.");

                    LdapAuthentication ldap = new LdapAuthentication(
                        String.Format("{0}:{1}", ldap_autenticacao_config.Value.dsc_ip_ldap, ldap_autenticacao_config.Value.nmr_porta_ldap),
                        ldap_autenticacao_config.Value.dsc_arvore_ldap, "sAMAccountName={0}");

                    return ldap.Authenticate(nme_login, dsc_senha);
                }

                case "P":
                {
                    return criptografar_senha(dsc_senha, usuario.Value.dsc_chave) == usuario.Value.dsc_senha_criptografada;
                }

                default:
                    throw new Exception("Tipo de autenticação desconhecido.");
            }
        }

        private Usuario? obter_usuario(string nme_login)
        {
            using (Conexao conexao = new Conexao(Credencial.ObterCredencial()))
            {
                using (OdbcDataReader dr = conexao.executar_select(
                    @"SELECT ua.tpo_autenticacao, u.dsc_senha_criptografada, u.dsc_chave
                  FROM seg.seg_usuario_autenticacao ua
                  INNER JOIN seg.seg_usuario u ON u.cdg_usuario = ua.cdg_usuario
                  WHERE ua.cdg_sistema = 'CCT'
                    AND u.nme_login = '{0}'
                    AND u.sta_situacao = 'A'", nme_login))
                {
                    if (!dr.Read())
                        return null;

                    Usuario usuario;

                    usuario.tpo_autenticacao = dr.GetString(0);
                    usuario.dsc_senha_criptografada = dr.GetString(1);
                    usuario.dsc_chave = dr.GetString(2);

                    return usuario;
                }
            }
        }

        private LDAPAutenticacaoConfig? ObterConfiguracaoAutenticacaoLDAP()
        {
            LDAPAutenticacaoConfig ldap_autenticacao;

            using (Conexao conexao = new Conexao(Credencial.ObterCredencial()))
            {
                using (OdbcDataReader dr = conexao.executar_select(
                    "SELECT dsc_ip_ldap, dsc_arvore_ldap, nmr_porta_ldap FROM seg.seg_autenticacao_config WHERE cdg_sistema = 'CCT'"))
                {
                    if (!dr.Read())
                        return null;

                    ldap_autenticacao.dsc_ip_ldap = dr.GetString(0);
                    ldap_autenticacao.dsc_arvore_ldap = dr.GetString(1);
                    ldap_autenticacao.nmr_porta_ldap = dr.GetInt32(2);

                    return ldap_autenticacao;
                }
            }
        }

        private String criptografar_senha(String senha, String chave)
        {
            String senha_com_chave = senha + chave;

            var hash_senha_com_chave = new SHA1Managed().ComputeHash(Encoding.ASCII.GetBytes(senha_com_chave));

            String senha_criptografada = "";

            foreach (var caracter in hash_senha_com_chave)
                senha_criptografada += caracter.ToString("X2");

            senha_criptografada = senha_criptografada.ToUpper();

            return senha_criptografada;
        }
    }
}

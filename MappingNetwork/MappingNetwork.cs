using aejw.Network;
using IWshRuntimeLibrary;
using System;
using System.Reflection;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.ComponentModel;

namespace Network
{
    public partial class MappingNetwork : Form
    {
        #region Mover a tela pressionando o mouse

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        #endregion

        private struct LDAPAutenticacaoConfig
        {
            public string dsc_ip_ldap;
            public string dsc_arvore_ldap;
            public int nmr_porta_ldap;
        };

        private bool _mapeou = true;

        public MappingNetwork()
        {
            AppDomain.CurrentDomain.AssemblyResolve += (sender, args) =>
            {
                string resourceName = new AssemblyName(args.Name).Name + ".dll";
                string resource = Array.Find(this.GetType().Assembly.GetManifestResourceNames(), element => element.EndsWith(resourceName));

                using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resource))
                {
                    Byte[] assemblyData = new Byte[stream.Length];
                    stream.Read(assemblyData, 0, assemblyData.Length);
                    return Assembly.Load(assemblyData);
                }
            };

            InitializeComponent();
        }

        private void btn_mapear_Click(object sender, System.EventArgs e)
        {
            if (txtPassword.Text.Trim() == "" || txtUsername.Text.Trim() == "")
            {
                MessageBox.Show("Usuário e senha necessários.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!usuario_valido(txtUsername.Text.Trim(), txtPassword.Text.Trim()))
            {
                MessageBox.Show("Usuário ou senha inválidos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            if (chk_R.Checked)
            {
                mapear_unidade_rede("R:", @"\\dados.lbv.org.br\data1$");
                CreateShortcut("R");
            }

            if (chk_S.Checked)
            {
                mapear_unidade_rede("S:", @"\\manisa.lbvdc.lbv.org.br\data1$");
                CreateShortcut("S");
            }

            if (chk_T.Checked)
            {
                mapear_unidade_rede("T:", @"\\samsun.lbvdc.lbv.org.br\transfer$");
                CreateShortcut("T");
            }

            if (_mapeou)
            {
                txtPassword.Text = "";
                this.WindowState = FormWindowState.Minimized;
            }

            // Define true novamente, para que seja possível tentar mapear novamente.
            _mapeou = true;
        }

        private void btn_desconectar_Click(object sender, EventArgs e)
        {
            if (chk_R.Checked)
            {
                desmapear_unidade_rede("R:");
                DeleteShortcut("R");
            }

            if (chk_S.Checked)
            {
                desmapear_unidade_rede("S:");
                DeleteShortcut("S");
            }

            if (chk_T.Checked)
            {
                desmapear_unidade_rede("T:");
                DeleteShortcut("T");
            }

            this.WindowState = FormWindowState.Minimized;
        }

        private void mapear_unidade_rede(string letter_drive, string txtAddress)
        {
            // Se na primeira tentativa não mapeou, não tenta de novo para evitar o bloqueio do usuário.
            if (_mapeou == false)
                return;

            NetworkDrive oNetDrive = new NetworkDrive();

            try
            {
                oNetDrive.LocalDrive = letter_drive;
                oNetDrive.Force = true;
                oNetDrive.ShareName = txtAddress;
                oNetDrive.MapDrive(txtUsername.Text, txtPassword.Text);
            }
            catch (Win32Exception err)
            {
                _mapeou = false;

                if (err.NativeErrorCode == 1202 /*"O nome de dispositivo local tem uma conexão lembrada com outro recurso de rede"*/)
                {
                    MessageBox.Show(String.Format("Não foi possível fazer mapear {0}, pois já existe um mapeamento para essa unidade", letter_drive), "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (err.NativeErrorCode == 1909 /*"A conta referenciada está bloqueada no momento e pode não ser possível fazer logon"*/)
                {
                    MessageBox.Show(String.Format("Não foi possível fazer mapear {0}, pois o usuário está bloqueado, procure o administrador da rede.", letter_drive), "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (err.NativeErrorCode == 86 /*"A senha de rede especificada não está correta"*/)
                {
                    MessageBox.Show(String.Format("Não foi possível fazer mapear {0}, usuário ou senha inválidos.", letter_drive), "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (err.NativeErrorCode == 1326 /*"Nome de usuário ou senha incorretos"*/)
                {
                    MessageBox.Show(String.Format("Não foi possível fazer mapear {0}, usuário ou senha inválidos.", letter_drive), "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(String.Format("Não foi possível fazer mapear {0}.", letter_drive), "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            oNetDrive = null;
        }

        private void desmapear_unidade_rede(string letter_drive)
        {
            NetworkDrive oNetDrive = new NetworkDrive();

            try
            {
                // Unmap the drive
                oNetDrive.LocalDrive = letter_drive;
                oNetDrive.Force = true;
                oNetDrive.UnMapDrive();
            }
            catch (Exception) { }

            oNetDrive = null;
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar_enter(e);
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar_enter(e);
        }

        private void validar_enter(KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                btn_mapear_Click(null, null);
            }
        }

        private void CreateShortcut(string letter_drive)
        {
            if (!_mapeou)
                return;

            object shDesktop = (object)"Desktop";
            WshShell shell = new WshShell();
            string shortcutAddress = (string)shell.SpecialFolders.Item(ref shDesktop) + string.Format(@"\{0}.lnk", letter_drive);
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
            shortcut.TargetPath = letter_drive + ":";
            shortcut.Save();
        }

        private void DeleteShortcut(string letter_drive)
        {
            object shDesktop = (object)"Desktop";
            WshShell shell = new WshShell();
            string shortcutAddress = (string)shell.SpecialFolders.Item(ref shDesktop) + string.Format(@"\{0}.lnk", letter_drive);
            System.IO.File.Delete(shortcutAddress);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool usuario_valido(string nme_login, string dsc_senha)
        {
            try
            { 
            LDAPAutenticacaoConfig ldap_autenticacao_config;
            ldap_autenticacao_config.dsc_ip_ldap = "lbvdc.lbv.org.br";
            ldap_autenticacao_config.dsc_arvore_ldap = "DC=lbvdc,DC=lbv,DC=org,DC=br";
            ldap_autenticacao_config.nmr_porta_ldap = 636;

            LdapAuthentication ldap = new LdapAuthentication(
                String.Format("{0}:{1}", ldap_autenticacao_config.dsc_ip_ldap, ldap_autenticacao_config.nmr_porta_ldap),
                ldap_autenticacao_config.dsc_arvore_ldap, "sAMAccountName={0}");

            return ldap.Authenticate(nme_login, dsc_senha);
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        private void General_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            General_MouseDown(sender, e);
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            General_MouseDown(sender, e);
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            General_MouseDown(sender, e);
        }

        private void label4_MouseDown(object sender, MouseEventArgs e)
        {
            General_MouseDown(sender, e);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            General_MouseDown(sender, e);
        }

        private void lbl_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lbl_fechar_MouseHover(object sender, EventArgs e)
        {
            lbl_fechar.Cursor = Cursors.Hand;
        }
    }
}

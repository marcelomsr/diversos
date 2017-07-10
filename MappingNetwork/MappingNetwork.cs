using aejw.Network;
using IWshRuntimeLibrary;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace Network
{
    public partial class MappingNetwork : Form
    {
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
            if (chk_R.Checked)
            {
                desmapear_unidade_rede("R:");
                mapear_unidade_rede("R:", @"\\dados.lbv.org.br\data1$");
                CreateShortcut("R");
            }

            if (chk_S.Checked)
            {
                desmapear_unidade_rede("S:");
                mapear_unidade_rede("S:", @"\\manisa.lbvdc.lbv.org.br\data1$");
                CreateShortcut("S");
            }

            if (chk_T.Checked)
            {
                desmapear_unidade_rede("T:");
                mapear_unidade_rede("T:", @"\\samsun.lbvdc.lbv.org.br\transfer$");
                CreateShortcut("T");
            }

            if (_mapeou)
                this.WindowState = FormWindowState.Minimized;
        }

        private void zUpdateStatus(string psStatus)
        {
            //update the status bar and refresh
            this.conStatusBar.Panels[0].Text = psStatus;
            this.Refresh();
        }

        private void mapear_unidade_rede(string letter_drive, string txtAddress)
        {
            NetworkDrive oNetDrive = new NetworkDrive();
            zUpdateStatus(string.Format("Mapeando {0} com letra {1}", txtAddress, letter_drive));

            try
            {
                oNetDrive.LocalDrive = letter_drive;
                oNetDrive.Force = true;
                oNetDrive.ShareName = txtAddress;
                //match call to options provided
                if (txtPassword.Text == "" && txtUsername.Text == "")
                {
                    oNetDrive.MapDrive();
                }
                else if (txtUsername.Text == "")
                {
                    oNetDrive.MapDrive(txtPassword.Text);
                }
                else
                {
                    oNetDrive.MapDrive(txtUsername.Text, txtPassword.Text);
                }
                //update status
                zUpdateStatus("Drive mapeado com successo");
            }
            catch (Exception err)
            {
                _mapeou = false;

                string message = string.Format("Não foi possível mapear o {0}! - {1}", letter_drive, err.Message);

                //report error
                zUpdateStatus(message);
            }

            oNetDrive = null;
        }

        private void desmapear_unidade_rede(string letter_drive)
        {
            NetworkDrive oNetDrive = new NetworkDrive();
            zUpdateStatus("Unmapping drive...");
            try
            {
                //unmap the drive
                oNetDrive.LocalDrive = letter_drive;
                oNetDrive.Force = true;
                oNetDrive.UnMapDrive();
                //update status
                zUpdateStatus("Drive removido com successo.");
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
            object shDesktop = (object)"Desktop";
            WshShell shell = new WshShell();
            string shortcutAddress = (string)shell.SpecialFolders.Item(ref shDesktop) + string.Format(@"\{0}.lnk", letter_drive);
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
            shortcut.TargetPath = letter_drive + ":";
            shortcut.Save();
        }
    }
}

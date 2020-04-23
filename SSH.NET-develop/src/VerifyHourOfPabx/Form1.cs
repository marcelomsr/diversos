using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerifyHourOfPabx
{
    public partial class Form1 : Form
    {
        public delegate void ServerUpdatedHandler();
        public event ServerUpdatedHandler ServerUpdated;

        IList<Server> _Servers;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _Servers = Server.getServers();
            dgv_servers.DataSource = _Servers;
        }

        private void updateDataServers()
        {
            Parallel.ForEach(_Servers, (currentServer) =>
                {
                    SshClient sshClient = new SshClient(currentServer.serverName, "recorder", "C0n$ul#0r1@Arr3c@d@c@0");
                    string dateServer = string.Empty;
                    DateTime dateTimeServer;
                    DateTime dateTimeLocal;

                    try
                    {
                        sshClient.Connect();

                        SshCommand command = sshClient.CreateCommand("date +\"%Y-%m-%d %H:%M:%S\"");

                        dateTimeServer = DateTime.ParseExact(command.Execute().Substring(0, 19), "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
                        dateTimeLocal = DateTime.Now;
                    }
                    catch (Exception ex)
                    {
                        currentServer.message = ex.Message;
                        return;
                    }

                    TimeSpan diff = dateTimeLocal - dateTimeServer;
                    currentServer.serverDate = dateTimeServer;
                    currentServer.localDate = dateTimeLocal;
                    currentServer.diffDate = diff;
                    currentServer.message = "OK";
                });
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            updateDataServers();

            dgv_servers.Columns[1].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
            dgv_servers.Columns[2].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";

            dgv_servers.Columns[1].Width = 120;
            dgv_servers.Columns[2].Width = 120;
            dgv_servers.Columns[3].Width = 120;
            dgv_servers.Columns[4].Width = 300;

            dgv_servers.Refresh();
        }
    }
}

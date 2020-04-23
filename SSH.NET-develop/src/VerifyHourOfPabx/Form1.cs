using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerifyHourOfPabx
{
    public partial class Form1 : Form
    {
        IList<Server> _Servers;
        object x = new object();

        public Form1()
        {
            InitializeComponent();
        }

        private IList<Server> getServers()
        {
            List<Server> servers = new List<Server>();
            servers.Add(new Server() { serverName = "Antibes" });
            servers.Add(new Server() { serverName = "Beder" });
            servers.Add(new Server() { serverName = "Ebelfort" });
            servers.Add(new Server() { serverName = "Grenoble" });
            servers.Add(new Server() { serverName = "Jyllinge" });
            servers.Add(new Server() { serverName = "Hamamatsu" });
            servers.Add(new Server() { serverName = "Kobe" });
            servers.Add(new Server() { serverName = "Lille" });
            servers.Add(new Server() { serverName = "Niort" });
            servers.Add(new Server() { serverName = "Nordby" });
            servers.Add(new Server() { serverName = "Oita" });
            servers.Add(new Server() { serverName = "Praesto" });
            servers.Add(new Server() { serverName = "Rouen" });
            servers.Add(new Server() { serverName = "Soro" });
            servers.Add(new Server() { serverName = "Stoholm" });
            servers.Add(new Server() { serverName = "Vamdrup" });
            servers.Add(new Server() { serverName = "Viborg" });
            servers.Add(new Server() { serverName = "Vicky" });

            return servers;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _Servers = getServers();

            dgv_servers.DataSource = _Servers;
            dgv_servers.Columns[4].Width = 300;
        }

        private void updateDataServers()
        {
            Parallel.ForEach(_Servers, (currentServer) =>
            {
                using (SshClient sshClient = new SshClient(currentServer.serverName, "recorder", "C0n$ul#0r1@Arr3c@d@c@0"))
                {
                    string dateServer = string.Empty;

                    try
                    {
                        sshClient.Connect();
                        SshCommand command = sshClient.CreateCommand("date +\"%Y-%m-%d %H:%M:%S\"");
                        dateServer = command.Execute().Substring(0, 19);
                    }
                    catch (Exception ex)
                    {
                        currentServer.message = ex.Message;
                        return;
                    }

                    string format = "yyyy-MM-dd HH:mm:ss";
                    DateTime dateTimeServer = DateTime.ParseExact(dateServer, format, CultureInfo.InvariantCulture);
                    DateTime dateTimeLocal = DateTime.Now;

                    TimeSpan diff = dateTimeServer - dateTimeLocal;

                    lock (x)
                    {
                        currentServer.serverDate = dateTimeServer;
                        currentServer.localDate = dateTimeLocal;
                        currentServer.diffDate = diff;
                        currentServer.message = "OK";
                    }
                }
            });
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            updateDataServers();
            dgv_servers.Refresh();
        }
    }
}

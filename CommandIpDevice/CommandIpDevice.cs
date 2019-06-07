//using Asterisk.NET.Manager;
//using Asterisk.NET.Manager.Action;
//using Asterisk.NET.Manager.Response;
using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace CommandIpDevice
{
    public partial class CommandIpDevice : Form
    {
        //private ManagerConnection _manager;

        private const string _PATH_REQUEST = "/cgi-bin/ConfigManApp.com?key=";
        private string _user_device = "admin";
        private string _password_device = "Ast10*tmkt";

        public CommandIpDevice()
        {
            InitializeComponent();
            cboCommand.SelectedIndex = 0;
        }

        private void btnConnectServerAsterisk_Click(object sender, EventArgs e)
        {
            ConectarServerAsterisk();
        }

        private void ConectarServerAsterisk()
        {/*
            if (_manager != null && _manager.IsConnected())
            {
                try
                {
                    _manager.Logoff();

                    btnListDevices.Enabled = false;
                    chkLstDevices.Enabled = false;
                    btnConnectServerAsterisk.Text = "Connect Server";                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error logoff\n" + ex.Message);
                }
            }

            _manager = new ManagerConnection(
                txtHostServerAsterisk.Text, int.Parse(txtPortServerAsterisk.Text), txtUserServerAsterisk.Text, txtPasswordServerAsterisk.Text);

            try
            {
                _manager.Login();

                btnListDevices.Enabled = true;
                btnConnectServerAsterisk.Text = "Disconnect Server";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connect\n" + ex.Message);
                _manager.Logoff();

                btnListDevices.Enabled = false;
            }*/
        }
        
        private void btnListDevices_Click(object sender, EventArgs e)
        {/*
            var action = new CommandAction();
            action.Command = "SIP SHOW PEERS";

            ManagerResponse mr = _manager.SendAction(action);
            string resposta = mr.Response;
            */
        }

        private void btn_send_command_Click(object sender, EventArgs e)
        {
            _user_device = txtUserDevice.Text.Trim();
            _password_device = txtPasswordDevice.Text.Trim();
            
            send_command("10.100.5.196", cboCommand.Text);
        }

        private void send_command(string IpDevice, string variable)
        {
            HttpWebRequest request = WebRequest.Create(String.Format("http://{0}/cgi-bin/ConfigManApp.com?key={1}", IpDevice, variable)) as HttpWebRequest;
            request.ContentType = "application/json";
            request.Method = "POST";
            request.ContentLength = 0;

            string base64Credentials = GetEncodedCredentials();
            request.Headers.Add("Authorization", "Basic " + base64Credentials);

            request.GetRequestStream();
            request.GetResponse();
        }

        private string GetEncodedCredentials()
        {
            string mergedCredentials = string.Format("{0}:{1}", _user_device, _password_device);
            byte[] byteCredentials = UTF8Encoding.UTF8.GetBytes(mergedCredentials);
            return Convert.ToBase64String(byteCredentials);
        }
    }
}
//key=OK/key=ENTER
//Press the OK key or the Enter soft key.
//key=SPEAKER
//Press the Speaker key.
//key= F_TRANSFER
//Press the Transfer key.
//key= VOLUME_UP
//Increase the volume.
//key= VOLUME_DOWN
//Decrease the volume.
//key= MUTE
//Mute the call.
//key= F_HOLD
//Press the Hold key.
//key= X
//Press the X key.
//key= 0 - 9/*/POUND
//Send the DTMF digit (0-9, * or #).  
//key=L1-L6
//Press the Line key.
//key=D1-D10
//Press the DSS key.
//key=F_CONFERENCE
//Press the Conference key.
//key=F1-F4
//Press the Soft key.
//key=MSG
//Press the MESSAGE key.
//key=HEADSET
//Press the HEADSET key.
//key=RD
//Press the Redial key.
//key=UP/DOWN/LEFT/RIGHT
//Press the Navigation keys.
//key=Reboot
//Reboot the IP phone.
//key=AutoP
//Let the IP phone do auto   provisioning.
//key=DNDOn
//Activate the DND mode.
//key=DNDOff
//Deactivate the DND mode.

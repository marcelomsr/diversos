using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Asterisk.NET.Manager;
using Asterisk.NET.Manager.Event;
using System.Diagnostics;
using Asterisk.NET.Manager.Action;
using Asterisk.NET.Manager.Response;

namespace Asterisk.NET.WinForm
{
    public partial class FormMain : Form
    {
        // Dados de conexão
        private bool _conectado;
        private string _address;
        private int _port;
        private string _user;
        private string _password;
        private bool _gravando = false;

        private int _actionID;
        private ManagerConnection _manager;

        // Mensagens enviadas e recebidas do Asterisk.
        private Dictionary<int, string> _messages_spy;
        private Object _lock_messages;
        private string _filter;

        public FormMain()
        {
            InitializeComponent();

            _actionID = 0;
            _manager = null;

            _messages_spy = new Dictionary<int, string>();
            _lock_messages = new Object();
            _filter = "";
        }

        private void conectar()
        {
            _address = this.tbAddress.Text;
            _port = int.Parse(this.tbPort.Text);
            _user = this.tbUser.Text;
            _password = this.tbPassword.Text;

            _manager = new ManagerConnection(_address, _port, _user, _password);

            // Define os eventos
            _manager.UnhandledEvent += new ManagerEventHandler(manager_Events);
            _manager.ConnectionState += new ConnectionStateEventHandler(tratar_connection_state);
            _manager.DialBegin += new DialBeginEventHandler(tratar_dial_begin);
            _manager.DialEnd += new DialEndEventHandler(tratar_dial_end);
            _manager.Hangup += new HangupEventHandler(tratar_hangup);
            _manager.VarSet += new VarSetEventHandler(tratar_var_set);

            try
            {
                // Uncomment next 2 line comments to Disable timeout (debug mode)
#if (DEBUG)
                _manager.DefaultResponseTimeout = 0;
                _manager.DefaultEventTimeout = 0;
#endif

                // TODO: Fazer tratamento de timeout. (ver se tem timeout, mas quando testei, demorou e nada)
                _manager.Login();

                // TODO: Ver como fazer para logar action login, o interessante seria ver uma forma de no sendaction ele retornar um evento, aí alimentar
                // o campo de spy com esse valor.

                _conectado = true;

                tratar_botoes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connect\n" + ex.Message);
                _manager.Logoff();

                btn_discar.Enabled = false;
            }
        }

        private void desconectar()
        {
            if (this._manager != null)
            {
                _manager.Logoff();
                this._manager = null;

                _conectado = false;
                tratar_botoes();
            }
        }

        private void tratar_botoes()
        {
            btn_discar.Enabled = _conectado;

            if (_conectado)
            {
                btn_conexao.Text = "Desconectar";
                lbl_status.Text = String.Format("Conectado no {0}", _address);
                lbl_status.ForeColor = Color.Blue;
            }
            else
            {
                btn_conexao.Text = "Conectar";
                lbl_status.Text = "Desconectado";
                lbl_status.ForeColor = Color.DarkRed;
            }
        }

        #region TRATAR_EVENTOS

        void manager_Events(object sender, ManagerEvent e)
        {
            register_spy(e.ToString());
        }

        private void tratar_connection_state(object sender, ConnectionStateEvent e)
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)(() =>
                {
                    tratar_connection_state(sender, e);
                }));

                return;
            }

            // TODO: Não recebe na desconexão, provavalmente por já não tem comunicação com o servidor.

            register_spy(e.ToString());
        }

        private void tratar_dial_begin(object sender, DialBeginEvent e)
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)(() =>
                {
                    tratar_dial_begin(sender, e);
                }));

                return;
            }

            if (e.Channel != null)
                txt_channel.Text = e.Channel;
            else
                txt_channel.Text = e.DestChannel;

            register_spy(e.ToString());
        }

        private void tratar_dial_end(object sender, DialEndEvent e)
        {
            register_spy(e.ToString());
        }

        private void tratar_hangup(object sender, HangupEvent e)
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)(() =>
                {
                    tratar_hangup(sender, e);
                }));

                return;
            }

            int position = txt_channel.Text.IndexOf('-');

            if (position > 0)
                txt_channel.Text = txt_channel.Text.Substring(0, position);

            register_spy(e.ToString());
        }

        private void tratar_var_set(object sender, VarSetEvent e)
        {
            register_spy(e.ToString());
        }

        private void register_spy(string text, int? key = null)
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)(() =>
                {
                    register_spy(text);
                }));

                return;
            }

            rch_txt_spy.AppendText("\r\n");
            rch_txt_spy.AppendText(text);
            rch_txt_spy.AppendText("\r\n");
            rch_txt_spy.ScrollToCaret();

            // Se o key não for nulo é porque está filtrando, então não adiciona nas mensagens.
            if (key != null)
                return;

            lock (_lock_messages)
            {
                _messages_spy.Add(_messages_spy.Count + 1, text);
            }
        }

        private void filtrar_spy(string filter)
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)(() =>
                {
                    filtrar_spy(filter);
                }));

                return;
            }

            rch_txt_spy.Clear();

            int qtd_ocorrencias_filtro = 0;

            foreach (KeyValuePair<int, string> message_spy in _messages_spy)
            {
                if (message_spy.Value.ToLower().Contains(_filter))
                {
                    register_spy(message_spy.Value, message_spy.Key);
                    qtd_ocorrencias_filtro++;
                }
            }

            lbl_ocorrencias_filtro.Text = String.Format("Ocorrências no filtro: {0}", qtd_ocorrencias_filtro.ToString());
        }

        #endregion

        #region SEND_ACTIONS

        private void send_originate_action()
        {
            var action = new OriginateAction();
            action.Channel = txt_channel.Text;      //"Khomp/b00c060/952369287";
            action.Context = txt_context.Text;
            action.Exten = txt_exten.Text;
            action.Priority = 1;
            //action.CallerId = "110001";
            action.Timeout = Convert.ToInt32(txt_timeout.Text); // Default 30000 (30 segundos)
            action.Variable = string.Format("var1={0},var2={1},var3={2}", txt_var1.Text, txt_var2.Text, txt_var3.Text);
            action.ActionId = _actionID++.ToString();//"ABCABCTODACRIANCATEMQUELEREESCREVER";

            ManagerResponse mr = _manager.SendAction(action);
            register_spy(action.ToString());
            register_spy(mr.ToString());

            btn_desligar.Enabled = mr.IsSuccess();
            btn_discar.Enabled = !btn_desligar.Enabled;
            btn_mix_monitor.Enabled = mr.IsSuccess();
        }

        private void send_hangup_action()
        {
            if (_gravando)
                send_stop_mix_monitor_action();

            var action = new HangupAction(txt_channel.Text);
            action.ActionId = _actionID++.ToString();

            ManagerResponse mr = _manager.SendAction(action);
            register_spy(action.ToString());
            register_spy(mr.ToString());
                        
            btn_discar.Enabled = mr.IsSuccess();
            btn_desligar.Enabled = !btn_discar.Enabled;
            btn_mix_monitor.Enabled = btn_desligar.Enabled;
        }

        private void send_redirect_action()
        {
            var action = new RedirectAction();
            action.ActionId = _actionID++.ToString();
            action.Channel = "SIP/110002";
            action.Exten = "110002";
            action.Context = "lbv-spo";
            action.Priority = 1;

            ManagerResponse mr = _manager.SendAction(action);
            register_spy(action.ToString());
            register_spy(mr.ToString());
        }

        private void send_command_action()
        {
            var action = new CommandAction();
            action.Command = txt_command.Text;

            ManagerResponse mr = _manager.SendAction(action);
            register_spy(action.ToString());
            register_spy(mr.ToString());
        }

        private void send_mix_monitor_action()
        {
            var action = new MixMonitorAction();
            action.ActionId = _actionID++.ToString();
            action.Channel = txt_channel.Text;
            string nmr_arquivo = DateTime.Now.ToString("yyyyMMddHHmmss");
            action.File = nmr_arquivo + ".wav";

            ManagerResponse mr = _manager.SendAction(action);
            register_spy(action.ToString());
            register_spy(mr.ToString());

            _gravando = mr.IsSuccess();

            btn_stop_mix_monitor.Enabled = mr.IsSuccess();
            btn_mix_monitor.Enabled = !btn_stop_mix_monitor.Enabled;
        }

        private void send_stop_mix_monitor_action()
        {
            var action = new StopMixMonitorAction();
            action.ActionId = _actionID++.ToString();
            action.Channel = txt_channel.Text;

            ManagerResponse mr = _manager.SendAction(action);
            register_spy(action.ToString());
            register_spy(mr.ToString());

            _gravando = !mr.IsSuccess();

            btn_mix_monitor.Enabled = mr.IsSuccess();
            btn_stop_mix_monitor.Enabled = !btn_mix_monitor.Enabled;
        }

        #endregion

        #region EVENTOS_FORMULÁRIO

        private void btn_conexao_Click(object sender, EventArgs e)
        {
            if (_conectado)
                desconectar();
            else
                conectar();
        }

        private void btn_discar_Click(object sender, EventArgs e)
        {
            send_originate_action();
        }

        private void btn_desligar_Click(object sender, EventArgs e)
        {
            send_hangup_action();
        }

        private void btn_send_command_Click(object sender, EventArgs e)
        {
            send_command_action();
        }

        private void btn_redirect_Click(object sender, EventArgs e)
        {
            send_redirect_action();
        }

        private void btn_expand_collapse_Click(object sender, EventArgs e)
        {
            this.Size = btn_expand_collapse.Text.Contains("> >") ? new Size(565, 516) : new Size(252, 516);
            btn_expand_collapse.Text = btn_expand_collapse.Text.Contains("> >") ? "< <" : "> >";
        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            if (txt_filter.Text.ToLower() == _filter)
                return;

            _filter = txt_filter.Text.ToLower();
            filtrar_spy(_filter);
        }

        private void btn_clear_filter_Click(object sender, EventArgs e)
        {
            // Limpa o filtro e pesquisa novamente passando o filtro limpo para mostrar tudo.
            _filter = "";
            filtrar_spy(_filter);
        }

        private void btn_mix_monitor_Click(object sender, EventArgs e)
        {
            send_mix_monitor_action();
        }

        private void btn_stop_mix_monitor_Click(object sender, EventArgs e)
        {
            send_stop_mix_monitor_action();
        }

        private void rch_txt_spy_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                return;

            ContextMenu context_menu = new ContextMenu();

            MenuItem menuItem = new MenuItem("Limpar log");
            menuItem.Click += new EventHandler(limpar_log);
            context_menu.MenuItems.Add(menuItem);

            menuItem = new MenuItem("Copiar log");
            menuItem.Click += new EventHandler(copiar_log);
            context_menu.MenuItems.Add(menuItem);

            rch_txt_spy.ContextMenu = context_menu;
        }

        private void limpar_log(object sender, EventArgs e)
        {
            _messages_spy.Clear();
            rch_txt_spy.Clear();
        }

        private void copiar_log(object sender, EventArgs e)
        {
            rch_txt_spy.SelectAll();
            rch_txt_spy.Copy();
        }

        #endregion

    }
}
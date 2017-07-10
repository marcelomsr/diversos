using DB2CoreOdbc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administrator
{
    public partial class AdministratorForm : Form
    {
        private ConnectDB2 _connection;
        private bool _combinateKeysPressed;

        public AdministratorForm()
        {
            InitializeComponent();

            populate_combo_databases();
        }

        private void populate_combo_databases()
        {
            Dictionary<string, Database> items = new Dictionary<string, Database>();

            Database apn_vld_zehahahaha = new Database();
            apn_vld_zehahahaha.name_connection = "APNVLD - Zehahahaha";
            apn_vld_zehahahaha.dsn = "APNVLD";
            apn_vld_zehahahaha.user = "ADMUSR";
            apn_vld_zehahahaha.password = "admlight";
            
            Database apn_vld_marcelo = new Database();
            apn_vld_marcelo.name_connection = "APNVLD - marcelo_";
            apn_vld_marcelo.dsn = "APNVLD";
            apn_vld_marcelo.user = "marcelo_";
            apn_vld_marcelo.password = "10155996";

            Database apn_des_desenv = new Database();
            apn_des_desenv.name_connection = "APNDES - desenv";
            apn_des_desenv.dsn = "APNDES";
            apn_des_desenv.user = "desenv";
            apn_des_desenv.password = "envdes";
                        
            items.Add(apn_vld_zehahahaha.name_connection, apn_vld_zehahahaha);
            items.Add(apn_vld_marcelo.name_connection, apn_vld_marcelo);
            items.Add(apn_des_desenv.name_connection, apn_des_desenv);

            BindingSource binding_databases = new BindingSource(items, null);
                        
            cbo_databases.DataSource = binding_databases;
            cbo_databases.DisplayMember = "Key";
            cbo_databases.ValueMember = "Value";

            cbo_databases.SelectedIndex = 0;
        }

        private void mmo_script_KeyDown(object sender, KeyEventArgs e)
        {
            _combinateKeysPressed = false;
            var resultado = -1;

            try
            {
                // Se o usuário pressionar as teclas Control + Enter, o sistema será fechado.
                if (Control.ModifierKeys == Keys.Control && e.KeyCode == Keys.Enter)
                {
                    _combinateKeysPressed = true;
                    resultado = _connection.executeNonQuery(mmo_script.SelectedText);
                }
            }
            catch (Exception ex)
            {
                mmo_result.Text += string.Format("Script:\r\n{0}\r\n\r\nResult:\r\n{1}\r\n\r\n", mmo_script.SelectedText, ex.Message);
                mmo_result.Text += "---------------------------------------------\r\n\r\n";
            }
            finally
            {
                if (resultado != -1)
                {
                    mmo_result.Text += string.Format("Script:\r\n{0}\r\n\r\nLinhas afetadas:\r\n{1}\r\n\r\n", mmo_script.SelectedText, resultado);
                    mmo_result.Text += "---------------------------------------------\r\n\r\n";
                }
            }            
        }

        private void mmo_script_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (_combinateKeysPressed)
            {
                e.Cancel = true;
            }
        }

        private void AdministratorForm_Load(object sender, EventArgs e)
        {
            connect();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            connect();
        }

        private void connect()
        {
            Database database = (Database)cbo_databases.SelectedValue;

            _connection = new ConnectDB2(database.dsn, database.user, database.password);

            if (_connection._statusConnection)
            {
                _connection.closeConnection();
                tool_label.Text = database.name_connection;
            }
            else
            {
                tool_label.Text = "Não foi possível conectar\n" + _connection._error;
            }
        }

        private void btn_commit_Click(object sender, EventArgs e)
        {
            _connection.commitTransaction();
        }

        private void btn_rollback_Click(object sender, EventArgs e)
        {
            _connection.rollbackTransaction();
        }
    }

    public class Database
    {
        public string name_connection;
        public string dsn;
        public string user;
        public string password;
    }
}
namespace Asterisk.NET.WinForm
{
	partial class FormMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.lbl_host = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.grp_box_connection = new System.Windows.Forms.GroupBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbl_port = new System.Windows.Forms.Label();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.btn_discar = new System.Windows.Forms.Button();
            this.txt_command = new System.Windows.Forms.TextBox();
            this.btn_send_command = new System.Windows.Forms.Button();
            this.btn_redirect = new System.Windows.Forms.Button();
            this.txt_var1 = new System.Windows.Forms.TextBox();
            this.txt_var2 = new System.Windows.Forms.TextBox();
            this.txt_var3 = new System.Windows.Forms.TextBox();
            this.lbl_var1 = new System.Windows.Forms.Label();
            this.lbl_var2 = new System.Windows.Forms.Label();
            this.lbl_var3 = new System.Windows.Forms.Label();
            this.lbl_channel = new System.Windows.Forms.Label();
            this.txt_channel = new System.Windows.Forms.TextBox();
            this.lbl_exten = new System.Windows.Forms.Label();
            this.txt_exten = new System.Windows.Forms.TextBox();
            this.lbl_context = new System.Windows.Forms.Label();
            this.txt_context = new System.Windows.Forms.TextBox();
            this.btn_desligar = new System.Windows.Forms.Button();
            this.lbl_timeout = new System.Windows.Forms.Label();
            this.txt_timeout = new System.Windows.Forms.TextBox();
            this.lbl_priority = new System.Windows.Forms.Label();
            this.txt_priority = new System.Windows.Forms.TextBox();
            this.stt_strip = new System.Windows.Forms.StatusStrip();
            this.lbl_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_conexao = new System.Windows.Forms.Button();
            this.btn_expand_collapse = new System.Windows.Forms.Button();
            this.rch_txt_spy = new System.Windows.Forms.RichTextBox();
            this.txt_filter = new System.Windows.Forms.TextBox();
            this.btn_filter = new System.Windows.Forms.Button();
            this.lbl_ocorrencias_filtro = new System.Windows.Forms.Label();
            this.btn_clear_filter = new System.Windows.Forms.Button();
            this.btn_stop_mix_monitor = new System.Windows.Forms.Button();
            this.btn_mix_monitor = new System.Windows.Forms.Button();
            this.grp_box_connection.SuspendLayout();
            this.stt_strip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_host
            // 
            this.lbl_host.AutoSize = true;
            this.lbl_host.Location = new System.Drawing.Point(6, 24);
            this.lbl_host.Name = "lbl_host";
            this.lbl_host.Size = new System.Drawing.Size(29, 13);
            this.lbl_host.TabIndex = 0;
            this.lbl_host.Text = "Host";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(94, 19);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(100, 20);
            this.tbAddress.TabIndex = 1;
            this.tbAddress.Text = "10.0.68.56";
            // 
            // grp_box_connection
            // 
            this.grp_box_connection.Controls.Add(this.lbl_password);
            this.grp_box_connection.Controls.Add(this.lbl_user);
            this.grp_box_connection.Controls.Add(this.tbUser);
            this.grp_box_connection.Controls.Add(this.tbPassword);
            this.grp_box_connection.Controls.Add(this.lbl_port);
            this.grp_box_connection.Controls.Add(this.tbPort);
            this.grp_box_connection.Controls.Add(this.lbl_host);
            this.grp_box_connection.Controls.Add(this.tbAddress);
            this.grp_box_connection.Location = new System.Drawing.Point(1, 1);
            this.grp_box_connection.Name = "grp_box_connection";
            this.grp_box_connection.Size = new System.Drawing.Size(200, 124);
            this.grp_box_connection.TabIndex = 2;
            this.grp_box_connection.TabStop = false;
            this.grp_box_connection.Text = "Parameters connection";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(6, 102);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(53, 13);
            this.lbl_password.TabIndex = 6;
            this.lbl_password.Text = "Password";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Location = new System.Drawing.Point(6, 76);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(29, 13);
            this.lbl_user.TabIndex = 4;
            this.lbl_user.Text = "User";
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(94, 71);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(100, 20);
            this.tbUser.TabIndex = 3;
            this.tbUser.Text = "ctiuser";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(94, 97);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(100, 20);
            this.tbPassword.TabIndex = 4;
            this.tbPassword.Text = "CTIuser01%";
            // 
            // lbl_port
            // 
            this.lbl_port.AutoSize = true;
            this.lbl_port.Location = new System.Drawing.Point(6, 50);
            this.lbl_port.Name = "lbl_port";
            this.lbl_port.Size = new System.Drawing.Size(26, 13);
            this.lbl_port.TabIndex = 2;
            this.lbl_port.Text = "Port";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(94, 45);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(100, 20);
            this.tbPort.TabIndex = 2;
            this.tbPort.Text = "5039";
            // 
            // btn_discar
            // 
            this.btn_discar.Enabled = false;
            this.btn_discar.Location = new System.Drawing.Point(10, 157);
            this.btn_discar.Name = "btn_discar";
            this.btn_discar.Size = new System.Drawing.Size(90, 23);
            this.btn_discar.TabIndex = 5;
            this.btn_discar.Text = "Discar";
            this.btn_discar.UseVisualStyleBackColor = true;
            this.btn_discar.Click += new System.EventHandler(this.btn_discar_Click);
            // 
            // txt_command
            // 
            this.txt_command.Location = new System.Drawing.Point(10, 426);
            this.txt_command.Name = "txt_command";
            this.txt_command.Size = new System.Drawing.Size(186, 20);
            this.txt_command.TabIndex = 10;
            this.txt_command.Text = "dialplan show";
            // 
            // btn_send_command
            // 
            this.btn_send_command.Location = new System.Drawing.Point(10, 454);
            this.btn_send_command.Name = "btn_send_command";
            this.btn_send_command.Size = new System.Drawing.Size(186, 23);
            this.btn_send_command.TabIndex = 11;
            this.btn_send_command.Text = "Enviar comando";
            this.btn_send_command.UseVisualStyleBackColor = true;
            this.btn_send_command.Click += new System.EventHandler(this.btn_send_command_Click);
            // 
            // btn_redirect
            // 
            this.btn_redirect.Enabled = false;
            this.btn_redirect.Location = new System.Drawing.Point(105, 128);
            this.btn_redirect.Name = "btn_redirect";
            this.btn_redirect.Size = new System.Drawing.Size(90, 23);
            this.btn_redirect.TabIndex = 10;
            this.btn_redirect.Text = "Redirect";
            this.btn_redirect.UseVisualStyleBackColor = true;
            this.btn_redirect.Click += new System.EventHandler(this.btn_redirect_Click);
            // 
            // txt_var1
            // 
            this.txt_var1.Location = new System.Drawing.Point(70, 348);
            this.txt_var1.Name = "txt_var1";
            this.txt_var1.Size = new System.Drawing.Size(126, 20);
            this.txt_var1.TabIndex = 9;
            this.txt_var1.Text = "var1";
            // 
            // txt_var2
            // 
            this.txt_var2.Location = new System.Drawing.Point(70, 374);
            this.txt_var2.Name = "txt_var2";
            this.txt_var2.Size = new System.Drawing.Size(126, 20);
            this.txt_var2.TabIndex = 10;
            this.txt_var2.Text = "var2";
            // 
            // txt_var3
            // 
            this.txt_var3.Location = new System.Drawing.Point(70, 400);
            this.txt_var3.Name = "txt_var3";
            this.txt_var3.Size = new System.Drawing.Size(126, 20);
            this.txt_var3.TabIndex = 11;
            this.txt_var3.Text = "var3";
            // 
            // lbl_var1
            // 
            this.lbl_var1.AutoSize = true;
            this.lbl_var1.Location = new System.Drawing.Point(13, 351);
            this.lbl_var1.Name = "lbl_var1";
            this.lbl_var1.Size = new System.Drawing.Size(28, 13);
            this.lbl_var1.TabIndex = 10;
            this.lbl_var1.Text = "var1";
            // 
            // lbl_var2
            // 
            this.lbl_var2.AutoSize = true;
            this.lbl_var2.Location = new System.Drawing.Point(12, 377);
            this.lbl_var2.Name = "lbl_var2";
            this.lbl_var2.Size = new System.Drawing.Size(28, 13);
            this.lbl_var2.TabIndex = 14;
            this.lbl_var2.Text = "var2";
            // 
            // lbl_var3
            // 
            this.lbl_var3.AutoSize = true;
            this.lbl_var3.Location = new System.Drawing.Point(13, 403);
            this.lbl_var3.Name = "lbl_var3";
            this.lbl_var3.Size = new System.Drawing.Size(28, 13);
            this.lbl_var3.TabIndex = 15;
            this.lbl_var3.Text = "var3";
            // 
            // lbl_channel
            // 
            this.lbl_channel.AutoSize = true;
            this.lbl_channel.Location = new System.Drawing.Point(12, 223);
            this.lbl_channel.Name = "lbl_channel";
            this.lbl_channel.Size = new System.Drawing.Size(46, 13);
            this.lbl_channel.TabIndex = 16;
            this.lbl_channel.Text = "Channel";
            // 
            // txt_channel
            // 
            this.txt_channel.Location = new System.Drawing.Point(70, 220);
            this.txt_channel.Name = "txt_channel";
            this.txt_channel.Size = new System.Drawing.Size(126, 20);
            this.txt_channel.TabIndex = 6;
            this.txt_channel.Text = "SIP/551101";
            // 
            // lbl_exten
            // 
            this.lbl_exten.AutoSize = true;
            this.lbl_exten.Location = new System.Drawing.Point(12, 247);
            this.lbl_exten.Name = "lbl_exten";
            this.lbl_exten.Size = new System.Drawing.Size(34, 13);
            this.lbl_exten.TabIndex = 18;
            this.lbl_exten.Text = "Exten";
            // 
            // txt_exten
            // 
            this.txt_exten.Location = new System.Drawing.Point(70, 244);
            this.txt_exten.Name = "txt_exten";
            this.txt_exten.Size = new System.Drawing.Size(126, 20);
            this.txt_exten.TabIndex = 7;
            this.txt_exten.Text = "551102";
            // 
            // lbl_context
            // 
            this.lbl_context.AutoSize = true;
            this.lbl_context.Location = new System.Drawing.Point(12, 273);
            this.lbl_context.Name = "lbl_context";
            this.lbl_context.Size = new System.Drawing.Size(43, 13);
            this.lbl_context.TabIndex = 20;
            this.lbl_context.Text = "Context";
            // 
            // txt_context
            // 
            this.txt_context.Location = new System.Drawing.Point(70, 270);
            this.txt_context.Name = "txt_context";
            this.txt_context.Size = new System.Drawing.Size(126, 20);
            this.txt_context.TabIndex = 8;
            this.txt_context.Text = "agentes";
            // 
            // btn_desligar
            // 
            this.btn_desligar.Enabled = false;
            this.btn_desligar.Location = new System.Drawing.Point(105, 157);
            this.btn_desligar.Name = "btn_desligar";
            this.btn_desligar.Size = new System.Drawing.Size(90, 23);
            this.btn_desligar.TabIndex = 21;
            this.btn_desligar.Text = "Desligar";
            this.btn_desligar.UseVisualStyleBackColor = true;
            this.btn_desligar.Click += new System.EventHandler(this.btn_desligar_Click);
            // 
            // lbl_timeout
            // 
            this.lbl_timeout.AutoSize = true;
            this.lbl_timeout.Location = new System.Drawing.Point(12, 325);
            this.lbl_timeout.Name = "lbl_timeout";
            this.lbl_timeout.Size = new System.Drawing.Size(45, 13);
            this.lbl_timeout.TabIndex = 23;
            this.lbl_timeout.Text = "Timeout";
            // 
            // txt_timeout
            // 
            this.txt_timeout.Location = new System.Drawing.Point(70, 322);
            this.txt_timeout.Name = "txt_timeout";
            this.txt_timeout.Size = new System.Drawing.Size(126, 20);
            this.txt_timeout.TabIndex = 22;
            this.txt_timeout.Text = "30000";
            // 
            // lbl_priority
            // 
            this.lbl_priority.AutoSize = true;
            this.lbl_priority.Location = new System.Drawing.Point(12, 299);
            this.lbl_priority.Name = "lbl_priority";
            this.lbl_priority.Size = new System.Drawing.Size(38, 13);
            this.lbl_priority.TabIndex = 25;
            this.lbl_priority.Text = "Priority";
            // 
            // txt_priority
            // 
            this.txt_priority.Location = new System.Drawing.Point(70, 296);
            this.txt_priority.Name = "txt_priority";
            this.txt_priority.Size = new System.Drawing.Size(126, 20);
            this.txt_priority.TabIndex = 24;
            this.txt_priority.Text = "1";
            // 
            // stt_strip
            // 
            this.stt_strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_status});
            this.stt_strip.Location = new System.Drawing.Point(0, 488);
            this.stt_strip.Name = "stt_strip";
            this.stt_strip.Size = new System.Drawing.Size(632, 22);
            this.stt_strip.TabIndex = 26;
            this.stt_strip.Text = "statusStrip1";
            // 
            // lbl_status
            // 
            this.lbl_status.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_status.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(86, 17);
            this.lbl_status.Text = "Desconectado";
            // 
            // btn_conexao
            // 
            this.btn_conexao.Location = new System.Drawing.Point(10, 128);
            this.btn_conexao.Name = "btn_conexao";
            this.btn_conexao.Size = new System.Drawing.Size(90, 23);
            this.btn_conexao.TabIndex = 27;
            this.btn_conexao.Text = "Conectar";
            this.btn_conexao.UseVisualStyleBackColor = true;
            this.btn_conexao.Click += new System.EventHandler(this.btn_conexao_Click);
            // 
            // btn_expand_collapse
            // 
            this.btn_expand_collapse.Location = new System.Drawing.Point(201, 141);
            this.btn_expand_collapse.Name = "btn_expand_collapse";
            this.btn_expand_collapse.Size = new System.Drawing.Size(31, 23);
            this.btn_expand_collapse.TabIndex = 28;
            this.btn_expand_collapse.Text = "< <";
            this.btn_expand_collapse.UseVisualStyleBackColor = true;
            this.btn_expand_collapse.Click += new System.EventHandler(this.btn_expand_collapse_Click);
            // 
            // rch_txt_spy
            // 
            this.rch_txt_spy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rch_txt_spy.Location = new System.Drawing.Point(238, 46);
            this.rch_txt_spy.Name = "rch_txt_spy";
            this.rch_txt_spy.ReadOnly = true;
            this.rch_txt_spy.Size = new System.Drawing.Size(387, 431);
            this.rch_txt_spy.TabIndex = 29;
            this.rch_txt_spy.Text = "";
            this.rch_txt_spy.WordWrap = false;
            this.rch_txt_spy.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rch_txt_spy_MouseDown);
            // 
            // txt_filter
            // 
            this.txt_filter.Location = new System.Drawing.Point(238, 7);
            this.txt_filter.Name = "txt_filter";
            this.txt_filter.Size = new System.Drawing.Size(225, 20);
            this.txt_filter.TabIndex = 30;
            this.txt_filter.Text = "Originate";
            // 
            // btn_filter
            // 
            this.btn_filter.Location = new System.Drawing.Point(469, 5);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(73, 23);
            this.btn_filter.TabIndex = 31;
            this.btn_filter.Text = "Filtrar";
            this.btn_filter.UseVisualStyleBackColor = true;
            this.btn_filter.Click += new System.EventHandler(this.btn_filtrar_Click);
            // 
            // lbl_ocorrencias_filtro
            // 
            this.lbl_ocorrencias_filtro.AutoSize = true;
            this.lbl_ocorrencias_filtro.Location = new System.Drawing.Point(235, 30);
            this.lbl_ocorrencias_filtro.Name = "lbl_ocorrencias_filtro";
            this.lbl_ocorrencias_filtro.Size = new System.Drawing.Size(113, 13);
            this.lbl_ocorrencias_filtro.TabIndex = 32;
            this.lbl_ocorrencias_filtro.Text = "Ocorrências no filtro: 0";
            // 
            // btn_clear_filter
            // 
            this.btn_clear_filter.Location = new System.Drawing.Point(548, 5);
            this.btn_clear_filter.Name = "btn_clear_filter";
            this.btn_clear_filter.Size = new System.Drawing.Size(73, 23);
            this.btn_clear_filter.TabIndex = 33;
            this.btn_clear_filter.Text = "Limpar filtro";
            this.btn_clear_filter.UseVisualStyleBackColor = true;
            this.btn_clear_filter.Click += new System.EventHandler(this.btn_clear_filter_Click);
            // 
            // btn_stop_mix_monitor
            // 
            this.btn_stop_mix_monitor.Enabled = false;
            this.btn_stop_mix_monitor.Location = new System.Drawing.Point(105, 186);
            this.btn_stop_mix_monitor.Name = "btn_stop_mix_monitor";
            this.btn_stop_mix_monitor.Size = new System.Drawing.Size(90, 23);
            this.btn_stop_mix_monitor.TabIndex = 35;
            this.btn_stop_mix_monitor.Text = "Stop Mix Monitor";
            this.btn_stop_mix_monitor.UseVisualStyleBackColor = true;
            this.btn_stop_mix_monitor.Click += new System.EventHandler(this.btn_stop_mix_monitor_Click);
            // 
            // btn_mix_monitor
            // 
            this.btn_mix_monitor.Enabled = false;
            this.btn_mix_monitor.Location = new System.Drawing.Point(10, 186);
            this.btn_mix_monitor.Name = "btn_mix_monitor";
            this.btn_mix_monitor.Size = new System.Drawing.Size(90, 23);
            this.btn_mix_monitor.TabIndex = 34;
            this.btn_mix_monitor.Text = "Mix Monitor";
            this.btn_mix_monitor.UseVisualStyleBackColor = true;
            this.btn_mix_monitor.Click += new System.EventHandler(this.btn_mix_monitor_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 510);
            this.Controls.Add(this.btn_stop_mix_monitor);
            this.Controls.Add(this.btn_mix_monitor);
            this.Controls.Add(this.btn_clear_filter);
            this.Controls.Add(this.lbl_ocorrencias_filtro);
            this.Controls.Add(this.btn_filter);
            this.Controls.Add(this.txt_filter);
            this.Controls.Add(this.rch_txt_spy);
            this.Controls.Add(this.btn_expand_collapse);
            this.Controls.Add(this.btn_conexao);
            this.Controls.Add(this.stt_strip);
            this.Controls.Add(this.lbl_priority);
            this.Controls.Add(this.txt_priority);
            this.Controls.Add(this.lbl_timeout);
            this.Controls.Add(this.txt_timeout);
            this.Controls.Add(this.btn_desligar);
            this.Controls.Add(this.lbl_context);
            this.Controls.Add(this.txt_context);
            this.Controls.Add(this.lbl_exten);
            this.Controls.Add(this.txt_exten);
            this.Controls.Add(this.lbl_channel);
            this.Controls.Add(this.txt_channel);
            this.Controls.Add(this.lbl_var3);
            this.Controls.Add(this.lbl_var2);
            this.Controls.Add(this.lbl_var1);
            this.Controls.Add(this.txt_var3);
            this.Controls.Add(this.txt_var2);
            this.Controls.Add(this.txt_var1);
            this.Controls.Add(this.btn_redirect);
            this.Controls.Add(this.btn_send_command);
            this.Controls.Add(this.txt_command);
            this.Controls.Add(this.btn_discar);
            this.Controls.Add(this.grp_box_connection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client for Asterisk";
            this.TopMost = true;
            this.grp_box_connection.ResumeLayout(false);
            this.grp_box_connection.PerformLayout();
            this.stt_strip.ResumeLayout(false);
            this.stt_strip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl_host;
		private System.Windows.Forms.TextBox tbAddress;
		private System.Windows.Forms.GroupBox grp_box_connection;
		private System.Windows.Forms.Label lbl_user;
		private System.Windows.Forms.TextBox tbUser;
		private System.Windows.Forms.Label lbl_port;
		private System.Windows.Forms.TextBox tbPort;
		private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btn_discar;
        private System.Windows.Forms.TextBox txt_command;
        private System.Windows.Forms.Button btn_send_command;
        private System.Windows.Forms.Button btn_redirect;
        private System.Windows.Forms.TextBox txt_var1;
        private System.Windows.Forms.TextBox txt_var2;
        private System.Windows.Forms.TextBox txt_var3;
        private System.Windows.Forms.Label lbl_var1;
        private System.Windows.Forms.Label lbl_var2;
        private System.Windows.Forms.Label lbl_var3;
        private System.Windows.Forms.Label lbl_channel;
        private System.Windows.Forms.TextBox txt_channel;
        private System.Windows.Forms.Label lbl_exten;
        private System.Windows.Forms.TextBox txt_exten;
        private System.Windows.Forms.Label lbl_context;
        private System.Windows.Forms.TextBox txt_context;
        private System.Windows.Forms.Button btn_desligar;
        private System.Windows.Forms.Label lbl_timeout;
        private System.Windows.Forms.TextBox txt_timeout;
        private System.Windows.Forms.Label lbl_priority;
        private System.Windows.Forms.TextBox txt_priority;
        private System.Windows.Forms.StatusStrip stt_strip;
        private System.Windows.Forms.ToolStripStatusLabel lbl_status;
        private System.Windows.Forms.Button btn_conexao;
        private System.Windows.Forms.Button btn_expand_collapse;
        private System.Windows.Forms.RichTextBox rch_txt_spy;
        private System.Windows.Forms.TextBox txt_filter;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.Label lbl_ocorrencias_filtro;
        private System.Windows.Forms.Button btn_clear_filter;
        private System.Windows.Forms.Button btn_stop_mix_monitor;
        private System.Windows.Forms.Button btn_mix_monitor;
    }
}


namespace CommandIpDevice
{
    partial class CommandIpDevice
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
            this.btn_send_command = new System.Windows.Forms.Button();
            this.txtUserDevice = new System.Windows.Forms.TextBox();
            this.txtPasswordDevice = new System.Windows.Forms.TextBox();
            this.lblUserDevice = new System.Windows.Forms.Label();
            this.lblPasswordDevice = new System.Windows.Forms.Label();
            this.lblCommandDevice = new System.Windows.Forms.Label();
            this.cboCommand = new System.Windows.Forms.ComboBox();
            this.grbConnectionServerAsterisk = new System.Windows.Forms.GroupBox();
            this.lblPasswordUserAsterisk = new System.Windows.Forms.Label();
            this.lblUserServerAsterisk = new System.Windows.Forms.Label();
            this.txtUserServerAsterisk = new System.Windows.Forms.TextBox();
            this.txtPasswordServerAsterisk = new System.Windows.Forms.TextBox();
            this.lblPortServerAsterisk = new System.Windows.Forms.Label();
            this.txtPortServerAsterisk = new System.Windows.Forms.TextBox();
            this.lblHostServerAsterisk = new System.Windows.Forms.Label();
            this.txtHostServerAsterisk = new System.Windows.Forms.TextBox();
            this.grbIPDevice = new System.Windows.Forms.GroupBox();
            this.btnConnectServerAsterisk = new System.Windows.Forms.Button();
            this.btnListDevices = new System.Windows.Forms.Button();
            this.chkLstDevices = new System.Windows.Forms.CheckedListBox();
            this.grbConnectionServerAsterisk.SuspendLayout();
            this.grbIPDevice.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_send_command
            // 
            this.btn_send_command.Location = new System.Drawing.Point(211, 344);
            this.btn_send_command.Name = "btn_send_command";
            this.btn_send_command.Size = new System.Drawing.Size(93, 23);
            this.btn_send_command.TabIndex = 4;
            this.btn_send_command.Text = "Send Command";
            this.btn_send_command.UseVisualStyleBackColor = true;
            this.btn_send_command.Click += new System.EventHandler(this.btn_send_command_Click);
            // 
            // txtUserDevice
            // 
            this.txtUserDevice.Location = new System.Drawing.Point(104, 29);
            this.txtUserDevice.Name = "txtUserDevice";
            this.txtUserDevice.Size = new System.Drawing.Size(125, 20);
            this.txtUserDevice.TabIndex = 1;
            // 
            // txtPasswordDevice
            // 
            this.txtPasswordDevice.Location = new System.Drawing.Point(104, 55);
            this.txtPasswordDevice.Name = "txtPasswordDevice";
            this.txtPasswordDevice.PasswordChar = '*';
            this.txtPasswordDevice.Size = new System.Drawing.Size(125, 20);
            this.txtPasswordDevice.TabIndex = 2;
            // 
            // lblUserDevice
            // 
            this.lblUserDevice.AutoSize = true;
            this.lblUserDevice.Location = new System.Drawing.Point(10, 32);
            this.lblUserDevice.Name = "lblUserDevice";
            this.lblUserDevice.Size = new System.Drawing.Size(64, 13);
            this.lblUserDevice.TabIndex = 3;
            this.lblUserDevice.Text = "User device";
            // 
            // lblPasswordDevice
            // 
            this.lblPasswordDevice.AutoSize = true;
            this.lblPasswordDevice.Location = new System.Drawing.Point(10, 58);
            this.lblPasswordDevice.Name = "lblPasswordDevice";
            this.lblPasswordDevice.Size = new System.Drawing.Size(88, 13);
            this.lblPasswordDevice.TabIndex = 4;
            this.lblPasswordDevice.Text = "Password device";
            // 
            // lblCommandDevice
            // 
            this.lblCommandDevice.AutoSize = true;
            this.lblCommandDevice.Location = new System.Drawing.Point(10, 84);
            this.lblCommandDevice.Name = "lblCommandDevice";
            this.lblCommandDevice.Size = new System.Drawing.Size(54, 13);
            this.lblCommandDevice.TabIndex = 5;
            this.lblCommandDevice.Text = "Command";
            // 
            // cboCommand
            // 
            this.cboCommand.FormattingEnabled = true;
            this.cboCommand.Items.AddRange(new object[] {
            "Reboot",
            "OK",
            "ENTER",
            "VOLUME_UP",
            "VOLUME_DOWN",
            "MUTE"});
            this.cboCommand.Location = new System.Drawing.Point(104, 81);
            this.cboCommand.Name = "cboCommand";
            this.cboCommand.Size = new System.Drawing.Size(125, 21);
            this.cboCommand.TabIndex = 3;
            // 
            // grbConnectionServerAsterisk
            // 
            this.grbConnectionServerAsterisk.Controls.Add(this.btnListDevices);
            this.grbConnectionServerAsterisk.Controls.Add(this.btnConnectServerAsterisk);
            this.grbConnectionServerAsterisk.Controls.Add(this.lblPasswordUserAsterisk);
            this.grbConnectionServerAsterisk.Controls.Add(this.lblUserServerAsterisk);
            this.grbConnectionServerAsterisk.Controls.Add(this.txtUserServerAsterisk);
            this.grbConnectionServerAsterisk.Controls.Add(this.txtPasswordServerAsterisk);
            this.grbConnectionServerAsterisk.Controls.Add(this.lblPortServerAsterisk);
            this.grbConnectionServerAsterisk.Controls.Add(this.txtPortServerAsterisk);
            this.grbConnectionServerAsterisk.Controls.Add(this.lblHostServerAsterisk);
            this.grbConnectionServerAsterisk.Controls.Add(this.txtHostServerAsterisk);
            this.grbConnectionServerAsterisk.Location = new System.Drawing.Point(12, 12);
            this.grbConnectionServerAsterisk.Name = "grbConnectionServerAsterisk";
            this.grbConnectionServerAsterisk.Size = new System.Drawing.Size(240, 161);
            this.grbConnectionServerAsterisk.TabIndex = 6;
            this.grbConnectionServerAsterisk.TabStop = false;
            this.grbConnectionServerAsterisk.Text = "Asterisk Server - Parameters connection";
            // 
            // lblPasswordUserAsterisk
            // 
            this.lblPasswordUserAsterisk.AutoSize = true;
            this.lblPasswordUserAsterisk.Location = new System.Drawing.Point(6, 100);
            this.lblPasswordUserAsterisk.Name = "lblPasswordUserAsterisk";
            this.lblPasswordUserAsterisk.Size = new System.Drawing.Size(53, 13);
            this.lblPasswordUserAsterisk.TabIndex = 6;
            this.lblPasswordUserAsterisk.Text = "Password";
            // 
            // lblUserServerAsterisk
            // 
            this.lblUserServerAsterisk.AutoSize = true;
            this.lblUserServerAsterisk.Location = new System.Drawing.Point(6, 74);
            this.lblUserServerAsterisk.Name = "lblUserServerAsterisk";
            this.lblUserServerAsterisk.Size = new System.Drawing.Size(29, 13);
            this.lblUserServerAsterisk.TabIndex = 4;
            this.lblUserServerAsterisk.Text = "User";
            // 
            // txtUserServerAsterisk
            // 
            this.txtUserServerAsterisk.Location = new System.Drawing.Point(94, 71);
            this.txtUserServerAsterisk.Name = "txtUserServerAsterisk";
            this.txtUserServerAsterisk.Size = new System.Drawing.Size(100, 20);
            this.txtUserServerAsterisk.TabIndex = 2;
            // 
            // txtPasswordServerAsterisk
            // 
            this.txtPasswordServerAsterisk.Location = new System.Drawing.Point(94, 97);
            this.txtPasswordServerAsterisk.Name = "txtPasswordServerAsterisk";
            this.txtPasswordServerAsterisk.PasswordChar = '*';
            this.txtPasswordServerAsterisk.Size = new System.Drawing.Size(100, 20);
            this.txtPasswordServerAsterisk.TabIndex = 3;
            // 
            // lblPortServerAsterisk
            // 
            this.lblPortServerAsterisk.AutoSize = true;
            this.lblPortServerAsterisk.Location = new System.Drawing.Point(6, 48);
            this.lblPortServerAsterisk.Name = "lblPortServerAsterisk";
            this.lblPortServerAsterisk.Size = new System.Drawing.Size(26, 13);
            this.lblPortServerAsterisk.TabIndex = 2;
            this.lblPortServerAsterisk.Text = "Port";
            // 
            // txtPortServerAsterisk
            // 
            this.txtPortServerAsterisk.Location = new System.Drawing.Point(94, 45);
            this.txtPortServerAsterisk.Name = "txtPortServerAsterisk";
            this.txtPortServerAsterisk.Size = new System.Drawing.Size(100, 20);
            this.txtPortServerAsterisk.TabIndex = 1;
            this.txtPortServerAsterisk.Text = "5039";
            // 
            // lblHostServerAsterisk
            // 
            this.lblHostServerAsterisk.AutoSize = true;
            this.lblHostServerAsterisk.Location = new System.Drawing.Point(6, 22);
            this.lblHostServerAsterisk.Name = "lblHostServerAsterisk";
            this.lblHostServerAsterisk.Size = new System.Drawing.Size(29, 13);
            this.lblHostServerAsterisk.TabIndex = 0;
            this.lblHostServerAsterisk.Text = "Host";
            // 
            // txtHostServerAsterisk
            // 
            this.txtHostServerAsterisk.Location = new System.Drawing.Point(94, 19);
            this.txtHostServerAsterisk.Name = "txtHostServerAsterisk";
            this.txtHostServerAsterisk.Size = new System.Drawing.Size(100, 20);
            this.txtHostServerAsterisk.TabIndex = 0;
            this.txtHostServerAsterisk.Text = "localhost";
            // 
            // grbIPDevice
            // 
            this.grbIPDevice.Controls.Add(this.lblUserDevice);
            this.grbIPDevice.Controls.Add(this.txtUserDevice);
            this.grbIPDevice.Controls.Add(this.cboCommand);
            this.grbIPDevice.Controls.Add(this.txtPasswordDevice);
            this.grbIPDevice.Controls.Add(this.lblCommandDevice);
            this.grbIPDevice.Controls.Add(this.lblPasswordDevice);
            this.grbIPDevice.Enabled = false;
            this.grbIPDevice.Location = new System.Drawing.Point(12, 185);
            this.grbIPDevice.Name = "grbIPDevice";
            this.grbIPDevice.Size = new System.Drawing.Size(240, 124);
            this.grbIPDevice.TabIndex = 7;
            this.grbIPDevice.TabStop = false;
            this.grbIPDevice.Text = "IP Device - Parameters connection";
            // 
            // btnConnectServerAsterisk
            // 
            this.btnConnectServerAsterisk.Location = new System.Drawing.Point(7, 126);
            this.btnConnectServerAsterisk.Name = "btnConnectServerAsterisk";
            this.btnConnectServerAsterisk.Size = new System.Drawing.Size(105, 23);
            this.btnConnectServerAsterisk.TabIndex = 4;
            this.btnConnectServerAsterisk.Text = "Connect Server";
            this.btnConnectServerAsterisk.UseVisualStyleBackColor = true;
            this.btnConnectServerAsterisk.Click += new System.EventHandler(this.btnConnectServerAsterisk_Click);
            // 
            // btnListDevices
            // 
            this.btnListDevices.Enabled = false;
            this.btnListDevices.Location = new System.Drawing.Point(128, 126);
            this.btnListDevices.Name = "btnListDevices";
            this.btnListDevices.Size = new System.Drawing.Size(105, 23);
            this.btnListDevices.TabIndex = 7;
            this.btnListDevices.Text = "List Devices";
            this.btnListDevices.UseVisualStyleBackColor = true;
            this.btnListDevices.Click += new System.EventHandler(this.btnListDevices_Click);
            // 
            // chkLstDevices
            // 
            this.chkLstDevices.Enabled = false;
            this.chkLstDevices.FormattingEnabled = true;
            this.chkLstDevices.Location = new System.Drawing.Point(277, 13);
            this.chkLstDevices.Name = "chkLstDevices";
            this.chkLstDevices.Size = new System.Drawing.Size(243, 304);
            this.chkLstDevices.TabIndex = 8;
            // 
            // CommandIpDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 384);
            this.Controls.Add(this.chkLstDevices);
            this.Controls.Add(this.grbIPDevice);
            this.Controls.Add(this.grbConnectionServerAsterisk);
            this.Controls.Add(this.btn_send_command);
            this.Name = "CommandIpDevice";
            this.Text = "Command IP Device";
            this.grbConnectionServerAsterisk.ResumeLayout(false);
            this.grbConnectionServerAsterisk.PerformLayout();
            this.grbIPDevice.ResumeLayout(false);
            this.grbIPDevice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_send_command;
        private System.Windows.Forms.TextBox txtUserDevice;
        private System.Windows.Forms.TextBox txtPasswordDevice;
        private System.Windows.Forms.Label lblUserDevice;
        private System.Windows.Forms.Label lblPasswordDevice;
        private System.Windows.Forms.Label lblCommandDevice;
        private System.Windows.Forms.ComboBox cboCommand;
        private System.Windows.Forms.GroupBox grbConnectionServerAsterisk;
        private System.Windows.Forms.Label lblPasswordUserAsterisk;
        private System.Windows.Forms.Label lblUserServerAsterisk;
        private System.Windows.Forms.TextBox txtUserServerAsterisk;
        private System.Windows.Forms.TextBox txtPasswordServerAsterisk;
        private System.Windows.Forms.Label lblPortServerAsterisk;
        private System.Windows.Forms.TextBox txtPortServerAsterisk;
        private System.Windows.Forms.Label lblHostServerAsterisk;
        private System.Windows.Forms.TextBox txtHostServerAsterisk;
        private System.Windows.Forms.GroupBox grbIPDevice;
        private System.Windows.Forms.Button btnConnectServerAsterisk;
        private System.Windows.Forms.Button btnListDevices;
        private System.Windows.Forms.CheckedListBox chkLstDevices;
    }
}


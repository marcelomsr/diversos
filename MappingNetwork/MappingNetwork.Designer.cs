namespace Network
{
    partial class MappingNetwork
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MappingNetwork));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btn_map_drive = new System.Windows.Forms.Button();
            this.conStatusBar = new System.Windows.Forms.StatusBar();
            this.conStatusBar_Panel_Action = new System.Windows.Forms.StatusBarPanel();
            this.conMenu = new System.Windows.Forms.MainMenu(this.components);
            this.chk_R = new System.Windows.Forms.CheckBox();
            this.chk_T = new System.Windows.Forms.CheckBox();
            this.chk_S = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conStatusBar_Panel_Action)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_S);
            this.groupBox1.Controls.Add(this.chk_T);
            this.groupBox1.Controls.Add(this.chk_R);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.btn_map_drive);
            this.groupBox1.Location = new System.Drawing.Point(8, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 100);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(18, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "Senha:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(18, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "Usuário:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(114, 45);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(176, 21);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(114, 19);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(176, 21);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsername_KeyPress);
            // 
            // btn_map_drive
            // 
            this.btn_map_drive.Location = new System.Drawing.Point(296, 70);
            this.btn_map_drive.Name = "btn_map_drive";
            this.btn_map_drive.Size = new System.Drawing.Size(120, 24);
            this.btn_map_drive.TabIndex = 3;
            this.btn_map_drive.Text = "Mapear";
            this.btn_map_drive.Click += new System.EventHandler(this.btn_mapear_Click);
            // 
            // conStatusBar
            // 
            this.conStatusBar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conStatusBar.Location = new System.Drawing.Point(0, 105);
            this.conStatusBar.Name = "conStatusBar";
            this.conStatusBar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.conStatusBar_Panel_Action});
            this.conStatusBar.ShowPanels = true;
            this.conStatusBar.Size = new System.Drawing.Size(440, 24);
            this.conStatusBar.SizingGrip = false;
            this.conStatusBar.TabIndex = 14;
            // 
            // conStatusBar_Panel_Action
            // 
            this.conStatusBar_Panel_Action.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            this.conStatusBar_Panel_Action.Name = "conStatusBar_Panel_Action";
            this.conStatusBar_Panel_Action.Width = 440;
            // 
            // chk_R
            // 
            this.chk_R.AutoSize = true;
            this.chk_R.Checked = true;
            this.chk_R.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_R.Location = new System.Drawing.Point(13, 77);
            this.chk_R.Name = "chk_R";
            this.chk_R.Size = new System.Drawing.Size(37, 17);
            this.chk_R.TabIndex = 22;
            this.chk_R.Text = "R:";
            this.chk_R.UseVisualStyleBackColor = true;
            // 
            // chk_T
            // 
            this.chk_T.AutoSize = true;
            this.chk_T.Checked = true;
            this.chk_T.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_T.Location = new System.Drawing.Point(99, 77);
            this.chk_T.Name = "chk_T";
            this.chk_T.Size = new System.Drawing.Size(36, 17);
            this.chk_T.TabIndex = 23;
            this.chk_T.Text = "T:";
            this.chk_T.UseVisualStyleBackColor = true;
            // 
            // chk_S
            // 
            this.chk_S.AutoSize = true;
            this.chk_S.Checked = true;
            this.chk_S.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_S.Location = new System.Drawing.Point(56, 77);
            this.chk_S.Name = "chk_S";
            this.chk_S.Size = new System.Drawing.Size(36, 17);
            this.chk_S.TabIndex = 24;
            this.chk_S.Text = "S:";
            this.chk_S.UseVisualStyleBackColor = true;
            // 
            // MappingNetwork
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
            this.ClientSize = new System.Drawing.Size(440, 129);
            this.Controls.Add(this.conStatusBar);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.conMenu;
            this.Name = "MappingNetwork";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mapear unidade de rede 2.0";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conStatusBar_Panel_Action)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btn_map_drive;
        private System.Windows.Forms.StatusBar conStatusBar;
        private System.Windows.Forms.StatusBarPanel conStatusBar_Panel_Action;
        private System.Windows.Forms.MainMenu conMenu;
        private System.Windows.Forms.CheckBox chk_R;
        private System.Windows.Forms.CheckBox chk_S;
        private System.Windows.Forms.CheckBox chk_T;
    }
}

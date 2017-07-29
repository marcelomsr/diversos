﻿namespace Network
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_desconectar = new System.Windows.Forms.Button();
            this.chk_S = new System.Windows.Forms.CheckBox();
            this.chk_T = new System.Windows.Forms.CheckBox();
            this.chk_R = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btn_map_drive = new System.Windows.Forms.Button();
            this.conMenu = new System.Windows.Forms.MainMenu(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_fechar = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(72, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 21);
            this.label1.TabIndex = 26;
            this.label1.Text = "Unidades:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // btn_desconectar
            // 
            this.btn_desconectar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_desconectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(71)))), ((int)(((byte)(138)))));
            this.btn_desconectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_desconectar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_desconectar.ForeColor = System.Drawing.Color.White;
            this.btn_desconectar.Location = new System.Drawing.Point(176, 165);
            this.btn_desconectar.Name = "btn_desconectar";
            this.btn_desconectar.Size = new System.Drawing.Size(95, 24);
            this.btn_desconectar.TabIndex = 7;
            this.btn_desconectar.Text = "Desconectar";
            this.btn_desconectar.UseVisualStyleBackColor = false;
            this.btn_desconectar.Click += new System.EventHandler(this.btn_desconectar_Click);
            // 
            // chk_S
            // 
            this.chk_S.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_S.AutoSize = true;
            this.chk_S.Checked = true;
            this.chk_S.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_S.Location = new System.Drawing.Point(191, 130);
            this.chk_S.Name = "chk_S";
            this.chk_S.Size = new System.Drawing.Size(36, 17);
            this.chk_S.TabIndex = 4;
            this.chk_S.Text = "S:";
            this.chk_S.UseVisualStyleBackColor = true;
            // 
            // chk_T
            // 
            this.chk_T.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_T.AutoSize = true;
            this.chk_T.Checked = true;
            this.chk_T.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_T.Location = new System.Drawing.Point(244, 130);
            this.chk_T.Name = "chk_T";
            this.chk_T.Size = new System.Drawing.Size(36, 17);
            this.chk_T.TabIndex = 5;
            this.chk_T.Text = "T:";
            this.chk_T.UseVisualStyleBackColor = true;
            // 
            // chk_R
            // 
            this.chk_R.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_R.AutoSize = true;
            this.chk_R.Checked = true;
            this.chk_R.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_R.Location = new System.Drawing.Point(138, 130);
            this.chk_R.Name = "chk_R";
            this.chk_R.Size = new System.Drawing.Size(37, 17);
            this.chk_R.TabIndex = 3;
            this.chk_R.Text = "R:";
            this.chk_R.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Image = global::Network.Properties.Resources.senha_login_16x16;
            this.label4.Location = new System.Drawing.Point(64, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 21);
            this.label4.TabIndex = 21;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label4_MouseDown);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(95, 96);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(176, 21);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.Location = new System.Drawing.Point(95, 65);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(176, 21);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsername_KeyPress);
            // 
            // btn_map_drive
            // 
            this.btn_map_drive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_map_drive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(71)))), ((int)(((byte)(138)))));
            this.btn_map_drive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_map_drive.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_map_drive.ForeColor = System.Drawing.Color.White;
            this.btn_map_drive.Location = new System.Drawing.Point(68, 165);
            this.btn_map_drive.Name = "btn_map_drive";
            this.btn_map_drive.Size = new System.Drawing.Size(95, 24);
            this.btn_map_drive.TabIndex = 6;
            this.btn_map_drive.Text = "Mapear";
            this.btn_map_drive.UseVisualStyleBackColor = false;
            this.btn_map_drive.Click += new System.EventHandler(this.btn_mapear_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 35);
            this.label2.TabIndex = 28;
            this.label2.Text = "Mapear Unidades de Rede";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label2_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_fechar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.chk_R);
            this.panel1.Controls.Add(this.btn_desconectar);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.chk_T);
            this.panel1.Controls.Add(this.chk_S);
            this.panel1.Controls.Add(this.btn_map_drive);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 211);
            this.panel1.TabIndex = 29;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Image = global::Network.Properties.Resources.usuario_login_16x16;
            this.label3.Location = new System.Drawing.Point(65, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 21);
            this.label3.TabIndex = 20;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label3_MouseDown);
            // 
            // lbl_fechar
            // 
            this.lbl_fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_fechar.Image = global::Network.Properties.Resources.fechar_16x16;
            this.lbl_fechar.Location = new System.Drawing.Point(304, 5);
            this.lbl_fechar.Name = "lbl_fechar";
            this.lbl_fechar.Size = new System.Drawing.Size(33, 23);
            this.lbl_fechar.TabIndex = 29;
            this.lbl_fechar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_fechar.Click += new System.EventHandler(this.lbl_fechar_Click);
            this.lbl_fechar.MouseHover += new System.EventHandler(this.lbl_fechar_MouseHover);
            // 
            // MappingNetwork
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
            this.ClientSize = new System.Drawing.Size(343, 211);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.conMenu;
            this.Name = "MappingNetwork";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mapear unidade de rede 2.0";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btn_map_drive;
        private System.Windows.Forms.MainMenu conMenu;
        private System.Windows.Forms.CheckBox chk_R;
        private System.Windows.Forms.CheckBox chk_S;
        private System.Windows.Forms.CheckBox chk_T;
        private System.Windows.Forms.Button btn_desconectar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_fechar;
    }
}

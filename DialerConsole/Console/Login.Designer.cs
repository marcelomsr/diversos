namespace Console
{
    partial class Login
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
            this.btn_conectar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.ckb_lembreme = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_conectar
            // 
            this.btn_conectar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_conectar.Location = new System.Drawing.Point(112, 109);
            this.btn_conectar.Name = "btn_conectar";
            this.btn_conectar.Size = new System.Drawing.Size(75, 23);
            this.btn_conectar.TabIndex = 3;
            this.btn_conectar.Text = "Conectar";
            this.btn_conectar.UseVisualStyleBackColor = true;
            this.btn_conectar.Click += new System.EventHandler(this.btn_conectar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuário";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(75, 20);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(190, 20);
            this.txt_usuario.TabIndex = 1;
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(75, 56);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(190, 20);
            this.txt_senha.TabIndex = 0;
            // 
            // ckb_lembreme
            // 
            this.ckb_lembreme.AutoSize = true;
            this.ckb_lembreme.Checked = true;
            this.ckb_lembreme.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckb_lembreme.Location = new System.Drawing.Point(75, 80);
            this.ckb_lembreme.Name = "ckb_lembreme";
            this.ckb_lembreme.Size = new System.Drawing.Size(78, 17);
            this.ckb_lembreme.TabIndex = 2;
            this.ckb_lembreme.Text = "Lembre-me";
            this.ckb_lembreme.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 144);
            this.Controls.Add(this.ckb_lembreme);
            this.Controls.Add(this.btn_conectar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_conectar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.CheckBox ckb_lembreme;
    }
}
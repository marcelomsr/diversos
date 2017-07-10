namespace EncryptAndDecrypt
{
    partial class Form1
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
            this.lbl_arquivo_a_ser_encriptado_decriptado = new System.Windows.Forms.Label();
            this.lbl_nome_arquivo_destino = new System.Windows.Forms.Label();
            this.txt_arquivo_entrada = new System.Windows.Forms.TextBox();
            this.txt_arquivo_destino = new System.Windows.Forms.TextBox();
            this.btn_encripta = new System.Windows.Forms.Button();
            this.btn_decripta = new System.Windows.Forms.Button();
            this.open_file_dialog = new System.Windows.Forms.OpenFileDialog();
            this.btn_source_file = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_arquivo_a_ser_encriptado_decriptado
            // 
            this.lbl_arquivo_a_ser_encriptado_decriptado.AutoSize = true;
            this.lbl_arquivo_a_ser_encriptado_decriptado.Location = new System.Drawing.Point(12, 9);
            this.lbl_arquivo_a_ser_encriptado_decriptado.Name = "lbl_arquivo_a_ser_encriptado_decriptado";
            this.lbl_arquivo_a_ser_encriptado_decriptado.Size = new System.Drawing.Size(279, 13);
            this.lbl_arquivo_a_ser_encriptado_decriptado.TabIndex = 0;
            this.lbl_arquivo_a_ser_encriptado_decriptado.Text = "Digite o caminho do arquivo a ser encriptado / decriptado";
            // 
            // lbl_nome_arquivo_destino
            // 
            this.lbl_nome_arquivo_destino.AutoSize = true;
            this.lbl_nome_arquivo_destino.Location = new System.Drawing.Point(12, 48);
            this.lbl_nome_arquivo_destino.Name = "lbl_nome_arquivo_destino";
            this.lbl_nome_arquivo_destino.Size = new System.Drawing.Size(177, 13);
            this.lbl_nome_arquivo_destino.TabIndex = 1;
            this.lbl_nome_arquivo_destino.Text = "Digite o nome do arquivo de destino";
            // 
            // txt_arquivo_entrada
            // 
            this.txt_arquivo_entrada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_arquivo_entrada.Location = new System.Drawing.Point(12, 25);
            this.txt_arquivo_entrada.Name = "txt_arquivo_entrada";
            this.txt_arquivo_entrada.Size = new System.Drawing.Size(325, 20);
            this.txt_arquivo_entrada.TabIndex = 3;
            // 
            // txt_arquivo_destino
            // 
            this.txt_arquivo_destino.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_arquivo_destino.Location = new System.Drawing.Point(12, 61);
            this.txt_arquivo_destino.Name = "txt_arquivo_destino";
            this.txt_arquivo_destino.Size = new System.Drawing.Size(391, 20);
            this.txt_arquivo_destino.TabIndex = 5;
            // 
            // btn_encripta
            // 
            this.btn_encripta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_encripta.Location = new System.Drawing.Point(125, 87);
            this.btn_encripta.Name = "btn_encripta";
            this.btn_encripta.Size = new System.Drawing.Size(75, 23);
            this.btn_encripta.TabIndex = 6;
            this.btn_encripta.Text = "Encripta";
            this.btn_encripta.UseVisualStyleBackColor = true;
            this.btn_encripta.Click += new System.EventHandler(this.btn_encripta_Click);
            // 
            // btn_decripta
            // 
            this.btn_decripta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_decripta.Location = new System.Drawing.Point(206, 88);
            this.btn_decripta.Name = "btn_decripta";
            this.btn_decripta.Size = new System.Drawing.Size(75, 23);
            this.btn_decripta.TabIndex = 7;
            this.btn_decripta.Text = "Decripta";
            this.btn_decripta.UseVisualStyleBackColor = true;
            this.btn_decripta.Click += new System.EventHandler(this.btn_decripta_Click);
            // 
            // open_file_dialog
            // 
            this.open_file_dialog.FileName = "openFileDialog1";
            // 
            // btn_source_file
            // 
            this.btn_source_file.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_source_file.Location = new System.Drawing.Point(343, 23);
            this.btn_source_file.Name = "btn_source_file";
            this.btn_source_file.Size = new System.Drawing.Size(60, 23);
            this.btn_source_file.TabIndex = 8;
            this.btn_source_file.Text = "Arquivo";
            this.btn_source_file.UseVisualStyleBackColor = true;
            this.btn_source_file.Click += new System.EventHandler(this.btn_source_file_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 119);
            this.Controls.Add(this.btn_source_file);
            this.Controls.Add(this.btn_decripta);
            this.Controls.Add(this.btn_encripta);
            this.Controls.Add(this.txt_arquivo_destino);
            this.Controls.Add(this.txt_arquivo_entrada);
            this.Controls.Add(this.lbl_nome_arquivo_destino);
            this.Controls.Add(this.lbl_arquivo_a_ser_encriptado_decriptado);
            this.Name = "Form1";
            this.Text = "Encriptação / Decriptação de arquivos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_arquivo_a_ser_encriptado_decriptado;
        private System.Windows.Forms.Label lbl_nome_arquivo_destino;
        private System.Windows.Forms.TextBox txt_arquivo_entrada;
        private System.Windows.Forms.TextBox txt_arquivo_destino;
        private System.Windows.Forms.Button btn_encripta;
        private System.Windows.Forms.Button btn_decripta;
        private System.Windows.Forms.OpenFileDialog open_file_dialog;
        private System.Windows.Forms.Button btn_source_file;
    }
}


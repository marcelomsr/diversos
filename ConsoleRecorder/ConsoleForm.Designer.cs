namespace ConsoleRecorder
{
    partial class ConsoleForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_tocar_audio = new System.Windows.Forms.Button();
            this.btn_gravar_arquivo = new System.Windows.Forms.Button();
            this.cbo_comandos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_enviar_comando = new System.Windows.Forms.Button();
            this.rct_retorno = new System.Windows.Forms.RichTextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btn_tocar_audio
            // 
            this.btn_tocar_audio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_tocar_audio.Location = new System.Drawing.Point(466, 370);
            this.btn_tocar_audio.Name = "btn_tocar_audio";
            this.btn_tocar_audio.Size = new System.Drawing.Size(75, 23);
            this.btn_tocar_audio.TabIndex = 0;
            this.btn_tocar_audio.Text = "Tocar audio";
            this.btn_tocar_audio.UseVisualStyleBackColor = true;
            this.btn_tocar_audio.Click += new System.EventHandler(this.btn_tocar_audio_Click);
            // 
            // btn_gravar_arquivo
            // 
            this.btn_gravar_arquivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_gravar_arquivo.Location = new System.Drawing.Point(547, 370);
            this.btn_gravar_arquivo.Name = "btn_gravar_arquivo";
            this.btn_gravar_arquivo.Size = new System.Drawing.Size(75, 23);
            this.btn_gravar_arquivo.TabIndex = 2;
            this.btn_gravar_arquivo.Text = "Gravar arquivo";
            this.btn_gravar_arquivo.UseVisualStyleBackColor = true;
            this.btn_gravar_arquivo.Click += new System.EventHandler(this.btn_gravar_arquivo_Click);
            // 
            // cbo_comandos
            // 
            this.cbo_comandos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_comandos.FormattingEnabled = true;
            this.cbo_comandos.Location = new System.Drawing.Point(141, 12);
            this.cbo_comandos.Name = "cbo_comandos";
            this.cbo_comandos.Size = new System.Drawing.Size(229, 21);
            this.cbo_comandos.TabIndex = 3;
            this.cbo_comandos.SelectedValueChanged += new System.EventHandler(this.cbo_comandos_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Comando";
            // 
            // btn_enviar_comando
            // 
            this.btn_enviar_comando.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_enviar_comando.Location = new System.Drawing.Point(366, 370);
            this.btn_enviar_comando.Name = "btn_enviar_comando";
            this.btn_enviar_comando.Size = new System.Drawing.Size(94, 23);
            this.btn_enviar_comando.TabIndex = 6;
            this.btn_enviar_comando.Text = "Enviar comando";
            this.btn_enviar_comando.UseVisualStyleBackColor = true;
            this.btn_enviar_comando.Click += new System.EventHandler(this.btn_enviar_comando_Click);
            // 
            // rct_retorno
            // 
            this.rct_retorno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rct_retorno.Location = new System.Drawing.Point(15, 216);
            this.rct_retorno.Name = "rct_retorno";
            this.rct_retorno.Size = new System.Drawing.Size(607, 148);
            this.rct_retorno.TabIndex = 11;
            this.rct_retorno.Text = "";
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(15, 39);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(607, 171);
            this.panel.TabIndex = 12;
            // 
            // ConsoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 405);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.rct_retorno);
            this.Controls.Add(this.btn_enviar_comando);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_comandos);
            this.Controls.Add(this.btn_gravar_arquivo);
            this.Controls.Add(this.btn_tocar_audio);
            this.Name = "ConsoleForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_tocar_audio;
        private System.Windows.Forms.Button btn_gravar_arquivo;
        private System.Windows.Forms.ComboBox cbo_comandos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_enviar_comando;
        private System.Windows.Forms.RichTextBox rct_retorno;
        private System.Windows.Forms.Panel panel;
    }
}


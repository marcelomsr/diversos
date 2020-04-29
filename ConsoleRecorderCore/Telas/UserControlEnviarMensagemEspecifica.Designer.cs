namespace ConsoleRecorderCore
{
    partial class UserControlEnviarMensagemEspecifica
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_message = new System.Windows.Forms.Label();
            this.txt_message = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_sqc_gravacao
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Location = new System.Drawing.Point(5, 6);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(75, 13);
            this.lbl_message.TabIndex = 14;
            this.lbl_message.Text = "message";
            // 
            // txt_message
            // 
            this.txt_message.Location = new System.Drawing.Point(100, 3);
            this.txt_message.Name = "txt_message";
            this.txt_message.Size = new System.Drawing.Size(530, 20);
            this.txt_message.TabIndex = 13;
            this.txt_message.Text = "001@1231&1586198746364.107234d&Local/09931031998983013@agentes-0004348f;1&7149&1915546320&A&94$";
            // 
            // UserControlEnviarMensagemEspecífica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_message);
            this.Controls.Add(this.txt_message);
            this.Name = "UserControlEnviarMensagemEspecifica";
            this.Size = new System.Drawing.Size(670, 48);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.TextBox txt_message;
    }
}

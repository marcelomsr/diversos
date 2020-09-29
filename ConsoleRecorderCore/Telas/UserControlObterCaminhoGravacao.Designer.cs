namespace ConsoleRecorderCore
{
    partial class UserControlObterCaminhoGravacao
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
            this.lbl_sqc_gravacao = new System.Windows.Forms.Label();
            this.txt_sqc_gravacao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_sqc_gravacao
            // 
            this.lbl_sqc_gravacao.AutoSize = true;
            this.lbl_sqc_gravacao.Location = new System.Drawing.Point(5, 6);
            this.lbl_sqc_gravacao.Name = "lbl_sqc_gravacao";
            this.lbl_sqc_gravacao.Size = new System.Drawing.Size(75, 13);
            this.lbl_sqc_gravacao.TabIndex = 14;
            this.lbl_sqc_gravacao.Text = "sqc_gravacao";
            // 
            // txt_message
            // 
            this.txt_sqc_gravacao.Location = new System.Drawing.Point(134, 3);
            this.txt_sqc_gravacao.Name = "txt_sqc_gravacao";
            this.txt_sqc_gravacao.Size = new System.Drawing.Size(135, 20);
            this.txt_sqc_gravacao.TabIndex = 13;
            this.txt_sqc_gravacao.Text = "5452885";
            // 
            // UserControlObterGravacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_sqc_gravacao);
            this.Controls.Add(this.txt_sqc_gravacao);
            this.Name = "UserControlObterGravacao";
            this.Size = new System.Drawing.Size(305, 48);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_sqc_gravacao;
        private System.Windows.Forms.TextBox txt_sqc_gravacao;
    }
}

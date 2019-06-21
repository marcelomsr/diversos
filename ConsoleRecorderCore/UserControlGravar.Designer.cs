namespace ConsoleRecorderCore
{
    partial class UserControlGravar
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
            this.lbl_dispositivo = new System.Windows.Forms.Label();
            this.txt_nmr_dispositivo = new System.Windows.Forms.TextBox();
            this.lbl_chamada_id = new System.Windows.Forms.Label();
            this.txt_chamada_id = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_dispositivo
            // 
            this.lbl_dispositivo.AutoSize = true;
            this.lbl_dispositivo.Location = new System.Drawing.Point(5, 32);
            this.lbl_dispositivo.Name = "lbl_dispositivo";
            this.lbl_dispositivo.Size = new System.Drawing.Size(37, 13);
            this.lbl_dispositivo.TabIndex = 14;
            this.lbl_dispositivo.Text = "Ramal";
            // 
            // txt_nmr_dispositivo
            // 
            this.txt_nmr_dispositivo.Location = new System.Drawing.Point(134, 29);
            this.txt_nmr_dispositivo.Name = "txt_nmr_dispositivo";
            this.txt_nmr_dispositivo.Size = new System.Drawing.Size(135, 20);
            this.txt_nmr_dispositivo.TabIndex = 13;
            this.txt_nmr_dispositivo.Text = "114758";
            // 
            // lbl_chamada_id
            // 
            this.lbl_chamada_id.AutoSize = true;
            this.lbl_chamada_id.Location = new System.Drawing.Point(5, 6);
            this.lbl_chamada_id.Name = "lbl_chamada_id";
            this.lbl_chamada_id.Size = new System.Drawing.Size(62, 13);
            this.lbl_chamada_id.TabIndex = 12;
            this.lbl_chamada_id.Text = "chamadaID";
            // 
            // txt_chamada_id
            // 
            this.txt_chamada_id.Location = new System.Drawing.Point(134, 3);
            this.txt_chamada_id.Name = "txt_chamada_id";
            this.txt_chamada_id.Size = new System.Drawing.Size(135, 20);
            this.txt_chamada_id.TabIndex = 11;
            this.txt_chamada_id.Text = "1";
            // 
            // UserControlGravar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_dispositivo);
            this.Controls.Add(this.txt_nmr_dispositivo);
            this.Controls.Add(this.lbl_chamada_id);
            this.Controls.Add(this.txt_chamada_id);
            this.Name = "UserControlGravar";
            this.Size = new System.Drawing.Size(308, 69);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_dispositivo;
        private System.Windows.Forms.TextBox txt_nmr_dispositivo;
        private System.Windows.Forms.Label lbl_chamada_id;
        private System.Windows.Forms.TextBox txt_chamada_id;
    }
}

namespace ConsoleRecorderCore
{
    partial class UserControlPararGravar
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
            this.lbl_gravacao_id = new System.Windows.Forms.Label();
            this.txt_gravacao_id = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_gravacao_id
            // 
            this.lbl_gravacao_id.AutoSize = true;
            this.lbl_gravacao_id.Location = new System.Drawing.Point(5, 6);
            this.lbl_gravacao_id.Name = "lbl_gravacao_id";
            this.lbl_gravacao_id.Size = new System.Drawing.Size(65, 13);
            this.lbl_gravacao_id.TabIndex = 14;
            this.lbl_gravacao_id.Text = "GravacaoID";
            // 
            // txt_gravacao_id
            // 
            this.txt_gravacao_id.Location = new System.Drawing.Point(134, 3);
            this.txt_gravacao_id.Name = "txt_gravacao_id";
            this.txt_gravacao_id.Size = new System.Drawing.Size(135, 20);
            this.txt_gravacao_id.TabIndex = 13;
            this.txt_gravacao_id.Text = "1";
            // 
            // UserControlPararGravar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_gravacao_id);
            this.Controls.Add(this.txt_gravacao_id);
            this.Name = "UserControlPararGravar";
            this.Size = new System.Drawing.Size(305, 48);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_gravacao_id;
        private System.Windows.Forms.TextBox txt_gravacao_id;
    }
}

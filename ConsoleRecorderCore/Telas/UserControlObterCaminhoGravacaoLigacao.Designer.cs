namespace ConsoleRecorderCore
{
    partial class UserControlObterCaminhoGravacaoLigacao
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
            this.lbl_cdg_cliente = new System.Windows.Forms.Label();
            this.txt_cdg_cliente = new System.Windows.Forms.TextBox();
            this.lbl_tpo_origem = new System.Windows.Forms.Label();
            this.txt_tpo_origem = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_sqc_gravacao
            // 
            this.lbl_cdg_cliente.AutoSize = true;
            this.lbl_cdg_cliente.Location = new System.Drawing.Point(5, 6);
            this.lbl_cdg_cliente.Name = "lbl_cdg_cliente";
            this.lbl_cdg_cliente.Size = new System.Drawing.Size(75, 13);
            this.lbl_cdg_cliente.TabIndex = 14;
            this.lbl_cdg_cliente.Text = "cdg_cliente";
            // 
            // txt_cdg_cliente
            // 
            this.txt_cdg_cliente.Location = new System.Drawing.Point(134, 3);
            this.txt_cdg_cliente.Name = "txt_cdg_cliente";
            this.txt_cdg_cliente.Size = new System.Drawing.Size(135, 20);
            this.txt_cdg_cliente.TabIndex = 13;
            this.txt_cdg_cliente.Text = "23740892";
            // 
            // lbl_tpo_origem
            // 
            this.lbl_tpo_origem.AutoSize = true;
            this.lbl_tpo_origem.Location = new System.Drawing.Point(5, 26);
            this.lbl_tpo_origem.Name = "lbl_tpo_origem";
            this.lbl_tpo_origem.Size = new System.Drawing.Size(75, 13);
            this.lbl_tpo_origem.TabIndex = 16;
            this.lbl_tpo_origem.Text = "tpo_origem";
            // 
            // txt_tpo_origem
            // 
            this.txt_tpo_origem.Location = new System.Drawing.Point(134, 23);
            this.txt_tpo_origem.Name = "txt_tpo_origem";
            this.txt_tpo_origem.Size = new System.Drawing.Size(135, 20);
            this.txt_tpo_origem.TabIndex = 15;
            this.txt_tpo_origem.Text = "F";
            // 
            // UserControlObterGravacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_cdg_cliente);
            this.Controls.Add(this.txt_cdg_cliente);
            this.Controls.Add(this.lbl_tpo_origem);
            this.Controls.Add(this.txt_tpo_origem);
            this.Name = "UserControlObterGravacao";
            this.Size = new System.Drawing.Size(305, 48);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_cdg_cliente;
        private System.Windows.Forms.TextBox txt_cdg_cliente;
        private System.Windows.Forms.Label lbl_tpo_origem;
        private System.Windows.Forms.TextBox txt_tpo_origem;
    }
}

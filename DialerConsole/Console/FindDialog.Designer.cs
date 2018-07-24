namespace Console
{
    partial class FindDialog
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
            this.btn_procurar = new System.Windows.Forms.Button();
            this.txt_texto_procurado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_procurar
            // 
            this.btn_procurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_procurar.Location = new System.Drawing.Point(232, 53);
            this.btn_procurar.Name = "btn_procurar";
            this.btn_procurar.Size = new System.Drawing.Size(75, 23);
            this.btn_procurar.TabIndex = 2;
            this.btn_procurar.Text = "Procurar";
            this.btn_procurar.UseVisualStyleBackColor = true;
            this.btn_procurar.Click += new System.EventHandler(this.btn_procurar_Click);
            // 
            // txt_texto_procurado
            // 
            this.txt_texto_procurado.Location = new System.Drawing.Point(52, 19);
            this.txt_texto_procurado.Name = "txt_texto_procurado";
            this.txt_texto_procurado.Size = new System.Drawing.Size(255, 20);
            this.txt_texto_procurado.TabIndex = 0;
            this.txt_texto_procurado.TextChanged += new System.EventHandler(this.txt_texto_procurado_TextChanged);
            this.txt_texto_procurado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_texto_procurado_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Texto";
            // 
            // FindDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 88);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_texto_procurado);
            this.Controls.Add(this.btn_procurar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Procurar";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FindDialog_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_procurar;
        private System.Windows.Forms.TextBox txt_texto_procurado;
        private System.Windows.Forms.Label label1;
    }
}
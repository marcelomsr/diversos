namespace ImprimindoControles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_preview = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.prt_document = new System.Drawing.Printing.PrintDocument();
            this.prt_prv_dialog = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(529, 20);
            this.textBox1.TabIndex = 0;
            // 
            // btn_preview
            // 
            this.btn_preview.Location = new System.Drawing.Point(136, 38);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(75, 23);
            this.btn_preview.TabIndex = 1;
            this.btn_preview.Text = "Preview";
            this.btn_preview.UseVisualStyleBackColor = true;
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(336, 38);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(75, 23);
            this.btn_print.TabIndex = 2;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // prt_document
            // 
            this.prt_document.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.prt_document_PrintPage);
            // 
            // prt_prv_dialog
            // 
            this.prt_prv_dialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.prt_prv_dialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.prt_prv_dialog.ClientSize = new System.Drawing.Size(400, 300);
            this.prt_prv_dialog.Enabled = true;
            this.prt_prv_dialog.Icon = ((System.Drawing.Icon)(resources.GetObject("prt_prv_dialog.Icon")));
            this.prt_prv_dialog.Name = "prt_prv_dialog";
            this.prt_prv_dialog.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 72);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.btn_preview);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Imprimindo controles";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_preview;
        private System.Windows.Forms.Button btn_print;
        private System.Drawing.Printing.PrintDocument prt_document;
        private System.Windows.Forms.PrintPreviewDialog prt_prv_dialog;
    }
}


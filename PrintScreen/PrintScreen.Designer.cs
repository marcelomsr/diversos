namespace Diversos
{
    partial class PrintScreen
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
            this.btn_print_screen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_print_screen
            // 
            this.btn_print_screen.Location = new System.Drawing.Point(39, 21);
            this.btn_print_screen.Name = "btn_print_screen";
            this.btn_print_screen.Size = new System.Drawing.Size(108, 23);
            this.btn_print_screen.TabIndex = 0;
            this.btn_print_screen.Text = "Tirar print screen";
            this.btn_print_screen.UseVisualStyleBackColor = true;
            this.btn_print_screen.Click += new System.EventHandler(this.btn_print_screen_Click);
            // 
            // PrintScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 68);
            this.Controls.Add(this.btn_print_screen);
            this.Name = "PrintScreen";
            this.Text = "Print Screen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_print_screen;
    }
}


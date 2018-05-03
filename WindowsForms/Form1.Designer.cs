namespace WindowsForms
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
            this.btn_calc_damage = new System.Windows.Forms.Button();
            this.cbo_level = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_calc_damage
            // 
            this.btn_calc_damage.Location = new System.Drawing.Point(102, 188);
            this.btn_calc_damage.Name = "btn_calc_damage";
            this.btn_calc_damage.Size = new System.Drawing.Size(75, 23);
            this.btn_calc_damage.TabIndex = 0;
            this.btn_calc_damage.Text = "button2";
            this.btn_calc_damage.UseVisualStyleBackColor = true;
            this.btn_calc_damage.Click += new System.EventHandler(this.btn_calc_damage_Click);
            // 
            // cbo_level
            // 
            this.cbo_level.FormattingEnabled = true;
            this.cbo_level.Location = new System.Drawing.Point(56, 12);
            this.cbo_level.Name = "cbo_level";
            this.cbo_level.Size = new System.Drawing.Size(121, 21);
            this.cbo_level.TabIndex = 1;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cbo_level);
            this.Controls.Add(this.btn_calc_damage);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_calc_damage;
        private System.Windows.Forms.ComboBox cbo_level;
    }
}


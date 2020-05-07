namespace CalculadoraDanosPokemon
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.lbl_formula = new System.Windows.Forms.Label();
            this.nmr_level = new System.Windows.Forms.NumericUpDown();
            this.nmr_attack_power = new System.Windows.Forms.NumericUpDown();
            this.nmr_defense = new System.Windows.Forms.NumericUpDown();
            this.nmr_attack = new System.Windows.Forms.NumericUpDown();
            this.chk_stab = new System.Windows.Forms.CheckBox();
            this.chk_critical_hit = new System.Windows.Forms.CheckBox();
            this.cbo_type_effectiveness = new System.Windows.Forms.ComboBox();
            this.lbl_type_effectiveness = new System.Windows.Forms.Label();
            this.lbl_dano_minimo = new System.Windows.Forms.Label();
            this.lbl_dano_maximo = new System.Windows.Forms.Label();
            this.chk_choice_item = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_level)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_attack_power)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_defense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_attack)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Atk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Def";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Atk Power";
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(204, 234);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_calcular.TabIndex = 8;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_formula
            // 
            this.lbl_formula.AutoSize = true;
            this.lbl_formula.Location = new System.Drawing.Point(6, 244);
            this.lbl_formula.Name = "lbl_formula";
            this.lbl_formula.Size = new System.Drawing.Size(44, 13);
            this.lbl_formula.TabIndex = 9;
            this.lbl_formula.Text = "Fórmula";
            // 
            // nmr_level
            // 
            this.nmr_level.Location = new System.Drawing.Point(9, 25);
            this.nmr_level.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmr_level.Name = "nmr_level";
            this.nmr_level.Size = new System.Drawing.Size(51, 20);
            this.nmr_level.TabIndex = 10;
            this.nmr_level.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nmr_attack_power
            // 
            this.nmr_attack_power.Location = new System.Drawing.Point(180, 25);
            this.nmr_attack_power.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.nmr_attack_power.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmr_attack_power.Name = "nmr_attack_power";
            this.nmr_attack_power.Size = new System.Drawing.Size(51, 20);
            this.nmr_attack_power.TabIndex = 11;
            this.nmr_attack_power.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nmr_defense
            // 
            this.nmr_defense.Location = new System.Drawing.Point(123, 25);
            this.nmr_defense.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.nmr_defense.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmr_defense.Name = "nmr_defense";
            this.nmr_defense.Size = new System.Drawing.Size(51, 20);
            this.nmr_defense.TabIndex = 12;
            this.nmr_defense.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nmr_attack
            // 
            this.nmr_attack.Location = new System.Drawing.Point(66, 25);
            this.nmr_attack.Maximum = new decimal(new int[] {
            1300,
            0,
            0,
            0});
            this.nmr_attack.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmr_attack.Name = "nmr_attack";
            this.nmr_attack.Size = new System.Drawing.Size(51, 20);
            this.nmr_attack.TabIndex = 13;
            this.nmr_attack.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chk_stab
            // 
            this.chk_stab.AutoSize = true;
            this.chk_stab.Location = new System.Drawing.Point(12, 100);
            this.chk_stab.Name = "chk_stab";
            this.chk_stab.Size = new System.Drawing.Size(54, 17);
            this.chk_stab.TabIndex = 14;
            this.chk_stab.Text = "STAB";
            this.chk_stab.UseVisualStyleBackColor = true;
            // 
            // chk_critical_hit
            // 
            this.chk_critical_hit.AutoSize = true;
            this.chk_critical_hit.Location = new System.Drawing.Point(12, 123);
            this.chk_critical_hit.Name = "chk_critical_hit";
            this.chk_critical_hit.Size = new System.Drawing.Size(73, 17);
            this.chk_critical_hit.TabIndex = 17;
            this.chk_critical_hit.Text = "Critical Hit";
            this.chk_critical_hit.UseVisualStyleBackColor = true;
            // 
            // cbo_type_effectiveness
            // 
            this.cbo_type_effectiveness.FormattingEnabled = true;
            this.cbo_type_effectiveness.Items.AddRange(new object[] {
            "0,25",
            "0,5",
            "1,0",
            "2,0",
            "4,0"});
            this.cbo_type_effectiveness.Location = new System.Drawing.Point(9, 72);
            this.cbo_type_effectiveness.Name = "cbo_type_effectiveness";
            this.cbo_type_effectiveness.Size = new System.Drawing.Size(80, 21);
            this.cbo_type_effectiveness.TabIndex = 19;
            // 
            // lbl_type_effectiveness
            // 
            this.lbl_type_effectiveness.AutoSize = true;
            this.lbl_type_effectiveness.Location = new System.Drawing.Point(9, 56);
            this.lbl_type_effectiveness.Name = "lbl_type_effectiveness";
            this.lbl_type_effectiveness.Size = new System.Drawing.Size(97, 13);
            this.lbl_type_effectiveness.TabIndex = 20;
            this.lbl_type_effectiveness.Text = "Type effectiveness";
            // 
            // lbl_dano_minimo
            // 
            this.lbl_dano_minimo.AutoSize = true;
            this.lbl_dano_minimo.Location = new System.Drawing.Point(9, 171);
            this.lbl_dano_minimo.Name = "lbl_dano_minimo";
            this.lbl_dano_minimo.Size = new System.Drawing.Size(70, 13);
            this.lbl_dano_minimo.TabIndex = 21;
            this.lbl_dano_minimo.Text = "Dano mínimo";
            // 
            // lbl_dano_maximo
            // 
            this.lbl_dano_maximo.AutoSize = true;
            this.lbl_dano_maximo.Location = new System.Drawing.Point(9, 193);
            this.lbl_dano_maximo.Name = "lbl_dano_maximo";
            this.lbl_dano_maximo.Size = new System.Drawing.Size(71, 13);
            this.lbl_dano_maximo.TabIndex = 22;
            this.lbl_dano_maximo.Text = "Dano máximo";
            // 
            // chk_choice_item
            // 
            this.chk_choice_item.AutoSize = true;
            this.chk_choice_item.Location = new System.Drawing.Point(108, 100);
            this.chk_choice_item.Name = "chk_choice_item";
            this.chk_choice_item.Size = new System.Drawing.Size(86, 17);
            this.chk_choice_item.TabIndex = 23;
            this.chk_choice_item.Text = "Choice band";
            this.chk_choice_item.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.chk_choice_item);
            this.Controls.Add(this.lbl_dano_maximo);
            this.Controls.Add(this.lbl_dano_minimo);
            this.Controls.Add(this.lbl_type_effectiveness);
            this.Controls.Add(this.cbo_type_effectiveness);
            this.Controls.Add(this.chk_critical_hit);
            this.Controls.Add(this.chk_stab);
            this.Controls.Add(this.nmr_attack);
            this.Controls.Add(this.nmr_defense);
            this.Controls.Add(this.nmr_attack_power);
            this.Controls.Add(this.nmr_level);
            this.Controls.Add(this.lbl_formula);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nmr_level)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_attack_power)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_defense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_attack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Label lbl_formula;
        private System.Windows.Forms.NumericUpDown nmr_level;
        private System.Windows.Forms.NumericUpDown nmr_attack_power;
        private System.Windows.Forms.NumericUpDown nmr_defense;
        private System.Windows.Forms.NumericUpDown nmr_attack;
        private System.Windows.Forms.CheckBox chk_stab;
        private System.Windows.Forms.CheckBox chk_critical_hit;
        private System.Windows.Forms.ComboBox cbo_type_effectiveness;
        private System.Windows.Forms.Label lbl_type_effectiveness;
        private System.Windows.Forms.Label lbl_dano_minimo;
        private System.Windows.Forms.Label lbl_dano_maximo;
        private System.Windows.Forms.CheckBox chk_choice_item;
    }
}


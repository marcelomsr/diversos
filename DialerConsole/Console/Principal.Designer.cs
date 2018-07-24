namespace Console
{
    partial class Principal
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
            this.lst_instancias = new System.Windows.Forms.ListBox();
            this.txt_endereco_ip = new System.Windows.Forms.TextBox();
            this.txt_porta = new System.Windows.Forms.TextBox();
            this.chk_outra_instancia = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_abrir_conexao = new System.Windows.Forms.ToolStripButton();
            this.btn_executar = new System.Windows.Forms.ToolStripButton();
            this.btn_configuracoes = new System.Windows.Forms.ToolStripSplitButton();
            this.btn_abrir_como_superadmin = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_registrar_log_dialer4com = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_mostrar_identificacao_colunas = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_medir_tempo_resposta = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_repetir_ultimo_comando = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_cada_2_segundos = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_cada_5_segundos = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_cada_10_segundos = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_cada_30_segundos = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_cada_1_minuto = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_cada_5_minutos = new System.Windows.Forms.ToolStripMenuItem();
            this.tab_principal = new System.Windows.Forms.TabControl();
            this.tpg_conexao_template = new System.Windows.Forms.TabPage();
            this.pnl_conexao_template = new System.Windows.Forms.Panel();
            this.spt_conexao_template = new System.Windows.Forms.SplitContainer();
            this.txt_comando_template = new System.Windows.Forms.RichTextBox();
            this.txt_resultado_template = new System.Windows.Forms.RichTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStrip1.SuspendLayout();
            this.tab_principal.SuspendLayout();
            this.tpg_conexao_template.SuspendLayout();
            this.pnl_conexao_template.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spt_conexao_template)).BeginInit();
            this.spt_conexao_template.Panel1.SuspendLayout();
            this.spt_conexao_template.Panel2.SuspendLayout();
            this.spt_conexao_template.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Instâncias";
            // 
            // lst_instancias
            // 
            this.lst_instancias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lst_instancias.FormattingEnabled = true;
            this.lst_instancias.Location = new System.Drawing.Point(12, 22);
            this.lst_instancias.Name = "lst_instancias";
            this.lst_instancias.Size = new System.Drawing.Size(155, 381);
            this.lst_instancias.TabIndex = 3;
            this.lst_instancias.SelectedIndexChanged += new System.EventHandler(this.lst_instancias_SelectedIndexChanged);
            // 
            // txt_endereco_ip
            // 
            this.txt_endereco_ip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_endereco_ip.Location = new System.Drawing.Point(17, 461);
            this.txt_endereco_ip.Name = "txt_endereco_ip";
            this.txt_endereco_ip.Size = new System.Drawing.Size(92, 20);
            this.txt_endereco_ip.TabIndex = 6;
            // 
            // txt_porta
            // 
            this.txt_porta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_porta.Location = new System.Drawing.Point(116, 461);
            this.txt_porta.Name = "txt_porta";
            this.txt_porta.Size = new System.Drawing.Size(44, 20);
            this.txt_porta.TabIndex = 7;
            this.txt_porta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_porta_KeyPress);
            // 
            // chk_outra_instancia
            // 
            this.chk_outra_instancia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chk_outra_instancia.AutoSize = true;
            this.chk_outra_instancia.Location = new System.Drawing.Point(12, 424);
            this.chk_outra_instancia.Name = "chk_outra_instancia";
            this.chk_outra_instancia.Size = new System.Drawing.Size(97, 17);
            this.chk_outra_instancia.TabIndex = 9;
            this.chk_outra_instancia.Text = "Outra instância";
            this.chk_outra_instancia.UseVisualStyleBackColor = true;
            this.chk_outra_instancia.CheckedChanged += new System.EventHandler(this.chk_outra_instancia_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 445);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Endereço IP";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 445);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Porta";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_abrir_conexao,
            this.btn_executar,
            this.btn_configuracoes});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(884, 25);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_abrir_conexao
            // 
            this.btn_abrir_conexao.Name = "btn_abrir_conexao";
            this.btn_abrir_conexao.Size = new System.Drawing.Size(84, 22);
            this.btn_abrir_conexao.Text = "&Abrir conexão";
            this.btn_abrir_conexao.Click += new System.EventHandler(this.btn_abrir_conexao_Click);
            // 
            // btn_executar
            // 
            this.btn_executar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_executar.Name = "btn_executar";
            this.btn_executar.Size = new System.Drawing.Size(55, 22);
            this.btn_executar.Text = "Executar";
            this.btn_executar.Click += new System.EventHandler(this.btn_executar_Click);
            // 
            // btn_configuracoes
            // 
            this.btn_configuracoes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_configuracoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_abrir_como_superadmin,
            this.btn_registrar_log_dialer4com,
            this.btn_mostrar_identificacao_colunas,
            this.btn_medir_tempo_resposta,
            this.btn_repetir_ultimo_comando});
            this.btn_configuracoes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_configuracoes.Name = "btn_configuracoes";
            this.btn_configuracoes.Size = new System.Drawing.Size(100, 22);
            this.btn_configuracoes.Text = "Configurações";
            this.btn_configuracoes.ButtonClick += new System.EventHandler(this.btn_configuracoes_ButtonClick);
            // 
            // btn_abrir_como_superadmin
            // 
            this.btn_abrir_como_superadmin.CheckOnClick = true;
            this.btn_abrir_como_superadmin.Name = "btn_abrir_como_superadmin";
            this.btn_abrir_como_superadmin.Size = new System.Drawing.Size(251, 22);
            this.btn_abrir_como_superadmin.Text = "Usar modo superadministrador";
            this.btn_abrir_como_superadmin.CheckStateChanged += new System.EventHandler(this.btn_abrir_como_superadmin_CheckStateChanged);
            // 
            // btn_registrar_log_dialer4com
            // 
            this.btn_registrar_log_dialer4com.CheckOnClick = true;
            this.btn_registrar_log_dialer4com.Name = "btn_registrar_log_dialer4com";
            this.btn_registrar_log_dialer4com.Size = new System.Drawing.Size(251, 22);
            this.btn_registrar_log_dialer4com.Text = "Registrar logs do Dialer4COM";
            this.btn_registrar_log_dialer4com.CheckStateChanged += new System.EventHandler(this.btn_registrar_log_dialer4com_CheckStateChanged);
            // 
            // btn_mostrar_identificacao_colunas
            // 
            this.btn_mostrar_identificacao_colunas.CheckOnClick = true;
            this.btn_mostrar_identificacao_colunas.Name = "btn_mostrar_identificacao_colunas";
            this.btn_mostrar_identificacao_colunas.Size = new System.Drawing.Size(251, 22);
            this.btn_mostrar_identificacao_colunas.Text = "Mostrar identificação das colunas";
            this.btn_mostrar_identificacao_colunas.CheckStateChanged += new System.EventHandler(this.btn_mostrar_nome_colunas_CheckStateChanged);
            // 
            // btn_medir_tempo_resposta
            // 
            this.btn_medir_tempo_resposta.CheckOnClick = true;
            this.btn_medir_tempo_resposta.Name = "btn_medir_tempo_resposta";
            this.btn_medir_tempo_resposta.Size = new System.Drawing.Size(251, 22);
            this.btn_medir_tempo_resposta.Text = "Medir tempo de resposta";
            this.btn_medir_tempo_resposta.CheckStateChanged += new System.EventHandler(this.btn_medir_tempo_resposta_CheckStateChanged);
            // 
            // btn_repetir_ultimo_comando
            // 
            this.btn_repetir_ultimo_comando.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_cada_2_segundos,
            this.btn_cada_5_segundos,
            this.btn_cada_10_segundos,
            this.btn_cada_30_segundos,
            this.btn_cada_1_minuto,
            this.btn_cada_5_minutos});
            this.btn_repetir_ultimo_comando.Name = "btn_repetir_ultimo_comando";
            this.btn_repetir_ultimo_comando.Size = new System.Drawing.Size(251, 22);
            this.btn_repetir_ultimo_comando.Text = "Repetir último comando a cada";
            this.btn_repetir_ultimo_comando.CheckStateChanged += new System.EventHandler(this.btn_repetir_ultimo_comando_CheckStateChanged);
            // 
            // btn_cada_2_segundos
            // 
            this.btn_cada_2_segundos.CheckOnClick = true;
            this.btn_cada_2_segundos.Name = "btn_cada_2_segundos";
            this.btn_cada_2_segundos.Size = new System.Drawing.Size(152, 22);
            this.btn_cada_2_segundos.Text = "2 segundos";
            this.btn_cada_2_segundos.CheckStateChanged += new System.EventHandler(this.btn_cada_2_segundos_CheckStateChanged);
            // 
            // btn_cada_5_segundos
            // 
            this.btn_cada_5_segundos.CheckOnClick = true;
            this.btn_cada_5_segundos.Name = "btn_cada_5_segundos";
            this.btn_cada_5_segundos.Size = new System.Drawing.Size(152, 22);
            this.btn_cada_5_segundos.Text = "5 segundos";
            this.btn_cada_5_segundos.CheckStateChanged += new System.EventHandler(this.btn_cada_5_segundos_CheckStateChanged);
            // 
            // btn_cada_10_segundos
            // 
            this.btn_cada_10_segundos.CheckOnClick = true;
            this.btn_cada_10_segundos.Name = "btn_cada_10_segundos";
            this.btn_cada_10_segundos.Size = new System.Drawing.Size(152, 22);
            this.btn_cada_10_segundos.Text = "10 segundos";
            this.btn_cada_10_segundos.CheckStateChanged += new System.EventHandler(this.btn_cada_10_segundos_CheckStateChanged);
            // 
            // btn_cada_30_segundos
            // 
            this.btn_cada_30_segundos.CheckOnClick = true;
            this.btn_cada_30_segundos.Name = "btn_cada_30_segundos";
            this.btn_cada_30_segundos.Size = new System.Drawing.Size(152, 22);
            this.btn_cada_30_segundos.Text = "30 segundos";
            this.btn_cada_30_segundos.CheckStateChanged += new System.EventHandler(this.btn_cada_30_segundos_CheckStateChanged);
            // 
            // btn_cada_1_minuto
            // 
            this.btn_cada_1_minuto.CheckOnClick = true;
            this.btn_cada_1_minuto.Name = "btn_cada_1_minuto";
            this.btn_cada_1_minuto.Size = new System.Drawing.Size(152, 22);
            this.btn_cada_1_minuto.Text = "1 minuto";
            this.btn_cada_1_minuto.CheckStateChanged += new System.EventHandler(this.btn_cada_1_minuto_CheckStateChanged);
            // 
            // btn_cada_5_minutos
            // 
            this.btn_cada_5_minutos.CheckOnClick = true;
            this.btn_cada_5_minutos.Name = "btn_cada_5_minutos";
            this.btn_cada_5_minutos.Size = new System.Drawing.Size(152, 22);
            this.btn_cada_5_minutos.Text = "5 minutos";
            this.btn_cada_5_minutos.CheckStateChanged += new System.EventHandler(this.btn_cada_5_minutos_CheckStateChanged);
            // 
            // tab_principal
            // 
            this.tab_principal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_principal.Controls.Add(this.tpg_conexao_template);
            this.tab_principal.Location = new System.Drawing.Point(3, 3);
            this.tab_principal.Name = "tab_principal";
            this.tab_principal.SelectedIndex = 0;
            this.tab_principal.Size = new System.Drawing.Size(704, 485);
            this.tab_principal.TabIndex = 4;
            this.tab_principal.SelectedIndexChanged += new System.EventHandler(this.tab_principal_SelectedIndexChanged);
            this.tab_principal.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tab_principal_MouseUp);
            // 
            // tpg_conexao_template
            // 
            this.tpg_conexao_template.Controls.Add(this.pnl_conexao_template);
            this.tpg_conexao_template.Location = new System.Drawing.Point(4, 22);
            this.tpg_conexao_template.Name = "tpg_conexao_template";
            this.tpg_conexao_template.Size = new System.Drawing.Size(696, 459);
            this.tpg_conexao_template.TabIndex = 0;
            this.tpg_conexao_template.Text = "Template";
            this.tpg_conexao_template.UseVisualStyleBackColor = true;
            // 
            // pnl_conexao_template
            // 
            this.pnl_conexao_template.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_conexao_template.Controls.Add(this.spt_conexao_template);
            this.pnl_conexao_template.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_conexao_template.Location = new System.Drawing.Point(0, 0);
            this.pnl_conexao_template.Name = "pnl_conexao_template";
            this.pnl_conexao_template.Size = new System.Drawing.Size(696, 459);
            this.pnl_conexao_template.TabIndex = 2;
            // 
            // spt_conexao_template
            // 
            this.spt_conexao_template.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spt_conexao_template.Location = new System.Drawing.Point(0, 0);
            this.spt_conexao_template.Margin = new System.Windows.Forms.Padding(0);
            this.spt_conexao_template.Name = "spt_conexao_template";
            this.spt_conexao_template.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spt_conexao_template.Panel1
            // 
            this.spt_conexao_template.Panel1.Controls.Add(this.txt_comando_template);
            // 
            // spt_conexao_template.Panel2
            // 
            this.spt_conexao_template.Panel2.Controls.Add(this.txt_resultado_template);
            this.spt_conexao_template.Size = new System.Drawing.Size(694, 456);
            this.spt_conexao_template.SplitterDistance = 90;
            this.spt_conexao_template.TabIndex = 2;
            // 
            // txt_comando_template
            // 
            this.txt_comando_template.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_comando_template.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_comando_template.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_comando_template.Location = new System.Drawing.Point(0, 0);
            this.txt_comando_template.Margin = new System.Windows.Forms.Padding(0);
            this.txt_comando_template.Name = "txt_comando_template";
            this.txt_comando_template.Size = new System.Drawing.Size(694, 90);
            this.txt_comando_template.TabIndex = 0;
            this.txt_comando_template.Text = "";
            this.txt_comando_template.WordWrap = false;
            // 
            // txt_resultado_template
            // 
            this.txt_resultado_template.BackColor = System.Drawing.SystemColors.Window;
            this.txt_resultado_template.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_resultado_template.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_resultado_template.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_resultado_template.Location = new System.Drawing.Point(0, 0);
            this.txt_resultado_template.Margin = new System.Windows.Forms.Padding(0);
            this.txt_resultado_template.Name = "txt_resultado_template";
            this.txt_resultado_template.ReadOnly = true;
            this.txt_resultado_template.Size = new System.Drawing.Size(694, 362);
            this.txt_resultado_template.TabIndex = 1;
            this.txt_resultado_template.Text = "";
            this.txt_resultado_template.WordWrap = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lst_instancias);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.txt_endereco_ip);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txt_porta);
            this.splitContainer1.Panel1.Controls.Add(this.chk_outra_instancia);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tab_principal);
            this.splitContainer1.Size = new System.Drawing.Size(884, 491);
            this.splitContainer1.SplitterDistance = 170;
            this.splitContainer1.TabIndex = 14;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 516);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "Principal";
            this.Text = "Altrium Console";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tab_principal.ResumeLayout(false);
            this.tpg_conexao_template.ResumeLayout(false);
            this.pnl_conexao_template.ResumeLayout(false);
            this.spt_conexao_template.Panel1.ResumeLayout(false);
            this.spt_conexao_template.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spt_conexao_template)).EndInit();
            this.spt_conexao_template.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lst_instancias;
        private System.Windows.Forms.TabControl tab_principal;
        private System.Windows.Forms.TabPage tpg_conexao_template;
        private System.Windows.Forms.RichTextBox txt_comando_template;
        private System.Windows.Forms.RichTextBox txt_resultado_template;
        private System.Windows.Forms.Panel pnl_conexao_template;
        private System.Windows.Forms.SplitContainer spt_conexao_template;
        private System.Windows.Forms.TextBox txt_endereco_ip;
        private System.Windows.Forms.TextBox txt_porta;
        private System.Windows.Forms.CheckBox chk_outra_instancia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_abrir_conexao;
        private System.Windows.Forms.ToolStripButton btn_executar;
        private System.Windows.Forms.ToolStripSplitButton btn_configuracoes;
        private System.Windows.Forms.ToolStripMenuItem btn_abrir_como_superadmin;
        private System.Windows.Forms.ToolStripMenuItem btn_registrar_log_dialer4com;
        private System.Windows.Forms.ToolStripMenuItem btn_mostrar_identificacao_colunas;
        private System.Windows.Forms.ToolStripMenuItem btn_medir_tempo_resposta;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripMenuItem btn_repetir_ultimo_comando;
        private System.Windows.Forms.ToolStripMenuItem btn_cada_2_segundos;
        private System.Windows.Forms.ToolStripMenuItem btn_cada_5_segundos;
        private System.Windows.Forms.ToolStripMenuItem btn_cada_10_segundos;
        private System.Windows.Forms.ToolStripMenuItem btn_cada_30_segundos;
        private System.Windows.Forms.ToolStripMenuItem btn_cada_1_minuto;
        private System.Windows.Forms.ToolStripMenuItem btn_cada_5_minutos;

    }
}


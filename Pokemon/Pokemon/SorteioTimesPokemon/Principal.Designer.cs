namespace SorteioTimesPokemon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.lst_listview = new System.Windows.Forms.ListBox();
            this.txt_nme_jogador = new System.Windows.Forms.TextBox();
            this.lbl_jogadores_adicionados = new System.Windows.Forms.Label();
            this.btn_remover_jogador = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_sortear_base_dados = new System.Windows.Forms.Button();
            this.lbl_quantidade_pokemons_jogador = new System.Windows.Forms.Label();
            this.nmc_qtd_pokemons = new System.Windows.Forms.NumericUpDown();
            this.chk_permite_repetir = new System.Windows.Forms.CheckBox();
            this.lbl_permite_repetir_mesmo_time = new System.Windows.Forms.Label();
            this.lbl_incluir_lendarios = new System.Windows.Forms.Label();
            this.chk_lendarios = new System.Windows.Forms.CheckBox();
            this.nmc_vlr_minimo = new System.Windows.Forms.NumericUpDown();
            this.nmc_vlr_maximo = new System.Windows.Forms.NumericUpDown();
            this.lbl_total_base_status_entre = new System.Windows.Forms.Label();
            this.btn_sortear_arquivo = new System.Windows.Forms.Button();
            this.grp_filtros = new System.Windows.Forms.GroupBox();
            this.chk_geracao_5 = new System.Windows.Forms.CheckBox();
            this.chk_geracao_6 = new System.Windows.Forms.CheckBox();
            this.chk_geracao_4 = new System.Windows.Forms.CheckBox();
            this.nmc_media_minima_base_status = new System.Windows.Forms.NumericUpDown();
            this.lbl_media_minima_base_status = new System.Windows.Forms.Label();
            this.lnklbl_desmarcar_todos = new System.Windows.Forms.LinkLabel();
            this.chk_type_ghost = new System.Windows.Forms.CheckBox();
            this.chk_type_dragon = new System.Windows.Forms.CheckBox();
            this.chk_type_bug = new System.Windows.Forms.CheckBox();
            this.chk_type_ice = new System.Windows.Forms.CheckBox();
            this.chk_type_rock = new System.Windows.Forms.CheckBox();
            this.chk_type_steel = new System.Windows.Forms.CheckBox();
            this.chk_type_dark = new System.Windows.Forms.CheckBox();
            this.chk_type_psychic = new System.Windows.Forms.CheckBox();
            this.chk_type_ground = new System.Windows.Forms.CheckBox();
            this.chk_type_electric = new System.Windows.Forms.CheckBox();
            this.chk_type_water = new System.Windows.Forms.CheckBox();
            this.chk_type_poison = new System.Windows.Forms.CheckBox();
            this.chk_type_fighting = new System.Windows.Forms.CheckBox();
            this.chk_type_flying = new System.Windows.Forms.CheckBox();
            this.chk_type_fire = new System.Windows.Forms.CheckBox();
            this.chk_type_grass = new System.Windows.Forms.CheckBox();
            this.chk_type_normal = new System.Windows.Forms.CheckBox();
            this.chk_ultima_evolucao = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chk_geracao_3 = new System.Windows.Forms.CheckBox();
            this.chk_geracao_2 = new System.Windows.Forms.CheckBox();
            this.chk_geracao_1 = new System.Windows.Forms.CheckBox();
            this.chk_sorteio_secreto = new System.Windows.Forms.CheckBox();
            this.lbl_sorteio_secreto = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_listar_pokemons_disponiveis = new System.Windows.Forms.Button();
            this.lbl_about = new System.Windows.Forms.Label();
            this.chk_incluir_mega_evolucao = new System.Windows.Forms.CheckBox();
            this.lbl_incluir_ao_menos_uma_mega_evolucao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmc_qtd_pokemons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmc_vlr_minimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmc_vlr_maximo)).BeginInit();
            this.grp_filtros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmc_media_minima_base_status)).BeginInit();
            this.SuspendLayout();
            // 
            // lst_listview
            // 
            this.lst_listview.FormattingEnabled = true;
            this.lst_listview.Location = new System.Drawing.Point(8, 61);
            this.lst_listview.Name = "lst_listview";
            this.lst_listview.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lst_listview.Size = new System.Drawing.Size(234, 95);
            this.lst_listview.TabIndex = 0;
            // 
            // txt_nme_jogador
            // 
            this.txt_nme_jogador.Location = new System.Drawing.Point(8, 21);
            this.txt_nme_jogador.Name = "txt_nme_jogador";
            this.txt_nme_jogador.Size = new System.Drawing.Size(234, 20);
            this.txt_nme_jogador.TabIndex = 0;
            this.txt_nme_jogador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nme_jogador_KeyPress);
            // 
            // lbl_jogadores_adicionados
            // 
            this.lbl_jogadores_adicionados.AutoSize = true;
            this.lbl_jogadores_adicionados.Location = new System.Drawing.Point(8, 45);
            this.lbl_jogadores_adicionados.Name = "lbl_jogadores_adicionados";
            this.lbl_jogadores_adicionados.Size = new System.Drawing.Size(116, 13);
            this.lbl_jogadores_adicionados.TabIndex = 2;
            this.lbl_jogadores_adicionados.Text = "Jogadores adicionados";
            // 
            // btn_remover_jogador
            // 
            this.btn_remover_jogador.Location = new System.Drawing.Point(248, 133);
            this.btn_remover_jogador.Name = "btn_remover_jogador";
            this.btn_remover_jogador.Size = new System.Drawing.Size(67, 23);
            this.btn_remover_jogador.TabIndex = 3;
            this.btn_remover_jogador.Text = "Remover";
            this.btn_remover_jogador.UseVisualStyleBackColor = true;
            this.btn_remover_jogador.Click += new System.EventHandler(this.btn_remover_jogador_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome do jogador a adicionar";
            // 
            // btn_sortear_base_dados
            // 
            this.btn_sortear_base_dados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_sortear_base_dados.Location = new System.Drawing.Point(9, 494);
            this.btn_sortear_base_dados.Name = "btn_sortear_base_dados";
            this.btn_sortear_base_dados.Size = new System.Drawing.Size(105, 47);
            this.btn_sortear_base_dados.TabIndex = 5;
            this.btn_sortear_base_dados.Text = "Sortear com base de dados";
            this.btn_sortear_base_dados.UseVisualStyleBackColor = true;
            this.btn_sortear_base_dados.Click += new System.EventHandler(this.btn_sortear_base_dados_Click);
            // 
            // lbl_quantidade_pokemons_jogador
            // 
            this.lbl_quantidade_pokemons_jogador.AutoSize = true;
            this.lbl_quantidade_pokemons_jogador.Location = new System.Drawing.Point(9, 21);
            this.lbl_quantidade_pokemons_jogador.Name = "lbl_quantidade_pokemons_jogador";
            this.lbl_quantidade_pokemons_jogador.Size = new System.Drawing.Size(147, 13);
            this.lbl_quantidade_pokemons_jogador.TabIndex = 7;
            this.lbl_quantidade_pokemons_jogador.Text = "Qtd de pokémons por jogador";
            // 
            // nmc_qtd_pokemons
            // 
            this.nmc_qtd_pokemons.Location = new System.Drawing.Point(167, 19);
            this.nmc_qtd_pokemons.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nmc_qtd_pokemons.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmc_qtd_pokemons.Name = "nmc_qtd_pokemons";
            this.nmc_qtd_pokemons.Size = new System.Drawing.Size(55, 20);
            this.nmc_qtd_pokemons.TabIndex = 8;
            this.nmc_qtd_pokemons.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // chk_permite_repetir
            // 
            this.chk_permite_repetir.AutoSize = true;
            this.chk_permite_repetir.Location = new System.Drawing.Point(186, 106);
            this.chk_permite_repetir.Name = "chk_permite_repetir";
            this.chk_permite_repetir.Size = new System.Drawing.Size(15, 14);
            this.chk_permite_repetir.TabIndex = 9;
            this.chk_permite_repetir.UseVisualStyleBackColor = true;
            // 
            // lbl_permite_repetir_mesmo_time
            // 
            this.lbl_permite_repetir_mesmo_time.AutoSize = true;
            this.lbl_permite_repetir_mesmo_time.Location = new System.Drawing.Point(9, 106);
            this.lbl_permite_repetir_mesmo_time.Name = "lbl_permite_repetir_mesmo_time";
            this.lbl_permite_repetir_mesmo_time.Size = new System.Drawing.Size(153, 13);
            this.lbl_permite_repetir_mesmo_time.TabIndex = 10;
            this.lbl_permite_repetir_mesmo_time.Text = "Permite repetir no mesmo time?";
            // 
            // lbl_incluir_lendarios
            // 
            this.lbl_incluir_lendarios.AutoSize = true;
            this.lbl_incluir_lendarios.Location = new System.Drawing.Point(11, 183);
            this.lbl_incluir_lendarios.Name = "lbl_incluir_lendarios";
            this.lbl_incluir_lendarios.Size = new System.Drawing.Size(86, 13);
            this.lbl_incluir_lendarios.TabIndex = 12;
            this.lbl_incluir_lendarios.Text = "Incluir lendários?";
            this.lbl_incluir_lendarios.Visible = false;
            // 
            // chk_lendarios
            // 
            this.chk_lendarios.AutoSize = true;
            this.chk_lendarios.Location = new System.Drawing.Point(186, 183);
            this.chk_lendarios.Name = "chk_lendarios";
            this.chk_lendarios.Size = new System.Drawing.Size(15, 14);
            this.chk_lendarios.TabIndex = 11;
            this.chk_lendarios.UseVisualStyleBackColor = true;
            this.chk_lendarios.Visible = false;
            // 
            // nmc_vlr_minimo
            // 
            this.nmc_vlr_minimo.Location = new System.Drawing.Point(167, 48);
            this.nmc_vlr_minimo.Maximum = new decimal(new int[] {
            700,
            0,
            0,
            0});
            this.nmc_vlr_minimo.Name = "nmc_vlr_minimo";
            this.nmc_vlr_minimo.Size = new System.Drawing.Size(55, 20);
            this.nmc_vlr_minimo.TabIndex = 13;
            // 
            // nmc_vlr_maximo
            // 
            this.nmc_vlr_maximo.Location = new System.Drawing.Point(242, 48);
            this.nmc_vlr_maximo.Maximum = new decimal(new int[] {
            720,
            0,
            0,
            0});
            this.nmc_vlr_maximo.Name = "nmc_vlr_maximo";
            this.nmc_vlr_maximo.Size = new System.Drawing.Size(55, 20);
            this.nmc_vlr_maximo.TabIndex = 14;
            this.nmc_vlr_maximo.Value = new decimal(new int[] {
            720,
            0,
            0,
            0});
            // 
            // lbl_total_base_status_entre
            // 
            this.lbl_total_base_status_entre.AutoSize = true;
            this.lbl_total_base_status_entre.Location = new System.Drawing.Point(9, 50);
            this.lbl_total_base_status_entre.Name = "lbl_total_base_status_entre";
            this.lbl_total_base_status_entre.Size = new System.Drawing.Size(145, 13);
            this.lbl_total_base_status_entre.TabIndex = 15;
            this.lbl_total_base_status_entre.Text = "Total da base de status entre";
            // 
            // btn_sortear_arquivo
            // 
            this.btn_sortear_arquivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_sortear_arquivo.Location = new System.Drawing.Point(208, 493);
            this.btn_sortear_arquivo.Name = "btn_sortear_arquivo";
            this.btn_sortear_arquivo.Size = new System.Drawing.Size(105, 47);
            this.btn_sortear_arquivo.TabIndex = 16;
            this.btn_sortear_arquivo.Text = "Sortear com arquivo texto";
            this.btn_sortear_arquivo.UseVisualStyleBackColor = true;
            this.btn_sortear_arquivo.Click += new System.EventHandler(this.btn_sortear_arquivo_Click);
            // 
            // grp_filtros
            // 
            this.grp_filtros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grp_filtros.Controls.Add(this.chk_incluir_mega_evolucao);
            this.grp_filtros.Controls.Add(this.lbl_incluir_ao_menos_uma_mega_evolucao);
            this.grp_filtros.Controls.Add(this.chk_geracao_5);
            this.grp_filtros.Controls.Add(this.chk_geracao_6);
            this.grp_filtros.Controls.Add(this.chk_geracao_4);
            this.grp_filtros.Controls.Add(this.nmc_media_minima_base_status);
            this.grp_filtros.Controls.Add(this.lbl_media_minima_base_status);
            this.grp_filtros.Controls.Add(this.lnklbl_desmarcar_todos);
            this.grp_filtros.Controls.Add(this.chk_type_ghost);
            this.grp_filtros.Controls.Add(this.chk_type_dragon);
            this.grp_filtros.Controls.Add(this.chk_type_bug);
            this.grp_filtros.Controls.Add(this.chk_type_ice);
            this.grp_filtros.Controls.Add(this.chk_type_rock);
            this.grp_filtros.Controls.Add(this.chk_type_steel);
            this.grp_filtros.Controls.Add(this.chk_type_dark);
            this.grp_filtros.Controls.Add(this.chk_lendarios);
            this.grp_filtros.Controls.Add(this.lbl_incluir_lendarios);
            this.grp_filtros.Controls.Add(this.chk_type_psychic);
            this.grp_filtros.Controls.Add(this.chk_type_ground);
            this.grp_filtros.Controls.Add(this.chk_type_electric);
            this.grp_filtros.Controls.Add(this.chk_type_water);
            this.grp_filtros.Controls.Add(this.chk_type_poison);
            this.grp_filtros.Controls.Add(this.chk_type_fighting);
            this.grp_filtros.Controls.Add(this.chk_type_flying);
            this.grp_filtros.Controls.Add(this.chk_type_fire);
            this.grp_filtros.Controls.Add(this.chk_type_grass);
            this.grp_filtros.Controls.Add(this.chk_type_normal);
            this.grp_filtros.Controls.Add(this.chk_ultima_evolucao);
            this.grp_filtros.Controls.Add(this.label2);
            this.grp_filtros.Controls.Add(this.chk_geracao_3);
            this.grp_filtros.Controls.Add(this.chk_geracao_2);
            this.grp_filtros.Controls.Add(this.chk_geracao_1);
            this.grp_filtros.Controls.Add(this.chk_sorteio_secreto);
            this.grp_filtros.Controls.Add(this.lbl_sorteio_secreto);
            this.grp_filtros.Controls.Add(this.label4);
            this.grp_filtros.Controls.Add(this.lbl_total_base_status_entre);
            this.grp_filtros.Controls.Add(this.nmc_qtd_pokemons);
            this.grp_filtros.Controls.Add(this.chk_permite_repetir);
            this.grp_filtros.Controls.Add(this.lbl_quantidade_pokemons_jogador);
            this.grp_filtros.Controls.Add(this.lbl_permite_repetir_mesmo_time);
            this.grp_filtros.Controls.Add(this.nmc_vlr_maximo);
            this.grp_filtros.Controls.Add(this.nmc_vlr_minimo);
            this.grp_filtros.Location = new System.Drawing.Point(8, 162);
            this.grp_filtros.Name = "grp_filtros";
            this.grp_filtros.Size = new System.Drawing.Size(307, 325);
            this.grp_filtros.TabIndex = 17;
            this.grp_filtros.TabStop = false;
            this.grp_filtros.Text = "Filtros";
            // 
            // chk_geracao_5
            // 
            this.chk_geracao_5.AutoSize = true;
            this.chk_geracao_5.Checked = true;
            this.chk_geracao_5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_geracao_5.Location = new System.Drawing.Point(221, 182);
            this.chk_geracao_5.Name = "chk_geracao_5";
            this.chk_geracao_5.Size = new System.Drawing.Size(76, 17);
            this.chk_geracao_5.TabIndex = 46;
            this.chk_geracao_5.Text = "Geração 5";
            this.chk_geracao_5.UseVisualStyleBackColor = true;
            // 
            // chk_geracao_6
            // 
            this.chk_geracao_6.AutoSize = true;
            this.chk_geracao_6.Checked = true;
            this.chk_geracao_6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_geracao_6.Location = new System.Drawing.Point(221, 201);
            this.chk_geracao_6.Name = "chk_geracao_6";
            this.chk_geracao_6.Size = new System.Drawing.Size(76, 17);
            this.chk_geracao_6.TabIndex = 45;
            this.chk_geracao_6.Text = "Geração 6";
            this.chk_geracao_6.UseVisualStyleBackColor = true;
            // 
            // chk_geracao_4
            // 
            this.chk_geracao_4.AutoSize = true;
            this.chk_geracao_4.Checked = true;
            this.chk_geracao_4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_geracao_4.Location = new System.Drawing.Point(221, 163);
            this.chk_geracao_4.Name = "chk_geracao_4";
            this.chk_geracao_4.Size = new System.Drawing.Size(76, 17);
            this.chk_geracao_4.TabIndex = 44;
            this.chk_geracao_4.Text = "Geração 4";
            this.chk_geracao_4.UseVisualStyleBackColor = true;
            // 
            // nmc_media_minima_base_status
            // 
            this.nmc_media_minima_base_status.Location = new System.Drawing.Point(167, 76);
            this.nmc_media_minima_base_status.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nmc_media_minima_base_status.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmc_media_minima_base_status.Name = "nmc_media_minima_base_status";
            this.nmc_media_minima_base_status.Size = new System.Drawing.Size(55, 20);
            this.nmc_media_minima_base_status.TabIndex = 43;
            this.nmc_media_minima_base_status.Value = new decimal(new int[] {
            485,
            0,
            0,
            0});
            // 
            // lbl_media_minima_base_status
            // 
            this.lbl_media_minima_base_status.AutoSize = true;
            this.lbl_media_minima_base_status.Location = new System.Drawing.Point(12, 78);
            this.lbl_media_minima_base_status.Name = "lbl_media_minima_base_status";
            this.lbl_media_minima_base_status.Size = new System.Drawing.Size(130, 13);
            this.lbl_media_minima_base_status.TabIndex = 42;
            this.lbl_media_minima_base_status.Text = "Média mínima base status";
            // 
            // lnklbl_desmarcar_todos
            // 
            this.lnklbl_desmarcar_todos.AutoSize = true;
            this.lnklbl_desmarcar_todos.Location = new System.Drawing.Point(209, 300);
            this.lnklbl_desmarcar_todos.Name = "lnklbl_desmarcar_todos";
            this.lnklbl_desmarcar_todos.Size = new System.Drawing.Size(87, 13);
            this.lnklbl_desmarcar_todos.TabIndex = 41;
            this.lnklbl_desmarcar_todos.TabStop = true;
            this.lnklbl_desmarcar_todos.Text = "Desmarcar todos";
            this.lnklbl_desmarcar_todos.Visible = false;
            this.lnklbl_desmarcar_todos.Click += new System.EventHandler(this.lnklbl_desmarcar_todos_Click);
            // 
            // chk_type_ghost
            // 
            this.chk_type_ghost.AutoSize = true;
            this.chk_type_ghost.Checked = true;
            this.chk_type_ghost.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_type_ghost.Location = new System.Drawing.Point(241, 279);
            this.chk_type_ghost.Name = "chk_type_ghost";
            this.chk_type_ghost.Size = new System.Drawing.Size(54, 17);
            this.chk_type_ghost.TabIndex = 40;
            this.chk_type_ghost.Text = "Ghost";
            this.chk_type_ghost.UseVisualStyleBackColor = true;
            this.chk_type_ghost.Visible = false;
            // 
            // chk_type_dragon
            // 
            this.chk_type_dragon.AutoSize = true;
            this.chk_type_dragon.Checked = true;
            this.chk_type_dragon.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_type_dragon.Location = new System.Drawing.Point(182, 279);
            this.chk_type_dragon.Name = "chk_type_dragon";
            this.chk_type_dragon.Size = new System.Drawing.Size(61, 17);
            this.chk_type_dragon.TabIndex = 39;
            this.chk_type_dragon.Text = "Dragon";
            this.chk_type_dragon.UseVisualStyleBackColor = true;
            this.chk_type_dragon.Visible = false;
            // 
            // chk_type_bug
            // 
            this.chk_type_bug.AutoSize = true;
            this.chk_type_bug.Checked = true;
            this.chk_type_bug.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_type_bug.Location = new System.Drawing.Point(120, 279);
            this.chk_type_bug.Name = "chk_type_bug";
            this.chk_type_bug.Size = new System.Drawing.Size(45, 17);
            this.chk_type_bug.TabIndex = 38;
            this.chk_type_bug.Text = "Bug";
            this.chk_type_bug.UseVisualStyleBackColor = true;
            this.chk_type_bug.Visible = false;
            // 
            // chk_type_ice
            // 
            this.chk_type_ice.AutoSize = true;
            this.chk_type_ice.Checked = true;
            this.chk_type_ice.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_type_ice.Location = new System.Drawing.Point(68, 279);
            this.chk_type_ice.Name = "chk_type_ice";
            this.chk_type_ice.Size = new System.Drawing.Size(41, 17);
            this.chk_type_ice.TabIndex = 37;
            this.chk_type_ice.Text = "Ice";
            this.chk_type_ice.UseVisualStyleBackColor = true;
            this.chk_type_ice.Visible = false;
            // 
            // chk_type_rock
            // 
            this.chk_type_rock.AutoSize = true;
            this.chk_type_rock.Checked = true;
            this.chk_type_rock.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_type_rock.Location = new System.Drawing.Point(11, 279);
            this.chk_type_rock.Name = "chk_type_rock";
            this.chk_type_rock.Size = new System.Drawing.Size(52, 17);
            this.chk_type_rock.TabIndex = 36;
            this.chk_type_rock.Text = "Rock";
            this.chk_type_rock.UseVisualStyleBackColor = true;
            this.chk_type_rock.Visible = false;
            // 
            // chk_type_steel
            // 
            this.chk_type_steel.AutoSize = true;
            this.chk_type_steel.Checked = true;
            this.chk_type_steel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_type_steel.Location = new System.Drawing.Point(68, 299);
            this.chk_type_steel.Name = "chk_type_steel";
            this.chk_type_steel.Size = new System.Drawing.Size(50, 17);
            this.chk_type_steel.TabIndex = 35;
            this.chk_type_steel.Text = "Steel";
            this.chk_type_steel.UseVisualStyleBackColor = true;
            this.chk_type_steel.Visible = false;
            // 
            // chk_type_dark
            // 
            this.chk_type_dark.AutoSize = true;
            this.chk_type_dark.Checked = true;
            this.chk_type_dark.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_type_dark.Location = new System.Drawing.Point(11, 299);
            this.chk_type_dark.Name = "chk_type_dark";
            this.chk_type_dark.Size = new System.Drawing.Size(49, 17);
            this.chk_type_dark.TabIndex = 34;
            this.chk_type_dark.Text = "Dark";
            this.chk_type_dark.UseVisualStyleBackColor = true;
            this.chk_type_dark.Visible = false;
            // 
            // chk_type_psychic
            // 
            this.chk_type_psychic.AutoSize = true;
            this.chk_type_psychic.Checked = true;
            this.chk_type_psychic.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_type_psychic.Location = new System.Drawing.Point(241, 258);
            this.chk_type_psychic.Name = "chk_type_psychic";
            this.chk_type_psychic.Size = new System.Drawing.Size(63, 17);
            this.chk_type_psychic.TabIndex = 33;
            this.chk_type_psychic.Text = "Psychic";
            this.chk_type_psychic.UseVisualStyleBackColor = true;
            this.chk_type_psychic.Visible = false;
            // 
            // chk_type_ground
            // 
            this.chk_type_ground.AutoSize = true;
            this.chk_type_ground.Checked = true;
            this.chk_type_ground.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_type_ground.Location = new System.Drawing.Point(241, 237);
            this.chk_type_ground.Name = "chk_type_ground";
            this.chk_type_ground.Size = new System.Drawing.Size(61, 17);
            this.chk_type_ground.TabIndex = 32;
            this.chk_type_ground.Text = "Ground";
            this.chk_type_ground.UseVisualStyleBackColor = true;
            this.chk_type_ground.Visible = false;
            // 
            // chk_type_electric
            // 
            this.chk_type_electric.AutoSize = true;
            this.chk_type_electric.Checked = true;
            this.chk_type_electric.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_type_electric.Location = new System.Drawing.Point(182, 258);
            this.chk_type_electric.Name = "chk_type_electric";
            this.chk_type_electric.Size = new System.Drawing.Size(61, 17);
            this.chk_type_electric.TabIndex = 31;
            this.chk_type_electric.Text = "Electric";
            this.chk_type_electric.UseVisualStyleBackColor = true;
            this.chk_type_electric.Visible = false;
            // 
            // chk_type_water
            // 
            this.chk_type_water.AutoSize = true;
            this.chk_type_water.Checked = true;
            this.chk_type_water.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_type_water.Location = new System.Drawing.Point(182, 237);
            this.chk_type_water.Name = "chk_type_water";
            this.chk_type_water.Size = new System.Drawing.Size(55, 17);
            this.chk_type_water.TabIndex = 30;
            this.chk_type_water.Text = "Water";
            this.chk_type_water.UseVisualStyleBackColor = true;
            this.chk_type_water.Visible = false;
            // 
            // chk_type_poison
            // 
            this.chk_type_poison.AutoSize = true;
            this.chk_type_poison.Checked = true;
            this.chk_type_poison.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_type_poison.Location = new System.Drawing.Point(120, 258);
            this.chk_type_poison.Name = "chk_type_poison";
            this.chk_type_poison.Size = new System.Drawing.Size(58, 17);
            this.chk_type_poison.TabIndex = 29;
            this.chk_type_poison.Text = "Poison";
            this.chk_type_poison.UseVisualStyleBackColor = true;
            this.chk_type_poison.Visible = false;
            // 
            // chk_type_fighting
            // 
            this.chk_type_fighting.AutoSize = true;
            this.chk_type_fighting.Checked = true;
            this.chk_type_fighting.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_type_fighting.Location = new System.Drawing.Point(120, 237);
            this.chk_type_fighting.Name = "chk_type_fighting";
            this.chk_type_fighting.Size = new System.Drawing.Size(63, 17);
            this.chk_type_fighting.TabIndex = 28;
            this.chk_type_fighting.Text = "Fighting";
            this.chk_type_fighting.UseVisualStyleBackColor = true;
            this.chk_type_fighting.Visible = false;
            // 
            // chk_type_flying
            // 
            this.chk_type_flying.AutoSize = true;
            this.chk_type_flying.Checked = true;
            this.chk_type_flying.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_type_flying.Location = new System.Drawing.Point(68, 258);
            this.chk_type_flying.Name = "chk_type_flying";
            this.chk_type_flying.Size = new System.Drawing.Size(53, 17);
            this.chk_type_flying.TabIndex = 27;
            this.chk_type_flying.Text = "Flying";
            this.chk_type_flying.UseVisualStyleBackColor = true;
            this.chk_type_flying.Visible = false;
            // 
            // chk_type_fire
            // 
            this.chk_type_fire.AutoSize = true;
            this.chk_type_fire.Checked = true;
            this.chk_type_fire.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_type_fire.Location = new System.Drawing.Point(68, 237);
            this.chk_type_fire.Name = "chk_type_fire";
            this.chk_type_fire.Size = new System.Drawing.Size(43, 17);
            this.chk_type_fire.TabIndex = 26;
            this.chk_type_fire.Text = "Fire";
            this.chk_type_fire.UseVisualStyleBackColor = true;
            this.chk_type_fire.Visible = false;
            // 
            // chk_type_grass
            // 
            this.chk_type_grass.AutoSize = true;
            this.chk_type_grass.Checked = true;
            this.chk_type_grass.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_type_grass.Location = new System.Drawing.Point(11, 258);
            this.chk_type_grass.Name = "chk_type_grass";
            this.chk_type_grass.Size = new System.Drawing.Size(53, 17);
            this.chk_type_grass.TabIndex = 25;
            this.chk_type_grass.Text = "Grass";
            this.chk_type_grass.UseVisualStyleBackColor = true;
            this.chk_type_grass.Visible = false;
            // 
            // chk_type_normal
            // 
            this.chk_type_normal.AutoSize = true;
            this.chk_type_normal.Checked = true;
            this.chk_type_normal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_type_normal.Location = new System.Drawing.Point(11, 237);
            this.chk_type_normal.Name = "chk_type_normal";
            this.chk_type_normal.Size = new System.Drawing.Size(59, 17);
            this.chk_type_normal.TabIndex = 24;
            this.chk_type_normal.Text = "Normal";
            this.chk_type_normal.UseVisualStyleBackColor = true;
            this.chk_type_normal.Visible = false;
            // 
            // chk_ultima_evolucao
            // 
            this.chk_ultima_evolucao.AutoSize = true;
            this.chk_ultima_evolucao.Location = new System.Drawing.Point(186, 163);
            this.chk_ultima_evolucao.Name = "chk_ultima_evolucao";
            this.chk_ultima_evolucao.Size = new System.Drawing.Size(15, 14);
            this.chk_ultima_evolucao.TabIndex = 22;
            this.chk_ultima_evolucao.UseVisualStyleBackColor = true;
            this.chk_ultima_evolucao.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Apenas última evolução?";
            this.label2.Visible = false;
            // 
            // chk_geracao_3
            // 
            this.chk_geracao_3.AutoSize = true;
            this.chk_geracao_3.Checked = true;
            this.chk_geracao_3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_geracao_3.Location = new System.Drawing.Point(221, 144);
            this.chk_geracao_3.Name = "chk_geracao_3";
            this.chk_geracao_3.Size = new System.Drawing.Size(76, 17);
            this.chk_geracao_3.TabIndex = 21;
            this.chk_geracao_3.Text = "Geração 3";
            this.chk_geracao_3.UseVisualStyleBackColor = true;
            // 
            // chk_geracao_2
            // 
            this.chk_geracao_2.AutoSize = true;
            this.chk_geracao_2.Checked = true;
            this.chk_geracao_2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_geracao_2.Location = new System.Drawing.Point(221, 125);
            this.chk_geracao_2.Name = "chk_geracao_2";
            this.chk_geracao_2.Size = new System.Drawing.Size(76, 17);
            this.chk_geracao_2.TabIndex = 20;
            this.chk_geracao_2.Text = "Geração 2";
            this.chk_geracao_2.UseVisualStyleBackColor = true;
            // 
            // chk_geracao_1
            // 
            this.chk_geracao_1.AutoSize = true;
            this.chk_geracao_1.Checked = true;
            this.chk_geracao_1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_geracao_1.Location = new System.Drawing.Point(221, 106);
            this.chk_geracao_1.Name = "chk_geracao_1";
            this.chk_geracao_1.Size = new System.Drawing.Size(76, 17);
            this.chk_geracao_1.TabIndex = 19;
            this.chk_geracao_1.Text = "Geração 1";
            this.chk_geracao_1.UseVisualStyleBackColor = true;
            // 
            // chk_sorteio_secreto
            // 
            this.chk_sorteio_secreto.AutoSize = true;
            this.chk_sorteio_secreto.Location = new System.Drawing.Point(186, 125);
            this.chk_sorteio_secreto.Name = "chk_sorteio_secreto";
            this.chk_sorteio_secreto.Size = new System.Drawing.Size(15, 14);
            this.chk_sorteio_secreto.TabIndex = 17;
            this.chk_sorteio_secreto.UseVisualStyleBackColor = true;
            // 
            // lbl_sorteio_secreto
            // 
            this.lbl_sorteio_secreto.AutoSize = true;
            this.lbl_sorteio_secreto.Location = new System.Drawing.Point(9, 125);
            this.lbl_sorteio_secreto.Name = "lbl_sorteio_secreto";
            this.lbl_sorteio_secreto.Size = new System.Drawing.Size(84, 13);
            this.lbl_sorteio_secreto.TabIndex = 18;
            this.lbl_sorteio_secreto.Text = "Sorteio secreto?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "e";
            // 
            // btn_listar_pokemons_disponiveis
            // 
            this.btn_listar_pokemons_disponiveis.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_listar_pokemons_disponiveis.Location = new System.Drawing.Point(120, 494);
            this.btn_listar_pokemons_disponiveis.Name = "btn_listar_pokemons_disponiveis";
            this.btn_listar_pokemons_disponiveis.Size = new System.Drawing.Size(82, 47);
            this.btn_listar_pokemons_disponiveis.TabIndex = 41;
            this.btn_listar_pokemons_disponiveis.Text = "Listar Pokémons disponíveis";
            this.btn_listar_pokemons_disponiveis.UseVisualStyleBackColor = true;
            this.btn_listar_pokemons_disponiveis.Click += new System.EventHandler(this.btn_listar_pokemons_disponiveis_Click);
            // 
            // lbl_about
            // 
            this.lbl_about.Image = global::SorteioTimesPokemon.Properties.Resources.About_icon_16x16;
            this.lbl_about.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_about.Location = new System.Drawing.Point(298, 7);
            this.lbl_about.Name = "lbl_about";
            this.lbl_about.Size = new System.Drawing.Size(18, 18);
            this.lbl_about.TabIndex = 42;
            this.lbl_about.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_about.Click += new System.EventHandler(this.lbl_about_Click);
            // 
            // chk_incluir_mega_evolucao
            // 
            this.chk_incluir_mega_evolucao.AutoSize = true;
            this.chk_incluir_mega_evolucao.Location = new System.Drawing.Point(186, 144);
            this.chk_incluir_mega_evolucao.Name = "chk_incluir_mega_evolucao";
            this.chk_incluir_mega_evolucao.Size = new System.Drawing.Size(15, 14);
            this.chk_incluir_mega_evolucao.TabIndex = 47;
            this.chk_incluir_mega_evolucao.UseVisualStyleBackColor = true;
            // 
            // lbl_incluir_ao_menos_uma_mega_evolucao
            // 
            this.lbl_incluir_ao_menos_uma_mega_evolucao.AutoSize = true;
            this.lbl_incluir_ao_menos_uma_mega_evolucao.Location = new System.Drawing.Point(9, 144);
            this.lbl_incluir_ao_menos_uma_mega_evolucao.Name = "lbl_incluir_ao_menos_uma_mega_evolucao";
            this.lbl_incluir_ao_menos_uma_mega_evolucao.Size = new System.Drawing.Size(175, 13);
            this.lbl_incluir_ao_menos_uma_mega_evolucao.TabIndex = 48;
            this.lbl_incluir_ao_menos_uma_mega_evolucao.Text = "Incluir ao menos 1 mega evolução?";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 547);
            this.Controls.Add(this.lbl_about);
            this.Controls.Add(this.btn_listar_pokemons_disponiveis);
            this.Controls.Add(this.grp_filtros);
            this.Controls.Add(this.btn_sortear_arquivo);
            this.Controls.Add(this.btn_sortear_base_dados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_remover_jogador);
            this.Controls.Add(this.lbl_jogadores_adicionados);
            this.Controls.Add(this.txt_nme_jogador);
            this.Controls.Add(this.lst_listview);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sorteio de equipes pokemon";
            ((System.ComponentModel.ISupportInitialize)(this.nmc_qtd_pokemons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmc_vlr_minimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmc_vlr_maximo)).EndInit();
            this.grp_filtros.ResumeLayout(false);
            this.grp_filtros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmc_media_minima_base_status)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_listview;
        private System.Windows.Forms.TextBox txt_nme_jogador;
        private System.Windows.Forms.Label lbl_jogadores_adicionados;
        private System.Windows.Forms.Button btn_remover_jogador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_sortear_base_dados;
        private System.Windows.Forms.Label lbl_quantidade_pokemons_jogador;
        private System.Windows.Forms.NumericUpDown nmc_qtd_pokemons;
        private System.Windows.Forms.CheckBox chk_permite_repetir;
        private System.Windows.Forms.Label lbl_permite_repetir_mesmo_time;
        private System.Windows.Forms.Label lbl_incluir_lendarios;
        private System.Windows.Forms.CheckBox chk_lendarios;
        private System.Windows.Forms.NumericUpDown nmc_vlr_minimo;
        private System.Windows.Forms.NumericUpDown nmc_vlr_maximo;
        private System.Windows.Forms.Label lbl_total_base_status_entre;
        private System.Windows.Forms.Button btn_sortear_arquivo;
        private System.Windows.Forms.GroupBox grp_filtros;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chk_sorteio_secreto;
        private System.Windows.Forms.Label lbl_sorteio_secreto;
        private System.Windows.Forms.CheckBox chk_geracao_3;
        private System.Windows.Forms.CheckBox chk_geracao_2;
        private System.Windows.Forms.CheckBox chk_geracao_1;
        private System.Windows.Forms.CheckBox chk_ultima_evolucao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chk_type_grass;
        private System.Windows.Forms.CheckBox chk_type_normal;
        private System.Windows.Forms.CheckBox chk_type_steel;
        private System.Windows.Forms.CheckBox chk_type_dark;
        private System.Windows.Forms.CheckBox chk_type_psychic;
        private System.Windows.Forms.CheckBox chk_type_ground;
        private System.Windows.Forms.CheckBox chk_type_electric;
        private System.Windows.Forms.CheckBox chk_type_water;
        private System.Windows.Forms.CheckBox chk_type_poison;
        private System.Windows.Forms.CheckBox chk_type_fighting;
        private System.Windows.Forms.CheckBox chk_type_flying;
        private System.Windows.Forms.CheckBox chk_type_fire;
        private System.Windows.Forms.CheckBox chk_type_ghost;
        private System.Windows.Forms.CheckBox chk_type_dragon;
        private System.Windows.Forms.CheckBox chk_type_bug;
        private System.Windows.Forms.CheckBox chk_type_ice;
        private System.Windows.Forms.CheckBox chk_type_rock;
        private System.Windows.Forms.Button btn_listar_pokemons_disponiveis;
        private System.Windows.Forms.LinkLabel lnklbl_desmarcar_todos;
        private System.Windows.Forms.Label lbl_about;
        private System.Windows.Forms.NumericUpDown nmc_media_minima_base_status;
        private System.Windows.Forms.Label lbl_media_minima_base_status;
        private System.Windows.Forms.CheckBox chk_geracao_4;
        private System.Windows.Forms.CheckBox chk_geracao_5;
        private System.Windows.Forms.CheckBox chk_geracao_6;
        private System.Windows.Forms.CheckBox chk_incluir_mega_evolucao;
        private System.Windows.Forms.Label lbl_incluir_ao_menos_uma_mega_evolucao;
    }
}


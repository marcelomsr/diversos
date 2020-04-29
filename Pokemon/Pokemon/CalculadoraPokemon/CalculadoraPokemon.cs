using System;
using System.Collections.Generic;
using System.Pokemon;
using System.Windows.Forms;

namespace CalculadoraPokemon
{
    public partial class CalculadoraPokemon : Form
    {
        public CalculadoraPokemon()
        {
            InitializeComponent();

            popular_combos_pokemon();
            popular_combos_ability();
            popular_combos_nature();
            popular_combos_held_item();
            popular_combos_wheater();
            popular_combos_effectiveness();

            cbo_tpo_ataque.SelectedIndex = 0;
            cbo_nature_attacker.SelectedIndex = 1;
            cbo_nature_defender.SelectedIndex = 1;
            cbo_type_effectiveness.SelectedIndex = 2;
        }

        private void popular_combos_pokemon()
        {
            Pokemons pokemons = new Pokemons();

            Dictionary<string, Pokemon> items = new Dictionary<string, Pokemon>();

            foreach (Pokemon pokemon in pokemons.obter_pokemons())
            {
                items.Add(pokemon.Nome, pokemon);
            }

            BindingSource binding_pkm_attacker = new BindingSource(items, null);
            BindingSource binding_pkm_defender = new BindingSource(items, null);
            BindingSource binding_pkm_status_1 = new BindingSource(items, null);
            BindingSource binding_pkm_status_2 = new BindingSource(items, null);

            // Combo Pokémon Attacker
            cbo_pokemon_attacker.DataSource = binding_pkm_attacker;
            cbo_pokemon_attacker.DisplayMember = "Key";
            cbo_pokemon_attacker.ValueMember = "Value";

            // Combo Pokémon Defender
            cbo_pokemon_defender.DataSource = binding_pkm_defender;
            cbo_pokemon_defender.DisplayMember = "Key";
            cbo_pokemon_defender.ValueMember = "Value";

            // Combo Status
            cbo_pokemon_status_1.DataSource = binding_pkm_status_1;
            cbo_pokemon_status_1.DisplayMember = "Key";
            cbo_pokemon_status_1.ValueMember = "Value";
            cbo_pokemon_status_2.DataSource = binding_pkm_status_2;
            cbo_pokemon_status_2.DisplayMember = "Key";
            cbo_pokemon_status_2.ValueMember = "Value";


            if (items.Count > 0)
            {
                cbo_pokemon_attacker.SelectedIndex = 0;
                cbo_pokemon_defender.SelectedIndex = 0;
                cbo_pokemon_status_1.SelectedIndex = 0;
                cbo_pokemon_status_2.SelectedIndex = 0;
            }
        }

        private void popular_combos_ability()
        {
            // TODO: Implementar essa parte.
        }

        private void popular_combos_nature()
        {
            // TODO: Implementar essa parte.
        }

        private void popular_combos_held_item()
        {
            // TODO: Implementar essa parte.
        }

        private void popular_combos_wheater()
        {
            // TODO: Implementar essa parte.
        }

        private void popular_combos_effectiveness()
        {
            // TODO: Implementar essa parte.
        }

        #region CALCULAR STATUS

        private void btn_calcular_status_Click(object sender, System.EventArgs e)
        {
            calcular_status();
        }

        private void calcular_status()
        {
            Pokemon pokemon_1 = (Pokemon)cbo_pokemon_status_1.SelectedValue;
            Pokemon pokemon_2 = (Pokemon)cbo_pokemon_status_2.SelectedValue;

            calcular_HP(pokemon_1, pokemon_2);
            calcular_ATAQUE(pokemon_1, pokemon_2);
            calcular_DEFESA(pokemon_1, pokemon_2);
            calcular_ESPECIAL_ATAQUE(pokemon_1, pokemon_2);
            calcular_ESPECIAL_DEFESA(pokemon_1, pokemon_2);
            calcular_SPEED(pokemon_1, pokemon_2);
        }

        private void calcular_HP(Pokemon pokemon_1, Pokemon pokemon_2)
        {
            if (pokemon_1.Nome == "Shedinja")
            {
                txt_hp_1.Text = "1";
            }
            else
            {
                txt_hp_1.Text = CalculaStatus.calcular_hp(
                    pokemon_1.HP,
                    (int)nmc_vlr_iv_hp_1.Value,
                    (int)nmc_vlr_ev_hp_1.Value,
                    (int)nmc_vlr_level_1.Value).ToString();
            }

            if (pokemon_2.Nome == "Shedinja")
            {
                txt_hp_2.Text = "1";
            }
            else
            {
                txt_hp_2.Text = CalculaStatus.calcular_hp(
                    pokemon_2.HP,
                    (int)nmc_vlr_iv_hp_2.Value,
                    (int)nmc_vlr_ev_hp_2.Value,
                    (int)nmc_vlr_level_2.Value).ToString();
            }
        }

        private void calcular_ATAQUE(Pokemon pokemon_1, Pokemon pokemon_2)
        {
            decimal boost_item_1 = 0m;

            if (chk_choice_band_1.Checked)
            {
                boost_item_1 = 0.5m;
            }
            else if (chk_life_orb_1.Checked)
            {
                boost_item_1 = 0.3m;
            }
            else if (chk_item_20_1.Checked)
            {
                boost_item_1 = 0.2m;
            }

            txt_stat_negativo_atk_1.Text = CalculaStatus.calcular_ataque(
                -1,
                pokemon_1.Attack,
                (int)nmc_vlr_iv_atk_1.Value,
                (int)nmc_vlr_ev_atk_1.Value,
                (int)nmc_vlr_level_1.Value,
                (int)nmc_vlr_estagio_atk_1.Value,
                boost_item_1).ToString();

            txt_stat_neutro_atk_1.Text = CalculaStatus.calcular_ataque(
                0,
                pokemon_1.Attack,
                (int)nmc_vlr_iv_atk_1.Value,
                (int)nmc_vlr_ev_atk_1.Value,
                (int)nmc_vlr_level_1.Value,
                (int)nmc_vlr_estagio_atk_1.Value,
                boost_item_1).ToString();

            txt_stat_positivo_atk_1.Text = CalculaStatus.calcular_ataque(
                1,
                pokemon_1.Attack,
                (int)nmc_vlr_iv_atk_1.Value,
                (int)nmc_vlr_ev_atk_1.Value,
                (int)nmc_vlr_level_1.Value,
                (int)nmc_vlr_estagio_atk_1.Value,
                boost_item_1).ToString();

            /*********************************************************/

            decimal boost_item_2 = 0m;

            if (chk_choice_band_2.Checked)
            {
                boost_item_2 = 0.5m;
            }
            else if (chk_life_orb_2.Checked)
            {
                boost_item_2 = 0.3m;
            }
            else if (chk_item_20_2.Checked)
            {
                boost_item_2 = 0.2m;
            }

            txt_stat_negativo_atk_2.Text = CalculaStatus.calcular_ataque(
                -1,
                pokemon_2.Attack,
                (int)nmc_vlr_iv_atk_2.Value,
                (int)nmc_vlr_ev_atk_2.Value,
                (int)nmc_vlr_level_2.Value,
                (int)nmc_vlr_estagio_atk_2.Value,
                boost_item_2).ToString();

            txt_stat_neutro_atk_2.Text = CalculaStatus.calcular_ataque(
                0,
                pokemon_2.Attack,
                (int)nmc_vlr_iv_atk_2.Value,
                (int)nmc_vlr_ev_atk_2.Value,
                (int)nmc_vlr_level_2.Value,
                (int)nmc_vlr_estagio_atk_2.Value,
                boost_item_2).ToString();

            txt_stat_positivo_atk_2.Text = CalculaStatus.calcular_ataque(
                1,
                pokemon_2.Attack,
                (int)nmc_vlr_iv_atk_2.Value,
                (int)nmc_vlr_ev_atk_2.Value,
                (int)nmc_vlr_level_2.Value,
                (int)nmc_vlr_estagio_atk_2.Value,
                boost_item_2).ToString();
        }

        private void calcular_DEFESA(Pokemon pokemon_1, Pokemon pokemon_2)
        {
            txt_stat_negativo_def_1.Text = CalculaStatus.calcular_defesa(
                -1,
                pokemon_1.Defense,
                (int)nmc_vlr_iv_def_1.Value,
                (int)nmc_vlr_ev_def_1.Value,
                (int)nmc_vlr_level_1.Value,
                (int)nmc_vlr_estagio_def_1.Value,
                chk_boom_1.Checked).ToString();

            txt_stat_neutro_def_1.Text = CalculaStatus.calcular_defesa(
                0,
                pokemon_1.Defense,
                (int)nmc_vlr_iv_def_1.Value,
                (int)nmc_vlr_ev_def_1.Value,
                (int)nmc_vlr_level_1.Value,
                (int)nmc_vlr_estagio_def_1.Value,
                chk_boom_1.Checked).ToString();

            txt_stat_positivo_def_1.Text = CalculaStatus.calcular_defesa(
                1,
                pokemon_1.Defense,
                (int)nmc_vlr_iv_def_1.Value,
                (int)nmc_vlr_ev_def_1.Value,
                (int)nmc_vlr_level_1.Value,
                (int)nmc_vlr_estagio_def_1.Value,
                chk_boom_1.Checked).ToString();

            /***************************************************************/

            txt_stat_negativo_def_2.Text = CalculaStatus.calcular_defesa(
                -1,
                pokemon_2.Defense,
                (int)nmc_vlr_iv_def_2.Value,
                (int)nmc_vlr_ev_def_2.Value,
                (int)nmc_vlr_level_2.Value,
                (int)nmc_vlr_estagio_def_2.Value,
                chk_boom_2.Checked).ToString();

            txt_stat_neutro_def_2.Text = CalculaStatus.calcular_defesa(
                0,
                pokemon_2.Defense,
                (int)nmc_vlr_iv_def_2.Value,
                (int)nmc_vlr_ev_def_2.Value,
                (int)nmc_vlr_level_2.Value,
                (int)nmc_vlr_estagio_def_2.Value,
                chk_boom_2.Checked).ToString();

            txt_stat_positivo_def_2.Text = CalculaStatus.calcular_defesa(
                1,
                pokemon_2.Defense,
                (int)nmc_vlr_iv_def_2.Value,
                (int)nmc_vlr_ev_def_2.Value,
                (int)nmc_vlr_level_2.Value,
                (int)nmc_vlr_estagio_def_2.Value,
                chk_boom_2.Checked).ToString();
        }

        private void calcular_ESPECIAL_ATAQUE(Pokemon pokemon_1, Pokemon pokemon_2)
        {
            decimal boost_item_1 = 0m;

            if (chk_choice_specs_1.Checked)
            {
                boost_item_1 = 0.5m;
            }
            else if (chk_life_orb_1.Checked)
            {
                boost_item_1 = 0.3m;
            }
            else if (chk_item_20_1.Checked)
            {
                boost_item_1 = 0.2m;
            }

            txt_stat_negativo_spatk_1.Text = CalculaStatus.calcular_ataque(
                -1,
                pokemon_1.SpAttack,
                (int)nmc_vlr_iv_spatk_1.Value,
                (int)nmc_vlr_ev_spatk_1.Value,
                (int)nmc_vlr_level_1.Value,
                (int)nmc_vlr_estagio_spatk_1.Value,
                boost_item_1).ToString();

            txt_stat_neutro_spatk_1.Text = CalculaStatus.calcular_ataque(
                0,
                pokemon_1.SpAttack,
                (int)nmc_vlr_iv_spatk_1.Value,
                (int)nmc_vlr_ev_spatk_1.Value,
                (int)nmc_vlr_level_1.Value,
                (int)nmc_vlr_estagio_spatk_1.Value,
                boost_item_1).ToString();

            txt_stat_positivo_spatk_1.Text = CalculaStatus.calcular_ataque(
                1,
                pokemon_1.SpAttack,
                (int)nmc_vlr_iv_spatk_1.Value,
                (int)nmc_vlr_ev_spatk_1.Value,
                (int)nmc_vlr_level_1.Value,
                (int)nmc_vlr_estagio_spatk_1.Value,
                boost_item_1).ToString();

            /************************************************************/

            decimal boost_item_2 = 0m;

            if (chk_choice_specs_2.Checked)
            {
                boost_item_2 = 0.5m;
            }
            else if (chk_life_orb_2.Checked)
            {
                boost_item_2 = 0.3m;
            }
            else if (chk_item_20_2.Checked)
            {
                boost_item_2 = 0.2m;
            }

            txt_stat_negativo_spatk_2.Text = CalculaStatus.calcular_ataque(
                -1,
                pokemon_2.SpAttack,
                (int)nmc_vlr_iv_spatk_2.Value,
                (int)nmc_vlr_ev_spatk_2.Value,
                (int)nmc_vlr_level_2.Value,
                (int)nmc_vlr_estagio_spatk_2.Value,
                boost_item_2).ToString();

            txt_stat_neutro_spatk_2.Text = CalculaStatus.calcular_ataque(
                0,
                pokemon_2.SpAttack,
                (int)nmc_vlr_iv_spatk_2.Value,
                (int)nmc_vlr_ev_spatk_2.Value,
                (int)nmc_vlr_level_2.Value,
                (int)nmc_vlr_estagio_spatk_2.Value,
                boost_item_2).ToString();

            txt_stat_positivo_spatk_2.Text = CalculaStatus.calcular_ataque(
                1,
                pokemon_2.SpAttack,
                (int)nmc_vlr_iv_spatk_2.Value,
                (int)nmc_vlr_ev_spatk_2.Value,
                (int)nmc_vlr_level_2.Value,
                (int)nmc_vlr_estagio_spatk_2.Value,
                boost_item_2).ToString();
        }

        private void calcular_ESPECIAL_DEFESA(Pokemon pokemon_1, Pokemon pokemon_2)
        {
            txt_stat_negativo_spdef_1.Text = CalculaStatus.calcular_sp_def(
                -1,
                pokemon_1.SpDefense,
                (int)nmc_vlr_iv_spdef_1.Value,
                (int)nmc_vlr_ev_spdef_1.Value,
                (int)nmc_vlr_level_1.Value,
                (int)nmc_vlr_estagio_spdef_1.Value,
                chk_sandstorm_1.Checked).ToString();

            txt_stat_neutro_spdef_1.Text = CalculaStatus.calcular_sp_def(
                0,
                pokemon_1.SpDefense,
                (int)nmc_vlr_iv_spdef_1.Value,
                (int)nmc_vlr_ev_spdef_1.Value,
                (int)nmc_vlr_level_1.Value,
                (int)nmc_vlr_estagio_spdef_1.Value,
                chk_sandstorm_1.Checked).ToString();

            txt_stat_positivo_spdef_1.Text = CalculaStatus.calcular_sp_def(
                1,
                pokemon_1.SpDefense,
                (int)nmc_vlr_iv_spdef_1.Value,
                (int)nmc_vlr_ev_spdef_1.Value,
                (int)nmc_vlr_level_1.Value,
                (int)nmc_vlr_estagio_spdef_1.Value,
                chk_sandstorm_1.Checked).ToString();

            /***************************************************************/

            txt_stat_negativo_spdef_2.Text = CalculaStatus.calcular_sp_def(
                -1,
                pokemon_2.SpDefense,
                (int)nmc_vlr_iv_spdef_2.Value,
                (int)nmc_vlr_ev_spdef_2.Value,
                (int)nmc_vlr_level_2.Value,
                (int)nmc_vlr_estagio_spdef_2.Value,
                chk_sandstorm_2.Checked).ToString();

            txt_stat_neutro_spdef_2.Text = CalculaStatus.calcular_sp_def(
                0,
                pokemon_2.SpDefense,
                (int)nmc_vlr_iv_spdef_2.Value,
                (int)nmc_vlr_ev_spdef_2.Value,
                (int)nmc_vlr_level_2.Value,
                (int)nmc_vlr_estagio_spdef_2.Value,
                chk_sandstorm_2.Checked).ToString();

            txt_stat_positivo_spdef_2.Text = CalculaStatus.calcular_sp_def(
                1,
                pokemon_2.SpDefense,
                (int)nmc_vlr_iv_spdef_2.Value,
                (int)nmc_vlr_ev_spdef_2.Value,
                (int)nmc_vlr_level_2.Value,
                (int)nmc_vlr_estagio_spdef_2.Value,
                chk_sandstorm_2.Checked).ToString();
        }

        private void calcular_SPEED(Pokemon pokemon_1, Pokemon pokemon_2)
        {
            txt_stat_negativo_spd_1.Text = CalculaStatus.calcular_speed(
                -1,
                pokemon_1.Speed,
                (int)nmc_vlr_iv_spd_1.Value,
                (int)nmc_vlr_ev_spd_1.Value,
                (int)nmc_vlr_level_1.Value,
                (int)nmc_vlr_estagio_spd_1.Value,
                chk_paralysis_1.Checked,
                chk_choice_scarf_1.Checked).ToString();

            txt_stat_neutro_spd_1.Text = CalculaStatus.calcular_speed(
                0,
                pokemon_1.Speed,
                (int)nmc_vlr_iv_spd_1.Value,
                (int)nmc_vlr_ev_spd_1.Value,
                (int)nmc_vlr_level_1.Value,
                (int)nmc_vlr_estagio_spd_1.Value,
                chk_paralysis_1.Checked,
                chk_choice_scarf_1.Checked).ToString();

            txt_stat_positivo_spd_1.Text = CalculaStatus.calcular_speed(
                1,
                pokemon_1.Speed,
                (int)nmc_vlr_iv_spd_1.Value,
                (int)nmc_vlr_ev_spd_1.Value,
                (int)nmc_vlr_level_1.Value,
                (int)nmc_vlr_estagio_spd_1.Value,
                chk_paralysis_1.Checked,
                chk_choice_scarf_1.Checked).ToString();

            /***********************************************************/

            txt_stat_negativo_spd_2.Text = CalculaStatus.calcular_speed(
                -1,
                pokemon_2.Speed,
                (int)nmc_vlr_iv_spd_2.Value,
                (int)nmc_vlr_ev_spd_2.Value,
                (int)nmc_vlr_level_2.Value,
                (int)nmc_vlr_estagio_spd_2.Value,
                chk_paralysis_2.Checked,
                chk_choice_scarf_2.Checked).ToString();

            txt_stat_neutro_spd_2.Text = CalculaStatus.calcular_speed(
                0,
                pokemon_2.Speed,
                (int)nmc_vlr_iv_spd_2.Value,
                (int)nmc_vlr_ev_spd_2.Value,
                (int)nmc_vlr_level_2.Value,
                (int)nmc_vlr_estagio_spd_2.Value,
                chk_paralysis_2.Checked,
                chk_choice_scarf_2.Checked).ToString();

            txt_stat_positivo_spd_2.Text = CalculaStatus.calcular_speed(
                1,
                pokemon_2.Speed,
                (int)nmc_vlr_iv_spd_2.Value,
                (int)nmc_vlr_ev_spd_2.Value,
                (int)nmc_vlr_level_2.Value,
                (int)nmc_vlr_estagio_spd_2.Value,
                chk_paralysis_2.Checked,
                chk_choice_scarf_2.Checked).ToString();
        }

        #endregion

        private void chk_choice_band_CheckedChanged(object sender, System.EventArgs e)
        {
            /*
            if (chk_choice_band.Checked)
                chk_choice_scarf.Checked = chk_choice_specs.Checked = false;
             * */
        }

        private void chk_choice_scarf_CheckedChanged(object sender, System.EventArgs e)
        {
            /*
            if (chk_choice_scarf.Checked)
                chk_choice_band.Checked = chk_choice_specs.Checked = false;
             * */
        }

        private void chk_choice_specs_CheckedChanged(object sender, System.EventArgs e)
        {
            /*
            if (chk_choice_specs.Checked)
                chk_choice_band.Checked = chk_choice_scarf.Checked = false;
             * */
        }

        #region CALCULA DANO

        private void btn_calcular_dano_Click(object sender, System.EventArgs e)
        {
            Pokemon pokemon_attacker = (Pokemon)cbo_pokemon_attacker.SelectedValue;
            Pokemon pokemon_defender = (Pokemon)cbo_pokemon_defender.SelectedValue;

            int nivel_attacker = 0;

            if (cbo_nature_attacker.SelectedIndex == 0)
            {
                nivel_attacker = -1;
            }
            else if (cbo_nature_attacker.SelectedIndex == 2)
            {
                nivel_attacker = 1;
            }

            decimal boost_item_atk = 0m;

            if (chk_choice_item_attacker.Checked)
            {
                boost_item_atk = 0.5m;
            }
            else if (chk_life_orb_attacker.Checked)
            {
                boost_item_atk = 0.3m;
            }

            decimal nmr_attack = CalculaStatus.calcular_ataque(
                nivel_attacker,
                cbo_tpo_ataque.SelectedIndex == 0 ? pokemon_attacker.Attack : pokemon_attacker.SpAttack,
                (int)nmc_iv_attacker.Value,
                (int)nmc_ev_attacker.Value,
                (int)nmc_vlr_lvl_attacker.Value,
                (int)nmc_estagio_attacker.Value,
                boost_item_atk);

            int nivel_defender = 0;

            if (cbo_nature_defender.SelectedIndex == 0)
            {
                nivel_defender = -1;
            }
            else if (cbo_nature_defender.SelectedIndex == 2)
            {
                nivel_defender = 1;
            }

            decimal nmr_defense = CalculaStatus.calcular_defesa(
                nivel_defender,
                cbo_tpo_ataque.SelectedIndex == 0 ? pokemon_defender.Defense : pokemon_defender.SpDefense,
                (int)nmc_iv_defesa_defender.Value,
                (int)nmc_ev_defesa_defender.Value,
                (int)nmc_level_defender.Value,
                (int)nmc_estagio_defender.Value,
                false);

            decimal dano_minimo = 0;
            decimal dano_maximo = 0;

            CalculaDano.calcular_dano(ref dano_minimo, ref dano_maximo,
                (int)nmc_vlr_lvl_attacker.Value,
                (int)nmr_attack,
                (int)nmr_defense,
                (int)nmc_base_power_attacker.Value,
                chk_stab.Checked,
                Convert.ToDecimal(cbo_type_effectiveness.SelectedItem),
                chk_critical_hit.Checked,
                false);

            int hp = (int)CalculaStatus.calcular_hp(pokemon_defender.HP, (int)nmc_iv_hp_defender.Value, (int)nmc_ev_hp_defender.Value, (int)nmc_level_defender.Value);

            lbl_damage.Text =
                String.Format("Dano: {0} ~ {1} {2}",
                (int)dano_minimo,
                (int)dano_maximo,
                (int)dano_minimo > hp ? "Mata em 1 golpe só!" : "Precisa de mais de 1 golpe!");

            lbl_hp_defensor.Text = String.Format("HP do defensor: {0}", hp);
        }

        #endregion

        #region CALCULAR HIDDEN POWER

        private void btn_calcular_hidden_power_Click(object sender, System.EventArgs e)
        {
            Dictionary<int, string> types = new Dictionary<int, string>();
            types.Add(0, "Fighting");
            types.Add(1, "Flying");
            types.Add(2, "Poison");
            types.Add(3, "Ground");
            types.Add(4, "Rock");
            types.Add(5, "Bug");
            types.Add(6, "Ghost");
            types.Add(7, "Steel");
            types.Add(8, "Fire");
            types.Add(9, "Water");
            types.Add(10, "Grass");
            types.Add(11, "Electric");
            types.Add(12, "Psychic");
            types.Add(13, "Ice");
            types.Add(14, "Dragon");
            types.Add(15, "Dark");

            int iv_HP = (int)nmc_hdd_pwr_hp.Value;
            int iv_atk = (int)nmc_hdd_pwr_atk.Value;
            int iv_def = (int)nmc_hdd_pwr_def.Value;
            int iv_speed = (int)nmc_hdd_pwr_spd.Value;
            int iv_sp_atk = (int)nmc_hdd_pwr_spatk.Value;
            int iv_sp_def = (int)nmc_hdd_pwr_spdef.Value;

            int type = (((iv_HP % 2) + (iv_atk % 2) * 2 + (iv_def % 2) * 4 + (iv_speed % 2) * 8 + (iv_sp_atk % 2) * 16 + (iv_sp_def % 2) * 32) * 15) / 63;
            lbl_vlr_type_hdd_pwr.Text = types[type];

            if ((iv_HP % 4) == 0 || (iv_HP % 4) == 1)
                iv_HP = 0;

            if ((iv_HP % 4) == 2 || (iv_HP % 4) == 3)
                iv_HP = 1;

            if ((iv_atk % 4) == 0 || (iv_atk % 4) == 1)
                iv_atk = 0;

            if ((iv_atk % 4) == 2 || (iv_atk % 4) == 3)
                iv_atk = 1;

            if ((iv_def % 4) == 0 || (iv_def % 4) == 1)
                iv_def = 0;

            if ((iv_def % 4) == 2 || (iv_def % 4) == 3)
                iv_def = 1;

            if ((iv_speed % 4) == 0 || (iv_speed % 4) == 1)
                iv_speed = 0;

            if ((iv_speed % 4) == 2 || (iv_speed % 4) == 3)
                iv_speed = 1;

            if ((iv_sp_atk % 4) == 0 || (iv_sp_atk % 4) == 1)
                iv_sp_atk = 0;

            if ((iv_sp_atk % 4) == 2 || (iv_sp_atk % 4) == 3)
                iv_sp_atk = 1;

            if ((iv_sp_def % 4) == 0 || (iv_sp_def % 4) == 1)
                iv_sp_def = 0;

            if ((iv_sp_def % 4) == 2 || (iv_sp_def % 4) == 3)
                iv_sp_def = 1;

            int power = (((iv_HP + iv_atk * 2 + iv_def * 4 + iv_speed * 8 + iv_sp_atk * 16 + iv_sp_def * 32) * 40) / 63) + 30;
            lbl_vlr_power_hdd_pwr.Text = power.ToString();
        }

        #endregion
    }
}
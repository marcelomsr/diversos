using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculadoraDanosPokemon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cbo_type_effectiveness.SelectedIndex = 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Damage = ((L * 2 + 10)/250 * (A / D) * B + 2) * M
            //L - Level of the attacking Pokémon.
            //A - Attack of the attacking Pokémon.
            //D - Defense of the defending Pokémon.
            //B - The base damage of the attack.
            //M - Any damage modifiers. M is calculated as follows:
            //Modifier = STAB * T * C * O * (rand ∈ [0.85, 1.00])
            //STAB - Same-type attack bonus. Value is 1.5 if the Pokémon gets STAB, 1 otherwise.
            //T - Type effectiveness. Value can be 0, 0.25, 0.5, 1, 2, or 4.
            //C - Critical hit. 2 if the attack lands a critical hit, 1 otherwise.
            //O - Other. Things like weather, held items, ect.
            //Rand - Random number between 0.85 and 1.00.

            decimal dano_primario;
            decimal modifiers_min;
            decimal modifiers_max;
            decimal level = nmr_level.Value;
            decimal attack = nmr_attack.Value;
            decimal defense = nmr_defense.Value; ;
            decimal power_attack = nmr_attack_power.Value;

            dano_primario = ((((level * 2 + 10) / 250) * (attack / defense) * power_attack) + 2);

            // STAB
            decimal stab = 1;

            if(chk_stab.Checked)
                stab = 1.5m;

            // Type effectiness
            decimal type_effectiness = Convert.ToDecimal(cbo_type_effectiveness.SelectedItem);

            // Critical Hit
            int critical_hit = 1;

            if (chk_critical_hit.Checked)
                critical_hit = 2;

            // Other
            decimal other = 1;

            if (chk_choice_item.Checked)
                other += 0.5m;

            modifiers_min = stab * type_effectiness * critical_hit * other * 0.85m;
            modifiers_max = stab * type_effectiness * critical_hit * other * 1.00m;
            
            decimal dano_final_minimo = dano_primario * modifiers_min;
            decimal dano_final_maximo = dano_primario * modifiers_max;
            
            lbl_dano_minimo.Text = dano_final_minimo.ToString();
            lbl_dano_maximo.Text = dano_final_maximo.ToString();            
        }
    }
}
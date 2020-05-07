using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Pokemon
{
    public class CalculaDano
    {
        public static void calcular_dano(
            ref decimal dano_minimo, ref decimal dano_maximo, int nmr_level, int nmr_attack, int nmr_defense, int nmr_attack_power,
            bool stab, decimal type_effectiness, bool critical_hit, bool choice_item)
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
            decimal level = nmr_level;
            decimal attack = nmr_attack;
            decimal defense = nmr_defense;
            decimal power_attack = nmr_attack_power;

            dano_primario = ((((level * 2 + 10) / 250) * (attack / defense) * power_attack) + 2);

            // STAB
            decimal vlr_stab = 1;

            if (stab)
                vlr_stab = 1.5m;

            // Critical Hit
            int vlr_critical_hit = 1;

            if (critical_hit)
                vlr_critical_hit = 2;

            // Other
            decimal vlr_other = 1;

            if (choice_item)
                vlr_other += 0.5m;

            modifiers_min = vlr_stab * type_effectiness * vlr_critical_hit * vlr_other * 0.85m;
            modifiers_max = vlr_stab * type_effectiness * vlr_critical_hit * vlr_other * 1.00m;

            dano_minimo = dano_primario * modifiers_min;
            dano_maximo = dano_primario * modifiers_max;
        }
    }
}

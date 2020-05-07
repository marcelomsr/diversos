using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Pokemon
{
    public class CalculaStatus
    {
        // TODO: Existem ainda as traits modificadoras, que são as abilities que fazem aumentar os stats, tipo Pure Power.
        // Falta calcular isso, se as traits entram nisso, os items que aumentam stats como choice band, choice specs e choice scarf também podem entrar.
        // Items como charcoal, black belt, entram no calculo de damage

        public static decimal calcular_hp(int base_stat, int iv, int ev, int level)
        {
            // HP = {[2 * Base Stat + IV + (EV ÷ 4) ]* Nível ÷ 100 + Nível + 10}

            return (((iv + (2 * base_stat) + (ev / 4) + 100) * level) / 100) + 10;
        }

        public static decimal calcular_ataque(int nivel, int base_stat, int iv, int ev, int level, int estagio, decimal boost_item)
        {
            // Stat = {[2 * Base Stat + IV + (EV ÷ 4) ] * Nível ÷ 100 + 5 } * Nature
            // Status final = Stat * Modificador

            decimal trait_modificadora = 1;            
            trait_modificadora += boost_item;

            decimal modificador = obter_modificador(estagio);

            switch (nivel)
            {
                case -1:
                    decimal stat_min = Math.Floor(((2 * base_stat + iv + (ev / 4)) * level / 100 + 5) * 0.9m);
                    return Math.Floor(stat_min * modificador * trait_modificadora);

                case 0:
                    decimal stat_neutro = Math.Floor(((2 * base_stat + iv + (ev / 4)) * level / 100 + 5) * 1m);
                    return Math.Floor(stat_neutro * modificador * trait_modificadora);

                case 1:
                    decimal stat_max = Math.Floor(((2 * base_stat + iv + (ev / 4)) * level / 100 + 5) * 1.1m);
                    return Math.Floor(stat_max * modificador * trait_modificadora);

                default:
                    return 0;
            }
        }

        public static decimal calcular_defesa(int nivel, int base_stat, int iv, int ev, int level, int estagio, bool boom)
        {
            // Stat = {[2 * Base Stat + IV + (EV ÷ 4) ] * Nível ÷ 100 + 5 } * Nature
            // Status final = Stat * Modificador

            decimal vlr_boom = 1.00m;

            if (boom)
                vlr_boom = 0.50m;

            decimal modificador = obter_modificador(estagio);

            switch (nivel)
            {
                case -1:
                    decimal stat_min = Math.Floor(((2 * base_stat + iv + (ev / 4)) * level / 100 + 5) * 0.9m);
                    return Math.Floor(stat_min * modificador * vlr_boom);

                case 0:
                    decimal stat_neutro = Math.Floor(((2 * base_stat + iv + (ev / 4)) * level / 100 + 5) * 1m);
                    return Math.Floor(stat_neutro * modificador * vlr_boom);

                case 1:
                    decimal stat_max = Math.Floor(((2 * base_stat + iv + (ev / 4)) * level / 100 + 5) * 1.1m);
                    return Math.Floor(stat_max * modificador * vlr_boom);

                default:
                    return 0;
            }
        }

        public static decimal calcular_sp_def(int nivel, int base_stat, int iv, int ev, int level, int estagio, bool sandstorm)
        {
            // Stat = {[2 * Base Stat + IV + (EV ÷ 4) ] * Nível ÷ 100 + 5 } * Nature
            // Status final = Stat * Modificador
            
            decimal modificador = obter_modificador(estagio);
            decimal sp_def = 1;

            if (sandstorm)
            {
                sp_def = 1.50m;
            }            

            switch (nivel)
            {
                case -1:
                    decimal stat_min = Math.Floor(((2 * base_stat + iv + (ev / 4)) * level / 100 + 5) * 0.9m);
                    return Math.Floor(stat_min * modificador * sp_def);

                case 0:
                    decimal stat_neutro = Math.Floor(((2 * base_stat + iv + (ev / 4)) * level / 100 + 5) * 1m);
                    return Math.Floor(stat_neutro * modificador * sp_def);

                case 1:
                    decimal stat_max = Math.Floor(((2 * base_stat + iv + (ev / 4)) * level / 100 + 5) * 1.1m);
                    return Math.Floor(stat_max * modificador * sp_def);

                default:
                    return 0;
            }
        }

        public static decimal calcular_speed(int nivel, int base_stat, int iv, int ev, int level, int estagio, bool paralysis, bool choice_item)
        {
            // Stat = {[2 * Base Stat + IV + (EV ÷ 4) ] * Nível ÷ 100 + 5 } * Nature
            // Status final = Stat * Modificador

            decimal trait_modificadora = 1;

            decimal speed = 1.00m;

            if (paralysis)
                speed = 0.25m;

            if (choice_item)
                trait_modificadora += 0.5m;

            decimal modificador = obter_modificador(estagio);

            switch (nivel)
            {
                case -1:
                    decimal stat_min = Math.Floor(((2 * base_stat + iv + (ev / 4)) * level / 100 + 5) * 0.9m);
                    return Math.Floor(stat_min * modificador * speed * trait_modificadora);

                case 0:
                    decimal stat_neutro = Math.Floor(((2 * base_stat + iv + (ev / 4)) * level / 100 + 5) * 1m);
                    return Math.Floor(stat_neutro * modificador * speed * trait_modificadora);

                case 1:
                    decimal stat_max = Math.Floor(((2 * base_stat + iv + (ev / 4)) * level / 100 + 5) * 1.1m);
                    return Math.Floor(stat_max * modificador * speed * trait_modificadora);

                default:
                    return 0;
            }
        }

        private static decimal obter_modificador(int estagio)
        {
            decimal modificador;

            switch (estagio)
            {
                case 0:
                    // Cálculo é feito da seguinte maneira: 2 / 2 que é igual (1).
                    modificador = 1;
                    break;

                case 1:
                    // Cálculo é feito da seguinte maneira: 3 / 2 que é igual (1.5).
                    modificador = 1.5m;
                    break;

                case 2:
                    // Cálculo é feito da seguinte maneira: 4 / 2 que é igual (2).
                    modificador = 2;
                    break;

                case 3:
                    // Cálculo é feito da seguinte maneira: 5 / 2 que é igual (2.5).
                    modificador = 2.5m;
                    break;

                case 4:
                    // Cálculo é feito da seguinte maneira: 6 / 2 que é igual (3).
                    modificador = 3;
                    break;

                case 5:
                    // Cálculo é feito da seguinte maneira: 7 / 2 que é igual (3.5).
                    modificador = 3.5m;
                    break;

                case 6:
                    // Cálculo é feito da seguinte maneira: 8 / 2 que é igual (4).
                    modificador = 4;
                    break;

                case -1:
                    // Cálculo é feito da seguinte maneira: 2 / 3 que é igual (0.6667).
                    modificador = 0.6667m;
                    break;

                case -2:
                    // Cálculo é feito da seguinte maneira: 2 / 4 que é igual (0.5).
                    modificador = 0.5m;
                    break;

                case -3:
                    // Cálculo é feito da seguinte maneira: 2 / 5 que é igual (0.4).
                    modificador = 0.4m;
                    break;

                case -4:
                    // Cálculo é feito da seguinte maneira: 2 / 6 que é igual (0.3333).
                    modificador = 0.3333m;
                    break;

                case -5:
                    // Cálculo é feito da seguinte maneira: 2 / 7 que é igual (0.2857).
                    modificador = 0.2857m;
                    break;

                case -6:
                    // Cálculo é feito da seguinte maneira: 2 / 8 que é igual (0.25).
                    modificador = 0.25m;
                    break;

                default:
                    // Cálculo é feito da seguinte maneira: 2 / 2 que é igual (1).
                    modificador = 1;
                    break;
            }

            return modificador;
        }
    }
}
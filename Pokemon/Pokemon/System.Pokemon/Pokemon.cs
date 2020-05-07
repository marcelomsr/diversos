using System.Collections.Generic;

namespace System.Pokemon
{
    public class Pokemon
    {
        public int Number { get; private set; }
        public string Name { get; private set; }
        public int HP { get; private set; }
        public int Attack { get; private set; }
        public int Defense { get; private set; }
        public int spAttack { get; private set; }
        public int spDefense { get; private set; }
        public int Speed { get; private set; }
        public int totalStatus { get; private set; }
        public decimal averageStatus { get; private set; }
        public int Generation { get; private set; }
        public bool isMegaForm { get; private set; }
        public bool isLegendary { get; private set; }
        public int[] priorEvolution { get; private set; }
        public int[] rearEvolution { get; private set; }
        public Types[] typesOfPokemon { get; private set; }

        public enum Types
        {
            Normal,
            Fire,
            Fighting,
            Water,
            Flying,
            Grass,
            Poison,
            Electric,
            Ground,
            Psychic,
            Rock,
            Ice,
            Bug,
            Dragon,
            Ghost,
            Dark,
            Steel,
            Fairy
        }

        public Pokemon(int Number, string Name, int HP, int Attack, int Defense, int spAttack, int spDefense, int Speed, int totalStatus, decimal averageStatus,
            int Generation, bool isLegendary, int[] priorEvolution, int[] rearEvolution, List<Types> typesOfPokemon, bool isMegaForm)
        {
            this.Number = Number;
            this.Name = Name;
            this.HP = HP;
            this.Attack = Attack;
            this.Defense = Defense;
            this.spAttack = spAttack;
            this.spDefense = spDefense;
            this.Speed = Speed;
            this.totalStatus = totalStatus;
            this.averageStatus = averageStatus;
            this.Generation = Generation;
            this.isLegendary = isLegendary;
            this.priorEvolution = priorEvolution;
            this.rearEvolution = rearEvolution;
            this.typesOfPokemon = typesOfPokemon.ToArray();
            this.isMegaForm = isMegaForm;
        }
    }
}

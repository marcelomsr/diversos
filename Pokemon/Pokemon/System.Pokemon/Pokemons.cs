using System.Collections.Generic;

namespace System.Pokemon
{
    public class Pokemons
    {
        private List<Pokemon> _pokemons_disponiveis;

        public Pokemons()
        {
            _pokemons_disponiveis = new List<Pokemon>();

            _pokemons_disponiveis.Add(new Pokemon(1, "Bulbasaur", 45, 49, 49, 65, 65, 45, 318, 53m, 1, false, new int[] { }, new int[] { 2 }, types(Pokemon.Types.Grass, Pokemon.Types.Poison), false));
            _pokemons_disponiveis.Add(new Pokemon(002, "Ivysaur", 60, 62, 63, 80, 80, 60, 405, 67.5m, 1, false, new int[] { 1 }, new int[] { 3 }, types(Pokemon.Types.Grass, Pokemon.Types.Poison), false));
            _pokemons_disponiveis.Add(new Pokemon(003, "Venusaur", 80, 82, 83, 100, 100, 80, 525, 87.5m, 1, false, new int[] { 2 }, new int[] { 1003 }, types(Pokemon.Types.Grass, Pokemon.Types.Poison), false));

            _pokemons_disponiveis.Add(new Pokemon(004, "Charmander", 39, 52, 43, 60, 50, 65, 309, 51.5m, 1, false, false, types(Pokemon.Types.Fire)));
            _pokemons_disponiveis.Add(new Pokemon(005, "Charmeleon", 58, 64, 58, 80, 65, 80, 405, 67.5m, 1, false, false, types(Pokemon.Types.Fire)));
            _pokemons_disponiveis.Add(new Pokemon(006, "Charizard", 78, 84, 78, 109, 85, 100, 534, 89m, 1, false, true, types(Pokemon.Types.Fire, Pokemon.Types.Flying)));

            _pokemons_disponiveis.Add(new Pokemon(006, "Mega Charizard X", 78, 130, 111, 130, 85, 100, 634, 105.67m, 6, false, true, types(Pokemon.Types.Fire, Pokemon.Types.Dragon)));
            _pokemons_disponiveis.Add(new Pokemon(006, "Mega Charizard Y", 78, 104, 78, 159, 115, 100, 634, 105.67m, 6, false, true, types(Pokemon.Types.Fire, Pokemon.Types.Flying)));



            #region PRIMEIRA GERAÇÃO
            /*
            _pokemons_disponiveis.Add(new Pokemon(4, "Charmander", 39, 52, 43, 60, 50, 65, 309, false, 1, false, types(Pokemon.Types.Fire)));
            _pokemons_disponiveis.Add(new Pokemon(5, "Charmeleon", 58, 64, 58, 80, 65, 80, 405, false, 1, false, types(Pokemon.Types.Fire)));
            _pokemons_disponiveis.Add(new Pokemon(6, "Charizard", 78, 84, 78, 109, 85, 100, 534, false, 1, true, types(Pokemon.Types.Fire, Pokemon.Types.Flying)));
            _pokemons_disponiveis.Add(new Pokemon(7, "Squirtle", 44, 48, 65, 50, 64, 43, 314, false, 1, false, types(Pokemon.Types.Water)));
            _pokemons_disponiveis.Add(new Pokemon(8, "Wartortle", 59, 63, 80, 65, 80, 58, 405, false, 1, false, types(Pokemon.Types.Water)));
            _pokemons_disponiveis.Add(new Pokemon(9, "Blastoise", 79, 83, 100, 85, 105, 78, 530, false, 1, true, types(Pokemon.Types.Water)));
            _pokemons_disponiveis.Add(new Pokemon(10, "Caterpie", 45, 30, 35, 20, 20, 45, 195, false, 1, false, types(Pokemon.Types.Bug)));
            _pokemons_disponiveis.Add(new Pokemon(11, "Metapod", 50, 20, 55, 25, 25, 30, 205, false, 1, false, types(Pokemon.Types.Bug)));
            _pokemons_disponiveis.Add(new Pokemon(12, "Butterfree", 60, 45, 50, 80, 80, 70, 385, false, 1, true, types(Pokemon.Types.Bug, Pokemon.Types.Flying)));
            _pokemons_disponiveis.Add(new Pokemon(13, "Weedle", 40, 35, 30, 20, 20, 50, 195, false, 1, false, types(Pokemon.Types.Bug, Pokemon.Types.Poison)));
            _pokemons_disponiveis.Add(new Pokemon(14, "Kakuna", 45, 25, 50, 25, 25, 35, 205, false, 1, false, types(Pokemon.Types.Bug, Pokemon.Types.Poison)));
            _pokemons_disponiveis.Add(new Pokemon(15, "Beedrill", 65, 80, 40, 45, 80, 75, 385, false, 1, true, types(Pokemon.Types.Bug, Pokemon.Types.Poison)));
            _pokemons_disponiveis.Add(new Pokemon(16, "Pidgey", 40, 45, 40, 35, 35, 56, 251, false, 1, false, types(Pokemon.Types.Normal, Pokemon.Types.Flying)));
            _pokemons_disponiveis.Add(new Pokemon(17, "Pidgeotto", 63, 60, 55, 50, 50, 71, 349, false, 1, false, types(Pokemon.Types.Normal, Pokemon.Types.Flying)));
            _pokemons_disponiveis.Add(new Pokemon(18, "Pidgeot", 83, 80, 75, 70, 70, 91, 469, false, 1, true, types(Pokemon.Types.Normal, Pokemon.Types.Flying)));
            _pokemons_disponiveis.Add(new Pokemon(19, "Rattata", 30, 56, 35, 25, 35, 72, 253, false, 1, false, types(Pokemon.Types.Normal)));
            _pokemons_disponiveis.Add(new Pokemon(20, "Raticate", 55, 81, 60, 50, 70, 97, 413, false, 1, true, types(Pokemon.Types.Normal)));
            _pokemons_disponiveis.Add(new Pokemon(21, "Spearow", 40, 60, 30, 31, 31, 70, 262, false, 1, false, types(Pokemon.Types.Normal, Pokemon.Types.Flying)));
            _pokemons_disponiveis.Add(new Pokemon(22, "Fearow", 65, 90, 65, 61, 61, 100, 442, false, 1, true, types(Pokemon.Types.Normal, Pokemon.Types.Flying)));
            _pokemons_disponiveis.Add(new Pokemon(23, "Ekans", 35, 60, 44, 40, 54, 55, 288, false, 1, false, types(Pokemon.Types.Poison)));
            _pokemons_disponiveis.Add(new Pokemon(24, "Arbok", 60, 85, 69, 65, 79, 80, 438, false, 1, true, types(Pokemon.Types.Poison)));
            _pokemons_disponiveis.Add(new Pokemon(25, "Pikachu", 35, 55, 30, 50, 40, 90, 300, false, 1, false, types(Pokemon.Types.Electric)));
            _pokemons_disponiveis.Add(new Pokemon(26, "Raichu", 60, 90, 55, 90, 80, 100, 475, false, 1, true, types(Pokemon.Types.Electric)));
            _pokemons_disponiveis.Add(new Pokemon(27, "Sandshrew", 50, 75, 85, 20, 30, 40, 300, false, 1, false, types(Pokemon.Types.Ground)));
            _pokemons_disponiveis.Add(new Pokemon(28, "Sandslash", 75, 100, 110, 45, 55, 65, 450, false, 1, true, types(Pokemon.Types.Ground)));
            _pokemons_disponiveis.Add(new Pokemon(29, "Nidoran(F)", 55, 47, 52, 40, 40, 41, 275, false, 1, false, types(Pokemon.Types.Poison)));
            _pokemons_disponiveis.Add(new Pokemon(30, "Nidorina", 70, 62, 67, 55, 55, 56, 365, false, 1, false, types(Pokemon.Types.Poison)));
            _pokemons_disponiveis.Add(new Pokemon(31, "Nidoqueen", 90, 82, 87, 75, 85, 76, 495, false, 1, true, types(Pokemon.Types.Ground, Pokemon.Types.Poison)));
            _pokemons_disponiveis.Add(new Pokemon(32, "Nidoran(M)", 46, 57, 40, 40, 40, 50, 273, false, 1, false, types(Pokemon.Types.Poison)));
            _pokemons_disponiveis.Add(new Pokemon(33, "Nidorino", 61, 72, 57, 55, 55, 65, 365, false, 1, false, types(Pokemon.Types.Poison)));
            _pokemons_disponiveis.Add(new Pokemon(34, "Nidoking", 81, 92, 77, 85, 75, 85, 495, false, 1, true, types(Pokemon.Types.Ground, Pokemon.Types.Poison)));
            _pokemons_disponiveis.Add(new Pokemon(35, "Clefairy", 70, 45, 48, 60, 65, 35, 323, false, 1, false, types(Pokemon.Types.Normal)));
            _pokemons_disponiveis.Add(new Pokemon(36, "Clefable", 95, 70, 73, 85, 90, 60, 473, false, 1, true, types(Pokemon.Types.Normal)));
            _pokemons_disponiveis.Add(new Pokemon(37, "Vulpix", 38, 41, 40, 50, 65, 65, 299, false, 1, false, types(Pokemon.Types.Fire)));
            _pokemons_disponiveis.Add(new Pokemon(38, "Ninetales", 73, 76, 75, 81, 100, 100, 505, false, 1, true, types(Pokemon.Types.Fire)));
            _pokemons_disponiveis.Add(new Pokemon(39, "Jigglypuff", 115, 45, 20, 45, 25, 20, 270, false, 1, false, types(Pokemon.Types.Normal)));
            _pokemons_disponiveis.Add(new Pokemon(40, "Wigglytuff", 140, 70, 45, 75, 50, 45, 425, false, 1, true, types(Pokemon.Types.Normal)));
            _pokemons_disponiveis.Add(new Pokemon(41, "Zubat", 40, 45, 35, 30, 40, 55, 245, false, 1, false, types(Pokemon.Types.Poison, Pokemon.Types.Flying)));
            _pokemons_disponiveis.Add(new Pokemon(42, "Golbat", 75, 80, 70, 65, 75, 90, 455, false, 1, false, types(Pokemon.Types.Poison, Pokemon.Types.Flying)));
            _pokemons_disponiveis.Add(new Pokemon(43, "Oddish", 45, 50, 55, 75, 65, 30, 320, false, 1, false, types(Pokemon.Types.Poison, Pokemon.Types.Grass)));
            _pokemons_disponiveis.Add(new Pokemon(44, "Gloom", 60, 65, 70, 85, 75, 40, 395, false, 1, false, types(Pokemon.Types.Poison, Pokemon.Types.Grass)));
            _pokemons_disponiveis.Add(new Pokemon(45, "Vileplume", 75, 80, 85, 100, 90, 50, 480, false, 1, true, types(Pokemon.Types.Poison, Pokemon.Types.Grass)));
            _pokemons_disponiveis.Add(new Pokemon(46, "Paras", 35, 70, 55, 45, 55, 25, 285, false, 1, false, types(Pokemon.Types.Bug, Pokemon.Types.Grass)));
            _pokemons_disponiveis.Add(new Pokemon(47, "Parasect", 60, 95, 80, 60, 80, 30, 405, false, 1, true, types(Pokemon.Types.Bug, Pokemon.Types.Grass)));
            _pokemons_disponiveis.Add(new Pokemon(48, "Venonat", 60, 55, 50, 40, 55, 45, 305, false, 1, false, types(Pokemon.Types.Bug, Pokemon.Types.Poison)));
            _pokemons_disponiveis.Add(new Pokemon(49, "Venomoth", 70, 65, 60, 90, 75, 90, 450, false, 1, true, types(Pokemon.Types.Bug, Pokemon.Types.Poison)));
            _pokemons_disponiveis.Add(new Pokemon(50, "Diglett", 10, 55, 25, 35, 45, 95, 265, false, 1, false, types(Pokemon.Types.Ground)));
            _pokemons_disponiveis.Add(new Pokemon(51, "Dugtrio", 35, 80, 50, 50, 70, 120, 405, false, 1, true, types(Pokemon.Types.Ground)));
            _pokemons_disponiveis.Add(new Pokemon(52, "Meowth", 40, 45, 35, 40, 40, 90, 290, false, 1, false, types(Pokemon.Types.Normal)));
            _pokemons_disponiveis.Add(new Pokemon(53, "Persian", 65, 70, 60, 65, 65, 115, 440, false, 1, true, types(Pokemon.Types.Normal)));
            _pokemons_disponiveis.Add(new Pokemon(54, "Psyduck", 50, 52, 48, 65, 50, 55, 320, false, 1, false, types(Pokemon.Types.Water)));
            _pokemons_disponiveis.Add(new Pokemon(55, "Golduck", 80, 82, 78, 95, 80, 85, 500, false, 1, true, types(Pokemon.Types.Water)));
            _pokemons_disponiveis.Add(new Pokemon(56, "Mankey", 40, 80, 35, 35, 45, 70, 305, false, 1, false, types(Pokemon.Types.Fighting)));
            _pokemons_disponiveis.Add(new Pokemon(57, "Primeape", 65, 105, 60, 60, 70, 95, 455, false, 1, true, types(Pokemon.Types.Fighting)));
            _pokemons_disponiveis.Add(new Pokemon(58, "Growlithe", 55, 70, 45, 70, 50, 60, 350, false, 1, false, types(Pokemon.Types.Fire)));
            _pokemons_disponiveis.Add(new Pokemon(59, "Arcanine", 90, 110, 80, 100, 80, 95, 555, false, 1, true, types(Pokemon.Types.Fire)));
            _pokemons_disponiveis.Add(new Pokemon(60, "Poliwag", 40, 50, 40, 40, 40, 90, 300, false, 1, false, types(Pokemon.Types.Water)));
            _pokemons_disponiveis.Add(new Pokemon(61, "Poliwhirl", 65, 65, 65, 50, 50, 90, 385, false, 1, false, types(Pokemon.Types.Water)));
            _pokemons_disponiveis.Add(new Pokemon(62, "Poliwrath", 90, 85, 95, 70, 90, 70, 500, false, 1, true, types(Pokemon.Types.Water, Pokemon.Types.Fighting)));
            _pokemons_disponiveis.Add(new Pokemon(63, "Abra", 25, 20, 15, 105, 55, 90, 310, false, 1, false, types(Pokemon.Types.Psychic)));
            _pokemons_disponiveis.Add(new Pokemon(64, "Kadabra", 40, 35, 30, 120, 70, 105, 400, false, 1, false, types(Pokemon.Types.Psychic)));
            _pokemons_disponiveis.Add(new Pokemon(65, "Alakazam", 55, 50, 45, 135, 85, 120, 490, false, 1, true, types(Pokemon.Types.Psychic)));
            _pokemons_disponiveis.Add(new Pokemon(66, "Machop", 70, 80, 50, 35, 35, 35, 305, false, 1, false, types(Pokemon.Types.Fighting)));
            _pokemons_disponiveis.Add(new Pokemon(67, "Machoke", 80, 100, 70, 50, 60, 45, 405, false, 1, false, types(Pokemon.Types.Fighting)));
            _pokemons_disponiveis.Add(new Pokemon(68, "Machamp", 90, 130, 80, 65, 85, 55, 505, false, 1, true, types(Pokemon.Types.Fighting)));
            _pokemons_disponiveis.Add(new Pokemon(69, "Bellsprout", 50, 75, 35, 70, 30, 40, 300, false, 1, false, types(Pokemon.Types.Grass, Pokemon.Types.Poison)));
            _pokemons_disponiveis.Add(new Pokemon(70, "Weepinbell", 65, 90, 50, 85, 45, 55, 390, false, 1, false, types(Pokemon.Types.Grass, Pokemon.Types.Poison)));
            _pokemons_disponiveis.Add(new Pokemon(71, "Victreebel", 80, 105, 65, 100, 60, 70, 480, false, 1, true, types(Pokemon.Types.Grass, Pokemon.Types.Poison)));
            _pokemons_disponiveis.Add(new Pokemon(72, "Tentacool", 40, 40, 35, 50, 100, 70, 335, false, 1, false, types(Pokemon.Types.Water, Pokemon.Types.Poison)));
            _pokemons_disponiveis.Add(new Pokemon(73, "Tentacruel", 80, 70, 65, 80, 120, 100, 515, false, 1, true, types(Pokemon.Types.Water, Pokemon.Types.Poison)));
            _pokemons_disponiveis.Add(new Pokemon(74, "Geodude", 40, 80, 100, 30, 30, 20, 300, false, 1, false, types(Pokemon.Types.Rock, Pokemon.Types.Ground)));
            _pokemons_disponiveis.Add(new Pokemon(75, "Graveler", 55, 95, 115, 45, 45, 35, 390, false, 1, false, types(Pokemon.Types.Rock, Pokemon.Types.Ground)));
            _pokemons_disponiveis.Add(new Pokemon(76, "Golem", 80, 110, 130, 55, 65, 45, 485, false, 1, true, types(Pokemon.Types.Rock, Pokemon.Types.Ground)));
            _pokemons_disponiveis.Add(new Pokemon(77, "Ponyta", 50, 85, 55, 65, 65, 90, 410, false, 1, false, types(Pokemon.Types.Fire)));
            _pokemons_disponiveis.Add(new Pokemon(78, "Rapidash", 65, 100, 70, 80, 80, 105, 500, false, 1, true, types(Pokemon.Types.Fire)));
            _pokemons_disponiveis.Add(new Pokemon(79, "Slowpoke", 90, 65, 65, 40, 40, 15, 315, false, 1, false, types(Pokemon.Types.Water, Pokemon.Types.Psychic)));
            _pokemons_disponiveis.Add(new Pokemon(80, "Slowbro", 95, 75, 110, 100, 80, 30, 490, false, 1, true, types(Pokemon.Types.Water, Pokemon.Types.Psychic)));
            _pokemons_disponiveis.Add(new Pokemon(81, "Magnemite", 25, 35, 70, 95, 55, 45, 325, false, 1, false, types(Pokemon.Types.Electric, Pokemon.Types.Steel)));
            _pokemons_disponiveis.Add(new Pokemon(82, "Magneton", 50, 60, 95, 120, 70, 70, 465, false, 1, true, types(Pokemon.Types.Electric, Pokemon.Types.Steel)));
            _pokemons_disponiveis.Add(new Pokemon(83, "Farfetch'd", 52, 65, 55, 58, 62, 60, 352, false, 1, true, types(Pokemon.Types.Normal, Pokemon.Types.Flying)));
            _pokemons_disponiveis.Add(new Pokemon(84, "Doduo", 35, 85, 45, 35, 35, 75, 310, false, 1, false, types(Pokemon.Types.Normal, Pokemon.Types.Flying)));
            _pokemons_disponiveis.Add(new Pokemon(85, "Dodrio", 60, 110, 70, 60, 60, 100, 460, false, 1, true, types(Pokemon.Types.Normal, Pokemon.Types.Flying)));
            _pokemons_disponiveis.Add(new Pokemon(86, "Seel", 65, 45, 55, 45, 70, 45, 325, false, 1, false, types(Pokemon.Types.Water)));
            _pokemons_disponiveis.Add(new Pokemon(87, "Dewgong", 90, 70, 80, 70, 95, 70, 475, false, 1, true, types(Pokemon.Types.Water, Pokemon.Types.Ice)));
            _pokemons_disponiveis.Add(new Pokemon(88, "Grimer", 80, 80, 50, 40, 50, 25, 325, false, 1, false, types(Pokemon.Types.Poison)));
            _pokemons_disponiveis.Add(new Pokemon(89, "Muk", 105, 105, 75, 65, 100, 50, 500, false, 1, true, types(Pokemon.Types.Poison)));
            _pokemons_disponiveis.Add(new Pokemon(90, "Shellder", 30, 65, 100, 45, 25, 40, 305, false, 1, false, types(Pokemon.Types.Water)));
            _pokemons_disponiveis.Add(new Pokemon(91, "Cloyster", 50, 95, 180, 85, 45, 70, 525, false, 1, true, types(Pokemon.Types.Water, Pokemon.Types.Ice)));
            _pokemons_disponiveis.Add(new Pokemon(92, "Gastly", 30, 35, 30, 100, 35, 80, 310, false, 1, false, types(Pokemon.Types.Ghost, Pokemon.Types.Poison)));
            _pokemons_disponiveis.Add(new Pokemon(93, "Haunter", 45, 50, 45, 115, 55, 95, 405, false, 1, false, types(Pokemon.Types.Ghost, Pokemon.Types.Poison)));
            _pokemons_disponiveis.Add(new Pokemon(94, "Gengar", 60, 65, 60, 130, 75, 110, 500, false, 1, true, types(Pokemon.Types.Ghost, Pokemon.Types.Poison)));
            _pokemons_disponiveis.Add(new Pokemon(95, "Onix", 35, 45, 160, 30, 45, 70, 385, false, 1, false, types(Pokemon.Types.Rock, Pokemon.Types.Ground)));
            _pokemons_disponiveis.Add(new Pokemon(96, "Drowzee", 60, 48, 45, 43, 90, 42, 328, false, 1, false, types(Pokemon.Types.Psychic)));
            _pokemons_disponiveis.Add(new Pokemon(97, "Hypno", 85, 73, 70, 73, 115, 67, 483, false, 1, true, types(Pokemon.Types.Psychic)));
            _pokemons_disponiveis.Add(new Pokemon(98, "Krabby", 30, 105, 90, 25, 25, 50, 325, false, 1, false, types(Pokemon.Types.Water)));
            _pokemons_disponiveis.Add(new Pokemon(99, "Kingler", 55, 130, 115, 50, 50, 75, 475, false, 1, true, types(Pokemon.Types.Water)));
            _pokemons_disponiveis.Add(new Pokemon(100, "Voltorb", 40, 30, 50, 55, 55, 100, 330, false, 1, false, types(Pokemon.Types.Electric)));
            _pokemons_disponiveis.Add(new Pokemon(101, "Electrode", 60, 50, 70, 80, 80, 140, 480, false, 1, true, types(Pokemon.Types.Electric)));
            _pokemons_disponiveis.Add(new Pokemon(102, "Exeggcute", 60, 40, 80, 60, 45, 40, 325, false, 1, false, types(Pokemon.Types.Grass, Pokemon.Types.Psychic)));
            _pokemons_disponiveis.Add(new Pokemon(103, "Exeggutor", 95, 95, 85, 125, 65, 55, 520, false, 1, true, types(Pokemon.Types.Grass, Pokemon.Types.Psychic)));
            _pokemons_disponiveis.Add(new Pokemon(104, "Cubone", 50, 50, 95, 40, 50, 35, 320, false, 1, false, types(Pokemon.Types.Ground)));
            _pokemons_disponiveis.Add(new Pokemon(105, "Marowak", 60, 80, 110, 50, 80, 45, 425, false, 1, true, types(Pokemon.Types.Ground)));
            _pokemons_disponiveis.Add(new Pokemon(106, "Hitmonlee", 50, 120, 53, 35, 110, 87, 455, false, 1, true, types(Pokemon.Types.Fighting)));
            _pokemons_disponiveis.Add(new Pokemon(107, "Hitmonchan", 50, 105, 79, 35, 110, 76, 455, false, 1, true, types(Pokemon.Types.Fighting)));
            _pokemons_disponiveis.Add(new Pokemon(108, "Lickitung", 90, 55, 75, 60, 75, 30, 385, false, 1, true, types(Pokemon.Types.Normal)));
            _pokemons_disponiveis.Add(new Pokemon(109, "Koffing", 40, 65, 95, 60, 45, 35, 340, false, 1, false, types(Pokemon.Types.Poison)));
            _pokemons_disponiveis.Add(new Pokemon(110, "Weezing", 65, 90, 120, 85, 70, 60, 490, false, 1, true, types(Pokemon.Types.Poison)));
            _pokemons_disponiveis.Add(new Pokemon(111, "Rhyhorn", 80, 85, 95, 30, 30, 25, 345, false, 1, false, types(Pokemon.Types.Rock, Pokemon.Types.Ground)));
            _pokemons_disponiveis.Add(new Pokemon(112, "Rhydon", 105, 130, 120, 45, 45, 40, 485, false, 1, true, types(Pokemon.Types.Rock, Pokemon.Types.Ground)));
            _pokemons_disponiveis.Add(new Pokemon(113, "Chansey", 250, 5, 5, 35, 105, 50, 450, false, 1, false, types(Pokemon.Types.Normal)));
            _pokemons_disponiveis.Add(new Pokemon(114, "Tangela", 65, 55, 115, 100, 40, 60, 435, false, 1, true, types(Pokemon.Types.Grass)));
            _pokemons_disponiveis.Add(new Pokemon(115, "Kangaskhan", 105, 95, 80, 40, 80, 90, 490, false, 1, true, types(Pokemon.Types.Normal)));
            _pokemons_disponiveis.Add(new Pokemon(116, "Horsea", 30, 40, 70, 70, 25, 60, 295, false, 1, false, types(Pokemon.Types.Water)));
            _pokemons_disponiveis.Add(new Pokemon(117, "Seadra", 55, 65, 95, 95, 45, 85, 440, false, 1, false, types(Pokemon.Types.Water)));
            _pokemons_disponiveis.Add(new Pokemon(118, "Goldeen", 45, 67, 60, 35, 50, 63, 320, false, 1, false, types(Pokemon.Types.Water)));
            _pokemons_disponiveis.Add(new Pokemon(119, "Seaking", 80, 92, 65, 65, 80, 68, 450, false, 1, true, types(Pokemon.Types.Water)));
            _pokemons_disponiveis.Add(new Pokemon(120, "Staryu", 30, 45, 55, 70, 55, 85, 340, false, 1, false, types(Pokemon.Types.Water)));
            _pokemons_disponiveis.Add(new Pokemon(121, "Starmie", 60, 75, 85, 100, 85, 115, 520, false, 1, true, types(Pokemon.Types.Water, Pokemon.Types.Psychic)));
            _pokemons_disponiveis.Add(new Pokemon(122, "Mr. Mime", 40, 45, 65, 100, 120, 90, 460, false, 1, true, types(Pokemon.Types.Psychic)));
            _pokemons_disponiveis.Add(new Pokemon(123, "Scyther", 70, 110, 80, 55, 80, 105, 500, false, 1, false, types(Pokemon.Types.Bug, Pokemon.Types.Flying)));
            _pokemons_disponiveis.Add(new Pokemon(124, "Jynx", 65, 50, 35, 115, 95, 95, 455, false, 1, true, types(Pokemon.Types.Psychic, Pokemon.Types.Ice)));
            _pokemons_disponiveis.Add(new Pokemon(125, "Electabuzz", 65, 83, 57, 95, 85, 105, 490, false, 1, true, types(Pokemon.Types.Electric)));
            _pokemons_disponiveis.Add(new Pokemon(126, "Magmar", 65, 95, 57, 100, 85, 93, 495, false, 1, true, types(Pokemon.Types.Fire)));
            _pokemons_disponiveis.Add(new Pokemon(127, "Pinsir", 65, 125, 100, 55, 70, 85, 500, false, 1, true, types(Pokemon.Types.Bug)));
            _pokemons_disponiveis.Add(new Pokemon(128, "Tauros", 75, 100, 95, 40, 70, 110, 490, false, 1, true, types(Pokemon.Types.Normal)));
            _pokemons_disponiveis.Add(new Pokemon(129, "Magikarp", 20, 10, 55, 15, 20, 80, 200, false, 1, false, types(Pokemon.Types.Water)));
            _pokemons_disponiveis.Add(new Pokemon(130, "Gyarados", 95, 125, 79, 60, 100, 81, 540, false, 1, true, types(Pokemon.Types.Water, Pokemon.Types.Flying)));
            _pokemons_disponiveis.Add(new Pokemon(131, "Lapras", 130, 85, 80, 85, 95, 60, 535, false, 1, true, types(Pokemon.Types.Water, Pokemon.Types.Ice)));
            _pokemons_disponiveis.Add(new Pokemon(132, "Ditto", 48, 48, 48, 48, 48, 48, 288, false, 1, true, types(Pokemon.Types.Normal)));
            _pokemons_disponiveis.Add(new Pokemon(133, "Eevee", 55, 55, 50, 45, 65, 55, 325, false, 1, false, types(Pokemon.Types.Normal)));
            _pokemons_disponiveis.Add(new Pokemon(134, "Vaporeon", 130, 65, 60, 110, 95, 65, 525, false, 1, true, types(Pokemon.Types.Water)));
            _pokemons_disponiveis.Add(new Pokemon(135, "Jolteon", 65, 65, 60, 110, 95, 130, 525, false, 1, true, types(Pokemon.Types.Electric)));
            _pokemons_disponiveis.Add(new Pokemon(136, "Flareon", 65, 130, 60, 95, 110, 65, 525, false, 1, true, types(Pokemon.Types.Fire)));
            _pokemons_disponiveis.Add(new Pokemon(137, "Porygon", 65, 60, 70, 85, 75, 40, 395, false, 1, false, types(Pokemon.Types.Normal)));
            _pokemons_disponiveis.Add(new Pokemon(138, "Omanyte", 35, 40, 100, 90, 55, 35, 355, false, 1, false, types(Pokemon.Types.Rock, Pokemon.Types.Water)));
            _pokemons_disponiveis.Add(new Pokemon(139, "Omastar", 70, 60, 125, 115, 70, 55, 495, false, 1, true, types(Pokemon.Types.Rock, Pokemon.Types.Water)));
            _pokemons_disponiveis.Add(new Pokemon(140, "Kabuto", 30, 80, 90, 55, 45, 55, 355, false, 1, false, types(Pokemon.Types.Rock, Pokemon.Types.Water)));
            _pokemons_disponiveis.Add(new Pokemon(141, "Kabutops", 60, 115, 105, 65, 70, 80, 495, false, 1, true, types(Pokemon.Types.Rock, Pokemon.Types.Water)));
            _pokemons_disponiveis.Add(new Pokemon(142, "Aerodactyl", 80, 105, 65, 60, 75, 130, 515, false, 1, true, types(Pokemon.Types.Rock, Pokemon.Types.Flying)));
            _pokemons_disponiveis.Add(new Pokemon(143, "Snorlax", 160, 110, 65, 65, 110, 30, 540, false, 1, true, types(Pokemon.Types.Normal)));
            _pokemons_disponiveis.Add(new Pokemon(144, "Articuno", 90, 85, 100, 95, 125, 85, 580, true, 1, true, types(Pokemon.Types.Ice, Pokemon.Types.Flying)));
            _pokemons_disponiveis.Add(new Pokemon(145, "Zapdos", 90, 90, 85, 125, 90, 100, 580, true, 1, true, types(Pokemon.Types.Electric, Pokemon.Types.Flying)));
            _pokemons_disponiveis.Add(new Pokemon(146, "Moltres", 90, 100, 90, 125, 85, 90, 580, true, 1, true, types(Pokemon.Types.Fire, Pokemon.Types.Flying)));
            _pokemons_disponiveis.Add(new Pokemon(147, "Dratini", 41, 64, 45, 50, 50, 50, 300, false, 1, false, types(Pokemon.Types.Dragon)));
            _pokemons_disponiveis.Add(new Pokemon(148, "Dragonair", 61, 84, 65, 70, 70, 70, 420, false, 1, false, types(Pokemon.Types.Dragon)));
            _pokemons_disponiveis.Add(new Pokemon(149, "Dragonite", 91, 134, 95, 100, 100, 80, 600, false, 1, true, types(Pokemon.Types.Dragon, Pokemon.Types.Flying)));
            _pokemons_disponiveis.Add(new Pokemon(150, "Mewtwo", 106, 110, 90, 154, 90, 130, 680, true, 1, true, types(Pokemon.Types.Psychic)));
            _pokemons_disponiveis.Add(new Pokemon(151, "Mew", 100, 100, 100, 100, 100, 100, 600, true, 1, true, types(Pokemon.Types.Psychic)));
            */
            #endregion

            #region SEGUNDA GERAÇÃO
            /*
            _pokemons_disponiveis.Add(new Pokemon(152, "Chikorita", 45, 49, 65, 49, 65, 45, 318, false, 2, false, types(Pokemon.Types.Grass)));
            _pokemons_disponiveis.Add(new Pokemon(153, "Bayleef", 60, 62, 80, 63, 80, 60, 405, false, 2, false, types(Pokemon.Types.Grass)));
            _pokemons_disponiveis.Add(new Pokemon(154, "Meganium", 80, 82, 100, 83, 100, 80, 525, false, 2, true, types(Pokemon.Types.Grass)));
            
            _pokemons_disponiveis.Add(new Pokemon(158, "Totodile", 50, 65, 64, 44, 48, 43, 314, false, 2, false, types(Pokemon.Types.Water)));
            _pokemons_disponiveis.Add(new Pokemon(159, "Croconaw", 65, 80, 80, 59, 63, 58, 405, false, 2, false, types(Pokemon.Types.Water)));
            _pokemons_disponiveis.Add(new Pokemon(160, "Feraligatr", 85, 105, 100, 79, 83, 78, 530, false, 2, true, types(Pokemon.Types.Water)));
            _pokemons_disponiveis.Add(new Pokemon(161, "Sentret", 35, 46, 34, 35, 45, 20, 215, false, 2, false, types(Pokemon.Types.Normal)));
            _pokemons_disponiveis.Add(new Pokemon(162, "Furret", 85, 76, 64, 45, 55, 90, 415, false, 2, true, types(Pokemon.Types.Normal)));
            _pokemons_disponiveis.Add(new Pokemon(163, "Hoothoot", 60, 30, 30, 36, 56, 50, 262, false, 2, false, types(Pokemon.Types.Normal, Pokemon.Types.Flying)));
            _pokemons_disponiveis.Add(new Pokemon(164, "Noctowl", 100, 50, 50, 76, 96, 70, 442, false, 2, true, types(Pokemon.Types.Normal, Pokemon.Types.Flying)));
            _pokemons_disponiveis.Add(new Pokemon(165, "Ledyba", 40, 20, 30, 40, 80, 55, 265, false, 2, false, types(Pokemon.Types.Bug, Pokemon.Types.Flying)));
            _pokemons_disponiveis.Add(new Pokemon(166, "Ledian", 55, 35, 50, 55, 110, 85, 390, false, 2, true, types(Pokemon.Types.Bug, Pokemon.Types.Flying)));
            _pokemons_disponiveis.Add(new Pokemon(167, "Spinarak", 40, 60, 40, 40, 40, 30, 250, false, 2, false, types(Pokemon.Types.Bug, Pokemon.Types.Poison)));
            _pokemons_disponiveis.Add(new Pokemon(168, "Ariados", 70, 90, 70, 60, 60, 40, 390, false, 2, true, types(Pokemon.Types.Bug, Pokemon.Types.Poison)));
            _pokemons_disponiveis.Add(new Pokemon(169, "Crobat", 85, 90, 80, 70, 80, 130, 535, false, 2, true, types(Pokemon.Types.Poison, Pokemon.Types.Flying)));
            _pokemons_disponiveis.Add(new Pokemon(170, "Chinchou", 75, 38, 38, 56, 56, 67, 330, false, 2, false, types(Pokemon.Types.Water, Pokemon.Types.Electric)));
            _pokemons_disponiveis.Add(new Pokemon(171, "Lanturn", 125, 58, 58, 76, 76, 67, 460, false, 2, true, types(Pokemon.Types.Water, Pokemon.Types.Electric)));
            _pokemons_disponiveis.Add(new Pokemon(172, "Pichu", 20, 40, 15, 35, 35, 60, 205, false, 2, false, types(Pokemon.Types.Electric)));
            _pokemons_disponiveis.Add(new Pokemon(173, "Cleffa", 50, 25, 28, 45, 55, 15, 218, false, 2, false, types(Pokemon.Types.Normal)));
            _pokemons_disponiveis.Add(new Pokemon(174, "Igglybuff", 90, 30, 15, 40, 20, 15, 210, false, 2, false, types(Pokemon.Types.Normal)));
            _pokemons_disponiveis.Add(new Pokemon(175, "Togepi", 35, 20, 65, 40, 65, 20, 245, false, 2, false, types(Pokemon.Types.Normal)));
            _pokemons_disponiveis.Add(new Pokemon(176, "Togetic", 55, 40, 85, 80, 105, 40, 405, false, 2, true, types(Pokemon.Types.Normal, Pokemon.Types.Flying)));
            _pokemons_disponiveis.Add(new Pokemon(177, "Natu", 40, 50, 45, 70, 45, 70, 320, false, 2, false, types(Pokemon.Types.Psychic, Pokemon.Types.Flying)));
            _pokemons_disponiveis.Add(new Pokemon(178, "Xatu", 65, 75, 70, 95, 70, 95, 470, false, 2, true, types(Pokemon.Types.Psychic, Pokemon.Types.Flying)));
            _pokemons_disponiveis.Add(new Pokemon(179, "Mareep", 55, 40, 40, 65, 45, 35, 280, false, 2, false, types(Pokemon.Types.Electric)));
            _pokemons_disponiveis.Add(new Pokemon(180, "Flaaffy", 70, 55, 55, 80, 60, 45, 365, false, 2, false, types(Pokemon.Types.Electric)));
            _pokemons_disponiveis.Add(new Pokemon(181, "Ampharos", 90, 75, 75, 115, 90, 55, 500, false, 2, true, types(Pokemon.Types.Electric)));
            _pokemons_disponiveis.Add(new Pokemon(182, "Bellossom", 75, 80, 85, 90, 100, 50, 480, false, 2, true, types(Pokemon.Types.Grass)));
            _pokemons_disponiveis.Add(new Pokemon(183, "Marill", 70, 20, 50, 20, 50, 40, 250, false, 2, false, types(Pokemon.Types.Water)));
            _pokemons_disponiveis.Add(new Pokemon(184, "Azumarill", 100, 50, 80, 50, 80, 50, 410, false, 2, true, types(Pokemon.Types.Water)));
            _pokemons_disponiveis.Add(new Pokemon(185, "Sudowoodo", 70, 100, 115, 30, 65, 30, 410, false, 2, true, types(Pokemon.Types.Rock)));
            _pokemons_disponiveis.Add(new Pokemon(186, "Politoed", 90, 75, 75, 90, 100, 70, 500, false, 2, true, types(Pokemon.Types.Water)));
            _pokemons_disponiveis.Add(new Pokemon(187, "Hoppip", 35, 35, 40, 35, 55, 50, 250, false, 2, false, types(Pokemon.Types.Grass, Pokemon.Types.Flying)));
            _pokemons_disponiveis.Add(new Pokemon(188, "Skiploom", 55, 45, 50, 45, 65, 80, 340, false, 2, false, types(Pokemon.Types.Grass, Pokemon.Types.Flying)));
            _pokemons_disponiveis.Add(new Pokemon(189, "Jumpluff", 75, 55, 70, 55, 85, 110, 450, false, 2, true, types(Pokemon.Types.Grass, Pokemon.Types.Flying)));
            _pokemons_disponiveis.Add(new Pokemon(190, "Aipom", 55, 70, 55, 40, 55, 85, 360, false, 2, true, types(Pokemon.Types.Normal)));
            _pokemons_disponiveis.Add(new Pokemon(191, "Sunkern", 30, 30, 30, 30, 30, 30, 180, false, 2, false, types(Pokemon.Types.Grass)));
            _pokemons_disponiveis.Add(new Pokemon(192, "Sunflora", 75, 75, 55, 105, 85, 30, 425, false, 2, true, types(Pokemon.Types.Grass)));
            _pokemons_disponiveis.Add(new Pokemon(193, "Yanma", 65, 65, 45, 75, 45, 95, 390, false, 2, true, types(Pokemon.Types.Bug, Pokemon.Types.Flying)));
            _pokemons_disponiveis.Add(new Pokemon(194, "Wooper", 55, 45, 45, 25, 25, 15, 210, false, 2, false, types(Pokemon.Types.Water, Pokemon.Types.Ground)));
            _pokemons_disponiveis.Add(new Pokemon(195, "Quagsire", 95, 85, 85, 65, 65, 35, 430, false, 2, true, types(Pokemon.Types.Water, Pokemon.Types.Ground)));
            _pokemons_disponiveis.Add(new Pokemon(196, "Espeon", 65, 65, 60, 130, 95, 110, 525, false, 2, true, types(Pokemon.Types.Psychic)));
            _pokemons_disponiveis.Add(new Pokemon(197, "Umbreon", 95, 65, 110, 60, 130, 65, 525, false, 2, true, types(Pokemon.Types.Dark)));
            _pokemons_disponiveis.Add(new Pokemon(198, "Murkrow", 60, 85, 42, 85, 42, 91, 405, false, 2, true, types(Pokemon.Types.Dark, Pokemon.Types.Flying)));
            _pokemons_disponiveis.Add(new Pokemon(199, "Slowking", 95, 75, 80, 100, 110, 30, 490, false, 2, true, types(Pokemon.Types.Water, Pokemon.Types.Psychic)));
            _pokemons_disponiveis.Add(new Pokemon(200, "Misdreavus", 60, 60, 60, 85, 85, 85, 435, false, 2, true, types(Pokemon.Types.Ghost)));
            _pokemons_disponiveis.Add(new Pokemon(201, "Unown", 48, 72, 48, 72, 48, 48, 336, false, 2, true, types(Pokemon.Types.Psychic)));
            _pokemons_disponiveis.Add(new Pokemon(202, "Wobbuffet", 190, 33, 58, 33, 58, 33, 405, false, 2, true, types(Pokemon.Types.Psychic)));
            _pokemons_disponiveis.Add(new Pokemon(203, "Girafarig", 70, 80, 65, 90, 65, 85, 455, false, 2, true, types(Pokemon.Types.Normal, Pokemon.Types.Psychic)));
            _pokemons_disponiveis.Add(new Pokemon(204, "Pineco", 50, 65, 90, 35, 35, 15, 290, false, 2, false, types(Pokemon.Types.Bug)));
            _pokemons_disponiveis.Add(new Pokemon(205, "Forretress", 75, 90, 140, 60, 60, 40, 465, false, 2, true, types(Pokemon.Types.Bug, Pokemon.Types.Steel)));
            _pokemons_disponiveis.Add(new Pokemon(206, "Dunsparce", 100, 70, 70, 65, 65, 45, 415, false, 2, true, types(Pokemon.Types.Normal)));
            _pokemons_disponiveis.Add(new Pokemon(207, "Gligar", 65, 75, 105, 35, 65, 85, 430, false, 2, true, types(Pokemon.Types.Ground, Pokemon.Types.Flying)));
            _pokemons_disponiveis.Add(new Pokemon(208, "Steelix", 75, 85, 200, 55, 65, 30, 510, false, 2, true, types(Pokemon.Types.Steel, Pokemon.Types.Ground)));
            _pokemons_disponiveis.Add(new Pokemon(209, "Snubbull", 60, 80, 50, 40, 40, 30, 300, false, 2, false, types(Pokemon.Types.Normal)));
            _pokemons_disponiveis.Add(new Pokemon(210, "Granbull", 90, 120, 75, 60, 60, 45, 450, false, 2, true, types(Pokemon.Types.Normal)));
            _pokemons_disponiveis.Add(new Pokemon(211, "Qwilfish", 65, 95, 75, 55, 55, 85, 430, false, 2, true, types(Pokemon.Types.Water, Pokemon.Types.Poison)));
            _pokemons_disponiveis.Add(new Pokemon(212, "Scizor", 70, 130, 100, 55, 80, 65, 500, false, 2, true, types(Pokemon.Types.Bug, Pokemon.Types.Steel)));
            _pokemons_disponiveis.Add(new Pokemon(213, "Shuckle", 20, 10, 230, 10, 230, 5, 505, false, 2, true, types(Pokemon.Types.Bug, Pokemon.Types.Rock)));
            _pokemons_disponiveis.Add(new Pokemon(214, "Heracross", 80, 125, 75, 40, 95, 85, 500, false, 2, true, types(Pokemon.Types.Bug, Pokemon.Types.Fighting)));
            _pokemons_disponiveis.Add(new Pokemon(215, "Sneasel", 55, 95, 55, 35, 75, 115, 430, false, 2, true, types(Pokemon.Types.Dark, Pokemon.Types.Ice)));
            _pokemons_disponiveis.Add(new Pokemon(216, "Teddiursa", 60, 80, 50, 50, 50, 40, 330, false, 2, false, types(Pokemon.Types.Normal)));
            _pokemons_disponiveis.Add(new Pokemon(217, "Ursaring", 90, 130, 75, 75, 75, 55, 500, false, 2, true, types(Pokemon.Types.Normal)));
            _pokemons_disponiveis.Add(new Pokemon(218, "Slugma", 40, 40, 40, 70, 40, 20, 250, false, 2, false, types(Pokemon.Types.Fire)));
            _pokemons_disponiveis.Add(new Pokemon(219, "Magcargo", 50, 50, 120, 80, 80, 30, 410, false, 2, true, types(Pokemon.Types.Fire, Pokemon.Types.Ground)));
            _pokemons_disponiveis.Add(new Pokemon(220, "Swinub", 50, 50, 40, 30, 30, 50, 250, false, 2, false, types(Pokemon.Types.Ice, Pokemon.Types.Ground)));
            _pokemons_disponiveis.Add(new Pokemon(221, "Piloswine", 100, 100, 80, 60, 60, 50, 450, false, 2, true, types(Pokemon.Types.Ice, Pokemon.Types.Ground)));
            _pokemons_disponiveis.Add(new Pokemon(222, "Corsola", 55, 55, 85, 65, 85, 35, 380, false, 2, true, types(Pokemon.Types.Water, Pokemon.Types.Rock)));
            _pokemons_disponiveis.Add(new Pokemon(223, "Remoraid", 35, 65, 35, 65, 35, 65, 300, false, 2, false, types(Pokemon.Types.Water)));
            _pokemons_disponiveis.Add(new Pokemon(224, "Octillery", 75, 105, 75, 105, 75, 45, 480, false, 2, true, types(Pokemon.Types.Water)));
            _pokemons_disponiveis.Add(new Pokemon(225, "Delibird", 45, 55, 45, 65, 45, 75, 330, false, 2, true, types(Pokemon.Types.Ice, Pokemon.Types.Flying)));
            _pokemons_disponiveis.Add(new Pokemon(226, "Mantine", 65, 40, 70, 80, 140, 70, 465, false, 2, true, types(Pokemon.Types.Water, Pokemon.Types.Flying)));
            _pokemons_disponiveis.Add(new Pokemon(227, "Skarmory", 65, 80, 140, 40, 70, 70, 465, false, 2, true, types(Pokemon.Types.Steel, Pokemon.Types.Flying)));
            _pokemons_disponiveis.Add(new Pokemon(228, "Houndour", 45, 60, 30, 80, 50, 65, 330, false, 2, false, types(Pokemon.Types.Dark, Pokemon.Types.Fire)));
            _pokemons_disponiveis.Add(new Pokemon(229, "Houndoom", 75, 90, 50, 110, 80, 95, 500, false, 2, true, types(Pokemon.Types.Dark, Pokemon.Types.Fire)));
            _pokemons_disponiveis.Add(new Pokemon(230, "Kingdra", 75, 95, 95, 95, 95, 85, 540, false, 2, true, types(Pokemon.Types.Water, Pokemon.Types.Dragon)));
            _pokemons_disponiveis.Add(new Pokemon(231, "Phanpy", 90, 60, 60, 40, 40, 40, 330, false, 2, false, types(Pokemon.Types.Ground)));
            _pokemons_disponiveis.Add(new Pokemon(232, "Donphan", 90, 120, 120, 60, 60, 50, 500, false, 2, true, types(Pokemon.Types.Ground)));
            _pokemons_disponiveis.Add(new Pokemon(233, "Porygon2", 85, 80, 90, 105, 95, 60, 515, false, 2, true, types(Pokemon.Types.Normal)));
            _pokemons_disponiveis.Add(new Pokemon(234, "Stantler", 73, 95, 62, 85, 65, 85, 465, false, 2, true, types(Pokemon.Types.Normal)));
            _pokemons_disponiveis.Add(new Pokemon(235, "Smeargle", 55, 20, 35, 20, 45, 75, 250, false, 2, true, types(Pokemon.Types.Normal)));
            _pokemons_disponiveis.Add(new Pokemon(236, "Tyrogue", 35, 35, 35, 35, 35, 35, 210, false, 2, false, types(Pokemon.Types.Fighting)));
            _pokemons_disponiveis.Add(new Pokemon(237, "Hitmontop", 50, 95, 95, 35, 110, 70, 455, false, 2, true, types(Pokemon.Types.Fighting)));
            _pokemons_disponiveis.Add(new Pokemon(238, "Smoochum", 45, 30, 15, 85, 65, 65, 305, false, 2, false, types(Pokemon.Types.Ice, Pokemon.Types.Psychic)));
            _pokemons_disponiveis.Add(new Pokemon(239, "Elekid", 45, 63, 37, 65, 55, 95, 360, false, 2, false, types(Pokemon.Types.Electric)));
            _pokemons_disponiveis.Add(new Pokemon(240, "Magby", 45, 75, 37, 70, 55, 83, 365, false, 2, false, types(Pokemon.Types.Fire)));
            _pokemons_disponiveis.Add(new Pokemon(241, "Miltank", 95, 80, 105, 40, 70, 100, 490, false, 2, true, types(Pokemon.Types.Normal)));
            _pokemons_disponiveis.Add(new Pokemon(242, "Blissey", 255, 10, 10, 75, 135, 55, 540, false, 2, true, types(Pokemon.Types.Normal)));
            _pokemons_disponiveis.Add(new Pokemon(243, "Raikou", 90, 85, 75, 115, 100, 115, 580, true, 2, true, types(Pokemon.Types.Electric)));
            _pokemons_disponiveis.Add(new Pokemon(244, "Entei", 115, 115, 85, 90, 75, 100, 580, true, 2, true, types(Pokemon.Types.Fire)));
            _pokemons_disponiveis.Add(new Pokemon(245, "Suicune", 100, 75, 115, 90, 115, 85, 580, true, 2, true, types(Pokemon.Types.Water)));
            _pokemons_disponiveis.Add(new Pokemon(246, "Larvitar", 50, 64, 50, 45, 50, 41, 300, false, 2, false, types(Pokemon.Types.Rock, Pokemon.Types.Ground)));
            _pokemons_disponiveis.Add(new Pokemon(247, "Pupitar", 70, 84, 70, 65, 70, 51, 410, false, 2, false, types(Pokemon.Types.Rock, Pokemon.Types.Ground)));
            _pokemons_disponiveis.Add(new Pokemon(248, "Tyranitar", 100, 134, 110, 95, 100, 61, 600, false, 2, true, types(Pokemon.Types.Rock, Pokemon.Types.Dark)));
            _pokemons_disponiveis.Add(new Pokemon(249, "Lugia", 106, 90, 130, 90, 154, 110, 680, true, 2, true, types(Pokemon.Types.Psychic, Pokemon.Types.Flying)));
            _pokemons_disponiveis.Add(new Pokemon(250, "Ho-Oh", 106, 130, 90, 110, 154, 90, 680, true, 2, true, types(Pokemon.Types.Fire, Pokemon.Types.Flying)));
            _pokemons_disponiveis.Add(new Pokemon(251, "Celebi", 100, 100, 100, 100, 100, 100, 600, true, 2, true, types(Pokemon.Types.Psychic, Pokemon.Types.Grass)));
            */
            #endregion

            #region TERCEIRA GERAÇÃO
            /*
            _pokemons_disponiveis.Add(new Pokemon(252, "Treecko", 40, 45, 35, 65, 55, 70, 310, false, 3, false, types(Pokemon.Types.Grass)));
            _pokemons_disponiveis.Add(new Pokemon(253, "Grovyle", 50, 65, 45, 85, 65, 95, 405, false, 3, false, types(Pokemon.Types.Grass)));
            _pokemons_disponiveis.Add(new Pokemon(254, "Sceptile", 70, 85, 65, 105, 85, 120, 530, false, 3, true, types(Pokemon.Types.Grass)));
            _pokemons_disponiveis.Add(new Pokemon(255, "Torchic", 45, 60, 40, 70, 50, 45, 310, false, 3, false, types(Pokemon.Types.Fire)));
            _pokemons_disponiveis.Add(new Pokemon(256, "Combusken", 60, 85, 60, 85, 60, 55, 405, false, 3, false, types(Pokemon.Types.Fire, Pokemon.Types.Fighting)));
            _pokemons_disponiveis.Add(new Pokemon(257, "Blaziken", 80, 120, 70, 110, 70, 80, 530, false, 3, true, types(Pokemon.Types.Fire, Pokemon.Types.Fighting)));
            _pokemons_disponiveis.Add(new Pokemon(258, "Mudkip", 50, 70, 50, 50, 50, 40, 310, false, 3, false, types(Pokemon.Types.Water)));
            _pokemons_disponiveis.Add(new Pokemon(259, "Marshtomp", 70, 85, 70, 60, 70, 50, 405, false, 3, false, types(Pokemon.Types.Water, Pokemon.Types.Ground)));
            _pokemons_disponiveis.Add(new Pokemon(260, "Swampert", 100, 110, 90, 85, 90, 60, 535, false, 3, true, types(Pokemon.Types.Water, Pokemon.Types.Ground)));
            _pokemons_disponiveis.Add(new Pokemon(261, "Poochyena", 35, 55, 35, 30, 30, 35, 220, false, 3, false, types(Pokemon.Types.Dark)));
            _pokemons_disponiveis.Add(new Pokemon(262, "Mightyena", 70, 90, 70, 60, 60, 70, 420, false, 3, true, types(Pokemon.Types.Dark)));
            _pokemons_disponiveis.Add(new Pokemon(263, "Zigzagoon", 38, 30, 41, 30, 41, 60, 240, false, 3, false, types(Pokemon.Types.Normal)));
            _pokemons_disponiveis.Add(new Pokemon(264, "Linoone", 78, 70, 61, 50, 61, 100, 420, false, 3, true, types(Pokemon.Types.Normal)));
            _pokemons_disponiveis.Add(new Pokemon(265, "Wurmple", 45, 45, 35, 20, 30, 20, 195, false, 3, false, types(Pokemon.Types.Bug)));
            _pokemons_disponiveis.Add(new Pokemon(266, "Silcoon", 50, 35, 55, 25, 25, 15, 205, false, 3, false, types(Pokemon.Types.Bug)));
            _pokemons_disponiveis.Add(new Pokemon(267, "Beautifly", 60, 70, 50, 90, 50, 65, 385, false, 3, true, types(Pokemon.Types.Bug, Pokemon.Types.Flying)));
            _pokemons_disponiveis.Add(new Pokemon(268, "Cascoon", 50, 35, 55, 25, 25, 15, 205, false, 3, false, types(Pokemon.Types.Bug)));
            _pokemons_disponiveis.Add(new Pokemon(269, "Dustox", 60, 50, 70, 50, 90, 65, 385, false, 3, true, types(Pokemon.Types.Bug, Pokemon.Types.Poison)));
            _pokemons_disponiveis.Add(new Pokemon(270, "Lotad", 40, 30, 30, 40, 50, 30, 220, false, 3, false, types(Pokemon.Types.Water, Pokemon.Types.Grass)));
            _pokemons_disponiveis.Add(new Pokemon(271, "Lombre", 60, 50, 50, 60, 70, 50, 340, false, 3, false, types(Pokemon.Types.Water, Pokemon.Types.Grass)));
            _pokemons_disponiveis.Add(new Pokemon(272, "Ludicolo", 80, 70, 70, 90, 100, 70, 480, false, 3, true, types(Pokemon.Types.Water, Pokemon.Types.Grass)));
            _pokemons_disponiveis.Add(new Pokemon(273, "Seedot", 40, 40, 50, 30, 30, 30, 220, false, 3, false, types(Pokemon.Types.Grass)));
            _pokemons_disponiveis.Add(new Pokemon(274, "Nuzleaf", 70, 70, 40, 60, 40, 60, 340, false, 3, false, types(Pokemon.Types.Grass, Pokemon.Types.Dark)));
            _pokemons_disponiveis.Add(new Pokemon(275, "Shiftry", 90, 100, 60, 90, 60, 80, 480, false, 3, true, types(Pokemon.Types.Grass, Pokemon.Types.Dark)));
            _pokemons_disponiveis.Add(new Pokemon(276, "Taillow", 40, 55, 30, 30, 30, 85, 270, false, 3, false, types(Pokemon.Types.Normal, Pokemon.Types.Flying)));
            _pokemons_disponiveis.Add(new Pokemon(277, "Swellow", 60, 85, 60, 50, 50, 125, 430, false, 3, true, types(Pokemon.Types.Normal, Pokemon.Types.Flying)));
            _pokemons_disponiveis.Add(new Pokemon(278, "Wingull", 40, 30, 30, 55, 30, 85, 270, false, 3, false, types(Pokemon.Types.Water, Pokemon.Types.Flying)));
            _pokemons_disponiveis.Add(new Pokemon(279, "Pelipper", 60, 50, 100, 85, 70, 65, 430, false, 3, true, types(Pokemon.Types.Water, Pokemon.Types.Flying)));
            _pokemons_disponiveis.Add(new Pokemon(280, "Ralts", 28, 25, 25, 45, 35, 40, 198, false, 3, false, types(Pokemon.Types.Psychic)));
            _pokemons_disponiveis.Add(new Pokemon(281, "Kirlia", 38, 35, 35, 65, 55, 50, 278, false, 3, false, types(Pokemon.Types.Psychic)));
            _pokemons_disponiveis.Add(new Pokemon(282, "Gardevoir", 68, 65, 65, 125, 115, 80, 518, false, 3, true, types(Pokemon.Types.Psychic)));
            _pokemons_disponiveis.Add(new Pokemon(283, "Surskit", 40, 30, 32, 50, 52, 65, 269, false, 3, false, types(Pokemon.Types.Bug, Pokemon.Types.Water)));
            _pokemons_disponiveis.Add(new Pokemon(284, "Masquerain", 70, 60, 62, 80, 82, 60, 414, false, 3, true, types(Pokemon.Types.Bug, Pokemon.Types.Flying)));
            _pokemons_disponiveis.Add(new Pokemon(285, "Shroomish", 60, 40, 60, 40, 60, 35, 295, false, 3, false, types(Pokemon.Types.Grass)));
            _pokemons_disponiveis.Add(new Pokemon(286, "Breloom", 60, 130, 80, 60, 60, 70, 460, false, 3, true, types(Pokemon.Types.Grass, Pokemon.Types.Fighting)));
            _pokemons_disponiveis.Add(new Pokemon(287, "Slakoth", 60, 60, 60, 35, 35, 30, 280, false, 3, false, types(Pokemon.Types.Normal)));
            _pokemons_disponiveis.Add(new Pokemon(288, "Vigoroth", 80, 80, 80, 55, 55, 90, 440, false, 3, false, types(Pokemon.Types.Normal)));
            _pokemons_disponiveis.Add(new Pokemon(289, "Slaking", 150, 160, 100, 95, 65, 100, 670, false, 3, true, types(Pokemon.Types.Normal)));
            _pokemons_disponiveis.Add(new Pokemon(290, "Nincada", 31, 45, 90, 30, 30, 40, 266, false, 3, false, types(Pokemon.Types.Bug, Pokemon.Types.Ground)));
            _pokemons_disponiveis.Add(new Pokemon(291, "Ninjask", 61, 90, 45, 50, 50, 160, 456, false, 3, true, types(Pokemon.Types.Bug, Pokemon.Types.Flying)));
            _pokemons_disponiveis.Add(new Pokemon(292, "Shedinja", 1, 90, 45, 30, 30, 40, 236, false, 3, true, types(Pokemon.Types.Ghost, Pokemon.Types.Bug)));
            _pokemons_disponiveis.Add(new Pokemon(293, "Whismur", 64, 51, 23, 51, 23, 28, 240, false, 3, false, types(Pokemon.Types.Normal)));
            _pokemons_disponiveis.Add(new Pokemon(294, "Loudred", 84, 71, 43, 71, 43, 48, 360, false, 3, false, types(Pokemon.Types.Normal)));
            _pokemons_disponiveis.Add(new Pokemon(295, "Exploud", 104, 91, 63, 91, 63, 68, 480, false, 3, true, types(Pokemon.Types.Normal)));
            _pokemons_disponiveis.Add(new Pokemon(296, "Makuhita", 72, 60, 30, 20, 30, 25, 237, false, 3, false, types(Pokemon.Types.Fighting)));
            _pokemons_disponiveis.Add(new Pokemon(297, "Hariyama", 144, 120, 60, 40, 60, 50, 474, false, 3, true, types(Pokemon.Types.Fighting)));
            _pokemons_disponiveis.Add(new Pokemon(298, "Azurill", 50, 20, 40, 20, 40, 20, 190, false, 3, false, types(Pokemon.Types.Normal)));
            _pokemons_disponiveis.Add(new Pokemon(299, "Nosepass", 30, 45, 135, 45, 90, 30, 375, false, 3, true, types(Pokemon.Types.Rock)));
            _pokemons_disponiveis.Add(new Pokemon(300, "Skitty", 50, 45, 45, 35, 35, 50, 260, false, 3, false, types(Pokemon.Types.Normal)));
            _pokemons_disponiveis.Add(new Pokemon(301, "Delcatty", 70, 65, 65, 55, 55, 70, 380, false, 3, true, types(Pokemon.Types.Normal)));
            _pokemons_disponiveis.Add(new Pokemon(302, "Sableye", 50, 75, 75, 65, 65, 50, 380, false, 3, true, types(Pokemon.Types.Dark, Pokemon.Types.Ghost)));
            _pokemons_disponiveis.Add(new Pokemon(303, "Mawile", 50, 85, 85, 55, 55, 50, 380, false, 3, true, types(Pokemon.Types.Steel)));
            _pokemons_disponiveis.Add(new Pokemon(304, "Aron", 50, 70, 100, 40, 40, 30, 330, false, 3, false, types(Pokemon.Types.Steel, Pokemon.Types.Rock)));
            _pokemons_disponiveis.Add(new Pokemon(305, "Lairon", 60, 90, 140, 50, 50, 40, 430, false, 3, false, types(Pokemon.Types.Steel, Pokemon.Types.Rock)));
            _pokemons_disponiveis.Add(new Pokemon(306, "Aggron", 70, 110, 180, 60, 60, 50, 530, false, 3, true, types(Pokemon.Types.Steel, Pokemon.Types.Rock)));
            _pokemons_disponiveis.Add(new Pokemon(307, "Meditite", 30, 40, 55, 40, 55, 60, 280, false, 3, false, types(Pokemon.Types.Fighting, Pokemon.Types.Psychic)));
            _pokemons_disponiveis.Add(new Pokemon(308, "Medicham", 60, 60, 75, 60, 75, 80, 410, false, 3, true, types(Pokemon.Types.Fighting, Pokemon.Types.Psychic)));
            _pokemons_disponiveis.Add(new Pokemon(309, "Electrike", 40, 45, 40, 65, 40, 65, 295, false, 3, false, types(Pokemon.Types.Electric)));
            _pokemons_disponiveis.Add(new Pokemon(310, "Manectric", 70, 75, 60, 105, 60, 105, 475, false, 3, true, types(Pokemon.Types.Electric)));
            _pokemons_disponiveis.Add(new Pokemon(311, "Plusle", 60, 50, 40, 85, 75, 95, 405, false, 3, true, types(Pokemon.Types.Electric)));
            _pokemons_disponiveis.Add(new Pokemon(312, "Minun", 60, 40, 50, 75, 85, 95, 405, false, 3, true, types(Pokemon.Types.Electric)));
            _pokemons_disponiveis.Add(new Pokemon(313, "Volbeat", 65, 73, 55, 47, 75, 85, 400, false, 3, true, types(Pokemon.Types.Bug)));
            _pokemons_disponiveis.Add(new Pokemon(314, "Illumise", 65, 47, 55, 73, 75, 85, 400, false, 3, true, types(Pokemon.Types.Bug)));
            _pokemons_disponiveis.Add(new Pokemon(315, "Roselia", 50, 60, 45, 100, 80, 65, 400, false, 3, true, types(Pokemon.Types.Grass, Pokemon.Types.Poison)));
            _pokemons_disponiveis.Add(new Pokemon(316, "Gulpin", 70, 43, 53, 43, 53, 40, 302, false, 3, false, types(Pokemon.Types.Poison)));
            _pokemons_disponiveis.Add(new Pokemon(317, "Swalot", 100, 73, 83, 73, 83, 55, 467, false, 3, true, types(Pokemon.Types.Poison)));
            _pokemons_disponiveis.Add(new Pokemon(318, "Carvanha", 45, 90, 20, 65, 20, 65, 305, false, 3, false, types(Pokemon.Types.Water, Pokemon.Types.Dark)));
            _pokemons_disponiveis.Add(new Pokemon(319, "Sharpedo", 70, 120, 40, 95, 40, 95, 460, false, 3, true, types(Pokemon.Types.Water, Pokemon.Types.Dark)));
            _pokemons_disponiveis.Add(new Pokemon(320, "Wailmer", 130, 70, 35, 70, 35, 60, 400, false, 3, false, types(Pokemon.Types.Water)));
            _pokemons_disponiveis.Add(new Pokemon(321, "Wailord", 170, 90, 45, 90, 45, 60, 500, false, 3, true, types(Pokemon.Types.Water)));
            _pokemons_disponiveis.Add(new Pokemon(322, "Numel", 60, 60, 40, 65, 45, 35, 305, false, 3, false, types(Pokemon.Types.Fire, Pokemon.Types.Ground)));
            _pokemons_disponiveis.Add(new Pokemon(323, "Camerupt", 70, 100, 70, 105, 75, 40, 460, false, 3, true, types(Pokemon.Types.Fire, Pokemon.Types.Ground)));
            _pokemons_disponiveis.Add(new Pokemon(324, "Torkoal", 70, 85, 140, 85, 70, 20, 470, false, 3, true, types(Pokemon.Types.Fire)));
            _pokemons_disponiveis.Add(new Pokemon(325, "Spoink", 60, 25, 35, 70, 80, 60, 330, false, 3, false, types(Pokemon.Types.Psychic)));
            _pokemons_disponiveis.Add(new Pokemon(326, "Grumpig", 80, 45, 65, 90, 110, 80, 470, false, 3, true, types(Pokemon.Types.Psychic)));
            _pokemons_disponiveis.Add(new Pokemon(327, "Spinda", 60, 60, 60, 60, 60, 60, 360, false, 3, true, types(Pokemon.Types.Normal)));
            _pokemons_disponiveis.Add(new Pokemon(328, "Trapinch", 45, 100, 45, 45, 45, 10, 290, false, 3, false, types(Pokemon.Types.Ground)));
            _pokemons_disponiveis.Add(new Pokemon(329, "Vibrava", 50, 70, 50, 50, 50, 70, 340, false, 3, false, types(Pokemon.Types.Ground, Pokemon.Types.Dragon)));
            _pokemons_disponiveis.Add(new Pokemon(330, "Flygon", 80, 100, 80, 80, 80, 100, 520, false, 3, true, types(Pokemon.Types.Ground, Pokemon.Types.Dragon)));
            _pokemons_disponiveis.Add(new Pokemon(331, "Cacnea", 50, 85, 40, 85, 40, 35, 335, false, 3, false, types(Pokemon.Types.Grass)));
            _pokemons_disponiveis.Add(new Pokemon(332, "Cacturne", 70, 115, 60, 115, 60, 55, 475, false, 3, true, types(Pokemon.Types.Grass, Pokemon.Types.Dark)));
            _pokemons_disponiveis.Add(new Pokemon(333, "Swablu", 45, 40, 60, 40, 75, 50, 310, false, 3, false, types(Pokemon.Types.Normal, Pokemon.Types.Flying)));
            _pokemons_disponiveis.Add(new Pokemon(334, "Altaria", 75, 70, 90, 70, 105, 80, 490, false, 3, true, types(Pokemon.Types.Dragon, Pokemon.Types.Flying)));
            _pokemons_disponiveis.Add(new Pokemon(335, "Zangoose", 73, 115, 60, 60, 60, 90, 458, false, 3, true, types(Pokemon.Types.Normal)));
            _pokemons_disponiveis.Add(new Pokemon(336, "Seviper", 73, 100, 60, 100, 60, 65, 458, false, 3, true, types(Pokemon.Types.Poison)));
            _pokemons_disponiveis.Add(new Pokemon(337, "Lunatone", 70, 55, 65, 95, 85, 70, 440, false, 3, true, types(Pokemon.Types.Rock, Pokemon.Types.Psychic)));
            _pokemons_disponiveis.Add(new Pokemon(338, "Solrock", 70, 95, 85, 55, 65, 70, 440, false, 3, true, types(Pokemon.Types.Rock, Pokemon.Types.Psychic)));
            _pokemons_disponiveis.Add(new Pokemon(339, "Barboach", 50, 48, 43, 46, 41, 60, 288, false, 3, false, types(Pokemon.Types.Water, Pokemon.Types.Ground)));
            _pokemons_disponiveis.Add(new Pokemon(340, "Whiscash", 110, 78, 73, 76, 71, 60, 468, false, 3, true, types(Pokemon.Types.Water, Pokemon.Types.Ground)));
            _pokemons_disponiveis.Add(new Pokemon(341, "Corphish", 43, 80, 65, 50, 35, 35, 308, false, 3, false, types(Pokemon.Types.Water)));
            _pokemons_disponiveis.Add(new Pokemon(342, "Crawdaunt", 63, 120, 85, 90, 55, 55, 468, false, 3, true, types(Pokemon.Types.Water, Pokemon.Types.Dark)));
            _pokemons_disponiveis.Add(new Pokemon(343, "Baltoy", 40, 40, 55, 40, 70, 55, 300, false, 3, false, types(Pokemon.Types.Ground, Pokemon.Types.Psychic)));
            _pokemons_disponiveis.Add(new Pokemon(344, "Claydol", 60, 70, 105, 70, 120, 75, 500, false, 3, true, types(Pokemon.Types.Ground, Pokemon.Types.Psychic)));
            _pokemons_disponiveis.Add(new Pokemon(345, "Lileep", 66, 41, 77, 61, 87, 23, 355, false, 3, false, types(Pokemon.Types.Rock, Pokemon.Types.Grass)));
            _pokemons_disponiveis.Add(new Pokemon(346, "Cradily", 86, 81, 97, 81, 107, 43, 495, false, 3, true, types(Pokemon.Types.Rock, Pokemon.Types.Grass)));
            _pokemons_disponiveis.Add(new Pokemon(347, "Anorith", 45, 95, 50, 40, 50, 75, 355, false, 3, false, types(Pokemon.Types.Rock, Pokemon.Types.Bug)));
            _pokemons_disponiveis.Add(new Pokemon(348, "Armaldo", 75, 125, 100, 70, 80, 45, 495, false, 3, true, types(Pokemon.Types.Rock, Pokemon.Types.Bug)));
            _pokemons_disponiveis.Add(new Pokemon(349, "Feebas", 20, 15, 20, 10, 55, 80, 200, false, 3, false, types(Pokemon.Types.Water)));
            _pokemons_disponiveis.Add(new Pokemon(350, "Milotic", 95, 60, 79, 100, 125, 81, 540, false, 3, true, types(Pokemon.Types.Water)));
            _pokemons_disponiveis.Add(new Pokemon(351, "Castform", 70, 70, 70, 70, 70, 70, 420, false, 3, true, types(Pokemon.Types.Normal)));
            _pokemons_disponiveis.Add(new Pokemon(352, "Kecleon", 60, 90, 70, 60, 120, 40, 440, false, 3, true, types(Pokemon.Types.Normal)));
            _pokemons_disponiveis.Add(new Pokemon(353, "Shuppet", 44, 75, 35, 63, 33, 45, 295, false, 3, false, types(Pokemon.Types.Poison)));
            _pokemons_disponiveis.Add(new Pokemon(354, "Banette", 64, 115, 65, 83, 63, 65, 455, false, 3, true, types(Pokemon.Types.Ghost)));
            _pokemons_disponiveis.Add(new Pokemon(355, "Duskull", 20, 40, 90, 30, 90, 25, 295, false, 3, false, types(Pokemon.Types.Ghost)));
            _pokemons_disponiveis.Add(new Pokemon(356, "Dusclops", 40, 70, 130, 60, 130, 25, 455, false, 3, true, types(Pokemon.Types.Ghost)));
            _pokemons_disponiveis.Add(new Pokemon(357, "Tropius", 99, 68, 83, 72, 87, 51, 460, false, 3, true, types(Pokemon.Types.Grass, Pokemon.Types.Flying)));
            _pokemons_disponiveis.Add(new Pokemon(358, "Chimecho", 65, 50, 70, 95, 80, 65, 425, false, 3, true, types(Pokemon.Types.Psychic)));
            _pokemons_disponiveis.Add(new Pokemon(359, "Absol", 65, 130, 60, 75, 60, 75, 465, false, 3, true, types(Pokemon.Types.Dark)));
            _pokemons_disponiveis.Add(new Pokemon(360, "Wynaut", 95, 23, 48, 23, 48, 23, 260, false, 3, false, types(Pokemon.Types.Psychic)));
            _pokemons_disponiveis.Add(new Pokemon(361, "Snorunt", 50, 50, 50, 50, 50, 50, 300, false, 3, false, types(Pokemon.Types.Ice)));
            _pokemons_disponiveis.Add(new Pokemon(362, "Glalie", 80, 80, 80, 80, 80, 80, 480, false, 3, true, types(Pokemon.Types.Ice)));
            _pokemons_disponiveis.Add(new Pokemon(363, "Spheal", 70, 40, 50, 55, 50, 25, 290, false, 3, false, types(Pokemon.Types.Ice, Pokemon.Types.Water)));
            _pokemons_disponiveis.Add(new Pokemon(364, "Sealeo", 90, 60, 70, 75, 70, 45, 410, false, 3, false, types(Pokemon.Types.Ice, Pokemon.Types.Water)));
            _pokemons_disponiveis.Add(new Pokemon(365, "Walrein", 110, 80, 90, 95, 90, 65, 530, false, 3, true, types(Pokemon.Types.Ice, Pokemon.Types.Water)));
            _pokemons_disponiveis.Add(new Pokemon(366, "Clamperl", 35, 64, 85, 74, 55, 32, 345, false, 3, false, types(Pokemon.Types.Water)));
            _pokemons_disponiveis.Add(new Pokemon(367, "Huntail", 55, 104, 105, 94, 75, 52, 485, false, 3, true, types(Pokemon.Types.Water)));
            _pokemons_disponiveis.Add(new Pokemon(368, "Gorebyss", 55, 84, 105, 114, 75, 52, 485, false, 3, true, types(Pokemon.Types.Water)));
            _pokemons_disponiveis.Add(new Pokemon(369, "Relicanth", 100, 90, 130, 45, 65, 55, 485, false, 3, true, types(Pokemon.Types.Water, Pokemon.Types.Rock)));
            _pokemons_disponiveis.Add(new Pokemon(370, "Luvdisc", 43, 30, 55, 40, 65, 97, 330, false, 3, true, types(Pokemon.Types.Water)));
            _pokemons_disponiveis.Add(new Pokemon(371, "Bagon", 45, 75, 60, 40, 30, 50, 300, false, 3, false, types(Pokemon.Types.Dragon)));
            _pokemons_disponiveis.Add(new Pokemon(372, "Shelgon", 65, 95, 100, 60, 50, 50, 420, false, 3, false, types(Pokemon.Types.Dragon)));
            _pokemons_disponiveis.Add(new Pokemon(373, "Salamence", 95, 135, 80, 110, 80, 100, 600, false, 3, true, types(Pokemon.Types.Dragon, Pokemon.Types.Flying)));
            _pokemons_disponiveis.Add(new Pokemon(374, "Beldum", 40, 55, 80, 35, 60, 30, 300, false, 3, false, types(Pokemon.Types.Steel, Pokemon.Types.Psychic)));
            _pokemons_disponiveis.Add(new Pokemon(375, "Metang", 60, 75, 100, 55, 80, 50, 420, false, 3, false, types(Pokemon.Types.Steel, Pokemon.Types.Psychic)));
            _pokemons_disponiveis.Add(new Pokemon(376, "Metagross", 80, 135, 130, 95, 90, 70, 600, false, 3, true, types(Pokemon.Types.Steel, Pokemon.Types.Psychic)));
            _pokemons_disponiveis.Add(new Pokemon(377, "Regirock", 80, 100, 200, 50, 100, 50, 580, true, 3, true, types(Pokemon.Types.Rock)));
            _pokemons_disponiveis.Add(new Pokemon(378, "Regice", 80, 50, 100, 100, 200, 50, 580, true, 3, true, types(Pokemon.Types.Ice)));
            _pokemons_disponiveis.Add(new Pokemon(379, "Registeel", 80, 75, 150, 75, 150, 50, 580, true, 3, true, types(Pokemon.Types.Steel)));
            _pokemons_disponiveis.Add(new Pokemon(380, "Latias", 80, 80, 90, 110, 130, 110, 600, true, 3, true, types(Pokemon.Types.Dragon, Pokemon.Types.Psychic)));
            _pokemons_disponiveis.Add(new Pokemon(381, "Latios", 80, 90, 80, 130, 110, 110, 600, true, 3, true, types(Pokemon.Types.Dragon, Pokemon.Types.Psychic)));
            _pokemons_disponiveis.Add(new Pokemon(382, "Kyogre", 100, 100, 90, 150, 140, 90, 670, true, 3, true, types(Pokemon.Types.Water)));
            _pokemons_disponiveis.Add(new Pokemon(383, "Groudon", 100, 150, 140, 100, 90, 90, 670, true, 3, true, types(Pokemon.Types.Ground)));
            _pokemons_disponiveis.Add(new Pokemon(384, "Rayquaza", 105, 150, 90, 150, 90, 95, 680, true, 3, true, types(Pokemon.Types.Dragon, Pokemon.Types.Flying)));
            _pokemons_disponiveis.Add(new Pokemon(385, "Jirachi", 100, 100, 100, 100, 100, 100, 600, true, 3, true, types(Pokemon.Types.Steel, Pokemon.Types.Psychic)));
            _pokemons_disponiveis.Add(new Pokemon(386, "Deoxys (Attack Forme)", 50, 180, 20, 180, 20, 150, 600, true, 3, true, types(Pokemon.Types.Psychic)));
            _pokemons_disponiveis.Add(new Pokemon(386, "Deoxys (Defense Forme)", 50, 70, 160, 70, 160, 90, 600, true, 3, true, types(Pokemon.Types.Psychic)));
            _pokemons_disponiveis.Add(new Pokemon(386, "Deoxys (Normal Forme)", 50, 150, 50, 150, 50, 150, 600, true, 3, true, types(Pokemon.Types.Psychic)));
            _pokemons_disponiveis.Add(new Pokemon(386, "Deoxys (Speed Forme)", 50, 95, 90, 95, 90, 180, 600, true, 3, true, types(Pokemon.Types.Psychic)));
            */
            #endregion

            /*
            _pokemons_disponiveis.Add(new Pokemon(83, "Farfetch'd", 52, 65, 55, 58, 62, 60, 352, false, 1, true, types(Pokemon.Types.Normal, Pokemon.Types.Flying)));
            _pokemons_disponiveis.Add(new Pokemon(84, "Doduo", 35, 85, 45, 35, 35, 75, 310, false, 1, false, types(Pokemon.Types.Normal, Pokemon.Types.Flying)));
            _pokemons_disponiveis.Add(new Pokemon(85, "Dodrio", 60, 110, 70, 60, 60, 100, 460, false, 1, true, types(Pokemon.Types.Normal, Pokemon.Types.Flying)));
            _pokemons_disponiveis.Add(new Pokemon(86, "Seel", 65, 45, 55, 45, 70, 45, 325, false, 1, false, types(Pokemon.Types.Water)));
            _pokemons_disponiveis.Add(new Pokemon(87, "Dewgong", 90, 70, 80, 70, 95, 70, 475, false, 1, true, types(Pokemon.Types.Water, Pokemon.Types.Ice)));
            _pokemons_disponiveis.Add(new Pokemon(88, "Grimer", 80, 80, 50, 40, 50, 25, 325, false, 1, false, types(Pokemon.Types.Poison)));
            _pokemons_disponiveis.Add(new Pokemon(89, "Muk", 105, 105, 75, 65, 100, 50, 500, false, 1, true, types(Pokemon.Types.Poison)));
            _pokemons_disponiveis.Add(new Pokemon(90, "Shellder", 30, 65, 100, 45, 25, 40, 305, false, 1, false, types(Pokemon.Types.Water)));
            _pokemons_disponiveis.Add(new Pokemon(91, "Cloyster", 50, 95, 180, 85, 45, 70, 525, false, 1, true, types(Pokemon.Types.Water, Pokemon.Types.Ice)));
            _pokemons_disponiveis.Add(new Pokemon(92, "Gastly", 30, 35, 30, 100, 35, 80, 310, false, 1, false, types(Pokemon.Types.Ghost, Pokemon.Types.Poison)));
            _pokemons_disponiveis.Add(new Pokemon(93, "Haunter", 45, 50, 45, 115, 55, 95, 405, false, 1, false, types(Pokemon.Types.Ghost, Pokemon.Types.Poison)));
            _pokemons_disponiveis.Add(new Pokemon(94, "Gengar", 60, 65, 60, 130, 75, 110, 500, false, 1, true, types(Pokemon.Types.Ghost, Pokemon.Types.Poison)));
            _pokemons_disponiveis.Add(new Pokemon(95, "Onix", 35, 45, 160, 30, 45, 70, 385, false, 1, false, types(Pokemon.Types.Rock, Pokemon.Types.Ground)));
            _pokemons_disponiveis.Add(new Pokemon(100, "Voltorb", 40, 30, 50, 55, 55, 100, 330, false, 1, false, types(Pokemon.Types.Electric)));
            _pokemons_disponiveis.Add(new Pokemon(101, "Electrode", 60, 50, 70, 80, 80, 140, 480, false, 1, true, types(Pokemon.Types.Electric)));
            _pokemons_disponiveis.Add(new Pokemon(102, "Exeggcute", 60, 40, 80, 60, 45, 40, 325, false, 1, false, types(Pokemon.Types.Grass, Pokemon.Types.Psychic)));
            _pokemons_disponiveis.Add(new Pokemon(103, "Exeggutor", 95, 95, 85, 125, 65, 55, 520, false, 1, true, types(Pokemon.Types.Grass, Pokemon.Types.Psychic)));
            _pokemons_disponiveis.Add(new Pokemon(104, "Cubone", 50, 50, 95, 40, 50, 35, 320, false, 1, false, types(Pokemon.Types.Ground)));
            _pokemons_disponiveis.Add(new Pokemon(105, "Marowak", 60, 80, 110, 50, 80, 45, 425, false, 1, true, types(Pokemon.Types.Ground)));
            _pokemons_disponiveis.Add(new Pokemon(106, "Hitmonlee", 50, 120, 53, 35, 110, 87, 455, false, 1, true, types(Pokemon.Types.Fighting)));
            _pokemons_disponiveis.Add(new Pokemon(107, "Hitmonchan", 50, 105, 79, 35, 110, 76, 455, false, 1, true, types(Pokemon.Types.Fighting)));
            _pokemons_disponiveis.Add(new Pokemon(108, "Lickitung", 90, 55, 75, 60, 75, 30, 385, false, 1, true, types(Pokemon.Types.Normal)));
            _pokemons_disponiveis.Add(new Pokemon(109, "Koffing", 40, 65, 95, 60, 45, 35, 340, false, 1, false, types(Pokemon.Types.Poison)));
            _pokemons_disponiveis.Add(new Pokemon(110, "Weezing", 65, 90, 120, 85, 70, 60, 490, false, 1, true, types(Pokemon.Types.Poison)));
            _pokemons_disponiveis.Add(new Pokemon(111, "Rhyhorn", 80, 85, 95, 30, 30, 25, 345, false, 1, false, types(Pokemon.Types.Rock, Pokemon.Types.Ground)));
            _pokemons_disponiveis.Add(new Pokemon(112, "Rhydon", 105, 130, 120, 45, 45, 40, 485, false, 1, true, types(Pokemon.Types.Rock, Pokemon.Types.Ground)));
            _pokemons_disponiveis.Add(new Pokemon(113, "Chansey", 250, 5, 5, 35, 105, 50, 450, false, 1, false, types(Pokemon.Types.Normal)));
            _pokemons_disponiveis.Add(new Pokemon(114, "Tangela", 65, 55, 115, 100, 40, 60, 435, false, 1, true, types(Pokemon.Types.Grass)));
            _pokemons_disponiveis.Add(new Pokemon(115, "Kangaskhan", 105, 95, 80, 40, 80, 90, 490, false, 1, true, types(Pokemon.Types.Normal)));
            _pokemons_disponiveis.Add(new Pokemon(123, "Scyther", 70, 110, 80, 55, 80, 105, 500, false, 1, false, types(Pokemon.Types.Bug, Pokemon.Types.Flying)));
            _pokemons_disponiveis.Add(new Pokemon(124, "Jynx", 65, 50, 35, 115, 95, 95, 455, false, 1, true, types(Pokemon.Types.Psychic, Pokemon.Types.Ice)));
            _pokemons_disponiveis.Add(new Pokemon(125, "Electabuzz", 65, 83, 57, 95, 85, 105, 490, false, 1, true, types(Pokemon.Types.Electric)));
            _pokemons_disponiveis.Add(new Pokemon(127, "Pinsir", 65, 125, 100, 55, 70, 85, 500, false, 1, true, types(Pokemon.Types.Bug)));
            _pokemons_disponiveis.Add(new Pokemon(128, "Tauros", 75, 100, 95, 40, 70, 110, 490, false, 1, true, types(Pokemon.Types.Normal)));
            _pokemons_disponiveis.Add(new Pokemon(129, "Magikarp", 20, 10, 55, 15, 20, 80, 200, false, 1, false, types(Pokemon.Types.Water)));
            _pokemons_disponiveis.Add(new Pokemon(130, "Gyarados", 95, 125, 79, 60, 100, 81, 540, false, 1, true, types(Pokemon.Types.Water, Pokemon.Types.Flying)));
            _pokemons_disponiveis.Add(new Pokemon(131, "Lapras", 130, 85, 80, 85, 95, 60, 535, false, 1, true, types(Pokemon.Types.Water, Pokemon.Types.Ice)));
            _pokemons_disponiveis.Add(new Pokemon(133, "Eevee", 55, 55, 50, 45, 65, 55, 325, false, 1, false, types(Pokemon.Types.Normal)));
            _pokemons_disponiveis.Add(new Pokemon(135, "Jolteon", 65, 65, 60, 110, 95, 130, 525, false, 1, true, types(Pokemon.Types.Electric)));
            _pokemons_disponiveis.Add(new Pokemon(137, "Porygon", 65, 60, 70, 85, 75, 40, 395, false, 1, false, types(Pokemon.Types.Normal)));
            _pokemons_disponiveis.Add(new Pokemon(138, "Omanyte", 35, 40, 100, 90, 55, 35, 355, false, 1, false, types(Pokemon.Types.Rock, Pokemon.Types.Water)));
            _pokemons_disponiveis.Add(new Pokemon(139, "Omastar", 70, 60, 125, 115, 70, 55, 495, false, 1, true, types(Pokemon.Types.Rock, Pokemon.Types.Water)));
            _pokemons_disponiveis.Add(new Pokemon(140, "Kabuto", 30, 80, 90, 55, 45, 55, 355, false, 1, false, types(Pokemon.Types.Rock, Pokemon.Types.Water)));
            _pokemons_disponiveis.Add(new Pokemon(141, "Kabutops", 60, 115, 105, 65, 70, 80, 495, false, 1, true, types(Pokemon.Types.Rock, Pokemon.Types.Water)));
            _pokemons_disponiveis.Add(new Pokemon(142, "Aerodactyl", 80, 105, 65, 60, 75, 130, 515, false, 1, true, types(Pokemon.Types.Rock, Pokemon.Types.Flying)));
            _pokemons_disponiveis.Add(new Pokemon(144, "Articuno", 90, 85, 100, 95, 125, 85, 580, true, 1, true, types(Pokemon.Types.Ice, Pokemon.Types.Flying)));
            _pokemons_disponiveis.Add(new Pokemon(145, "Zapdos", 90, 90, 85, 125, 90, 100, 580, true, 1, true, types(Pokemon.Types.Electric, Pokemon.Types.Flying)));
            _pokemons_disponiveis.Add(new Pokemon(146, "Moltres", 90, 100, 90, 125, 85, 90, 580, true, 1, true, types(Pokemon.Types.Fire, Pokemon.Types.Flying)));
            */



            _pokemons_disponiveis.Add(new Pokemon(007, "Squirtle", 44, 48, 65, 50, 64, 43, 314, 52.33m, 1, false, false, types(Pokemon.Types.Water)));
            _pokemons_disponiveis.Add(new Pokemon(008, "Wartortle", 59, 63, 80, 65, 80, 58, 405, 67.5m, 1, false, false, types(Pokemon.Types.Water)));
            _pokemons_disponiveis.Add(new Pokemon(009, "Blastoise", 79, 83, 100, 85, 105, 78, 530, 88.33m, 1, false, true, types(Pokemon.Types.Water),
                new Pokemon[] { new Pokemon(009, "Mega Blastoise", 79, 103, 120, 135, 115, 78, 630, 105m, 6, false, true, types(Pokemon.Types.Water)) }));

            _pokemons_disponiveis.Add(new Pokemon(010, "Caterpie", 45, 30, 35, 20, 20, 45, 195, 32.5m, 1, false, false, types(Pokemon.Types.Bug)));
            _pokemons_disponiveis.Add(new Pokemon(011, "Metapod", 50, 20, 55, 25, 25, 30, 205, 34.17m, 1, false, false, types(Pokemon.Types.Bug)));
            _pokemons_disponiveis.Add(new Pokemon(012, "Butterfree", 60, 45, 50, 90, 80, 70, 395, 65.83m, 1, false, true, types(Pokemon.Types.Bug, Pokemon.Types.Flying)));

            _pokemons_disponiveis.Add(new Pokemon(013, "Weedle", 40, 35, 30, 20, 20, 50, 195, 32.5m, 1, false, false, types(Pokemon.Types.Bug, Pokemon.Types.Poison)));
            _pokemons_disponiveis.Add(new Pokemon(014, "Kakuna", 45, 25, 50, 25, 25, 35, 205, 34.17m, 1, false, false, types(Pokemon.Types.Bug, Pokemon.Types.Poison)));
            _pokemons_disponiveis.Add(new Pokemon(015, "Beedrill", 65, 90, 40, 45, 80, 75, 395, 65.83m, 1, false, true, types(Pokemon.Types.Bug, Pokemon.Types.Poison),
                new Pokemon[] { new Pokemon(015, "Mega Beedrill", 65, 150, 40, 15, 80, 145, 495, 82.5m, 6, false, true, types(Pokemon.Types.Bug, Pokemon.Types.Poison)) }));

            _pokemons_disponiveis.Add(new Pokemon(016, "Pidgey", 40, 45, 40, 35, 35, 56, 251, 41.83m, 1, false, false, types(Pokemon.Types.Normal, Pokemon.Types.Flying)));
            _pokemons_disponiveis.Add(new Pokemon(017, "Pidgeotto", 63, 60, 55, 50, 50, 71, 349, 58.17m, 1, false, false, types(Pokemon.Types.Normal, Pokemon.Types.Flying)));
            _pokemons_disponiveis.Add(new Pokemon(018, "Pidgeot", 83, 80, 75, 70, 70, 101, 479, 79.83m, 1, false, true, types(Pokemon.Types.Normal, Pokemon.Types.Flying),
                new Pokemon[] { new Pokemon(018, "Mega Pidgeot", 83, 80, 80, 135, 80, 121, 579, 96.5m, 6, false, true, types(Pokemon.Types.Normal, Pokemon.Types.Flying)) }));

            _pokemons_disponiveis.Add(new Pokemon(019, "Rattata", 30, 56, 35, 25, 35, 72, 253, 42.17m, 1, false, false, types(Pokemon.Types.Normal)));
            _pokemons_disponiveis.Add(new Pokemon(020, "Raticate", 55, 81, 60, 50, 70, 97, 413, 68.83m, 1, false, true, types(Pokemon.Types.Normal)));

            _pokemons_disponiveis.Add(new Pokemon(021, "Spearow", 40, 60, 30, 31, 31, 70, 262, 43.67m, 1, false, false, types(Pokemon.Types.Normal, Pokemon.Types.Flying)));
            _pokemons_disponiveis.Add(new Pokemon(022, "Fearow", 65, 90, 65, 61, 61, 100, 442, 73.67m, 1, false, true, types(Pokemon.Types.Normal, Pokemon.Types.Flying)));

            _pokemons_disponiveis.Add(new Pokemon(023, "Ekans", 35, 60, 44, 40, 54, 55, 288, 48m, 1, false, false, types(Pokemon.Types.Poison)));
            _pokemons_disponiveis.Add(new Pokemon(024, "Arbok", 60, 85, 69, 65, 79, 80, 438, 73m, 1, false, true, types(Pokemon.Types.Poison)));

            _pokemons_disponiveis.Add(new Pokemon(025, "Pikachu", 35, 55, 40, 50, 50, 90, 320, 53.33m, 1, false, false, types(Pokemon.Types.Electric)));
            _pokemons_disponiveis.Add(new Pokemon(026, "Raichu", 60, 90, 55, 90, 80, 110, 485, 80.83m, 1, false, true, types(Pokemon.Types.Electric)));

            _pokemons_disponiveis.Add(new Pokemon(027, "Sandshrew", 50, 75, 85, 20, 30, 40, 300, 50m, 1, false, false, types(Pokemon.Types.Ground)));
            _pokemons_disponiveis.Add(new Pokemon(028, "Sandslash", 75, 100, 110, 45, 55, 65, 450, 75m, 1, false, true, types(Pokemon.Types.Ground)));

            _pokemons_disponiveis.Add(new Pokemon(029, "Nidoran♀", 55, 47, 52, 40, 40, 41, 275, 45.83m, 1, false, false, types(Pokemon.Types.Poison)));
            _pokemons_disponiveis.Add(new Pokemon(030, "Nidorina", 70, 62, 67, 55, 55, 56, 365, 60.83m, 1, false, false, types(Pokemon.Types.Poison)));
            _pokemons_disponiveis.Add(new Pokemon(031, "Nidoqueen", 90, 92, 87, 75, 85, 76, 505, 84.17m, 1, false, true, types(Pokemon.Types.Ground, Pokemon.Types.Poison)));

            _pokemons_disponiveis.Add(new Pokemon(032, "Nidoran♂", 46, 57, 40, 40, 40, 50, 273, 45.5m, 1, false, false, types(Pokemon.Types.Poison)));
            _pokemons_disponiveis.Add(new Pokemon(033, "Nidorino", 61, 72, 57, 55, 55, 65, 365, 60.83m, 1, false, false, types(Pokemon.Types.Poison)));
            _pokemons_disponiveis.Add(new Pokemon(034, "Nidoking", 81, 102, 77, 85, 75, 85, 505, 84.17m, 1, false, true, types(Pokemon.Types.Ground, Pokemon.Types.Poison)));

            _pokemons_disponiveis.Add(new Pokemon(035, "Clefairy", 70, 45, 48, 60, 65, 35, 323, 53.83m, 1, false, false, types(Pokemon.Types.Normal)));
            _pokemons_disponiveis.Add(new Pokemon(036, "Clefable", 95, 70, 73, 95, 90, 60, 483, 80.5m, 1, false, true, types(Pokemon.Types.Normal)));

            _pokemons_disponiveis.Add(new Pokemon(037, "Vulpix", 38, 41, 40, 50, 65, 65, 299, 49.83m, 1, false, false, types(Pokemon.Types.Fire)));
            _pokemons_disponiveis.Add(new Pokemon(038, "Ninetales", 73, 76, 75, 81, 100, 100, 505, 84.17m, 1, false, true, types(Pokemon.Types.Fire)));

            _pokemons_disponiveis.Add(new Pokemon(039, "Jigglypuff", 115, 45, 20, 45, 25, 20, 270, 45m, 1, false, false, types(Pokemon.Types.Normal)));
            _pokemons_disponiveis.Add(new Pokemon(040, "Wigglytuff", 140, 70, 45, 85, 50, 45, 435, 72.5m, 1, false, true, types(Pokemon.Types.Normal)));

            _pokemons_disponiveis.Add(new Pokemon(041, "Zubat", 40, 45, 35, 30, 40, 55, 245, 40.83m, 1, false, false, types(Pokemon.Types.Poison, Pokemon.Types.Flying)));
            _pokemons_disponiveis.Add(new Pokemon(042, "Golbat", 75, 80, 70, 65, 75, 90, 455, 75.83m, 1, false, false, types(Pokemon.Types.Poison, Pokemon.Types.Flying)));

            _pokemons_disponiveis.Add(new Pokemon(043, "Oddish", 45, 50, 55, 75, 65, 30, 320, 53.33m, 1, false, false, types(Pokemon.Types.Poison, Pokemon.Types.Grass)));
            _pokemons_disponiveis.Add(new Pokemon(044, "Gloom", 60, 65, 70, 85, 75, 40, 395, 65.83m, 1, false, false, types(Pokemon.Types.Poison, Pokemon.Types.Grass)));
            _pokemons_disponiveis.Add(new Pokemon(045, "Vileplume", 75, 80, 85, 110, 90, 50, 490, 81.67m, 1, false, true, types(Pokemon.Types.Poison, Pokemon.Types.Grass)));

            _pokemons_disponiveis.Add(new Pokemon(046, "Paras", 35, 70, 55, 45, 55, 25, 285, 47.5m, 1, false, false, types(Pokemon.Types.Bug, Pokemon.Types.Grass)));
            _pokemons_disponiveis.Add(new Pokemon(047, "Parasect", 60, 95, 80, 60, 80, 30, 405, 67.5m, 1, false, true, types(Pokemon.Types.Bug, Pokemon.Types.Grass)));

            _pokemons_disponiveis.Add(new Pokemon(048, "Venonat", 60, 55, 50, 40, 55, 45, 305, 50.83m, 1, false, false, types(Pokemon.Types.Bug, Pokemon.Types.Grass)));
            _pokemons_disponiveis.Add(new Pokemon(049, "Venomoth", 70, 65, 60, 90, 75, 90, 450, 75m, 1, false, true, types(Pokemon.Types.Bug, Pokemon.Types.Grass)));

            _pokemons_disponiveis.Add(new Pokemon(050, "Diglett", 10, 55, 25, 35, 45, 95, 265, 44.17m, 1, false, false, types(Pokemon.Types.Ground)));
            _pokemons_disponiveis.Add(new Pokemon(051, "Dugtrio", 35, 80, 50, 50, 70, 120, 405, 67.5m, 1, false, true, types(Pokemon.Types.Ground)));

            _pokemons_disponiveis.Add(new Pokemon(052, "Meowth", 40, 45, 35, 40, 40, 90, 290, 48.33m, 1, false, false, types(Pokemon.Types.Normal)));
            _pokemons_disponiveis.Add(new Pokemon(053, "Persian", 65, 70, 60, 65, 65, 115, 440, 73.33m, 1, false, true, types(Pokemon.Types.Normal)));

            _pokemons_disponiveis.Add(new Pokemon(054, "Psyduck", 50, 52, 48, 65, 50, 55, 320, 53.33m, 1, false, false, types(Pokemon.Types.Water)));
            _pokemons_disponiveis.Add(new Pokemon(055, "Golduck", 80, 82, 78, 95, 80, 85, 500, 83.33m, 1, false, true, types(Pokemon.Types.Water)));

            _pokemons_disponiveis.Add(new Pokemon(056, "Mankey", 40, 80, 35, 35, 45, 70, 305, 50.83m, 1, false, false, types(Pokemon.Types.Fighting)));
            _pokemons_disponiveis.Add(new Pokemon(057, "Primeape", 65, 105, 60, 60, 70, 95, 455, 75.83m, 1, false, true, types(Pokemon.Types.Fighting)));

            _pokemons_disponiveis.Add(new Pokemon(058, "Growlithe", 55, 70, 45, 70, 50, 60, 350, 58.33m, 1, false, false, types(Pokemon.Types.Fire)));
            _pokemons_disponiveis.Add(new Pokemon(059, "Arcanine", 90, 110, 80, 100, 80, 95, 555, 92.5m, 1, false, true, types(Pokemon.Types.Fire)));

            _pokemons_disponiveis.Add(new Pokemon(060, "Poliwag", 40, 50, 40, 40, 40, 90, 300, 50m, 1, false, false, types(Pokemon.Types.Water)));
            _pokemons_disponiveis.Add(new Pokemon(061, "Poliwhirl", 65, 65, 65, 50, 50, 90, 385, 64.17m, 1, false, false, types(Pokemon.Types.Water)));
            _pokemons_disponiveis.Add(new Pokemon(062, "Poliwrath", 90, 95, 95, 70, 90, 70, 510, 85m, 1, false, true, types(Pokemon.Types.Water, Pokemon.Types.Fighting)));

            _pokemons_disponiveis.Add(new Pokemon(063, "Abra", 25, 20, 15, 105, 55, 90, 310, 51.67m, 1, false, false, types(Pokemon.Types.Psychic)));
            _pokemons_disponiveis.Add(new Pokemon(064, "Kadabra", 40, 35, 30, 120, 70, 105, 400, 66.67m, 1, false, false, types(Pokemon.Types.Psychic)));
            _pokemons_disponiveis.Add(new Pokemon(065, "Alakazam", 55, 50, 45, 135, 95, 120, 500, 83.33m, 1, false, true, types(Pokemon.Types.Psychic),
                new Pokemon[] { new Pokemon(065, "Mega Alakazam", 55, 50, 65, 175, 95, 150, 590, 98.33m, 6, false, true, types(Pokemon.Types.Psychic)) }));

            _pokemons_disponiveis.Add(new Pokemon(066, "Machop", 70, 80, 50, 35, 35, 35, 305, 50.83m, 1, false, false, types(Pokemon.Types.Fighting)));
            _pokemons_disponiveis.Add(new Pokemon(067, "Machoke", 80, 100, 70, 50, 60, 45, 405, 67.5m, 1, false, false, types(Pokemon.Types.Fighting)));
            _pokemons_disponiveis.Add(new Pokemon(068, "Machamp", 90, 130, 80, 65, 85, 55, 505, 84.17m, 1, false, true, types(Pokemon.Types.Fighting)));

            _pokemons_disponiveis.Add(new Pokemon(069, "Bellsprout", 50, 75, 35, 70, 30, 40, 300, 50m, 1, false, false, types(Pokemon.Types.Grass, Pokemon.Types.Poison)));
            _pokemons_disponiveis.Add(new Pokemon(070, "Weepinbell", 65, 90, 50, 85, 45, 55, 390, 65m, 1, false, false, types(Pokemon.Types.Grass, Pokemon.Types.Poison)));
            _pokemons_disponiveis.Add(new Pokemon(071, "Victreebel", 80, 105, 65, 100, 70, 70, 490, 81.67m, 1, false, true, types(Pokemon.Types.Grass, Pokemon.Types.Poison)));

            _pokemons_disponiveis.Add(new Pokemon(072, "Tentacool", 40, 40, 35, 50, 100, 70, 335, 55.83m, 1, false, false, types(Pokemon.Types.Water)));
            _pokemons_disponiveis.Add(new Pokemon(073, "Tentacruel", 80, 70, 65, 80, 120, 100, 515, 85.83m, 1, false, true, types(Pokemon.Types.Water, Pokemon.Types.Poison)));

            _pokemons_disponiveis.Add(new Pokemon(074, "Geodude", 40, 80, 100, 30, 30, 20, 300, 50m, 1, false, false, types(Pokemon.Types.Rock, Pokemon.Types.Ground)));
            _pokemons_disponiveis.Add(new Pokemon(075, "Graveler", 55, 95, 115, 45, 45, 35, 390, 65m, 1, false, false, types(Pokemon.Types.Rock, Pokemon.Types.Ground)));
            _pokemons_disponiveis.Add(new Pokemon(076, "Golem", 80, 120, 130, 55, 65, 45, 495, 82.5m, 1, false, true, types(Pokemon.Types.Rock, Pokemon.Types.Ground)));

            _pokemons_disponiveis.Add(new Pokemon(077, "Ponyta", 50, 85, 55, 65, 65, 90, 410, 68.33m, 1, false, false, types(Pokemon.Types.Fire)));
            _pokemons_disponiveis.Add(new Pokemon(078, "Rapidash", 65, 100, 70, 80, 80, 105, 500, 83.33m, 1, false, true, types(Pokemon.Types.Fire)));

            _pokemons_disponiveis.Add(new Pokemon(079, "Slowpoke", 90, 65, 65, 40, 40, 15, 315, 52.5m, 1, false, false, types(Pokemon.Types.Water, Pokemon.Types.Psychic)));
            _pokemons_disponiveis.Add(new Pokemon(080, "Slowbro", 95, 75, 110, 100, 80, 30, 490, 81.67m, 1, false, true, types(Pokemon.Types.Water, Pokemon.Types.Psychic),
                new Pokemon[] { new Pokemon(080, "Mega Slowbro", 95, 75, 180, 130, 80, 30, 590, 98.33m, 6, false, true, types(Pokemon.Types.Water, Pokemon.Types.Psychic)) }));

            _pokemons_disponiveis.Add(new Pokemon(081, "Magnemite", 25, 35, 70, 95, 55, 45, 325, 54.17m, 1, false, false, types(Pokemon.Types.Electric, Pokemon.Types.Steel)));
            _pokemons_disponiveis.Add(new Pokemon(082, "Magneton", 50, 60, 95, 120, 70, 70, 465, 77.5m, 1, false, false, types(Pokemon.Types.Electric, Pokemon.Types.Steel)));

            _pokemons_disponiveis.Add(new Pokemon(083, "Farfetch'd", 52, 65, 55, 58, 62, 60, 352, 58.67m, 1));

            _pokemons_disponiveis.Add(new Pokemon(084, "Doduo", 35, 85, 45, 35, 35, 75, 310, 51.67m, 1));
            _pokemons_disponiveis.Add(new Pokemon(085, "Dodrio", 60, 110, 70, 60, 60, 100, 460, 76.67m, 1));

            _pokemons_disponiveis.Add(new Pokemon(086, "Seel", 65, 45, 55, 45, 70, 45, 325, 54.17m, 1));
            _pokemons_disponiveis.Add(new Pokemon(087, "Dewgong", 90, 70, 80, 70, 95, 70, 475, 79.17m, 1));

            _pokemons_disponiveis.Add(new Pokemon(088, "Grimer", 80, 80, 50, 40, 50, 25, 325, 54.17m, 1));
            _pokemons_disponiveis.Add(new Pokemon(089, "Muk", 105, 105, 75, 65, 100, 50, 500, 83.33m, 1));

            _pokemons_disponiveis.Add(new Pokemon(090, "Shellder", 30, 65, 100, 45, 25, 40, 305, 50.83m, 1));
            _pokemons_disponiveis.Add(new Pokemon(091, "Cloyster", 50, 95, 180, 85, 45, 70, 525, 87.5m, 1));

            _pokemons_disponiveis.Add(new Pokemon(092, "Gastly", 30, 35, 30, 100, 35, 80, 310, 51.67m, 1));
            _pokemons_disponiveis.Add(new Pokemon(093, "Haunter", 45, 50, 45, 115, 55, 95, 405, 67.5m, 1));
            _pokemons_disponiveis.Add(new Pokemon(094, "Gengar", 60, 65, 60, 130, 75, 110, 500, 83.33m, 1,
                new Pokemon[] { new Pokemon(094, "Mega Gengar", 60, 65, 80, 170, 95, 130, 600, 100m, 6) }));

            _pokemons_disponiveis.Add(new Pokemon(095, "Onix", 35, 45, 160, 30, 45, 70, 385, 64.17m, 1));

            _pokemons_disponiveis.Add(new Pokemon(096, "Drowzee", 60, 48, 45, 43, 90, 42, 328, 54.67m, 1, false, false, types(Pokemon.Types.Psychic)));
            _pokemons_disponiveis.Add(new Pokemon(097, "Hypno", 85, 73, 70, 73, 115, 67, 483, 80.5m, 1, false, true, types(Pokemon.Types.Psychic)));

            _pokemons_disponiveis.Add(new Pokemon(098, "Krabby", 30, 105, 90, 25, 25, 50, 325, 54.17m, 1, false, false, types(Pokemon.Types.Water)));
            _pokemons_disponiveis.Add(new Pokemon(099, "Kingler", 55, 130, 115, 50, 50, 75, 475, 79.17m, 1, false, true, types(Pokemon.Types.Water)));

            _pokemons_disponiveis.Add(new Pokemon(100, "Voltorb", 40, 30, 50, 55, 55, 100, 330, 55m, 1));
            _pokemons_disponiveis.Add(new Pokemon(101, "Electrode", 60, 50, 70, 80, 80, 140, 480, 80m, 1));

            _pokemons_disponiveis.Add(new Pokemon(102, "Exeggcute", 60, 40, 80, 60, 45, 40, 325, 54.17m, 1));
            _pokemons_disponiveis.Add(new Pokemon(103, "Exeggutor", 95, 95, 85, 125, 65, 55, 520, 86.67m, 1));

            _pokemons_disponiveis.Add(new Pokemon(104, "Cubone", 50, 50, 95, 40, 50, 35, 320, 53.33m, 1));
            _pokemons_disponiveis.Add(new Pokemon(105, "Marowak", 60, 80, 110, 50, 80, 45, 425, 70.83m, 1));

            _pokemons_disponiveis.Add(new Pokemon(106, "Hitmonlee", 50, 120, 53, 35, 110, 87, 455, 75.83m, 1));

            _pokemons_disponiveis.Add(new Pokemon(107, "Hitmonchan", 50, 105, 79, 35, 110, 76, 455, 75.83m, 1));

            _pokemons_disponiveis.Add(new Pokemon(108, "Lickitung", 90, 55, 75, 60, 75, 30, 385, 64.17m, 1));

            _pokemons_disponiveis.Add(new Pokemon(109, "Koffing", 40, 65, 95, 60, 45, 35, 340, 56.67m, 1));
            _pokemons_disponiveis.Add(new Pokemon(110, "Weezing", 65, 90, 120, 85, 70, 60, 490, 81.67m, 1));

            _pokemons_disponiveis.Add(new Pokemon(111, "Rhyhorn", 80, 85, 95, 30, 30, 25, 345, 57.5m, 1));
            _pokemons_disponiveis.Add(new Pokemon(112, "Rhydon", 105, 130, 120, 45, 45, 40, 485, 80.83m, 1));

            _pokemons_disponiveis.Add(new Pokemon(113, "Chansey", 250, 5, 5, 35, 105, 50, 450, 75m, 1));

            _pokemons_disponiveis.Add(new Pokemon(114, "Tangela", 65, 55, 115, 100, 40, 60, 435, 72.5m, 1));

            _pokemons_disponiveis.Add(new Pokemon(115, "Kangaskhan", 105, 95, 80, 40, 80, 90, 490, 81.67m, 1,
                new Pokemon[] { new Pokemon(115, "Mega Kangaskhan", 105, 125, 100, 60, 100, 100, 590, 98.33m, 6) }));

            _pokemons_disponiveis.Add(new Pokemon(116, "Horsea", 30, 40, 70, 70, 25, 60, 295, 49.17m, 1, false, false, types(Pokemon.Types.Water)));
            _pokemons_disponiveis.Add(new Pokemon(117, "Seadra", 55, 65, 95, 95, 45, 85, 440, 73.33m, 1, false, false, types(Pokemon.Types.Water)));

            _pokemons_disponiveis.Add(new Pokemon(118, "Goldeen", 45, 67, 60, 35, 50, 63, 320, 53.33m, 1, false, false, types(Pokemon.Types.Water)));
            _pokemons_disponiveis.Add(new Pokemon(119, "Seaking", 80, 92, 65, 65, 80, 68, 450, 75m, 1, false, true, types(Pokemon.Types.Water)));

            _pokemons_disponiveis.Add(new Pokemon(120, "Staryu", 30, 45, 55, 70, 55, 85, 340, 56.67m, 1, false, false, types(Pokemon.Types.Water)));
            _pokemons_disponiveis.Add(new Pokemon(121, "Starmie", 60, 75, 85, 100, 85, 115, 520, 86.67m, 1, false, true, types(Pokemon.Types.Water, Pokemon.Types.Psychic)));

            _pokemons_disponiveis.Add(new Pokemon(122, "Mr. Mime", 40, 45, 65, 100, 120, 90, 460, 76.67m, 1, false, true, types(Pokemon.Types.Psychic)));

            _pokemons_disponiveis.Add(new Pokemon(123, "Scyther", 70, 110, 80, 55, 80, 105, 500, 83.33m, 1));

            _pokemons_disponiveis.Add(new Pokemon(124, "Jynx", 65, 50, 35, 115, 95, 95, 455, 75.83m, 1));

            _pokemons_disponiveis.Add(new Pokemon(125, "Electabuzz", 65, 83, 57, 95, 85, 105, 490, 81.67m, 1));

            _pokemons_disponiveis.Add(new Pokemon(126, "Magmar", 65, 95, 57, 100, 85, 93, 495, 82.5m, 1, false, false, types(Pokemon.Types.Fire)));

            _pokemons_disponiveis.Add(new Pokemon(127, "Pinsir", 65, 125, 100, 55, 70, 85, 500, 83.33m, 1,
                new Pokemon[] { new Pokemon(127, "Mega Pinsir", 65, 155, 120, 65, 90, 105, 600, 100m, 6) }));

            _pokemons_disponiveis.Add(new Pokemon(128, "Tauros", 75, 100, 95, 40, 70, 110, 490, 81.67m, 1));

            _pokemons_disponiveis.Add(new Pokemon(129, "Magikarp", 20, 10, 55, 15, 20, 80, 200, 33.33m, 1));
            _pokemons_disponiveis.Add(new Pokemon(130, "Gyarados", 95, 125, 79, 60, 100, 81, 540, 90m, 1,
                new Pokemon[] { new Pokemon(130, "Mega Gyarados", 95, 155, 109, 70, 130, 81, 640, 106.67m, 6) }));

            _pokemons_disponiveis.Add(new Pokemon(131, "Lapras", 130, 85, 80, 85, 95, 60, 535, 89.17m, 1));

            _pokemons_disponiveis.Add(new Pokemon(132, "Ditto", 48, 48, 48, 48, 48, 48, 288, 48m, 1, false, true, types(Pokemon.Types.Normal)));

            _pokemons_disponiveis.Add(new Pokemon(133, "Eevee", 55, 55, 50, 45, 65, 55, 325, 54.17m, 1));
            _pokemons_disponiveis.Add(new Pokemon(134, "Vaporeon", 130, 65, 60, 110, 95, 65, 525, 87.5m, 1));
            _pokemons_disponiveis.Add(new Pokemon(135, "Jolteon", 65, 65, 60, 110, 95, 130, 525, 87.5m, 1, false, true, types(Pokemon.Types.Water)));
            _pokemons_disponiveis.Add(new Pokemon(136, "Flareon", 65, 130, 60, 95, 110, 65, 525, 87.5m, 1, false, true, types(Pokemon.Types.Fire)));

            _pokemons_disponiveis.Add(new Pokemon(137, "Porygon", 65, 60, 70, 85, 75, 40, 395, 65.83m, 1));

            _pokemons_disponiveis.Add(new Pokemon(138, "Omanyte", 35, 40, 100, 90, 55, 35, 355, 59.17m, 1));
            _pokemons_disponiveis.Add(new Pokemon(139, "Omastar", 70, 60, 125, 115, 70, 55, 495, 82.5m, 1));

            _pokemons_disponiveis.Add(new Pokemon(140, "Kabuto", 30, 80, 90, 55, 45, 55, 355, 59.17m, 1));
            _pokemons_disponiveis.Add(new Pokemon(141, "Kabutops", 60, 115, 105, 65, 70, 80, 495, 82.5m, 1));

            _pokemons_disponiveis.Add(new Pokemon(142, "Aerodactyl", 80, 105, 65, 60, 75, 130, 515, 85.83m, 1,
                new Pokemon[] { new Pokemon(142, "Mega Aerodactyl", 80, 135, 85, 70, 95, 150, 615, 102.5m, 6) }));

            _pokemons_disponiveis.Add(new Pokemon(143, "Snorlax", 160, 110, 65, 65, 110, 30, 540, 90m, 1, false, true, types(Pokemon.Types.Normal)));

            _pokemons_disponiveis.Add(new Pokemon(144, "Articuno", 90, 85, 100, 95, 125, 85, 580, 96.67m, 1));

            _pokemons_disponiveis.Add(new Pokemon(145, "Zapdos", 90, 90, 85, 125, 90, 100, 580, 96.67m, 1));

            _pokemons_disponiveis.Add(new Pokemon(146, "Moltres", 90, 100, 90, 125, 85, 90, 580, 96.67m, 1));

            _pokemons_disponiveis.Add(new Pokemon(147, "Dratini", 41, 64, 45, 50, 50, 50, 300, 50m, 1, false, false, types(Pokemon.Types.Dragon)));
            _pokemons_disponiveis.Add(new Pokemon(148, "Dragonair", 61, 84, 65, 70, 70, 70, 420, 70m, 1, false, false, types(Pokemon.Types.Dragon)));
            _pokemons_disponiveis.Add(new Pokemon(149, "Dragonite", 91, 134, 95, 100, 100, 80, 600, 100m, 1, false, true, types(Pokemon.Types.Dragon, Pokemon.Types.Flying)));

            _pokemons_disponiveis.Add(new Pokemon(150, "Mewtwo", 106, 110, 90, 154, 90, 130, 680, 113.33m, 1, false, true, types(Pokemon.Types.Psychic),
                new Pokemon[] { new Pokemon(150, "Mega Mewtwo X", 106, 190, 100, 154, 100, 130, 780, 130m, 6, false, true, types(Pokemon.Types.Psychic, Pokemon.Types.Psychic)),
                                new Pokemon(150, "Mega Mewtwo Y", 106, 150, 70, 194, 120, 140, 780, 130m, 6, false, true, types(Pokemon.Types.Psychic)) }));

            _pokemons_disponiveis.Add(new Pokemon(151, "Mew", 100, 100, 100, 100, 100, 100, 600, 100m, 1, false, true, types(Pokemon.Types.Psychic)));


            _pokemons_disponiveis.Add(new Pokemon(152, "Chikorita", 45, 49, 65, 49, 65, 45, 318, 53m, 2));
            _pokemons_disponiveis.Add(new Pokemon(153, "Bayleef", 60, 62, 80, 63, 80, 60, 405, 67.5m, 2));
            _pokemons_disponiveis.Add(new Pokemon(154, "Meganium", 80, 82, 100, 83, 100, 80, 525, 87.5m, 2));

            _pokemons_disponiveis.Add(new Pokemon(155, "Cyndaquil", 39, 52, 43, 60, 50, 65, 309, 51.5m, 2, false, false, types(Pokemon.Types.Fire)));
            _pokemons_disponiveis.Add(new Pokemon(156, "Quilava", 58, 64, 58, 80, 65, 80, 405, 67.5m, 2, false, false, types(Pokemon.Types.Fire)));
            _pokemons_disponiveis.Add(new Pokemon(157, "Typhlosion", 78, 84, 78, 109, 85, 100, 534, 89m, 2, false, true, types(Pokemon.Types.Fire)));

            _pokemons_disponiveis.Add(new Pokemon(158, "Totodile", 50, 65, 64, 44, 48, 43, 314, 52.33m, 2));
            _pokemons_disponiveis.Add(new Pokemon(159, "Croconaw", 65, 80, 80, 59, 63, 58, 405, 67.5m, 2));
            _pokemons_disponiveis.Add(new Pokemon(160, "Feraligatr", 85, 105, 100, 79, 83, 78, 530, 88.33m, 2));
            _pokemons_disponiveis.Add(new Pokemon(161, "Sentret", 35, 46, 34, 35, 45, 20, 215, 35.83m, 2));
            _pokemons_disponiveis.Add(new Pokemon(162, "Furret", 85, 76, 64, 45, 55, 90, 415, 69.17m, 2));
            _pokemons_disponiveis.Add(new Pokemon(163, "Hoothoot", 60, 30, 30, 36, 56, 50, 262, 43.67m, 2));
            _pokemons_disponiveis.Add(new Pokemon(164, "Noctowl", 100, 50, 50, 76, 96, 70, 442, 73.67m, 2));
            _pokemons_disponiveis.Add(new Pokemon(165, "Ledyba", 40, 20, 30, 40, 80, 55, 265, 44.17m, 2));
            _pokemons_disponiveis.Add(new Pokemon(166, "Ledian", 55, 35, 50, 55, 110, 85, 390, 65m, 2));
            _pokemons_disponiveis.Add(new Pokemon(167, "Spinarak", 40, 60, 40, 40, 40, 30, 250, 41.67m, 2));
            _pokemons_disponiveis.Add(new Pokemon(168, "Ariados", 70, 90, 70, 60, 60, 40, 390, 65m, 2));
            _pokemons_disponiveis.Add(new Pokemon(169, "Crobat", 85, 90, 80, 70, 80, 130, 535, 89.17m, 2));
            _pokemons_disponiveis.Add(new Pokemon(170, "Chinchou", 75, 38, 38, 56, 56, 67, 330, 55m, 2));
            _pokemons_disponiveis.Add(new Pokemon(171, "Lanturn", 125, 58, 58, 76, 76, 67, 460, 76.67m, 2));
            _pokemons_disponiveis.Add(new Pokemon(172, "Pichu", 20, 40, 15, 35, 35, 60, 205, 34.17m, 2));
            _pokemons_disponiveis.Add(new Pokemon(173, "Cleffa", 50, 25, 28, 45, 55, 15, 218, 36.33m, 2));
            _pokemons_disponiveis.Add(new Pokemon(174, "Igglybuff", 90, 30, 15, 40, 20, 15, 210, 35m, 2));
            _pokemons_disponiveis.Add(new Pokemon(175, "Togepi", 35, 20, 65, 40, 65, 20, 245, 40.83m, 2));
            _pokemons_disponiveis.Add(new Pokemon(176, "Togetic", 55, 40, 85, 80, 105, 40, 405, 67.5m, 2));
            _pokemons_disponiveis.Add(new Pokemon(177, "Natu", 40, 50, 45, 70, 45, 70, 320, 53.33m, 2));
            _pokemons_disponiveis.Add(new Pokemon(178, "Xatu", 65, 75, 70, 95, 70, 95, 470, 78.33m, 2));
            _pokemons_disponiveis.Add(new Pokemon(179, "Mareep", 55, 40, 40, 65, 45, 35, 280, 46.67m, 2));
            _pokemons_disponiveis.Add(new Pokemon(180, "Flaaffy", 70, 55, 55, 80, 60, 45, 365, 60.83m, 2));
            _pokemons_disponiveis.Add(new Pokemon(181, "Ampharos", 90, 75, 85, 115, 90, 55, 510, 85m, 2,
                new Pokemon[] { new Pokemon(181, "Mega Ampharos", 90, 95, 105, 165, 110, 45, 610, 101.67m, 6) }));

            _pokemons_disponiveis.Add(new Pokemon(182, "Bellossom", 75, 80, 95, 90, 100, 50, 490, 81.67m, 2));
            _pokemons_disponiveis.Add(new Pokemon(183, "Marill", 70, 20, 50, 20, 50, 40, 250, 41.67m, 2));
            _pokemons_disponiveis.Add(new Pokemon(184, "Azumarill", 100, 50, 80, 60, 80, 50, 420, 70m, 2));
            _pokemons_disponiveis.Add(new Pokemon(185, "Sudowoodo", 70, 100, 115, 30, 65, 30, 410, 68.33m, 2));
            _pokemons_disponiveis.Add(new Pokemon(186, "Politoed", 90, 75, 75, 90, 100, 70, 500, 83.33m, 2));
            _pokemons_disponiveis.Add(new Pokemon(187, "Hoppip", 35, 35, 40, 35, 55, 50, 250, 41.67m, 2));
            _pokemons_disponiveis.Add(new Pokemon(188, "Skiploom", 55, 45, 50, 45, 65, 80, 340, 56.67m, 2));
            _pokemons_disponiveis.Add(new Pokemon(189, "Jumpluff", 75, 55, 70, 55, 95, 110, 460, 76.67m, 2));
            _pokemons_disponiveis.Add(new Pokemon(190, "Aipom", 55, 70, 55, 40, 55, 85, 360, 60m, 2));
            _pokemons_disponiveis.Add(new Pokemon(191, "Sunkern", 30, 30, 30, 30, 30, 30, 180, 30m, 2));
            _pokemons_disponiveis.Add(new Pokemon(192, "Sunflora", 75, 75, 55, 105, 85, 30, 425, 70.83m, 2));
            _pokemons_disponiveis.Add(new Pokemon(193, "Yanma", 65, 65, 45, 75, 45, 95, 390, 65m, 2));
            _pokemons_disponiveis.Add(new Pokemon(194, "Wooper", 55, 45, 45, 25, 25, 15, 210, 35m, 2));
            _pokemons_disponiveis.Add(new Pokemon(195, "Quagsire", 95, 85, 85, 65, 65, 35, 430, 71.67m, 2));
            _pokemons_disponiveis.Add(new Pokemon(196, "Espeon", 65, 65, 60, 130, 95, 110, 525, 87.5m, 2));
            _pokemons_disponiveis.Add(new Pokemon(197, "Umbreon", 95, 65, 110, 60, 130, 65, 525, 87.5m, 2));
            _pokemons_disponiveis.Add(new Pokemon(198, "Murkrow", 60, 85, 42, 85, 42, 91, 405, 67.5m, 2));
            _pokemons_disponiveis.Add(new Pokemon(199, "Slowking", 95, 75, 80, 100, 110, 30, 490, 81.67m, 2));
            _pokemons_disponiveis.Add(new Pokemon(200, "Misdreavus", 60, 60, 60, 85, 85, 85, 435, 72.5m, 2));
            _pokemons_disponiveis.Add(new Pokemon(201, "Unown", 48, 72, 48, 72, 48, 48, 336, 56m, 2));
            _pokemons_disponiveis.Add(new Pokemon(202, "Wobbuffet", 190, 33, 58, 33, 58, 33, 405, 67.5m, 2));
            _pokemons_disponiveis.Add(new Pokemon(203, "Girafarig", 70, 80, 65, 90, 65, 85, 455, 75.83m, 2));
            _pokemons_disponiveis.Add(new Pokemon(204, "Pineco", 50, 65, 90, 35, 35, 15, 290, 48.33m, 2));
            _pokemons_disponiveis.Add(new Pokemon(205, "Forretress", 75, 90, 140, 60, 60, 40, 465, 77.5m, 2));
            _pokemons_disponiveis.Add(new Pokemon(206, "Dunsparce", 100, 70, 70, 65, 65, 45, 415, 69.17m, 2));
            _pokemons_disponiveis.Add(new Pokemon(207, "Gligar", 65, 75, 105, 35, 65, 85, 430, 71.67m, 2));
            _pokemons_disponiveis.Add(new Pokemon(208, "Steelix", 75, 85, 200, 55, 65, 30, 510, 85m, 2,
                            new Pokemon[] { new Pokemon(208, "Mega Steelix", 75, 125, 230, 55, 95, 30, 610, 101.67m, 6) }));

            _pokemons_disponiveis.Add(new Pokemon(209, "Snubbull", 60, 80, 50, 40, 40, 30, 300, 50m, 2));
            _pokemons_disponiveis.Add(new Pokemon(210, "Granbull", 90, 120, 75, 60, 60, 45, 450, 75m, 2));
            _pokemons_disponiveis.Add(new Pokemon(211, "Qwilfish", 65, 95, 75, 55, 55, 85, 430, 71.67m, 2));
            _pokemons_disponiveis.Add(new Pokemon(212, "Scizor", 70, 130, 100, 55, 80, 65, 500, 83.33m, 2,
                            new Pokemon[] { new Pokemon(212, "Mega Scizor", 70, 150, 140, 65, 100, 75, 600, 100m, 6) }));

            _pokemons_disponiveis.Add(new Pokemon(213, "Shuckle", 20, 10, 230, 10, 230, 5, 505, 84.17m, 2));
            _pokemons_disponiveis.Add(new Pokemon(214, "Heracross", 80, 125, 75, 40, 95, 85, 500, 83.33m, 2,
                            new Pokemon[] { new Pokemon(214, "Mega Heracross", 80, 185, 115, 40, 105, 75, 600, 100m, 6) }));

            _pokemons_disponiveis.Add(new Pokemon(215, "Sneasel", 55, 95, 55, 35, 75, 115, 430, 71.67m, 2));
            _pokemons_disponiveis.Add(new Pokemon(216, "Teddiursa", 60, 80, 50, 50, 50, 40, 330, 55m, 2));
            _pokemons_disponiveis.Add(new Pokemon(217, "Ursaring", 90, 130, 75, 75, 75, 55, 500, 83.33m, 2));
            _pokemons_disponiveis.Add(new Pokemon(218, "Slugma", 40, 40, 40, 70, 40, 20, 250, 41.67m, 2));
            _pokemons_disponiveis.Add(new Pokemon(219, "Magcargo", 50, 50, 120, 80, 80, 30, 410, 68.33m, 2));
            _pokemons_disponiveis.Add(new Pokemon(220, "Swinub", 50, 50, 40, 30, 30, 50, 250, 41.67m, 2));
            _pokemons_disponiveis.Add(new Pokemon(221, "Piloswine", 100, 100, 80, 60, 60, 50, 450, 75m, 2));
            _pokemons_disponiveis.Add(new Pokemon(222, "Corsola", 55, 55, 85, 65, 85, 35, 380, 63.33m, 2));
            _pokemons_disponiveis.Add(new Pokemon(223, "Remoraid", 35, 65, 35, 65, 35, 65, 300, 50m, 2));
            _pokemons_disponiveis.Add(new Pokemon(224, "Octillery", 75, 105, 75, 105, 75, 45, 480, 80m, 2));
            _pokemons_disponiveis.Add(new Pokemon(225, "Delibird", 45, 55, 45, 65, 45, 75, 330, 55m, 2));
            _pokemons_disponiveis.Add(new Pokemon(226, "Mantine", 65, 40, 70, 80, 140, 70, 465, 77.5m, 2));
            _pokemons_disponiveis.Add(new Pokemon(227, "Skarmory", 65, 80, 140, 40, 70, 70, 465, 77.5m, 2));
            _pokemons_disponiveis.Add(new Pokemon(228, "Houndour", 45, 60, 30, 80, 50, 65, 330, 55m, 2));
            _pokemons_disponiveis.Add(new Pokemon(229, "Houndoom", 75, 90, 50, 110, 80, 95, 500, 83.33m, 2,
                            new Pokemon[] { new Pokemon(229, "Mega Houndoom", 75, 90, 90, 140, 90, 115, 600, 100m, 6) }));

            _pokemons_disponiveis.Add(new Pokemon(230, "Kingdra", 75, 95, 95, 95, 95, 85, 540, 90m, 2));
            _pokemons_disponiveis.Add(new Pokemon(231, "Phanpy", 90, 60, 60, 40, 40, 40, 330, 55m, 2));
            _pokemons_disponiveis.Add(new Pokemon(232, "Donphan", 90, 120, 120, 60, 60, 50, 500, 83.33m, 2));
            _pokemons_disponiveis.Add(new Pokemon(233, "Porygon2", 85, 80, 90, 105, 95, 60, 515, 85.83m, 2));
            _pokemons_disponiveis.Add(new Pokemon(234, "Stantler", 73, 95, 62, 85, 65, 85, 465, 77.5m, 2));
            _pokemons_disponiveis.Add(new Pokemon(235, "Smeargle", 55, 20, 35, 20, 45, 75, 250, 41.67m, 2));
            _pokemons_disponiveis.Add(new Pokemon(236, "Tyrogue", 35, 35, 35, 35, 35, 35, 210, 35m, 2));
            _pokemons_disponiveis.Add(new Pokemon(237, "Hitmontop", 50, 95, 95, 35, 110, 70, 455, 75.83m, 2));
            _pokemons_disponiveis.Add(new Pokemon(238, "Smoochum", 45, 30, 15, 85, 65, 65, 305, 50.83m, 2));
            _pokemons_disponiveis.Add(new Pokemon(239, "Elekid", 45, 63, 37, 65, 55, 95, 360, 60m, 2));
            _pokemons_disponiveis.Add(new Pokemon(240, "Magby", 45, 75, 37, 70, 55, 83, 365, 60.83m, 2));
            _pokemons_disponiveis.Add(new Pokemon(241, "Miltank", 95, 80, 105, 40, 70, 100, 490, 81.67m, 2));
            _pokemons_disponiveis.Add(new Pokemon(242, "Blissey", 255, 10, 10, 75, 135, 55, 540, 90m, 2));
            _pokemons_disponiveis.Add(new Pokemon(243, "Raikou", 90, 85, 75, 115, 100, 115, 580, 96.67m, 2));
            _pokemons_disponiveis.Add(new Pokemon(244, "Entei", 115, 115, 85, 90, 75, 100, 580, 96.67m, 2));
            _pokemons_disponiveis.Add(new Pokemon(245, "Suicune", 100, 75, 115, 90, 115, 85, 580, 96.67m, 2));
            _pokemons_disponiveis.Add(new Pokemon(246, "Larvitar", 50, 64, 50, 45, 50, 41, 300, 50m, 2));
            _pokemons_disponiveis.Add(new Pokemon(247, "Pupitar", 70, 84, 70, 65, 70, 51, 410, 68.33m, 2));
            _pokemons_disponiveis.Add(new Pokemon(248, "Tyranitar", 100, 134, 110, 95, 100, 61, 600, 100m, 2,
                new Pokemon[] { new Pokemon(248, "Mega Tyranitar", 100, 164, 150, 95, 120, 71, 700, 116.67m, 6) }));

            _pokemons_disponiveis.Add(new Pokemon(249, "Lugia", 106, 90, 130, 90, 154, 110, 680, 113.33m, 2));
            _pokemons_disponiveis.Add(new Pokemon(250, "Ho-Oh", 106, 130, 90, 110, 154, 90, 680, 113.33m, 2));
            _pokemons_disponiveis.Add(new Pokemon(251, "Celebi", 100, 100, 100, 100, 100, 100, 600, 100m, 2));
            _pokemons_disponiveis.Add(new Pokemon(252, "Treecko", 40, 45, 35, 65, 55, 70, 310, 51.67m, 3));
            _pokemons_disponiveis.Add(new Pokemon(253, "Grovyle", 50, 65, 45, 85, 65, 95, 405, 67.5m, 3));
            _pokemons_disponiveis.Add(new Pokemon(254, "Sceptile", 70, 85, 65, 105, 85, 120, 530, 88.33m, 3,
                            new Pokemon[] { new Pokemon(254, "Mega Sceptile", 70, 110, 75, 145, 85, 145, 630, 105m, 6) }));

            _pokemons_disponiveis.Add(new Pokemon(255, "Torchic", 45, 60, 40, 70, 50, 45, 310, 51.67m, 3));
            _pokemons_disponiveis.Add(new Pokemon(256, "Combusken", 60, 85, 60, 85, 60, 55, 405, 67.5m, 3));
            _pokemons_disponiveis.Add(new Pokemon(257, "Blaziken", 80, 120, 70, 110, 70, 80, 530, 88.33m, 3,
                            new Pokemon[] { new Pokemon(257, "Mega Blaziken", 80, 160, 80, 130, 80, 100, 630, 105m, 6) }));

            _pokemons_disponiveis.Add(new Pokemon(258, "Mudkip", 50, 70, 50, 50, 50, 40, 310, 51.67m, 3));
            _pokemons_disponiveis.Add(new Pokemon(259, "Marshtomp", 70, 85, 70, 60, 70, 50, 405, 67.5m, 3));
            _pokemons_disponiveis.Add(new Pokemon(260, "Swampert", 100, 110, 90, 85, 90, 60, 535, 89.17m, 3,
                            new Pokemon[] { new Pokemon(260, "Mega Swampert", 100, 150, 110, 95, 110, 70, 635, 105.83m, 6) }));

            _pokemons_disponiveis.Add(new Pokemon(261, "Poochyena", 35, 55, 35, 30, 30, 35, 220, 36.67m, 3));
            _pokemons_disponiveis.Add(new Pokemon(262, "Mightyena", 70, 90, 70, 60, 60, 70, 420, 70m, 3));
            _pokemons_disponiveis.Add(new Pokemon(263, "Zigzagoon", 38, 30, 41, 30, 41, 60, 240, 40m, 3));
            _pokemons_disponiveis.Add(new Pokemon(264, "Linoone", 78, 70, 61, 50, 61, 100, 420, 70m, 3));
            _pokemons_disponiveis.Add(new Pokemon(265, "Wurmple", 45, 45, 35, 20, 30, 20, 195, 32.5m, 3));
            _pokemons_disponiveis.Add(new Pokemon(266, "Silcoon", 50, 35, 55, 25, 25, 15, 205, 34.17m, 3));
            _pokemons_disponiveis.Add(new Pokemon(267, "Beautifly", 60, 70, 50, 100, 50, 65, 395, 65.83m, 3));
            _pokemons_disponiveis.Add(new Pokemon(268, "Cascoon", 50, 35, 55, 25, 25, 15, 205, 34.17m, 3));
            _pokemons_disponiveis.Add(new Pokemon(269, "Dustox", 60, 50, 70, 50, 90, 65, 385, 64.17m, 3));
            _pokemons_disponiveis.Add(new Pokemon(270, "Lotad", 40, 30, 30, 40, 50, 30, 220, 36.67m, 3));
            _pokemons_disponiveis.Add(new Pokemon(271, "Lombre", 60, 50, 50, 60, 70, 50, 340, 56.67m, 3));
            _pokemons_disponiveis.Add(new Pokemon(272, "Ludicolo", 80, 70, 70, 90, 100, 70, 480, 80m, 3));
            _pokemons_disponiveis.Add(new Pokemon(273, "Seedot", 40, 40, 50, 30, 30, 30, 220, 36.67m, 3));
            _pokemons_disponiveis.Add(new Pokemon(274, "Nuzleaf", 70, 70, 40, 60, 40, 60, 340, 56.67m, 3));
            _pokemons_disponiveis.Add(new Pokemon(275, "Shiftry", 90, 100, 60, 90, 60, 80, 480, 80m, 3));
            _pokemons_disponiveis.Add(new Pokemon(276, "Taillow", 40, 55, 30, 30, 30, 85, 270, 45m, 3));
            _pokemons_disponiveis.Add(new Pokemon(277, "Swellow", 60, 85, 60, 50, 50, 125, 430, 71.67m, 3));
            _pokemons_disponiveis.Add(new Pokemon(278, "Wingull", 40, 30, 30, 55, 30, 85, 270, 45m, 3));
            _pokemons_disponiveis.Add(new Pokemon(279, "Pelipper", 60, 50, 100, 85, 70, 65, 430, 71.67m, 3));
            _pokemons_disponiveis.Add(new Pokemon(280, "Ralts", 28, 25, 25, 45, 35, 40, 198, 33m, 3));
            _pokemons_disponiveis.Add(new Pokemon(281, "Kirlia", 38, 35, 35, 65, 55, 50, 278, 46.33m, 3));
            _pokemons_disponiveis.Add(new Pokemon(282, "Gardevoir", 68, 65, 65, 125, 115, 80, 518, 86.33m, 3,
                new Pokemon[] { new Pokemon(282, "Mega Gardevoir", 68, 85, 65, 165, 135, 100, 618, 103m, 6) }));

            _pokemons_disponiveis.Add(new Pokemon(283, "Surskit", 40, 30, 32, 50, 52, 65, 269, 44.83m, 3));
            _pokemons_disponiveis.Add(new Pokemon(284, "Masquerain", 70, 60, 62, 80, 82, 60, 414, 69m, 3));
            _pokemons_disponiveis.Add(new Pokemon(285, "Shroomish", 60, 40, 60, 40, 60, 35, 295, 49.17m, 3));
            _pokemons_disponiveis.Add(new Pokemon(286, "Breloom", 60, 130, 80, 60, 60, 70, 460, 76.67m, 3));
            _pokemons_disponiveis.Add(new Pokemon(287, "Slakoth", 60, 60, 60, 35, 35, 30, 280, 46.67m, 3));
            _pokemons_disponiveis.Add(new Pokemon(288, "Vigoroth", 80, 80, 80, 55, 55, 90, 440, 73.33m, 3));
            _pokemons_disponiveis.Add(new Pokemon(289, "Slaking", 150, 160, 100, 95, 65, 100, 670, 111.67m, 3));
            _pokemons_disponiveis.Add(new Pokemon(290, "Nincada", 31, 45, 90, 30, 30, 40, 266, 44.33m, 3));
            _pokemons_disponiveis.Add(new Pokemon(291, "Ninjask", 61, 90, 45, 50, 50, 160, 456, 76m, 3));
            _pokemons_disponiveis.Add(new Pokemon(292, "Shedinja", 1, 90, 45, 30, 30, 40, 236, 39.33m, 3));
            _pokemons_disponiveis.Add(new Pokemon(293, "Whismur", 64, 51, 23, 51, 23, 28, 240, 40m, 3));
            _pokemons_disponiveis.Add(new Pokemon(294, "Loudred", 84, 71, 43, 71, 43, 48, 360, 60m, 3));
            _pokemons_disponiveis.Add(new Pokemon(295, "Exploud", 104, 91, 63, 91, 73, 68, 490, 81.67m, 3));
            _pokemons_disponiveis.Add(new Pokemon(296, "Makuhita", 72, 60, 30, 20, 30, 25, 237, 39.5m, 3));
            _pokemons_disponiveis.Add(new Pokemon(297, "Hariyama", 144, 120, 60, 40, 60, 50, 474, 79m, 3));
            _pokemons_disponiveis.Add(new Pokemon(298, "Azurill", 50, 20, 40, 20, 40, 20, 190, 31.67m, 3));
            _pokemons_disponiveis.Add(new Pokemon(299, "Nosepass", 30, 45, 135, 45, 90, 30, 375, 62.5m, 3));
            _pokemons_disponiveis.Add(new Pokemon(300, "Skitty", 50, 45, 45, 35, 35, 50, 260, 43.33m, 3));
            _pokemons_disponiveis.Add(new Pokemon(301, "Delcatty", 70, 65, 65, 55, 55, 70, 380, 63.33m, 3));
            _pokemons_disponiveis.Add(new Pokemon(302, "Sableye", 50, 75, 75, 65, 65, 50, 380, 63.33m, 3,
                new Pokemon[] { new Pokemon(302, "Mega Sableye", 50, 85, 125, 85, 115, 20, 480, 80m, 6) }));

            _pokemons_disponiveis.Add(new Pokemon(303, "Mawile", 50, 85, 85, 55, 55, 50, 380, 63.33m, 3,
                            new Pokemon[] { new Pokemon(303, "Mega Mawile", 50, 105, 125, 55, 95, 50, 480, 80m, 6) }));

            _pokemons_disponiveis.Add(new Pokemon(304, "Aron", 50, 70, 100, 40, 40, 30, 330, 55m, 3));
            _pokemons_disponiveis.Add(new Pokemon(305, "Lairon", 60, 90, 140, 50, 50, 40, 430, 71.67m, 3));
            _pokemons_disponiveis.Add(new Pokemon(306, "Aggron", 70, 110, 180, 60, 60, 50, 530, 88.33m, 3,
                            new Pokemon[] { new Pokemon(306, "Mega Aggron", 70, 140, 230, 60, 80, 50, 630, 105m, 6) }));

            _pokemons_disponiveis.Add(new Pokemon(307, "Meditite", 30, 40, 55, 40, 55, 60, 280, 46.67m, 3));
            _pokemons_disponiveis.Add(new Pokemon(308, "Medicham", 60, 60, 75, 60, 75, 80, 410, 68.33m, 3,
                            new Pokemon[] { new Pokemon(308, "Mega Medicham", 60, 100, 85, 80, 85, 100, 510, 85m, 6) }));

            _pokemons_disponiveis.Add(new Pokemon(309, "Electrike", 40, 45, 40, 65, 40, 65, 295, 49.17m, 3));
            _pokemons_disponiveis.Add(new Pokemon(310, "Manectric", 70, 75, 60, 105, 60, 105, 475, 79.17m, 3,
                            new Pokemon[] { new Pokemon(310, "Mega Manectric", 70, 75, 80, 135, 80, 135, 575, 95.83m, 6) }));

            _pokemons_disponiveis.Add(new Pokemon(311, "Plusle", 60, 50, 40, 85, 75, 95, 405, 67.5m, 3));
            _pokemons_disponiveis.Add(new Pokemon(312, "Minun", 60, 40, 50, 75, 85, 95, 405, 67.5m, 3));
            _pokemons_disponiveis.Add(new Pokemon(313, "Volbeat", 65, 73, 55, 47, 75, 85, 400, 66.67m, 3));
            _pokemons_disponiveis.Add(new Pokemon(314, "Illumise", 65, 47, 55, 73, 75, 85, 400, 66.67m, 3));
            _pokemons_disponiveis.Add(new Pokemon(315, "Roselia", 50, 60, 45, 100, 80, 65, 400, 66.67m, 3));
            _pokemons_disponiveis.Add(new Pokemon(316, "Gulpin", 70, 43, 53, 43, 53, 40, 302, 50.33m, 3));
            _pokemons_disponiveis.Add(new Pokemon(317, "Swalot", 100, 73, 83, 73, 83, 55, 467, 77.83m, 3));
            _pokemons_disponiveis.Add(new Pokemon(318, "Carvanha", 45, 90, 20, 65, 20, 65, 305, 50.83m, 3));
            _pokemons_disponiveis.Add(new Pokemon(319, "Sharpedo", 70, 120, 40, 95, 40, 95, 460, 76.67m, 3,
                            new Pokemon[] { new Pokemon(319, "Mega Sharpedo", 70, 140, 70, 110, 65, 105, 560, 93.33m, 6) }));

            _pokemons_disponiveis.Add(new Pokemon(320, "Wailmer", 130, 70, 35, 70, 35, 60, 400, 66.67m, 3));
            _pokemons_disponiveis.Add(new Pokemon(321, "Wailord", 170, 90, 45, 90, 45, 60, 500, 83.33m, 3));
            _pokemons_disponiveis.Add(new Pokemon(322, "Numel", 60, 60, 40, 65, 45, 35, 305, 50.83m, 3));
            _pokemons_disponiveis.Add(new Pokemon(323, "Camerupt", 70, 100, 70, 105, 75, 40, 460, 76.67m, 3,
                            new Pokemon[] { new Pokemon(323, "Mega Camerupt", 70, 120, 100, 145, 105, 20, 560, 93.33m, 6) }));

            _pokemons_disponiveis.Add(new Pokemon(324, "Torkoal", 70, 85, 140, 85, 70, 20, 470, 78.33m, 3));
            _pokemons_disponiveis.Add(new Pokemon(325, "Spoink", 60, 25, 35, 70, 80, 60, 330, 55m, 3));
            _pokemons_disponiveis.Add(new Pokemon(326, "Grumpig", 80, 45, 65, 90, 110, 80, 470, 78.33m, 3));
            _pokemons_disponiveis.Add(new Pokemon(327, "Spinda", 60, 60, 60, 60, 60, 60, 360, 60m, 3));
            _pokemons_disponiveis.Add(new Pokemon(328, "Trapinch", 45, 100, 45, 45, 45, 10, 290, 48.33m, 3));
            _pokemons_disponiveis.Add(new Pokemon(329, "Vibrava", 50, 70, 50, 50, 50, 70, 340, 56.67m, 3));
            _pokemons_disponiveis.Add(new Pokemon(330, "Flygon", 80, 100, 80, 80, 80, 100, 520, 86.67m, 3));
            _pokemons_disponiveis.Add(new Pokemon(331, "Cacnea", 50, 85, 40, 85, 40, 35, 335, 55.83m, 3));
            _pokemons_disponiveis.Add(new Pokemon(332, "Cacturne", 70, 115, 60, 115, 60, 55, 475, 79.17m, 3));
            _pokemons_disponiveis.Add(new Pokemon(333, "Swablu", 45, 40, 60, 40, 75, 50, 310, 51.67m, 3));
            _pokemons_disponiveis.Add(new Pokemon(334, "Altaria", 75, 70, 90, 70, 105, 80, 490, 81.67m, 3,
                            new Pokemon[] { new Pokemon(334, "Mega Altaria", 75, 110, 110, 110, 105, 80, 590, 98.33m, 6) }));

            _pokemons_disponiveis.Add(new Pokemon(335, "Zangoose", 73, 115, 60, 60, 60, 90, 458, 76.33m, 3));
            _pokemons_disponiveis.Add(new Pokemon(336, "Seviper", 73, 100, 60, 100, 60, 65, 458, 76.33m, 3));
            _pokemons_disponiveis.Add(new Pokemon(337, "Lunatone", 70, 55, 65, 95, 85, 70, 440, 73.33m, 3));
            _pokemons_disponiveis.Add(new Pokemon(338, "Solrock", 70, 95, 85, 55, 65, 70, 440, 73.33m, 3));
            _pokemons_disponiveis.Add(new Pokemon(339, "Barboach", 50, 48, 43, 46, 41, 60, 288, 48m, 3));
            _pokemons_disponiveis.Add(new Pokemon(340, "Whiscash", 110, 78, 73, 76, 71, 60, 468, 78m, 3));
            _pokemons_disponiveis.Add(new Pokemon(341, "Corphish", 43, 80, 65, 50, 35, 35, 308, 51.33m, 3));
            _pokemons_disponiveis.Add(new Pokemon(342, "Crawdaunt", 63, 120, 85, 90, 55, 55, 468, 78m, 3));
            _pokemons_disponiveis.Add(new Pokemon(343, "Baltoy", 40, 40, 55, 40, 70, 55, 300, 50m, 3));
            _pokemons_disponiveis.Add(new Pokemon(344, "Claydol", 60, 70, 105, 70, 120, 75, 500, 83.33m, 3));
            _pokemons_disponiveis.Add(new Pokemon(345, "Lileep", 66, 41, 77, 61, 87, 23, 355, 59.17m, 3));
            _pokemons_disponiveis.Add(new Pokemon(346, "Cradily", 86, 81, 97, 81, 107, 43, 495, 82.5m, 3));
            _pokemons_disponiveis.Add(new Pokemon(347, "Anorith", 45, 95, 50, 40, 50, 75, 355, 59.17m, 3));
            _pokemons_disponiveis.Add(new Pokemon(348, "Armaldo", 75, 125, 100, 70, 80, 45, 495, 82.5m, 3));
            _pokemons_disponiveis.Add(new Pokemon(349, "Feebas", 20, 15, 20, 10, 55, 80, 200, 33.33m, 3));
            _pokemons_disponiveis.Add(new Pokemon(350, "Milotic", 95, 60, 79, 100, 125, 81, 540, 90m, 3));
            _pokemons_disponiveis.Add(new Pokemon(351, "Castform", 70, 70, 70, 70, 70, 70, 420, 70m, 3));
            _pokemons_disponiveis.Add(new Pokemon(352, "Kecleon", 60, 90, 70, 60, 120, 40, 440, 73.33m, 3));
            _pokemons_disponiveis.Add(new Pokemon(353, "Shuppet", 44, 75, 35, 63, 33, 45, 295, 49.17m, 3));
            _pokemons_disponiveis.Add(new Pokemon(354, "Banette", 64, 115, 65, 83, 63, 65, 455, 75.83m, 3,
                            new Pokemon[] { new Pokemon(354, "Mega Banette", 64, 165, 75, 93, 83, 75, 555, 92.5m, 6) }));

            _pokemons_disponiveis.Add(new Pokemon(355, "Duskull", 20, 40, 90, 30, 90, 25, 295, 49.17m, 3));
            _pokemons_disponiveis.Add(new Pokemon(356, "Dusclops", 40, 70, 130, 60, 130, 25, 455, 75.83m, 3));
            _pokemons_disponiveis.Add(new Pokemon(357, "Tropius", 99, 68, 83, 72, 87, 51, 460, 76.67m, 3));
            _pokemons_disponiveis.Add(new Pokemon(358, "Chimecho", 65, 50, 70, 95, 80, 65, 425, 70.83m, 3));
            _pokemons_disponiveis.Add(new Pokemon(359, "Absol", 65, 130, 60, 75, 60, 75, 465, 77.5m, 3,
                            new Pokemon[] { new Pokemon(359, "Mega Absol", 65, 150, 60, 115, 60, 115, 565, 94.17m, 6) }));

            _pokemons_disponiveis.Add(new Pokemon(360, "Wynaut", 95, 23, 48, 23, 48, 23, 260, 43.33m, 3));
            _pokemons_disponiveis.Add(new Pokemon(361, "Snorunt", 50, 50, 50, 50, 50, 50, 300, 50m, 3));
            _pokemons_disponiveis.Add(new Pokemon(362, "Glalie", 80, 80, 80, 80, 80, 80, 480, 80m, 3,
                            new Pokemon[] { new Pokemon(362, "Mega Glalie", 80, 120, 80, 120, 80, 100, 580, 96.67m, 6) }));

            _pokemons_disponiveis.Add(new Pokemon(363, "Spheal", 70, 40, 50, 55, 50, 25, 290, 48.33m, 3));
            _pokemons_disponiveis.Add(new Pokemon(364, "Sealeo", 90, 60, 70, 75, 70, 45, 410, 68.33m, 3));
            _pokemons_disponiveis.Add(new Pokemon(365, "Walrein", 110, 80, 90, 95, 90, 65, 530, 88.33m, 3));
            _pokemons_disponiveis.Add(new Pokemon(366, "Clamperl", 35, 64, 85, 74, 55, 32, 345, 57.5m, 3));
            _pokemons_disponiveis.Add(new Pokemon(367, "Huntail", 55, 104, 105, 94, 75, 52, 485, 80.83m, 3));
            _pokemons_disponiveis.Add(new Pokemon(368, "Gorebyss", 55, 84, 105, 114, 75, 52, 485, 80.83m, 3));
            _pokemons_disponiveis.Add(new Pokemon(369, "Relicanth", 100, 90, 130, 45, 65, 55, 485, 80.83m, 3));
            _pokemons_disponiveis.Add(new Pokemon(370, "Luvdisc", 43, 30, 55, 40, 65, 97, 330, 55m, 3));
            _pokemons_disponiveis.Add(new Pokemon(371, "Bagon", 45, 75, 60, 40, 30, 50, 300, 50m, 3));
            _pokemons_disponiveis.Add(new Pokemon(372, "Shelgon", 65, 95, 100, 60, 50, 50, 420, 70m, 3));
            _pokemons_disponiveis.Add(new Pokemon(373, "Salamence", 95, 135, 80, 110, 80, 100, 600, 100m, 3,
                            new Pokemon[] { new Pokemon(373, "Mega Salamence", 95, 145, 130, 120, 90, 120, 700, 116.67m, 6) }));

            _pokemons_disponiveis.Add(new Pokemon(374, "Beldum", 40, 55, 80, 35, 60, 30, 300, 50m, 3));
            _pokemons_disponiveis.Add(new Pokemon(375, "Metang", 60, 75, 100, 55, 80, 50, 420, 70m, 3));
            _pokemons_disponiveis.Add(new Pokemon(376, "Metagross", 80, 135, 130, 95, 90, 70, 600, 100m, 3,
                new Pokemon[] { new Pokemon(376, "Mega Metagross", 80, 145, 150, 105, 110, 110, 700, 116.67m, 6) }));

            _pokemons_disponiveis.Add(new Pokemon(377, "Regirock", 80, 100, 200, 50, 100, 50, 580, 96.67m, 3));
            _pokemons_disponiveis.Add(new Pokemon(378, "Regice", 80, 50, 100, 100, 200, 50, 580, 96.67m, 3));
            _pokemons_disponiveis.Add(new Pokemon(379, "Registeel", 80, 75, 150, 75, 150, 50, 580, 96.67m, 3));
            _pokemons_disponiveis.Add(new Pokemon(380, "Latias", 80, 80, 90, 110, 130, 110, 600, 100m, 3,
                            new Pokemon[] { new Pokemon(380, "Mega Latias", 80, 100, 120, 140, 150, 110, 700, 116.67m, 6) }));

            _pokemons_disponiveis.Add(new Pokemon(381, "Latios", 80, 90, 80, 130, 110, 110, 600, 100m, 3,
                            new Pokemon[] { new Pokemon(381, "Mega Latios", 80, 130, 100, 160, 120, 110, 700, 116.67m, 6) }));

            _pokemons_disponiveis.Add(new Pokemon(382, "Kyogre", 100, 100, 90, 150, 140, 90, 670, 111.67m, 3,
                            new Pokemon[] { new Pokemon(382, "Primal Kyogre", 100, 150, 90, 180, 160, 90, 770, 128.33m, 6) }));

            _pokemons_disponiveis.Add(new Pokemon(383, "Groudon", 100, 150, 140, 100, 90, 90, 670, 111.67m, 3,
                            new Pokemon[] { new Pokemon(383, "Primal Groudon", 100, 180, 160, 150, 90, 90, 770, 128.33m, 6) }));

            _pokemons_disponiveis.Add(new Pokemon(384, "Rayquaza", 105, 150, 90, 150, 90, 95, 680, 113.33m, 3,
                            new Pokemon[] { new Pokemon(384, "Mega Rayquaza", 105, 180, 100, 180, 100, 115, 780, 130m, 6) }));

            _pokemons_disponiveis.Add(new Pokemon(385, "Jirachi", 100, 100, 100, 100, 100, 100, 600, 100m, 3));
            _pokemons_disponiveis.Add(new Pokemon(386, "Deoxys", 50, 150, 50, 150, 50, 150, 600, 100m, 3));
            _pokemons_disponiveis.Add(new Pokemon(387, "Turtwig", 55, 68, 64, 45, 55, 31, 318, 53m, 4));
            _pokemons_disponiveis.Add(new Pokemon(388, "Grotle", 75, 89, 85, 55, 65, 36, 405, 67.5m, 4));
            _pokemons_disponiveis.Add(new Pokemon(389, "Torterra", 95, 109, 105, 75, 85, 56, 525, 87.5m, 4));
            _pokemons_disponiveis.Add(new Pokemon(390, "Chimchar", 44, 58, 44, 58, 44, 61, 309, 51.5m, 4));
            _pokemons_disponiveis.Add(new Pokemon(391, "Monferno", 64, 78, 52, 78, 52, 81, 405, 67.5m, 4));
            _pokemons_disponiveis.Add(new Pokemon(392, "Infernape", 76, 104, 71, 104, 71, 108, 534, 89m, 4));
            _pokemons_disponiveis.Add(new Pokemon(393, "Piplup", 53, 51, 53, 61, 56, 40, 314, 52.33m, 4));
            _pokemons_disponiveis.Add(new Pokemon(394, "Prinplup", 64, 66, 68, 81, 76, 50, 405, 67.5m, 4));
            _pokemons_disponiveis.Add(new Pokemon(395, "Empoleon", 84, 86, 88, 111, 101, 60, 530, 88.33m, 4));
            _pokemons_disponiveis.Add(new Pokemon(396, "Starly", 40, 55, 30, 30, 30, 60, 245, 40.83m, 4));
            _pokemons_disponiveis.Add(new Pokemon(397, "Staravia", 55, 75, 50, 40, 40, 80, 340, 56.67m, 4));
            _pokemons_disponiveis.Add(new Pokemon(398, "Staraptor", 85, 120, 70, 50, 60, 100, 485, 80.83m, 4));
            _pokemons_disponiveis.Add(new Pokemon(399, "Bidoof", 59, 45, 40, 35, 40, 31, 250, 41.67m, 4));
            _pokemons_disponiveis.Add(new Pokemon(400, "Bibarel", 79, 85, 60, 55, 60, 71, 410, 68.33m, 4));
            _pokemons_disponiveis.Add(new Pokemon(401, "Kricketot", 37, 25, 41, 25, 41, 25, 194, 32.33m, 4));
            _pokemons_disponiveis.Add(new Pokemon(402, "Kricketune", 77, 85, 51, 55, 51, 65, 384, 64m, 4));
            _pokemons_disponiveis.Add(new Pokemon(403, "Shinx", 45, 65, 34, 40, 34, 45, 263, 43.83m, 4));
            _pokemons_disponiveis.Add(new Pokemon(404, "Luxio", 60, 85, 49, 60, 49, 60, 363, 60.5m, 4));
            _pokemons_disponiveis.Add(new Pokemon(405, "Luxray", 80, 120, 79, 95, 79, 70, 523, 87.17m, 4));
            _pokemons_disponiveis.Add(new Pokemon(406, "Budew", 40, 30, 35, 50, 70, 55, 280, 46.67m, 4));
            _pokemons_disponiveis.Add(new Pokemon(407, "Roserade", 60, 70, 65, 125, 105, 90, 515, 85.83m, 4));
            _pokemons_disponiveis.Add(new Pokemon(408, "Cranidos", 67, 125, 40, 30, 30, 58, 350, 58.33m, 4));
            _pokemons_disponiveis.Add(new Pokemon(409, "Rampardos", 97, 165, 60, 65, 50, 58, 495, 82.5m, 4));
            _pokemons_disponiveis.Add(new Pokemon(410, "Shieldon", 30, 42, 118, 42, 88, 30, 350, 58.33m, 4));
            _pokemons_disponiveis.Add(new Pokemon(411, "Bastiodon", 60, 52, 168, 47, 138, 30, 495, 82.5m, 4));
            _pokemons_disponiveis.Add(new Pokemon(412, "Burmy", 40, 29, 45, 29, 45, 36, 224, 37.33m, 4));
            _pokemons_disponiveis.Add(new Pokemon(413, "Wormadam", 60, 59, 85, 79, 105, 36, 424, 70.67m, 4));
            _pokemons_disponiveis.Add(new Pokemon(414, "Mothim", 70, 94, 50, 94, 50, 66, 424, 70.67m, 4));
            _pokemons_disponiveis.Add(new Pokemon(415, "Combee", 30, 30, 42, 30, 42, 70, 244, 40.67m, 4));
            _pokemons_disponiveis.Add(new Pokemon(416, "Vespiquen", 70, 80, 102, 80, 102, 40, 474, 79m, 4));
            _pokemons_disponiveis.Add(new Pokemon(417, "Pachirisu", 60, 45, 70, 45, 90, 95, 405, 67.5m, 4));
            _pokemons_disponiveis.Add(new Pokemon(418, "Buizel", 55, 65, 35, 60, 30, 85, 330, 55m, 4));
            _pokemons_disponiveis.Add(new Pokemon(419, "Floatzel", 85, 105, 55, 85, 50, 115, 495, 82.5m, 4));
            _pokemons_disponiveis.Add(new Pokemon(420, "Cherubi", 45, 35, 45, 62, 53, 35, 275, 45.83m, 4));
            _pokemons_disponiveis.Add(new Pokemon(421, "Cherrim", 70, 60, 70, 87, 78, 85, 450, 75m, 4));
            _pokemons_disponiveis.Add(new Pokemon(422, "Shellos", 76, 48, 48, 57, 62, 34, 325, 54.17m, 4));
            _pokemons_disponiveis.Add(new Pokemon(423, "Gastrodon", 111, 83, 68, 92, 82, 39, 475, 79.17m, 4));
            _pokemons_disponiveis.Add(new Pokemon(424, "Ambipom", 75, 100, 66, 60, 66, 115, 482, 80.33m, 4));
            _pokemons_disponiveis.Add(new Pokemon(425, "Drifloon", 90, 50, 34, 60, 44, 70, 348, 58m, 4));
            _pokemons_disponiveis.Add(new Pokemon(426, "Drifblim", 150, 80, 44, 90, 54, 80, 498, 83m, 4));
            _pokemons_disponiveis.Add(new Pokemon(427, "Buneary", 55, 66, 44, 44, 56, 85, 350, 58.33m, 4));
            _pokemons_disponiveis.Add(new Pokemon(428, "Lopunny", 65, 76, 84, 54, 96, 105, 480, 80m, 4,
                            new Pokemon[] { new Pokemon(428, "Mega Lopunny", 65, 136, 94, 54, 96, 135, 580, 96.67m, 6) }));

            _pokemons_disponiveis.Add(new Pokemon(429, "Mismagius", 60, 60, 60, 105, 105, 105, 495, 82.5m, 4));
            _pokemons_disponiveis.Add(new Pokemon(430, "Honchkrow", 100, 125, 52, 105, 52, 71, 505, 84.17m, 4));
            _pokemons_disponiveis.Add(new Pokemon(431, "Glameow", 49, 55, 42, 42, 37, 85, 310, 51.67m, 4));
            _pokemons_disponiveis.Add(new Pokemon(432, "Purugly", 71, 82, 64, 64, 59, 112, 452, 75.33m, 4));
            _pokemons_disponiveis.Add(new Pokemon(433, "Chingling", 45, 30, 50, 65, 50, 45, 285, 47.5m, 4));
            _pokemons_disponiveis.Add(new Pokemon(434, "Stunky", 63, 63, 47, 41, 41, 74, 329, 54.83m, 4));
            _pokemons_disponiveis.Add(new Pokemon(435, "Skuntank", 103, 93, 67, 71, 61, 84, 479, 79.83m, 4));
            _pokemons_disponiveis.Add(new Pokemon(436, "Bronzor", 57, 24, 86, 24, 86, 23, 300, 50m, 4));
            _pokemons_disponiveis.Add(new Pokemon(437, "Bronzong", 67, 89, 116, 79, 116, 33, 500, 83.33m, 4));
            _pokemons_disponiveis.Add(new Pokemon(438, "Bonsly", 50, 80, 95, 10, 45, 10, 290, 48.33m, 4));
            _pokemons_disponiveis.Add(new Pokemon(439, "Mime Jr.", 20, 25, 45, 70, 90, 60, 310, 51.67m, 4));
            _pokemons_disponiveis.Add(new Pokemon(440, "Happiny", 100, 5, 5, 15, 65, 30, 220, 36.67m, 4));
            _pokemons_disponiveis.Add(new Pokemon(441, "Chatot", 76, 65, 45, 92, 42, 91, 411, 68.5m, 4));
            _pokemons_disponiveis.Add(new Pokemon(442, "Spiritomb", 50, 92, 108, 92, 108, 35, 485, 80.83m, 4));
            _pokemons_disponiveis.Add(new Pokemon(443, "Gible", 58, 70, 45, 40, 45, 42, 300, 50m, 4));
            _pokemons_disponiveis.Add(new Pokemon(444, "Gabite", 68, 90, 65, 50, 55, 82, 410, 68.33m, 4));
            _pokemons_disponiveis.Add(new Pokemon(445, "Garchomp", 108, 130, 95, 80, 85, 102, 600, 100m, 4,
                            new Pokemon[] { new Pokemon(445, "Mega Garchomp", 108, 170, 115, 120, 95, 92, 700, 116.67m, 6) }));

            _pokemons_disponiveis.Add(new Pokemon(446, "Munchlax", 135, 85, 40, 40, 85, 5, 390, 65m, 4));
            _pokemons_disponiveis.Add(new Pokemon(447, "Riolu", 40, 70, 40, 35, 40, 60, 285, 47.5m, 4));
            _pokemons_disponiveis.Add(new Pokemon(448, "Lucario", 70, 110, 70, 115, 70, 90, 525, 87.5m, 4,
                            new Pokemon[] { new Pokemon(448, "Mega Lucario", 70, 145, 88, 140, 70, 112, 625, 104.17m, 6) }));

            _pokemons_disponiveis.Add(new Pokemon(449, "Hippopotas", 68, 72, 78, 38, 42, 32, 330, 55m, 4));
            _pokemons_disponiveis.Add(new Pokemon(450, "Hippowdon", 108, 112, 118, 68, 72, 47, 525, 87.5m, 4));
            _pokemons_disponiveis.Add(new Pokemon(451, "Skorupi", 40, 50, 90, 30, 55, 65, 330, 55m, 4));
            _pokemons_disponiveis.Add(new Pokemon(452, "Drapion", 70, 90, 110, 60, 75, 95, 500, 83.33m, 4));
            _pokemons_disponiveis.Add(new Pokemon(453, "Croagunk", 48, 61, 40, 61, 40, 50, 300, 50m, 4));
            _pokemons_disponiveis.Add(new Pokemon(454, "Toxicroak", 83, 106, 65, 86, 65, 85, 490, 81.67m, 4));
            _pokemons_disponiveis.Add(new Pokemon(455, "Carnivine", 74, 100, 72, 90, 72, 46, 454, 75.67m, 4));
            _pokemons_disponiveis.Add(new Pokemon(456, "Finneon", 49, 49, 56, 49, 61, 66, 330, 55m, 4));
            _pokemons_disponiveis.Add(new Pokemon(457, "Lumineon", 69, 69, 76, 69, 86, 91, 460, 76.67m, 4));
            _pokemons_disponiveis.Add(new Pokemon(458, "Mantyke", 45, 20, 50, 60, 120, 50, 345, 57.5m, 4));
            _pokemons_disponiveis.Add(new Pokemon(459, "Snover", 60, 62, 50, 62, 60, 40, 334, 55.67m, 4));
            _pokemons_disponiveis.Add(new Pokemon(460, "Abomasnow", 90, 92, 75, 92, 85, 60, 494, 82.33m, 4,
                            new Pokemon[] { new Pokemon(460, "Mega Abomasnow", 90, 132, 105, 132, 105, 30, 594, 99m, 6) }));

            _pokemons_disponiveis.Add(new Pokemon(461, "Weavile", 70, 120, 65, 45, 85, 125, 510, 85m, 4));
            _pokemons_disponiveis.Add(new Pokemon(462, "Magnezone", 70, 70, 115, 130, 90, 60, 535, 89.17m, 4));
            _pokemons_disponiveis.Add(new Pokemon(463, "Lickilicky", 110, 85, 95, 80, 95, 50, 515, 85.83m, 4));
            _pokemons_disponiveis.Add(new Pokemon(464, "Rhyperior", 115, 140, 130, 55, 55, 40, 535, 89.17m, 4));
            _pokemons_disponiveis.Add(new Pokemon(465, "Tangrowth", 100, 100, 125, 110, 50, 50, 535, 89.17m, 4));
            _pokemons_disponiveis.Add(new Pokemon(466, "Electivire", 75, 123, 67, 95, 85, 95, 540, 90m, 4));
            _pokemons_disponiveis.Add(new Pokemon(467, "Magmortar", 75, 95, 67, 125, 95, 83, 540, 90m, 4));
            _pokemons_disponiveis.Add(new Pokemon(468, "Togekiss", 85, 50, 95, 120, 115, 80, 545, 90.83m, 4));
            _pokemons_disponiveis.Add(new Pokemon(469, "Yanmega", 86, 76, 86, 116, 56, 95, 515, 85.83m, 4));
            _pokemons_disponiveis.Add(new Pokemon(470, "Leafeon", 65, 110, 130, 60, 65, 95, 525, 87.5m, 4));
            _pokemons_disponiveis.Add(new Pokemon(471, "Glaceon", 65, 60, 110, 130, 95, 65, 525, 87.5m, 4));
            _pokemons_disponiveis.Add(new Pokemon(472, "Gliscor", 75, 95, 125, 45, 75, 95, 510, 85m, 4));
            _pokemons_disponiveis.Add(new Pokemon(473, "Mamoswine", 110, 130, 80, 70, 60, 80, 530, 88.33m, 4));
            _pokemons_disponiveis.Add(new Pokemon(474, "Porygon-Z", 85, 80, 70, 135, 75, 90, 535, 89.17m, 4));
            _pokemons_disponiveis.Add(new Pokemon(475, "Gallade", 68, 125, 65, 65, 115, 80, 518, 86.33m, 4,
                            new Pokemon[] { new Pokemon(475, "Mega Gallade", 68, 165, 95, 65, 115, 110, 618, 103m, 6) }));

            _pokemons_disponiveis.Add(new Pokemon(476, "Probopass", 60, 55, 145, 75, 150, 40, 525, 87.5m, 4));
            _pokemons_disponiveis.Add(new Pokemon(477, "Dusknoir", 45, 100, 135, 65, 135, 45, 525, 87.5m, 4));
            _pokemons_disponiveis.Add(new Pokemon(478, "Froslass", 70, 80, 70, 80, 70, 110, 480, 80m, 4));
            _pokemons_disponiveis.Add(new Pokemon(479, "Rotom", 50, 50, 77, 95, 77, 91, 440, 73.33m, 4));
            _pokemons_disponiveis.Add(new Pokemon(480, "Uxie", 75, 75, 130, 75, 130, 95, 580, 96.67m, 4));
            _pokemons_disponiveis.Add(new Pokemon(481, "Mesprit", 80, 105, 105, 105, 105, 80, 580, 96.67m, 4));
            _pokemons_disponiveis.Add(new Pokemon(482, "Azelf", 75, 125, 70, 125, 70, 115, 580, 96.67m, 4));
            _pokemons_disponiveis.Add(new Pokemon(483, "Dialga", 100, 120, 120, 150, 100, 90, 680, 113.33m, 4));
            _pokemons_disponiveis.Add(new Pokemon(484, "Palkia", 90, 120, 100, 150, 120, 100, 680, 113.33m, 4));
            _pokemons_disponiveis.Add(new Pokemon(485, "Heatran", 91, 90, 106, 130, 106, 77, 600, 100m, 4));
            _pokemons_disponiveis.Add(new Pokemon(486, "Regigigas", 110, 160, 110, 80, 110, 100, 670, 111.67m, 4));
            _pokemons_disponiveis.Add(new Pokemon(487, "Giratina", 150, 100, 120, 100, 120, 90, 680, 113.33m, 4));
            _pokemons_disponiveis.Add(new Pokemon(488, "Cresselia", 120, 70, 120, 75, 130, 85, 600, 100m, 4));
            _pokemons_disponiveis.Add(new Pokemon(489, "Phione", 80, 80, 80, 80, 80, 80, 480, 80m, 4));
            _pokemons_disponiveis.Add(new Pokemon(490, "Manaphy", 100, 100, 100, 100, 100, 100, 600, 100m, 4));
            _pokemons_disponiveis.Add(new Pokemon(491, "Darkrai", 70, 90, 90, 135, 90, 125, 600, 100m, 4));
            _pokemons_disponiveis.Add(new Pokemon(492, "Shaymin", 100, 100, 100, 100, 100, 100, 600, 100m, 4));
            _pokemons_disponiveis.Add(new Pokemon(493, "Arceus", 120, 120, 120, 120, 120, 120, 720, 120m, 4));
            _pokemons_disponiveis.Add(new Pokemon(494, "Victini", 100, 100, 100, 100, 100, 100, 600, 100m, 5));
            _pokemons_disponiveis.Add(new Pokemon(495, "Snivy", 45, 45, 55, 45, 55, 63, 308, 51.33m, 5));
            _pokemons_disponiveis.Add(new Pokemon(496, "Servine", 60, 60, 75, 60, 75, 83, 413, 68.83m, 5));
            _pokemons_disponiveis.Add(new Pokemon(497, "Serperior", 75, 75, 95, 75, 95, 113, 528, 88m, 5));
            _pokemons_disponiveis.Add(new Pokemon(498, "Tepig", 65, 63, 45, 45, 45, 45, 308, 51.33m, 5));
            _pokemons_disponiveis.Add(new Pokemon(499, "Pignite", 90, 93, 55, 70, 55, 55, 418, 69.67m, 5));
            _pokemons_disponiveis.Add(new Pokemon(500, "Emboar", 110, 123, 65, 100, 65, 65, 528, 88m, 5));
            _pokemons_disponiveis.Add(new Pokemon(501, "Oshawott", 55, 55, 45, 63, 45, 45, 308, 51.33m, 5));
            _pokemons_disponiveis.Add(new Pokemon(502, "Dewott", 75, 75, 60, 83, 60, 60, 413, 68.83m, 5));
            _pokemons_disponiveis.Add(new Pokemon(503, "Samurott", 95, 100, 85, 108, 70, 70, 528, 88m, 5));
            _pokemons_disponiveis.Add(new Pokemon(504, "Patrat", 45, 55, 39, 35, 39, 42, 255, 42.5m, 5));
            _pokemons_disponiveis.Add(new Pokemon(505, "Watchog", 60, 85, 69, 60, 69, 77, 420, 70m, 5));
            _pokemons_disponiveis.Add(new Pokemon(506, "Lillipup", 45, 60, 45, 25, 45, 55, 275, 45.83m, 5));
            _pokemons_disponiveis.Add(new Pokemon(507, "Herdier", 65, 80, 65, 35, 65, 60, 370, 61.67m, 5));
            _pokemons_disponiveis.Add(new Pokemon(508, "Stoutland", 85, 110, 90, 45, 90, 80, 500, 83.33m, 5));
            _pokemons_disponiveis.Add(new Pokemon(509, "Purrloin", 41, 50, 37, 50, 37, 66, 281, 46.83m, 5));
            _pokemons_disponiveis.Add(new Pokemon(510, "Liepard", 64, 88, 50, 88, 50, 106, 446, 74.33m, 5));
            _pokemons_disponiveis.Add(new Pokemon(511, "Pansage", 50, 53, 48, 53, 48, 64, 316, 52.67m, 5));
            _pokemons_disponiveis.Add(new Pokemon(512, "Simisage", 75, 98, 63, 98, 63, 101, 498, 83m, 5));
            _pokemons_disponiveis.Add(new Pokemon(513, "Pansear", 50, 53, 48, 53, 48, 64, 316, 52.67m, 5));
            _pokemons_disponiveis.Add(new Pokemon(514, "Simisear", 75, 98, 63, 98, 63, 101, 498, 83m, 5));
            _pokemons_disponiveis.Add(new Pokemon(515, "Panpour", 50, 53, 48, 53, 48, 64, 316, 52.67m, 5));
            _pokemons_disponiveis.Add(new Pokemon(516, "Simipour", 75, 98, 63, 98, 63, 101, 498, 83m, 5));
            _pokemons_disponiveis.Add(new Pokemon(517, "Munna", 76, 25, 45, 67, 55, 24, 292, 48.67m, 5));
            _pokemons_disponiveis.Add(new Pokemon(518, "Musharna", 116, 55, 85, 107, 95, 29, 487, 81.17m, 5));
            _pokemons_disponiveis.Add(new Pokemon(519, "Pidove", 50, 55, 50, 36, 30, 43, 264, 44m, 5));
            _pokemons_disponiveis.Add(new Pokemon(520, "Tranquill", 62, 77, 62, 50, 42, 65, 358, 59.67m, 5));
            _pokemons_disponiveis.Add(new Pokemon(521, "Unfezant", 80, 115, 80, 65, 55, 93, 488, 81.33m, 5));
            _pokemons_disponiveis.Add(new Pokemon(522, "Blitzle", 45, 60, 32, 50, 32, 76, 295, 49.17m, 5));
            _pokemons_disponiveis.Add(new Pokemon(523, "Zebstrika", 75, 100, 63, 80, 63, 116, 497, 82.83m, 5));
            _pokemons_disponiveis.Add(new Pokemon(524, "Roggenrola", 55, 75, 85, 25, 25, 15, 280, 46.67m, 5));
            _pokemons_disponiveis.Add(new Pokemon(525, "Boldore", 70, 105, 105, 50, 40, 20, 390, 65m, 5));
            _pokemons_disponiveis.Add(new Pokemon(526, "Gigalith", 85, 135, 130, 60, 80, 25, 515, 85.83m, 5));
            _pokemons_disponiveis.Add(new Pokemon(527, "Woobat", 55, 45, 43, 55, 43, 72, 313, 52.17m, 5));
            _pokemons_disponiveis.Add(new Pokemon(528, "Swoobat", 67, 57, 55, 77, 55, 114, 425, 70.83m, 5));
            _pokemons_disponiveis.Add(new Pokemon(529, "Drilbur", 60, 85, 40, 30, 45, 68, 328, 54.67m, 5));
            _pokemons_disponiveis.Add(new Pokemon(530, "Excadrill", 110, 135, 60, 50, 65, 88, 508, 84.67m, 5));
            _pokemons_disponiveis.Add(new Pokemon(531, "Audino", 103, 60, 86, 60, 86, 50, 445, 74.17m, 5,
                new Pokemon[] { new Pokemon(531, "Mega Audino", 103, 60, 126, 80, 126, 50, 545, 90.83m, 6) }));

            _pokemons_disponiveis.Add(new Pokemon(532, "Timburr", 75, 80, 55, 25, 35, 35, 305, 50.83m, 5));
            _pokemons_disponiveis.Add(new Pokemon(533, "Gurdurr", 85, 105, 85, 40, 50, 40, 405, 67.5m, 5));
            _pokemons_disponiveis.Add(new Pokemon(534, "Conkeldurr", 105, 140, 95, 55, 65, 45, 505, 84.17m, 5));
            _pokemons_disponiveis.Add(new Pokemon(535, "Tympole", 50, 50, 40, 50, 40, 64, 294, 49m, 5));
            _pokemons_disponiveis.Add(new Pokemon(536, "Palpitoad", 75, 65, 55, 65, 55, 69, 384, 64m, 5));
            _pokemons_disponiveis.Add(new Pokemon(537, "Seismitoad", 105, 95, 75, 85, 75, 74, 509, 84.83m, 5));
            _pokemons_disponiveis.Add(new Pokemon(538, "Throh", 120, 100, 85, 30, 85, 45, 465, 77.5m, 5));
            _pokemons_disponiveis.Add(new Pokemon(539, "Sawk", 75, 125, 75, 30, 75, 85, 465, 77.5m, 5));
            _pokemons_disponiveis.Add(new Pokemon(540, "Sewaddle", 45, 53, 70, 40, 60, 42, 310, 51.67m, 5));
            _pokemons_disponiveis.Add(new Pokemon(541, "Swadloon", 55, 63, 90, 50, 80, 42, 380, 63.33m, 5));
            _pokemons_disponiveis.Add(new Pokemon(542, "Leavanny", 75, 103, 80, 70, 80, 92, 500, 83.33m, 5));
            _pokemons_disponiveis.Add(new Pokemon(543, "Venipede", 30, 45, 59, 30, 39, 57, 260, 43.33m, 5));
            _pokemons_disponiveis.Add(new Pokemon(544, "Whirlipede", 40, 55, 99, 40, 79, 47, 360, 60m, 5));
            _pokemons_disponiveis.Add(new Pokemon(545, "Scolipede", 60, 100, 89, 55, 69, 112, 485, 80.83m, 5));
            _pokemons_disponiveis.Add(new Pokemon(546, "Cottonee", 40, 27, 60, 37, 50, 66, 280, 46.67m, 5));
            _pokemons_disponiveis.Add(new Pokemon(547, "Whimsicott", 60, 67, 85, 77, 75, 116, 480, 80m, 5));
            _pokemons_disponiveis.Add(new Pokemon(548, "Petilil", 45, 35, 50, 70, 50, 30, 280, 46.67m, 5));
            _pokemons_disponiveis.Add(new Pokemon(549, "Lilligant", 70, 60, 75, 110, 75, 90, 480, 80m, 5));
            _pokemons_disponiveis.Add(new Pokemon(550, "Basculin", 70, 92, 65, 80, 55, 98, 460, 76.67m, 5));
            _pokemons_disponiveis.Add(new Pokemon(551, "Sandile", 50, 72, 35, 35, 35, 65, 292, 48.67m, 5));
            _pokemons_disponiveis.Add(new Pokemon(552, "Krokorok", 60, 82, 45, 45, 45, 74, 351, 58.5m, 5));
            _pokemons_disponiveis.Add(new Pokemon(553, "Krookodile", 95, 117, 80, 65, 70, 92, 519, 86.5m, 5));
            _pokemons_disponiveis.Add(new Pokemon(554, "Darumaka", 70, 90, 45, 15, 45, 50, 315, 52.5m, 5));
            _pokemons_disponiveis.Add(new Pokemon(555, "Darmanitan", 105, 30, 105, 140, 105, 55, 540, 90m, 5));
            _pokemons_disponiveis.Add(new Pokemon(556, "Maractus", 75, 86, 67, 106, 67, 60, 461, 76.83m, 5));
            _pokemons_disponiveis.Add(new Pokemon(557, "Dwebble", 50, 65, 85, 35, 35, 55, 325, 54.17m, 5));
            _pokemons_disponiveis.Add(new Pokemon(558, "Crustle", 70, 95, 125, 65, 75, 45, 475, 79.17m, 5));
            _pokemons_disponiveis.Add(new Pokemon(559, "Scraggy", 50, 75, 70, 35, 70, 48, 348, 58m, 5));
            _pokemons_disponiveis.Add(new Pokemon(560, "Scrafty", 65, 90, 115, 45, 115, 58, 488, 81.33m, 5));
            _pokemons_disponiveis.Add(new Pokemon(561, "Sigilyph", 72, 58, 80, 103, 80, 97, 490, 81.67m, 5));
            _pokemons_disponiveis.Add(new Pokemon(562, "Yamask", 38, 30, 85, 55, 65, 30, 303, 50.5m, 5));
            _pokemons_disponiveis.Add(new Pokemon(563, "Cofagrigus", 58, 50, 145, 95, 105, 30, 483, 80.5m, 5));
            _pokemons_disponiveis.Add(new Pokemon(564, "Tirtouga", 54, 78, 103, 53, 45, 22, 355, 59.17m, 5));
            _pokemons_disponiveis.Add(new Pokemon(565, "Carracosta", 74, 108, 133, 83, 65, 32, 495, 82.5m, 5));
            _pokemons_disponiveis.Add(new Pokemon(566, "Archen", 55, 112, 45, 74, 45, 70, 401, 66.83m, 5));
            _pokemons_disponiveis.Add(new Pokemon(567, "Archeops", 75, 140, 65, 112, 65, 110, 567, 94.5m, 5));
            _pokemons_disponiveis.Add(new Pokemon(568, "Trubbish", 50, 50, 62, 40, 62, 65, 329, 54.83m, 5));
            _pokemons_disponiveis.Add(new Pokemon(569, "Garbodor", 80, 95, 82, 60, 82, 75, 474, 79m, 5));
            _pokemons_disponiveis.Add(new Pokemon(570, "Zorua", 40, 65, 40, 80, 40, 65, 330, 55m, 5));
            _pokemons_disponiveis.Add(new Pokemon(571, "Zoroark", 60, 105, 60, 120, 60, 105, 510, 85m, 5));
            _pokemons_disponiveis.Add(new Pokemon(572, "Minccino", 55, 50, 40, 40, 40, 75, 300, 50m, 5));
            _pokemons_disponiveis.Add(new Pokemon(573, "Cinccino", 75, 95, 60, 65, 60, 115, 470, 78.33m, 5));
            _pokemons_disponiveis.Add(new Pokemon(574, "Gothita", 45, 30, 50, 55, 65, 45, 290, 48.33m, 5));
            _pokemons_disponiveis.Add(new Pokemon(575, "Gothorita", 60, 45, 70, 75, 85, 55, 390, 65m, 5));
            _pokemons_disponiveis.Add(new Pokemon(576, "Gothitelle", 70, 55, 95, 95, 110, 65, 490, 81.67m, 5));
            _pokemons_disponiveis.Add(new Pokemon(577, "Solosis", 45, 30, 40, 105, 50, 20, 290, 48.33m, 5));
            _pokemons_disponiveis.Add(new Pokemon(578, "Duosion", 65, 40, 50, 125, 60, 30, 370, 61.67m, 5));
            _pokemons_disponiveis.Add(new Pokemon(579, "Reuniclus", 110, 65, 75, 125, 85, 30, 490, 81.67m, 5));
            _pokemons_disponiveis.Add(new Pokemon(580, "Ducklett", 62, 44, 50, 44, 50, 55, 305, 50.83m, 5));
            _pokemons_disponiveis.Add(new Pokemon(581, "Swanna", 75, 87, 63, 87, 63, 98, 473, 78.83m, 5));
            _pokemons_disponiveis.Add(new Pokemon(582, "Vanillite", 36, 50, 50, 65, 60, 44, 305, 50.83m, 5));
            _pokemons_disponiveis.Add(new Pokemon(583, "Vanillish", 51, 65, 65, 80, 75, 59, 395, 65.83m, 5));
            _pokemons_disponiveis.Add(new Pokemon(584, "Vanilluxe", 71, 95, 85, 110, 95, 79, 535, 89.17m, 5));
            _pokemons_disponiveis.Add(new Pokemon(585, "Deerling", 60, 60, 50, 40, 50, 75, 335, 55.83m, 5));
            _pokemons_disponiveis.Add(new Pokemon(586, "Sawsbuck", 80, 100, 70, 60, 70, 95, 475, 79.17m, 5));
            _pokemons_disponiveis.Add(new Pokemon(587, "Emolga", 55, 75, 60, 75, 60, 103, 428, 71.33m, 5));
            _pokemons_disponiveis.Add(new Pokemon(588, "Karrablast", 50, 75, 45, 40, 45, 60, 315, 52.5m, 5));
            _pokemons_disponiveis.Add(new Pokemon(589, "Escavalier", 70, 135, 105, 60, 105, 20, 495, 82.5m, 5));
            _pokemons_disponiveis.Add(new Pokemon(590, "Foongus", 69, 55, 45, 55, 55, 15, 294, 49m, 5));
            _pokemons_disponiveis.Add(new Pokemon(591, "Amoonguss", 114, 85, 70, 85, 80, 30, 464, 77.33m, 5));
            _pokemons_disponiveis.Add(new Pokemon(592, "Frillish", 55, 40, 50, 65, 85, 40, 335, 55.83m, 5));
            _pokemons_disponiveis.Add(new Pokemon(593, "Jellicent", 100, 60, 70, 85, 105, 60, 480, 80m, 5));
            _pokemons_disponiveis.Add(new Pokemon(594, "Alomomola", 165, 75, 80, 40, 45, 65, 470, 78.33m, 5));
            _pokemons_disponiveis.Add(new Pokemon(595, "Joltik", 50, 47, 50, 57, 50, 65, 319, 53.17m, 5));
            _pokemons_disponiveis.Add(new Pokemon(596, "Galvantula", 70, 77, 60, 97, 60, 108, 472, 78.67m, 5));
            _pokemons_disponiveis.Add(new Pokemon(597, "Ferroseed", 44, 50, 91, 24, 86, 10, 305, 50.83m, 5));
            _pokemons_disponiveis.Add(new Pokemon(598, "Ferrothorn", 74, 94, 131, 54, 116, 20, 489, 81.5m, 5));
            _pokemons_disponiveis.Add(new Pokemon(599, "Klink", 40, 55, 70, 45, 60, 30, 300, 50m, 5));
            _pokemons_disponiveis.Add(new Pokemon(600, "Klang", 60, 80, 95, 70, 85, 50, 440, 73.33m, 5));
            _pokemons_disponiveis.Add(new Pokemon(601, "Klinklang", 60, 100, 115, 70, 85, 90, 520, 86.67m, 5));
            _pokemons_disponiveis.Add(new Pokemon(602, "Tynamo", 35, 55, 40, 45, 40, 60, 275, 45.83m, 5));
            _pokemons_disponiveis.Add(new Pokemon(603, "Eelektrik", 65, 85, 70, 75, 70, 40, 405, 67.5m, 5));
            _pokemons_disponiveis.Add(new Pokemon(604, "Eelektross", 85, 115, 80, 105, 80, 50, 515, 85.83m, 5));
            _pokemons_disponiveis.Add(new Pokemon(605, "Elgyem", 55, 55, 55, 85, 55, 30, 335, 55.83m, 5));
            _pokemons_disponiveis.Add(new Pokemon(606, "Beheeyem", 75, 75, 75, 125, 95, 40, 485, 80.83m, 5));
            _pokemons_disponiveis.Add(new Pokemon(607, "Litwick", 50, 30, 55, 65, 55, 20, 275, 45.83m, 5));
            _pokemons_disponiveis.Add(new Pokemon(608, "Lampent", 60, 40, 60, 95, 60, 55, 370, 61.67m, 5));
            _pokemons_disponiveis.Add(new Pokemon(609, "Chandelure", 60, 55, 90, 145, 90, 80, 520, 86.67m, 5));
            _pokemons_disponiveis.Add(new Pokemon(610, "Axew", 46, 87, 60, 30, 40, 57, 320, 53.33m, 5));
            _pokemons_disponiveis.Add(new Pokemon(611, "Fraxure", 66, 117, 70, 40, 50, 67, 410, 68.33m, 5));
            _pokemons_disponiveis.Add(new Pokemon(612, "Haxorus", 76, 147, 90, 60, 70, 97, 540, 90m, 5));
            _pokemons_disponiveis.Add(new Pokemon(613, "Cubchoo", 55, 70, 40, 60, 40, 40, 305, 50.83m, 5));
            _pokemons_disponiveis.Add(new Pokemon(614, "Beartic", 95, 110, 80, 70, 80, 50, 485, 80.83m, 5));
            _pokemons_disponiveis.Add(new Pokemon(615, "Cryogonal", 70, 50, 30, 95, 135, 105, 485, 80.83m, 5));
            _pokemons_disponiveis.Add(new Pokemon(616, "Shelmet", 50, 40, 85, 40, 65, 25, 305, 50.83m, 5));
            _pokemons_disponiveis.Add(new Pokemon(617, "Accelgor", 80, 70, 40, 100, 60, 145, 495, 82.5m, 5));
            _pokemons_disponiveis.Add(new Pokemon(618, "Stunfisk", 109, 66, 84, 81, 99, 32, 471, 78.5m, 5));
            _pokemons_disponiveis.Add(new Pokemon(619, "Mienfoo", 45, 85, 50, 55, 50, 65, 350, 58.33m, 5));
            _pokemons_disponiveis.Add(new Pokemon(620, "Mienshao", 65, 125, 60, 95, 60, 105, 510, 85m, 5));
            _pokemons_disponiveis.Add(new Pokemon(621, "Druddigon", 77, 120, 90, 60, 90, 48, 485, 80.83m, 5));
            _pokemons_disponiveis.Add(new Pokemon(622, "Golett", 59, 74, 50, 35, 50, 35, 303, 50.5m, 5));
            _pokemons_disponiveis.Add(new Pokemon(623, "Golurk", 89, 124, 80, 55, 80, 55, 483, 80.5m, 5));
            _pokemons_disponiveis.Add(new Pokemon(624, "Pawniard", 45, 85, 70, 40, 40, 60, 340, 56.67m, 5));
            _pokemons_disponiveis.Add(new Pokemon(625, "Bisharp", 65, 125, 100, 60, 70, 70, 490, 81.67m, 5));
            _pokemons_disponiveis.Add(new Pokemon(626, "Bouffalant", 95, 110, 95, 40, 95, 55, 490, 81.67m, 5));
            _pokemons_disponiveis.Add(new Pokemon(627, "Rufflet", 70, 83, 50, 37, 50, 60, 350, 58.33m, 5));
            _pokemons_disponiveis.Add(new Pokemon(628, "Braviary", 100, 123, 75, 57, 75, 80, 510, 85m, 5));
            _pokemons_disponiveis.Add(new Pokemon(629, "Vullaby", 70, 55, 75, 45, 65, 60, 370, 61.67m, 5));
            _pokemons_disponiveis.Add(new Pokemon(630, "Mandibuzz", 110, 65, 105, 55, 95, 80, 510, 85m, 5));
            _pokemons_disponiveis.Add(new Pokemon(631, "Heatmor", 85, 97, 66, 105, 66, 65, 484, 80.67m, 5));
            _pokemons_disponiveis.Add(new Pokemon(632, "Durant", 58, 109, 112, 48, 48, 109, 484, 80.67m, 5));
            _pokemons_disponiveis.Add(new Pokemon(633, "Deino", 52, 65, 50, 45, 50, 38, 300, 50m, 5));
            _pokemons_disponiveis.Add(new Pokemon(634, "Zweilous", 72, 85, 70, 65, 70, 58, 420, 70m, 5));
            _pokemons_disponiveis.Add(new Pokemon(635, "Hydreigon", 92, 105, 90, 125, 90, 98, 600, 100m, 5));
            _pokemons_disponiveis.Add(new Pokemon(636, "Larvesta", 55, 85, 55, 50, 55, 60, 360, 60m, 5));
            _pokemons_disponiveis.Add(new Pokemon(637, "Volcarona", 85, 60, 65, 135, 105, 100, 550, 91.67m, 5));
            _pokemons_disponiveis.Add(new Pokemon(638, "Cobalion", 91, 90, 129, 90, 72, 108, 580, 96.67m, 5));
            _pokemons_disponiveis.Add(new Pokemon(639, "Terrakion", 91, 129, 90, 72, 90, 108, 580, 96.67m, 5));
            _pokemons_disponiveis.Add(new Pokemon(640, "Virizion", 91, 90, 72, 90, 129, 108, 580, 96.67m, 5));
            _pokemons_disponiveis.Add(new Pokemon(641, "Tornadus", 79, 115, 70, 125, 80, 111, 580, 96.67m, 5));
            _pokemons_disponiveis.Add(new Pokemon(642, "Thundurus", 79, 115, 70, 125, 80, 111, 580, 96.67m, 5));
            _pokemons_disponiveis.Add(new Pokemon(643, "Reshiram", 100, 120, 100, 150, 120, 90, 680, 113.33m, 5));
            _pokemons_disponiveis.Add(new Pokemon(644, "Zekrom", 100, 150, 120, 120, 100, 90, 680, 113.33m, 5));
            _pokemons_disponiveis.Add(new Pokemon(645, "Landorus", 89, 125, 90, 115, 80, 101, 600, 100m, 5));
            _pokemons_disponiveis.Add(new Pokemon(646, "Kyurem", 125, 130, 90, 130, 90, 95, 660, 110m, 5));
            _pokemons_disponiveis.Add(new Pokemon(647, "Keldeo", 91, 72, 90, 129, 90, 108, 580, 96.67m, 5));
            _pokemons_disponiveis.Add(new Pokemon(648, "Meloetta", 100, 77, 77, 128, 128, 90, 600, 100m, 5));
            _pokemons_disponiveis.Add(new Pokemon(649, "Genesect", 71, 120, 95, 120, 95, 99, 600, 100m, 5));
            _pokemons_disponiveis.Add(new Pokemon(650, "Chespin", 56, 61, 65, 48, 45, 38, 313, 52.17m, 6));
            _pokemons_disponiveis.Add(new Pokemon(651, "Quilladin", 61, 78, 95, 56, 58, 57, 405, 67.5m, 6));
            _pokemons_disponiveis.Add(new Pokemon(652, "Chesnaught", 88, 107, 122, 74, 75, 64, 530, 88.33m, 6));
            _pokemons_disponiveis.Add(new Pokemon(653, "Fennekin", 40, 45, 40, 62, 60, 60, 307, 51.17m, 6));
            _pokemons_disponiveis.Add(new Pokemon(654, "Braixen", 59, 59, 58, 90, 70, 73, 409, 68.17m, 6));
            _pokemons_disponiveis.Add(new Pokemon(655, "Delphox", 75, 69, 72, 114, 100, 104, 534, 89m, 6));
            _pokemons_disponiveis.Add(new Pokemon(656, "Froakie", 41, 56, 40, 62, 44, 71, 314, 52.33m, 6));
            _pokemons_disponiveis.Add(new Pokemon(657, "Frogadier", 54, 63, 52, 83, 56, 97, 405, 67.5m, 6));
            _pokemons_disponiveis.Add(new Pokemon(658, "Greninja", 72, 95, 67, 103, 71, 122, 530, 88.33m, 6));
            _pokemons_disponiveis.Add(new Pokemon(659, "Bunnelby", 38, 36, 38, 32, 36, 57, 237, 39.5m, 6));
            _pokemons_disponiveis.Add(new Pokemon(660, "Diggersby", 85, 56, 77, 50, 77, 78, 423, 70.5m, 6));
            _pokemons_disponiveis.Add(new Pokemon(661, "Fletchling", 45, 50, 43, 40, 38, 62, 278, 46.33m, 6));
            _pokemons_disponiveis.Add(new Pokemon(662, "Fletchinder", 62, 73, 55, 56, 52, 84, 382, 63.67m, 6));
            _pokemons_disponiveis.Add(new Pokemon(663, "Talonflame", 78, 81, 71, 74, 69, 126, 499, 83.17m, 6));
            _pokemons_disponiveis.Add(new Pokemon(664, "Scatterbug", 38, 35, 40, 27, 25, 35, 200, 33.33m, 6));
            _pokemons_disponiveis.Add(new Pokemon(665, "Spewpa", 45, 22, 60, 27, 30, 29, 213, 35.5m, 6));
            _pokemons_disponiveis.Add(new Pokemon(666, "Vivillon", 80, 52, 50, 90, 50, 89, 411, 68.5m, 6));
            _pokemons_disponiveis.Add(new Pokemon(667, "Litleo", 62, 50, 58, 73, 54, 72, 369, 61.5m, 6));
            _pokemons_disponiveis.Add(new Pokemon(668, "Pyroar", 86, 68, 72, 109, 66, 106, 507, 84.5m, 6));
            _pokemons_disponiveis.Add(new Pokemon(669, "Flabébé", 44, 38, 39, 61, 79, 42, 303, 50.5m, 6));
            _pokemons_disponiveis.Add(new Pokemon(670, "Floette", 54, 45, 47, 75, 98, 52, 371, 61.83m, 6));
            _pokemons_disponiveis.Add(new Pokemon(671, "Florges", 78, 65, 68, 112, 154, 75, 552, 92m, 6));
            _pokemons_disponiveis.Add(new Pokemon(672, "Skiddo", 66, 65, 48, 62, 57, 52, 350, 58.33m, 6));
            _pokemons_disponiveis.Add(new Pokemon(673, "Gogoat", 123, 100, 62, 97, 81, 68, 531, 88.5m, 6));
            _pokemons_disponiveis.Add(new Pokemon(674, "Pancham", 67, 82, 62, 46, 48, 43, 348, 58m, 6));
            _pokemons_disponiveis.Add(new Pokemon(675, "Pangoro", 95, 124, 78, 69, 71, 58, 495, 82.5m, 6));
            _pokemons_disponiveis.Add(new Pokemon(676, "Furfrou", 75, 80, 60, 65, 90, 102, 472, 78.67m, 6));
            _pokemons_disponiveis.Add(new Pokemon(677, "Espurr", 62, 48, 54, 63, 60, 68, 355, 59.17m, 6));
            _pokemons_disponiveis.Add(new Pokemon(678, "Meowstic", 74, 48, 76, 83, 81, 104, 466, 77.67m, 6));
            _pokemons_disponiveis.Add(new Pokemon(679, "Honedge", 45, 80, 100, 35, 37, 28, 325, 54.17m, 6));
            _pokemons_disponiveis.Add(new Pokemon(680, "Doublade", 59, 110, 150, 45, 49, 35, 448, 74.67m, 6));
            _pokemons_disponiveis.Add(new Pokemon(681, "Aegislash", 60, 50, 150, 50, 150, 60, 520, 86.67m, 6));
            _pokemons_disponiveis.Add(new Pokemon(682, "Spritzee", 78, 52, 60, 63, 65, 23, 341, 56.83m, 6));
            _pokemons_disponiveis.Add(new Pokemon(683, "Aromatisse", 101, 72, 72, 99, 89, 29, 462, 77m, 6));
            _pokemons_disponiveis.Add(new Pokemon(684, "Swirlix", 62, 48, 66, 59, 57, 49, 341, 56.83m, 6));
            _pokemons_disponiveis.Add(new Pokemon(685, "Slurpuff", 82, 80, 86, 85, 75, 72, 480, 80m, 6));
            _pokemons_disponiveis.Add(new Pokemon(686, "Inkay", 53, 54, 53, 37, 46, 45, 288, 48m, 6));
            _pokemons_disponiveis.Add(new Pokemon(687, "Malamar", 86, 92, 88, 68, 75, 73, 482, 80.33m, 6));
            _pokemons_disponiveis.Add(new Pokemon(688, "Binacle", 42, 52, 67, 39, 56, 50, 306, 51m, 6));
            _pokemons_disponiveis.Add(new Pokemon(689, "Barbaracle", 72, 105, 115, 54, 86, 68, 500, 83.33m, 6));
            _pokemons_disponiveis.Add(new Pokemon(690, "Skrelp", 50, 60, 60, 60, 60, 30, 320, 53.33m, 6));
            _pokemons_disponiveis.Add(new Pokemon(691, "Dragalge", 65, 75, 90, 97, 123, 44, 494, 82.33m, 6));
            _pokemons_disponiveis.Add(new Pokemon(692, "Clauncher", 50, 53, 62, 58, 63, 44, 330, 55m, 6));
            _pokemons_disponiveis.Add(new Pokemon(693, "Clawitzer", 71, 73, 88, 120, 89, 59, 500, 83.33m, 6));
            _pokemons_disponiveis.Add(new Pokemon(694, "Helioptile", 44, 38, 33, 61, 43, 70, 289, 48.17m, 6));
            _pokemons_disponiveis.Add(new Pokemon(695, "Heliolisk", 62, 55, 52, 109, 94, 109, 481, 80.17m, 6));
            _pokemons_disponiveis.Add(new Pokemon(696, "Tyrunt", 58, 89, 77, 45, 45, 48, 362, 60.33m, 6));
            _pokemons_disponiveis.Add(new Pokemon(697, "Tyrantrum", 82, 121, 119, 69, 59, 71, 521, 86.83m, 6));
            _pokemons_disponiveis.Add(new Pokemon(698, "Amaura", 77, 59, 50, 67, 63, 46, 362, 60.33m, 6));
            _pokemons_disponiveis.Add(new Pokemon(699, "Aurorus", 123, 77, 72, 99, 92, 58, 521, 86.83m, 6));
            _pokemons_disponiveis.Add(new Pokemon(700, "Sylveon", 95, 65, 65, 110, 130, 60, 525, 87.5m, 6));
            _pokemons_disponiveis.Add(new Pokemon(701, "Hawlucha", 78, 92, 75, 74, 63, 118, 500, 83.33m, 6));
            _pokemons_disponiveis.Add(new Pokemon(702, "Dedenne", 67, 58, 57, 81, 67, 101, 431, 71.83m, 6));
            _pokemons_disponiveis.Add(new Pokemon(703, "Carbink", 50, 50, 150, 50, 150, 50, 500, 83.33m, 6));
            _pokemons_disponiveis.Add(new Pokemon(704, "Goomy", 45, 50, 35, 55, 75, 40, 300, 50m, 6));
            _pokemons_disponiveis.Add(new Pokemon(705, "Sliggoo", 68, 75, 53, 83, 113, 60, 452, 75.33m, 6));
            _pokemons_disponiveis.Add(new Pokemon(706, "Goodra", 90, 100, 70, 110, 150, 80, 600, 100m, 6));
            _pokemons_disponiveis.Add(new Pokemon(707, "Klefki", 57, 80, 91, 80, 87, 75, 470, 78.33m, 6));
            _pokemons_disponiveis.Add(new Pokemon(708, "Phantump", 43, 70, 48, 50, 60, 38, 309, 51.5m, 6));
            _pokemons_disponiveis.Add(new Pokemon(709, "Trevenant", 85, 110, 76, 65, 82, 56, 474, 79m, 6));
            _pokemons_disponiveis.Add(new Pokemon(710, "Pumpkaboo", 44, 66, 70, 44, 55, 56, 335, 55.83m, 6));
            _pokemons_disponiveis.Add(new Pokemon(711, "Gourgeist", 55, 85, 122, 58, 75, 99, 494, 82.33m, 6));
            _pokemons_disponiveis.Add(new Pokemon(712, "Bergmite", 55, 69, 85, 32, 35, 28, 304, 50.67m, 6));
            _pokemons_disponiveis.Add(new Pokemon(713, "Avalugg", 95, 117, 184, 44, 46, 28, 514, 85.67m, 6));
            _pokemons_disponiveis.Add(new Pokemon(714, "Noibat", 40, 30, 35, 45, 40, 55, 245, 40.83m, 6));
            _pokemons_disponiveis.Add(new Pokemon(715, "Noivern", 85, 70, 80, 97, 80, 123, 535, 89.17m, 6));
            _pokemons_disponiveis.Add(new Pokemon(716, "Xerneas", 126, 131, 95, 131, 98, 99, 680, 113.33m, 6));
            _pokemons_disponiveis.Add(new Pokemon(717, "Yveltal", 126, 131, 95, 131, 98, 99, 680, 113.33m, 6));
            _pokemons_disponiveis.Add(new Pokemon(718, "Zygarde", 108, 100, 121, 81, 95, 95, 600, 100m, 6));
            _pokemons_disponiveis.Add(new Pokemon(719, "Diancie", 50, 100, 150, 100, 150, 50, 600, 100m, 6,
                new Pokemon[] { new Pokemon(719, "Mega Diancie", 50, 160, 110, 160, 110, 110, 700, 116.67m, 6) }));

            _pokemons_disponiveis.Add(new Pokemon(720, "Hoopa", 80, 160, 60, 170, 130, 80, 680, 113.33m, 6));
            _pokemons_disponiveis.Add(new Pokemon(721, "Volcanion", 80, 110, 120, 130, 90, 70, 600, 100m, 6));

            //_pokemons_disponiveis.Add(new Pokemon(386, "Deoxys (Normal Forme)            ", 50, 150, 50, 150, 50, 150, 600, 100m));
            //_pokemons_disponiveis.Add(new Pokemon(386, "Deoxys (Attack Forme)            ", 50, 180, 20, 180, 20, 150, 600, 100m));
            //_pokemons_disponiveis.Add(new Pokemon(386, "Deoxys (Defense Forme)           ", 50, 70, 160, 70, 160, 90, 600, 100m));
            //_pokemons_disponiveis.Add(new Pokemon(386, "Deoxys (Speed Forme)             ", 50, 95, 90, 95, 90, 180, 600, 100m));
            //_pokemons_disponiveis.Add(new Pokemon(413, "Wormadam (Plant Cloak)           ", 60, 59, 85, 79, 105, 36, 424, 70.67m));
            //_pokemons_disponiveis.Add(new Pokemon(413, "Wormadam (Sandy Cloak)           ", 60, 79, 105, 59, 85, 36, 424, 70.67m));
            //_pokemons_disponiveis.Add(new Pokemon(413, "Wormadam (Trash Cloak)           ", 60, 69, 95, 69, 95, 36, 424, 70.67m));
            //_pokemons_disponiveis.Add(new Pokemon(479, "Rotom (Normal Rotom)             ", 50, 50, 77, 95, 77, 91, 440, 73.33m));
            //_pokemons_disponiveis.Add(new Pokemon(479, "Rotom (Heat Rotom)               ", 50, 65, 107, 105, 107, 86, 520, 86.67m));
            //_pokemons_disponiveis.Add(new Pokemon(479, "Rotom (Wash Rotom)               ", 50, 65, 107, 105, 107, 86, 520, 86.67m));
            //_pokemons_disponiveis.Add(new Pokemon(479, "Rotom (Frost Rotom)              ", 50, 65, 107, 105, 107, 86, 520, 86.67m));
            //_pokemons_disponiveis.Add(new Pokemon(479, "Rotom (Fan Rotom)                ", 50, 65, 107, 105, 107, 86, 520, 86.67m));
            //_pokemons_disponiveis.Add(new Pokemon(479, "Rotom (Mow Rotom)                ", 50, 65, 107, 105, 107, 86, 520, 86.67m));

            _pokemons_disponiveis.Add(new Pokemon(1003, "Mega Venusaur", 80, 100, 123, 122, 120, 80, 625, 104.17m, 6, false, new int[] { 3 }, new int[] { }, types(Pokemon.Types.Grass, Pokemon.Types.Poison), true));
        }

        private List<Pokemon.Types> types(params Pokemon.Types[] types)
        {
            List<Pokemon.Types> types_pokemon = new List<Pokemon.Types>(types);

            return types_pokemon;
        }

        public List<Pokemon> obter_pokemons()
        {
            return _pokemons_disponiveis;
        }
    }
}
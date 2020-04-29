using System;
using System.Collections.Generic;
using System.Drawing;
using System.Pokemon;
using System.Windows.Forms;
using SorteioTimesPokemon.Properties;

namespace SorteioTimesPokemon
{
    public partial class ResultadoSorteio : Form
    {
        private int nmr_jogador = 0;

        public ResultadoSorteio()
        {
            InitializeComponent();
        }

        public void alimentar_resultado_sorteio(string nome_jogador, List<Pokemon> pokemons)
        {
            pokemons.Sort((x, y) => string.Compare(x.Nome, y.Nome));

            int total_base_status = 0;

            for (int i = 0; i < pokemons.Count; i++)
                total_base_status += pokemons[i].TotalStatus;

            decimal media_base_status = Math.Round(decimal.Divide(total_base_status, pokemons.Count), 3);

            GroupBox grp_jogador = new GroupBox();
            grp_jogador.Width = 275;
            grp_jogador.Height = 120;
            grp_jogador.Text = nome_jogador != null ? String.Format("{0} {1}", nome_jogador, media_base_status.ToString()) : "Pokémons disponíveis: " + pokemons.Count;

            Point location_jogador = new Point();

            if (nmr_jogador == 0)
                location_jogador = new Point(8, 7);
            else if (nmr_jogador % 2 == 0)
                location_jogador = new Point(8, 130 * (nmr_jogador / 2) + 7);
            else
                location_jogador = new Point(288, 130 * (nmr_jogador / 2) + 7);

            grp_jogador.Location = location_jogador;

            Point location = new Point();

            for (int i = 0; i < pokemons.Count; i++)
            {
                Label lbl_pokemon = new Label();
                lbl_pokemon.Text = "           " + pokemons[i].Nome + " " + pokemons[i].MegaForms.Length;
                lbl_pokemon.Size = new Size(110, 32);
                lbl_pokemon.AutoSize = false;
                lbl_pokemon.ImageAlign = ContentAlignment.MiddleLeft;
                lbl_pokemon.TextAlign = ContentAlignment.BottomLeft;

                object obj = Resources.ResourceManager.GetObject("_" + pokemons[i].Numero.ToString());
                lbl_pokemon.Image = (Bitmap)(obj);

                if (i == 0)
                    location = new Point(150, -17);
                if (i % 2 == 0)
                    location = new Point(location.X - 120, location.Y + 30);
                else
                    location = new Point(location.X + 120, location.Y);

                lbl_pokemon.Location = location;

                grp_jogador.Controls.Add(lbl_pokemon);
            }

            this.Controls.Add(grp_jogador);

            nmr_jogador++;

            if (nmr_jogador == 1)
            {
                this.Width = 310;
                this.Height = 170;
            }
            else if (nmr_jogador == 2)
            {
                this.Width = 590;
                this.Height = 170;
            }
            else if (nmr_jogador == 3 || nmr_jogador == 4)
            {
                this.Width = 590;
                this.Height = 300;
            }
            else if (nmr_jogador == 5 || nmr_jogador == 6)
            {
                this.Width = 590;
                this.Height = 430;
            }
            else if (nmr_jogador == 7 || nmr_jogador == 8)
            {
                this.Width = 590;
                this.Height = 560;
            }

            if (nome_jogador == null)
            {
                grp_jogador.AutoSize = true;
                this.Height = 500;
            }
        }

        public void alimentar_pokemons_disponiveis(List<Pokemon> pokemons)
        {
            pokemons.Sort((x, y) => { return x.TotalStatus.CompareTo(y.TotalStatus); });

            GroupBox grp_jogador = new GroupBox();
            grp_jogador.Name = "grp_jogador";
            grp_jogador.Width = 275;
            grp_jogador.Height = 500;
            grp_jogador.AutoSize = true;
            grp_jogador.Text = "Pokémons disponíveis: " + pokemons.Count;
            grp_jogador.Location = new Point(8, 30);

            Point location = new Point();

            for (int i = 0; i < pokemons.Count; i++)
            {
                Label lbl_pokemon = new Label();
                lbl_pokemon.Text = "           " + pokemons[i].Nome + " " + pokemons[i].TotalStatus;
                lbl_pokemon.Tag = pokemons[i].Nome + ": " /*+ string.Join(", ", pokemons[i].TypesOfPokemon)*/;
                lbl_pokemon.Size = new Size(120, 32);
                lbl_pokemon.AutoSize = false;
                lbl_pokemon.ImageAlign = ContentAlignment.MiddleLeft;
                lbl_pokemon.TextAlign = ContentAlignment.BottomLeft;
                lbl_pokemon.Click += new EventHandler(lbl_pokemon_Click);

                object obj = Resources.ResourceManager.GetObject("_" + pokemons[i].Numero.ToString());
                lbl_pokemon.Image = (Bitmap)(obj);

                if (i == 0)
                    location = new Point(150, -17);
                if (i % 2 == 0)
                    location = new Point(location.X - 120, location.Y + 30);
                else
                    location = new Point(location.X + 120, location.Y);

                lbl_pokemon.Location = location;

                grp_jogador.Controls.Add(lbl_pokemon);
            }

            this.Width = 310;
            this.Controls.Add(grp_jogador);
        }

        private void lbl_pokemon_Click(object sender, EventArgs e)
        {
            Control[] controls = this.Controls.Find("labelPKM", true);

            if (controls.Length > 0)
            {
                controls[0].Text = ((Label)sender).Tag.ToString();
                return;
            }

            Label lbl_pokemon = new Label();
            lbl_pokemon.Text = ((Label)sender).Tag.ToString();
            lbl_pokemon.Location = new Point(8, 7);
            lbl_pokemon.Name = "labelPKM";
            lbl_pokemon.AutoSize = true;

            this.Controls.Add(lbl_pokemon);
        }
    }
}
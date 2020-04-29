using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Pokemon;
using System.Threading;
using System.Windows.Forms;
using WMPLib;
using System.Reflection;

namespace SorteioTimesPokemon
{
    public partial class Principal : Form
    {
        private const string VERSAO = "2.0";

        private bool desmarcar_todos = true;

        private List<Pokemon> _pokemons_disponiveis = new List<Pokemon>();

        public Principal()
        {
            InitializeComponent();

            WindowsMediaPlayer wplayer = new WindowsMediaPlayer();

            wplayer.URL = @"Opening.mp3";

            // Ficará repetindo o áudio;
            wplayer.settings.setMode("loop", true);

            //wplayer.controls.play();
        }

        private void sortear_times(bool usar_arquivo)
        {
            if (lst_listview.Items.Count == 0)
            {
                MessageBox.Show("Adicione os jogadores");

                return;
            }

            // Obtem os pokémons disponíveis para sorteio.
            if (!obter_pokemons(usar_arquivo))
                return;

            int nmr_pokemons_por_jogador = (int)nmc_qtd_pokemons.Value;

            if (nmr_pokemons_por_jogador > _pokemons_disponiveis.Count)
            {
                MessageBox.Show("A quantidade de pokémons disponíveis é menor do que a quantidade de pokémons por jogador!", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            ResultadoSorteio form = new ResultadoSorteio();

            foreach (string jogador in lst_listview.Items)
            {
                List<Pokemon> pokemons_sorteados = new List<Pokemon>();
                decimal media_base_status = 0m;

                bool sorteou_mega_form = false;
                bool precisa_mega_form = false;

                while (media_base_status < Convert.ToInt32(nmc_media_minima_base_status.Value) || precisa_mega_form)
                {
                    pokemons_sorteados = sortear_pokemons(nmr_pokemons_por_jogador, chk_permite_repetir.Checked);

                    int total_base_status = 0;

                    for (int i = 0; i < nmr_pokemons_por_jogador; i++)
                    {
                        if (!sorteou_mega_form)
                        {
                            if (sorteou_mega_form = pokemons_sorteados[i].MegaForms != null)
                            {
                                sorteou_mega_form = pokemons_sorteados[i].MegaForms.Length > 0;
                            }
                        }

                        total_base_status += pokemons_sorteados[i].TotalStatus;
                    }

                    if (chk_incluir_mega_evolucao.Checked)
                    {
                        precisa_mega_form = true;

                        if (sorteou_mega_form)
                        {
                            precisa_mega_form = false;
                        }
                    }

                    media_base_status = decimal.Divide(total_base_status, nmr_pokemons_por_jogador);

                    // Define false para caso tenha sorteado mega forma mas a média não tenha batido, garantindo que caso seja feito novo sorteio
                    // tenha uma mega evolução também
                    sorteou_mega_form = false;
                }

                // ATENÇÃO: Não sei o motivo, mas se tirar esse sleep, os jogadores ficam com os mesmos pokémons.
                Thread.Sleep(20);

                if (chk_sorteio_secreto.Checked)
                    escrever_sorteio_arquivo(jogador, pokemons_sorteados);
                else
                    form.alimentar_resultado_sorteio(jogador, pokemons_sorteados);

                pokemons_sorteados.Clear();
            }

            // Só abre o form do resultado se o sorteio não for secreto
            if (chk_sorteio_secreto.Checked)
                MessageBox.Show("Sorteio realizado com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                form.ShowDialog();
        }

        private void btn_sortear_arquivo_Click(object sender, EventArgs e)
        {
            sortear_times(true);
        }

        private void btn_sortear_base_dados_Click(object sender, EventArgs e)
        {
            sortear_times(false);
        }

        private void btn_listar_pokemons_disponiveis_Click(object sender, EventArgs e)
        {
            ResultadoSorteio form = new ResultadoSorteio();

            DialogResult dr = MessageBox.Show("Deseja ver somente os pokémons do arquivo?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Se não obter pokémons, sai do método.
            if (!obter_pokemons(dr == DialogResult.Yes))
                return;

            form.alimentar_pokemons_disponiveis(_pokemons_disponiveis);
            form.ShowDialog();
        }

        private bool obter_pokemons(bool usar_arquivo)
        {
            Pokemons pokemons = new Pokemons();

            _pokemons_disponiveis = pokemons.obter_pokemons();

            if (usar_arquivo)
            {
                if (!File.Exists(@"Pokemons.txt"))
                {
                    MessageBox.Show("Não foi possível encontrar o arquivo \"Pokemons.txt\" no diretório raiz do sistema.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _pokemons_disponiveis.Clear();

                    return false;
                }

                // Pega o arquivo, lê linha por linha, adicionando os nomes dos pokémons do arquivo na lista.
                StreamReader arquivo = File.OpenText(@"Pokemons.txt");

                string linha = string.Empty;
                List<string> pokemons_arquivo = new List<string>();

                while ((linha = arquivo.ReadLine()) != null)
                    if (!linha.Contains('#'))
                        pokemons_arquivo.Add(linha);

                arquivo.Close();

                // Obtém os Pokémons do escolhidos pelo arquivo.
                _pokemons_disponiveis = obter_pokemons_disponiveis_pelos_nomes(_pokemons_disponiveis, pokemons_arquivo);
            }

            // Obtém os pokémons de acordo com os filtros escolhidos.
            _pokemons_disponiveis = obter_pokemons_com_filtro(
                _pokemons_disponiveis,
                (int)nmc_vlr_minimo.Value,
                (int)nmc_vlr_maximo.Value,
                chk_lendarios.Checked,
                chk_ultima_evolucao.Checked,
                obter_geracoes_escolhidas(),
                obter_tipos_escolhidos());

            return true;
        }

        private void escrever_sorteio_arquivo(string jogador, List<Pokemon> pokemons)
        {
            string diretorio = Directory.GetCurrentDirectory() + "\\times";

            if (!Directory.Exists(diretorio))
            {
                Directory.CreateDirectory(diretorio);
            }

            StreamWriter wr = new StreamWriter(String.Format(@"{0}\pkm_{1}.txt", diretorio, jogador));

            foreach (Pokemon pokemon in pokemons)
            {
                wr.WriteLine(pokemon.Nome);
            }

            wr.Close();
        }

        private List<Pokemon> sortear_pokemons(int nmr_pokemons_por_jogador, bool permite_repetir)
        {
            Random random = new Random();
            List<Pokemon> pokemons_sorteados = new List<Pokemon>();

            while (pokemons_sorteados.Count < nmr_pokemons_por_jogador)
            {
                int nmr_pokemon = random.Next(0, _pokemons_disponiveis.Count);

                if (permite_repetir)
                {
                    pokemons_sorteados.Add(_pokemons_disponiveis[nmr_pokemon]);
                    continue;
                }

                if (!pokemons_sorteados.Contains(_pokemons_disponiveis[nmr_pokemon]))
                    pokemons_sorteados.Add(_pokemons_disponiveis[nmr_pokemon]);
            }

            return pokemons_sorteados;
        }

        private void txt_nme_jogador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txt_nme_jogador.Text.Trim().Length > 0)
                {
                    if (!lst_listview.Items.Contains(txt_nme_jogador.Text.Trim()))
                    {
                        lst_listview.Items.Add(txt_nme_jogador.Text.Trim());
                        txt_nme_jogador.ResetText();
                    }
                    else
                        MessageBox.Show("O nome do jogador já está inserido da lista!", "Atenção",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_remover_jogador_Click(object sender, EventArgs e)
        {
            // Crio o array de objetos para fazer a cópia dos itens selecionados para alterar na ListBox.
            object[] itens = new object[lst_listview.SelectedItems.Count];

            lst_listview.SelectedItems.CopyTo(itens, 0);

            foreach (object item in itens)
                lst_listview.Items.Remove(item);
        }

        private List<int> obter_geracoes_escolhidas()
        {
            List<int> geracoes = new List<int>();

            if (chk_geracao_1.Checked)
                geracoes.Add(1);

            if (chk_geracao_2.Checked)
                geracoes.Add(2);

            if (chk_geracao_3.Checked)
                geracoes.Add(3);

            if (chk_geracao_4.Checked)
                geracoes.Add(4);

            if (chk_geracao_5.Checked)
                geracoes.Add(5);

            if (chk_geracao_6.Checked)
                geracoes.Add(6);

            return geracoes;
        }

        private List<Pokemon.Types> obter_tipos_escolhidos()
        {
            List<Pokemon.Types> tipos = new List<Pokemon.Types>();

            if (chk_type_water.Checked)
                tipos.Add(Pokemon.Types.Water);

            if (chk_type_steel.Checked)
                tipos.Add(Pokemon.Types.Steel);

            if (chk_type_rock.Checked)
                tipos.Add(Pokemon.Types.Rock);

            if (chk_type_psychic.Checked)
                tipos.Add(Pokemon.Types.Psychic);

            if (chk_type_poison.Checked)
                tipos.Add(Pokemon.Types.Poison);

            if (chk_type_normal.Checked)
                tipos.Add(Pokemon.Types.Normal);

            if (chk_type_ice.Checked)
                tipos.Add(Pokemon.Types.Ice);

            if (chk_type_ground.Checked)
                tipos.Add(Pokemon.Types.Ground);

            if (chk_type_grass.Checked)
                tipos.Add(Pokemon.Types.Grass);

            if (chk_type_ghost.Checked)
                tipos.Add(Pokemon.Types.Ghost);

            if (chk_type_flying.Checked)
                tipos.Add(Pokemon.Types.Flying);

            if (chk_type_fire.Checked)
                tipos.Add(Pokemon.Types.Fire);

            if (chk_type_fighting.Checked)
                tipos.Add(Pokemon.Types.Fighting);

            if (chk_type_electric.Checked)
                tipos.Add(Pokemon.Types.Electric);

            if (chk_type_dragon.Checked)
                tipos.Add(Pokemon.Types.Dragon);

            if (chk_type_dark.Checked)
                tipos.Add(Pokemon.Types.Dark);

            if (chk_type_bug.Checked)
                tipos.Add(Pokemon.Types.Bug);

            return tipos;
        }

        private void lnklbl_desmarcar_todos_Click(object sender, EventArgs e)
        {
            // Desmarca e marca todos os tipos de pokémon.
            chk_type_water.Checked =
            chk_type_steel.Checked =
            chk_type_rock.Checked =
            chk_type_psychic.Checked =
            chk_type_poison.Checked =
            chk_type_normal.Checked =
            chk_type_ice.Checked =
            chk_type_ground.Checked =
            chk_type_grass.Checked =
            chk_type_ghost.Checked =
            chk_type_flying.Checked =
            chk_type_fire.Checked =
            chk_type_fighting.Checked =
            chk_type_electric.Checked =
            chk_type_dragon.Checked =
            chk_type_dark.Checked =
            chk_type_bug.Checked =
            desmarcar_todos = !desmarcar_todos;

            lnklbl_desmarcar_todos.Text = desmarcar_todos ? "Desmarcar todos" : "Marcar todos";
        }

        public List<Pokemon> obter_pokemons_com_filtro(List<Pokemon> pokemons_disponiveis, int vlr_minimo_status, int vlr_maximo_status, bool incluir_lendarios, bool ultima_evolucao, List<int> geracoes, List<Pokemon.Types> tipos)
        {
            List<Pokemon> pokemons = new List<Pokemon>();

            if (geracoes.Count > 0)
            {
                foreach (Pokemon pokemon in pokemons_disponiveis)
                {
                    /*
                    if (ultima_evolucao)
                        if (!pokemon.LastEvolution)
                            continue;                    

                    if (pokemon.Legendary && !incluir_lendarios)
                        continue;
                    */

                    if (pokemon.TotalStatus < vlr_minimo_status || pokemon.TotalStatus > vlr_maximo_status)
                        continue;

                    if (!geracoes.Contains(pokemon.Generation))
                        continue;

                    /*
                    if (pokemon.TypesOfPokemon.Length == 1)
                    {
                        if (!tipos.Contains(pokemon.TypesOfPokemon[0]))
                            continue;
                    }
                    else if (pokemon.TypesOfPokemon.Length == 2)
                    {
                        if (!tipos.Contains(pokemon.TypesOfPokemon[0]))
                            if (!tipos.Contains(pokemon.TypesOfPokemon[1]))
                                continue;
                    }
                    */

                    pokemons.Add(pokemon);
                }
            }

            return pokemons;
        }

        public List<Pokemon> obter_pokemons_disponiveis_pelos_nomes(List<Pokemon> pokemons_disponiveis, List<string> nomes_pokemons)
        {
            List<Pokemon> pokemons = new List<Pokemon>();

            foreach (Pokemon pokemon in pokemons_disponiveis)
            {
                foreach (string nome_pokemon in nomes_pokemons)
                {
                    if (pokemon.Nome.ToUpper() == nome_pokemon.ToUpper())
                    {
                        pokemons.Add(pokemon);
                        break;
                    }
                }
            }

            return pokemons;
        }

        private void lbl_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("Esta é a versão {0}.", VERSAO), "Versão", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

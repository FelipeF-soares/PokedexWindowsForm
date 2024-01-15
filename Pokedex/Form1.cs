using Newtonsoft.Json;
using Pokedex.Models;
using Pokedex.Models.PokemonClasses;

namespace Pokedex
{
    public partial class Form1 : Form
    {
        private List<Pokemon> pokemonList;
        private List<Label> labelsIDs;
        private List<Label> labesNomes;
        private List<Label> labesPower;
        private List<PictureBox> pictureBoxList;
        private LoadImagemPokemon imagem;

        public Form1()
        {
            InitializeComponent();
            pokemonList = new List<Pokemon>();
            labelsIDs = new List<Label>();
            labesNomes = new List<Label>();
            labesPower = new List<Label>();
            pictureBoxList = new List<PictureBox>();


            labelsIDs.Add(labelID0);
            labelsIDs.Add(labelID1);
            labelsIDs.Add(labelID2);
            labelsIDs.Add(labelID3);
            labelsIDs.Add(labelID4);
            labelsIDs.Add(labelID5);
            labelsIDs.Add(labelID6);
            labelsIDs.Add(labelID7);
            labelsIDs.Add(labelID8);
            labelsIDs.Add(labelID9);

            labesNomes.Add(labelNome0);
            labesNomes.Add(labelNome1);
            labesNomes.Add(labelNome2);
            labesNomes.Add(labelNome3);
            labesNomes.Add(labelNome4);
            labesNomes.Add(labelNome5);
            labesNomes.Add(labelNome6);
            labesNomes.Add(labelNome7);
            labesNomes.Add(labelNome8);
            labesNomes.Add(labelNome9);

            labesPower.Add(labelPower0);
            labesPower.Add(labelPower1);
            labesPower.Add(labelPower2);
            labesPower.Add(labelPower3);
            labesPower.Add(labelPower4);
            labesPower.Add(labelPower5);
            labesPower.Add(labelPower6);
            labesPower.Add(labelPower7);
            labesPower.Add(labelPower8);
            labesPower.Add(labelPower9);

            pictureBoxList.Add(pictureBoxPokemon0);
            pictureBoxList.Add(pictureBoxPokemon1);
            pictureBoxList.Add(pictureBoxPokemon2);
            pictureBoxList.Add(pictureBoxPokemon3);
            pictureBoxList.Add(pictureBoxPokemon4);
            pictureBoxList.Add(pictureBoxPokemon5);
            pictureBoxList.Add(pictureBoxPokemon6);
            pictureBoxList.Add(pictureBoxPokemon7);
            pictureBoxList.Add(pictureBoxPokemon8);
            pictureBoxList.Add(pictureBoxPokemon9);
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Pokemon pokemon = new Pokemon();
                pokemonList = await pokemon.Pokemons(10);
                PreencheLabel();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: "+ex.Message);
            }
            
        }

        private void PreencheLabel()
        {
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    labelsIDs[i].Text = pokemonList[i].Id.ToString();
                    labesNomes[i].Text = pokemonList[i].Name;
                    labesPower[i].Text = pokemonList[i].PokemonTypes[0].Type.Name;
                    imagem = new LoadImagemPokemon(pokemonList[i].Sprites.FrontDefault);
                    pictureBoxList[i].Image = imagem.RetornaImagem();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            
        }
    }
}
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Models.PokemonClasses;

public class Pokemon
{
    private GetPokemonAPI getPokemon;
    public Pokemon()
    {
        getPokemon = new GetPokemonAPI("http://pokeapi.co/api/v2/pokemon-form/");
    }

    [JsonProperty("id")]
    public int Id { get; set; }
    [JsonProperty("Name")]
    public string Name { get; set; }
    [JsonProperty("types")]
    public List<PokemonTypes> PokemonTypes { get; set; }
    [JsonProperty("sprites")]
    public Sprites Sprites { get; set; }

    public async Task <List<Pokemon>> Pokemons(int quantidade)
    {
        List<Pokemon> pokemons = new List<Pokemon>();
        for(int i = 0; i < quantidade; i++)
        {
            Pokemon pokemon = new Pokemon();
            string pokemonString = string.Empty;
            pokemonString = await getPokemon.RealizaRequisicaoAsysnc(i+1);
            pokemon = JsonConvert.DeserializeObject<Pokemon>(pokemonString);
            pokemons.Add(pokemon);
        }
        return pokemons;
    }
}

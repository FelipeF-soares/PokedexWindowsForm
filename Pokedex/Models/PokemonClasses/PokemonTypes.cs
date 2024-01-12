using Newtonsoft.Json;

namespace Pokedex.Models.PokemonClasses;

public class PokemonTypes
{
    [JsonProperty("type")]
    public PokemonTypeDetails Type { get; set; }
}
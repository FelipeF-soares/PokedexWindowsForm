using Newtonsoft.Json;

namespace Pokedex.Models.PokemonClasses;

public class PokemonTypeDetails
{
    [JsonProperty("name")]
    public string Name { get; set; }
}
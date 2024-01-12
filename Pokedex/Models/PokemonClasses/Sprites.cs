using Newtonsoft.Json;

namespace Pokedex.Models.PokemonClasses;

public class Sprites
{
    [JsonProperty("front_default")]
    public string FrontDefault {  get; set; }
}
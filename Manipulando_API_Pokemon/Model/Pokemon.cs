using Manipulando_API_Pokemon.API;
using Newtonsoft.Json;


namespace Manipulando_API_Pokemon.Model
{
    public class Pokemon
    {

        [JsonProperty("name")]    
        public string Name { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("weight")]
        public int Weight { get; set; }

        [JsonProperty("abilities")]
        public List<Abilities> abilities { get; set; }

        public Pokemon BuscarPokemon(string nome) => APIComunicacao.RetornarJSONAPIPokemon(nome);

    }
}

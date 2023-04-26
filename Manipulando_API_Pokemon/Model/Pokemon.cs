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
        public List<Abilities> Abilities { get; set; }

        [JsonProperty("stats")]

        public List<Stats> Stats { get; set; }

        public int Fome { get; set; }

        public int Sono { get; set; }

        public int Humor { get; set; }

        public Pokemon() {
            this.Fome = 0;
            this.Sono = 0;
            this.Humor = Fome + Sono;
        }


        public Pokemon BuscarPokemon(string nome) => APIComunicacao.RetornarJSONAPIPokemon(nome);

    }
}

using Manipulando_API_Pokemon.Model;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manipulando_API_Pokemon.API
{
    public static class APIComunicacao
    {
        public static Pokemon RetornarJSONAPIPokemon(string nome)
        {
            var client = new RestClient($"https://pokeapi.co/api/v2/"); // api
            RestRequest request = new RestRequest($"pokemon/{nome}", Method.Get); // rota
            var response = client.Execute(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var pokemon = JsonConvert.DeserializeObject<Pokemon>(response.Content);
                return pokemon;

            }
            else
            {
                Console.WriteLine(response.ErrorMessage);
                return null;
            }
        }

        public static Especie RetornarJSONAPIListaEspecies()
        {
            var client = new RestClient($"https://pokeapi.co/api/v2/");
            RestRequest request = new RestRequest($"pokemon/", Method.Get);
            var response = client.Execute(request);

            if(response.StatusCode == System.Net.HttpStatusCode.OK) 
            {
                var especies = JsonConvert.DeserializeObject<Especie>(response.Content);
                return especies ;
            } else
            {
                Console.WriteLine(response.ErrorMessage);
                return null;
            }
        }

    }
}

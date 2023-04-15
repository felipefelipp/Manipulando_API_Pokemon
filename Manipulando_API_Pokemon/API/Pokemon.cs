using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manipulando_API_Pokemon.API
{
    public  class Pokemon
    { 
        public void BuscarPokemon(string nome)
        {
            var client = new RestClient($"https://pokeapi.co/api/v2/"); // api
            RestRequest request = new RestRequest($"pokemon/{nome}", Method.Get); // rota
            var response = client.Execute(request);

            if(response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var pokemon = JsonConvert.DeserializeObject(response.Content);
                Console.WriteLine(JsonConvert.SerializeObject(pokemon, Formatting.Indented));    
            } else
            {
                Console.WriteLine(response.ErrorMessage);
            }
            Console.ReadKey();
        }

    }
} 

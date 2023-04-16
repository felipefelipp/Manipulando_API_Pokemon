using Manipulando_API_Pokemon.API;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manipulando_API_Pokemon.Model
{
    public class Especie
    {
        [JsonProperty("results")]
        public List<Results> Results { get; set; }

        public Especie ListarEspecies() => APIComunicacao.RetornarJSONAPIListaEspecies();
      
    }
}

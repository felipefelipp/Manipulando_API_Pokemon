using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manipulando_API_Pokemon.Model
{
    public class Usuario
    {
        public string Name { get; set; }    

        public List<Pokemon> Pokemons { get; set; }

        public Usuario() 
        {
            Pokemons = new List<Pokemon>();
        }
    }
}

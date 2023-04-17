using Manipulando_API_Pokemon.Controller;
using Manipulando_API_Pokemon.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Manipulando_API_Pokemon.View
{

    public class MenuView
    {
        private readonly PokemonController pokemonController;

        public MenuView()
        {
            pokemonController = new PokemonController();
        }

        public void IniciarJogo()
        {
            pokemonController.Jogar();
        }
    }

}

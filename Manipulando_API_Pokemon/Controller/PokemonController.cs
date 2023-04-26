using Manipulando_API_Pokemon.Model;
using Manipulando_API_Pokemon.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Manipulando_API_Pokemon.Controller
{


    public class PokemonController
    {

        private readonly PokemonView pokemonView;
        private readonly Usuario usuario;

        public PokemonController()
        {
            usuario = new Usuario();
            pokemonView = new PokemonView();
        }

        public void Jogar()
        {

            pokemonView.MensagemInicial(usuario);

            char opcaoSelecionada = '0';
            while (opcaoSelecionada != '6')
            {

                pokemonView.Opcoes();

                try
                {
                    opcaoSelecionada = Console.ReadLine()[0];
                }
                catch (IndexOutOfRangeException ex)
                { 
                    Console.WriteLine(ex.Message);
                }   

                switch (opcaoSelecionada)
                {
                    case '1':
                        pokemonView.ExibirEspecies();
                        AddPokemon(usuario);
                        break;
                    case '2':
                        pokemonView.ExibirPokemon(usuario);
                        break;
                    case '3':
                        pokemonView.ExibirListaPokemons(usuario);
                        break;
                    case '6':
                        pokemonView.EncerrarAplicacao();
                        break;
                    default:
                        Console.WriteLine("Esta opção não existe!");
                        Console.ReadKey();
                        break;
                }

            }
        }

        private void AddPokemon(Usuario usuario)
        {
            Pokemon pokemon = BuscarPokemon();
            if (pokemon != null) 
            {
                usuario.Pokemons.Add(pokemon);
            } 
            
        }

        private Pokemon BuscarPokemon()
        {
            try
            {
                Console.WriteLine("\nInsira o nome: ");
                string nomeEspecie = Console.ReadLine();
                Pokemon pokemonSelecionado = new Pokemon();

                var pokemonRetorno = pokemonSelecionado.BuscarPokemon(nomeEspecie);
                if (pokemonRetorno == null)
                {
                    throw new NullReferenceException("Não foi possível encontrar o Pokémon selecionado.");
                }
                Console.WriteLine($"Pokemon {pokemonRetorno.Name} adotado com sucesso!");
                Console.ReadKey();
                return pokemonRetorno;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType().ToString());
                Console.WriteLine(ex.Message);  
                Console.WriteLine("Pokemon não selecionado!");
                Console.ReadKey();
                return null;
            }
        }

    }

}

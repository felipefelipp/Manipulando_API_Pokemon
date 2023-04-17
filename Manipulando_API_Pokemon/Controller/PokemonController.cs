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
    // MenuController.cs

    public class PokemonController
    {
        private readonly Usuario usuario;

        public PokemonController()
        {
            usuario = new Usuario();
        }

        public void Jogar()
        {
            

            Console.WriteLine("****************************************");
            Console.WriteLine("*******         POKEMÓN         ********");
            Console.WriteLine("****************************************");

            Console.WriteLine("Qual o seu nome?");

            usuario.Name = Console.ReadLine();

            Console.WriteLine($"Seja bem vindo {usuario.Name}!\n\n ");
            char opcaoSelecionada = '0';
            while (opcaoSelecionada != '6')
            {
                Console.Clear();
                Console.WriteLine("O que você deseja? ");
                Console.WriteLine("1 - Adotar um Pokemon");
                Console.WriteLine("2 - Ver seus Pokemons");
                Console.WriteLine("6 - Sair");

                opcaoSelecionada = Console.ReadLine()[0];

                switch (opcaoSelecionada)
                {
                    case '1':
                        ExibirEspecies();
                       // try {
                            usuario.Pokemons.Add(AdicionarPokemon());
                        //}
                        //catch(Exception ex)
                        //{
                        //    Console.WriteLine(ex.Message + "Pokemon não encontrado, tente novamente: ");
                        //    //Console.Read();
                        //    //usuario.Pokemons.Add(AdicionarPokemon());
                            
                        //}
                       // Console.WriteLine("Teste");
                       // Console.Read();
                        break;
                    case '2':
                        ExibirPokemons();
                        break;
                    case '6':
                        EncerrarAplicacao();
                        //Application.Exit();
                        break;
                }
                 
            }
        }

        private void ExibirEspecies()
        {
            Console.WriteLine("Escolha uma das espécies a seguir:\n");
            var especie = new Especie().ListarEspecies();

            foreach (var lista in especie.Results)
            {
                Console.WriteLine(lista.Name);
            }
        }

        private Pokemon AdicionarPokemon()
        {
            Console.WriteLine("\nInsira o nome: ");
            string nomeEspecie = Console.ReadLine();
            Pokemon pokemonSelecionado = new Pokemon();
            return pokemonSelecionado.BuscarPokemon(nomeEspecie);
        }

        private void ExibirPokemons()
        {
            foreach (var pokemon in usuario.Pokemons)
            {
                Console.WriteLine("*******************************************");
                Console.WriteLine($"Pokemon: {pokemon.Name}");
                Console.WriteLine($"Altura: {pokemon.Height}cm");
                Console.WriteLine($"Peso: {pokemon.Weight}kg");
                Console.WriteLine("\nHabilidades: ");
                foreach (var abilities in pokemon.Abilities)
                {
                    Console.WriteLine(abilities.ability.name);
                }
                Console.WriteLine("\nEstatísticas: ");
                foreach (var stat in pokemon.Stats)
                {
                    Console.WriteLine($"Estatística: {stat.Stat.Name}");
                    Console.WriteLine($"Valor: {stat.Base_stat}");
                }

            }
            Console.ReadKey();
        }

        private void EncerrarAplicacao()
        {
            Console.WriteLine("... Encerrando a aplicação ...");
            Console.ReadKey();
            
        }
    }

}

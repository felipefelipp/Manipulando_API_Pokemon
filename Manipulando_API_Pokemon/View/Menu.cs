using Manipulando_API_Pokemon.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Manipulando_API_Pokemon.View
{
    public class Menu
    {
        public void Jogar()
        {
            Usuario usuario = new Usuario();

            char opcaoSelecionada = '0';


            Console.WriteLine("****************************************");
            Console.WriteLine("*******         POKEMÓN         ********");
            Console.WriteLine("****************************************");

            Console.WriteLine("Qual o seu nome?");

            usuario.Name = Console.ReadLine();

            Console.WriteLine($"Seja bem vindo {usuario.Name}!\n\n ");

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
                        usuario.Pokemons.Add(AdicionarPokemon());
                        break;
                    case '2':
                        foreach (var pokemon in usuario.Pokemons)
                        {
                            Console.WriteLine(pokemon.Name);
                        }
                        break;
                    case '6':
                        EncerrarAplicacao();
                        break;
                }
            }
        }

        public void ExibirEspecies()
        {
            Console.WriteLine("Escolha uma das espécies a seguir:\n");
            var especie = new Especie().ListarEspecies();

            foreach (var lista in especie.Results)
            {
                Console.WriteLine(lista.Name);
            }
        }

        public Pokemon AdicionarPokemon()
        {
            Console.WriteLine("\nInsira o nome: ");
            string nomeEspecie = Console.ReadLine();
            Pokemon pokemonSelecionado = new Pokemon();
            return pokemonSelecionado.BuscarPokemon(nomeEspecie);
        }

        private void EncerrarAplicacao()
        {
            Console.WriteLine("... Encerrando a aplicação ...");
            Console.ReadKey();
        }
    }
}

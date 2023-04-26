using Manipulando_API_Pokemon.Controller;
using Manipulando_API_Pokemon.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manipulando_API_Pokemon.View
{
    public class PokemonView
    {

        public void IniciarJogo()
        {
            PokemonController pokemonController = new PokemonController();
            pokemonController.Jogar();
        }

        public void Cabecalho()
        {
            Console.WriteLine("****************************************");
            Console.WriteLine("****************************************");
            Console.WriteLine("*******         POKEMÓN         ********");
            Console.WriteLine("****************************************");
            Console.WriteLine("****************************************");

        }
        public void MensagemInicial(Usuario usuario)
        {
            Cabecalho();
            Console.WriteLine("\n");
            Console.WriteLine("Qual o seu nome?");
            usuario.Name = Console.ReadLine();
            Console.WriteLine($"Seja bem vindo {usuario.Name}!\n\n ");
            Console.ReadKey();
        }

        public void Opcoes()
        {
            Console.Clear();
            Cabecalho();
            Console.WriteLine("\n");
            Console.WriteLine("O que você deseja? ");
            Console.WriteLine("1 - Adotar um Pokemon");
            Console.WriteLine("2 - Escolher um Pokemon ");
            Console.WriteLine("3 - Ver todos os seus Pokemons");
            Console.WriteLine("6 - Sair");
        }

        public void ExibirEspecies()
        {
            Console.Clear();
            Cabecalho();
            Console.WriteLine("\n");
            Console.WriteLine("Escolha uma das espécies a seguir:\n");
            var especie = new Especie().ListarEspecies();

            foreach (var lista in especie.Results)
            {
                Console.WriteLine(lista.Name);
            }
        }

        public void ExibirListaPokemons(Usuario usuario)
        {
            Console.Clear();
            Cabecalho();
            Console.WriteLine("\n");
            if (usuario.Pokemons.Count == 0) Console.WriteLine("Você ainda não tem pokemons, experimente adotar um no menu principal!");

            foreach (var pokemon in usuario.Pokemons)
            {

                Console.WriteLine($"Nome do pokemon: {pokemon.Name}");
                Console.WriteLine($"Altura: {pokemon.Height}");
                Console.WriteLine($"Peso: {pokemon.Weight}");
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
                if (pokemon.Fome == 2)
                {
                    Console.WriteLine("Seu Pokemon está cheio!");
                }
                else
                {
                    Console.WriteLine("Seu Pokemon está com fome!");
                }

                if (pokemon.Sono == 2)
                {
                    Console.WriteLine("Seu Pokemon está sem sono!");
                }
                else
                {
                    Console.WriteLine("Seu Pokemon está com sono!");
                }

                if (pokemon.Humor < 4)
                {
                    Console.WriteLine("Seu pokemon não está feliz!");
                }
                else
                {
                    Console.WriteLine("Seu pokemon está feliz!");
                }
                Console.WriteLine("-------------------------------------------");

            }
            Console.ReadKey();
        }

        public void ExibirPokemon(Usuario usuario)
        {
            Pokemon resultado = null; 
            Console.WriteLine("Qual pokemon você deseja? ");
            var nomePokemon = Console.ReadLine();
            if (nomePokemon.Length >= 1)
            {
              resultado = usuario.Pokemons.Find(x => x.Name.Contains(nomePokemon));
            }
            else resultado = null;

            if (resultado != null)
            {
                Console.WriteLine($"Nome do pokemon: {resultado.Name}");
                Console.WriteLine($"Altura: {resultado.Height}");
                Console.WriteLine($"Peso: {resultado.Weight}");
                Console.WriteLine("\nHabilidades: ");
                foreach (var abilities in resultado.Abilities)
                {
                    Console.WriteLine(abilities.ability.name);
                }
                Console.WriteLine("\nEstatísticas: ");
                foreach (var stat in resultado.Stats)
                {
                    Console.WriteLine($"Estatística: {stat.Stat.Name}");
                    Console.WriteLine($"Valor: {stat.Base_stat}");
                }
                if (resultado.Fome == 2)
                {
                    Console.WriteLine("Seu Pokemon está cheio!");
                }
                else
                {
                    Console.WriteLine("Seu Pokemon está com fome!");
                }

                if (resultado.Sono == 2)
                {
                    Console.WriteLine("Seu Pokemon está sem sono!");
                }
                else
                {
                    Console.WriteLine("Seu Pokemon está com sono!");
                }

                if (resultado.Humor < 4)
                {
                    Console.WriteLine("Seu pokemon não está feliz!");
                }
                else
                {
                    Console.WriteLine("Seu pokemon está feliz!");
                }
                Console.WriteLine("-------------------------------------------");

            }
            else
            {
                Console.WriteLine("Você não possui este pokemon!");
            }
            Console.ReadKey();
        }

        public void EncerrarAplicacao()
        {
            Console.Clear();
            Cabecalho();
            Console.WriteLine("\n");
            Console.WriteLine("... Encerrando a aplicação ...");
            Console.ReadKey();

        }
    }
}

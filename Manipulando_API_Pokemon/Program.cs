


using Manipulando_API_Pokemon.Model;

var nome = "blastoise";
Pokemon pokemon = new Pokemon();
var atributos = pokemon.BuscarPokemon(nome);

if (atributos != null)
{
    Console.WriteLine(atributos.Name);
    foreach (var ability in atributos.abilities)
    {
        Console.WriteLine(ability.ability.name);
    }
}

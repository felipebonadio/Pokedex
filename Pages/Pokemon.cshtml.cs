using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pokedex.Classes;
using System.Text.Json;
using Microsoft.AspNetCore.Http;

namespace Pokedex.Pages
{
    public class PokemonModel : PageModel
    {
        public Pokemon Pokemon{ get; set;}
        public Pokemon Anterior { get; set;}

        public Pokemon Proximo { get; set;}
        public void OnGet(int numero)
        {
            var ListaPokemon = JsonSerializer.Deserialize<List<Pokemon>>(HttpContext.Session.GetString("Pokemons"));
            Pokemon = ListaPokemon.Where(p => p.Numero == numero).SingleOrDefault();
            Anterior = Pokemon ==ListaPokemon.First()? null: ListaPokemon[ListaPokemon.IndexOf(Pokemon) - 1];
            Proximo = Pokemon ==ListaPokemon.Last()? null: ListaPokemon[ListaPokemon.IndexOf(Pokemon) + 1];
        }
    }
}

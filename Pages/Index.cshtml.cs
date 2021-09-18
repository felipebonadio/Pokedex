using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Pokedex.Classes;
using System.Collections.Generic;
using System.Text.Json;
using Microsoft.AspNetCore.Http;

namespace Pokedex.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public List<Pokemon> ListaPokemon { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("Pokemons"))){
                PopularLista();
            }
            ListaPokemon = JsonSerializer.Deserialize<List<Pokemon>>(HttpContext.Session.GetString("Pokemons"));
        }

        public void PopularLista(){
            var pokemons = new List<Pokemon>();
            HttpContext.Session.SetString("Pokemons", JsonSerializer.Serialize(pokemons));
        }
    }
}

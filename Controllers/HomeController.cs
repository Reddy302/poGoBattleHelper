using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PoGoBattleHelper.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace PoGoBattleHelper.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // CREATE FILEPATH
            string fileString = System.IO.File.ReadAllText("pokedex/pokemon.json");
            // CREATE A LIST OF POKES : List<Pokemon> pokes = parse json code here;
            List<Pokemon> pokeList = JsonSerializer.Deserialize<List<Pokemon>>(fileString);
            // RETURN THE VIEW WITH THE LIST OF POKES INCLUDED : View(pokes)
            return View(pokeList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

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
        private static readonly string fileString = System.IO.File.ReadAllText("pokedex/pokemon.json");
        private static readonly List<Pokemon> pokeList = JsonSerializer.Deserialize<List<Pokemon>>(fileString);
        private static List<Pokemon> myTeam = new List<Pokemon>();
        private static List<Pokemon> possiblePokes = new List<Pokemon>();
        private static List<Pokemon> possiblePokes2Types = new List<Pokemon>();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //[HttpGet]
        public IActionResult Index()
        {
            return View(pokeList);
        }

        [HttpGet]
        public IActionResult GetType()
        {
            ViewBag.possiblePokes = possiblePokes;
            return View();
        }

        [HttpPost, Route("/Home/GetType")]
        public IActionResult GetFirstType(string pokeTypes)
        {
            if (myTeam.Count < 3)
            {
                foreach (Pokemon poke in pokeList)
                {
                    for (int i = 0; i < poke.Types.Count(); i++)
                    {
                        if (poke.Types[i].Name == pokeTypes)
                        {
                            possiblePokes.Add(poke);
                        }
                    }
                }
            }
            ViewBag.possiblePokes = possiblePokes;
            return View("GetSecondType");
        }

        //[HttpPost, Route("/Home/GetType")]
        //public IActionResult FirstTypeDark(string pokeTypeDark)
        //{
        //    if (myTeam.Count < 3)
        //    {
        //        foreach (Pokemon poke in pokeList)
        //        {
        //            for (int i = 0; i < poke.Types.Count(); i++)
        //            {
        //                if (poke.Types[i].Name == pokeTypeDark)
        //                {
        //                    possiblePokes.Add(poke);
        //                }
        //            }
        //        }
        //    }
        //    ViewBag.possiblePokes = possiblePokes;
        //    return View("GetSecondType");
        //}

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

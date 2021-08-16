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

        [HttpGet, Route("Home/GetType")]
        public IActionResult GetType()
        {
            ViewBag.possiblePokes = possiblePokes;
            return View();
        }

        [HttpPost, Route("/Home/GetType")]
        public IActionResult GetType(string bugType, string darkType, string dragonType, string electricType, string fairyType, string fightingType, string fireType, string flyingType, string ghostType, string grassType, string groundType, string iceType, string normalType, string poisonType, string psychicType, string rockType, string steelType, string waterType)
        {
            if (myTeam.Count < 3)
            {
                foreach (Pokemon poke in pokeList)
                {
                    for (int i = 0; i < poke.Types.Count(); i++)
                    {
                        if (poke.Types[i].Name == bugType)
                        {
                            possiblePokes.Add(poke);
                        }
                        else if (poke.Types[i].Name == darkType)
                        {
                            possiblePokes.Add(poke);
                        }
                        else if (poke.Types[i].Name == dragonType)
                        {
                            possiblePokes.Add(poke);
                        }
                        else if (poke.Types[i].Name == electricType)
                        {
                            possiblePokes.Add(poke);
                        }
                        else if (poke.Types[i].Name == fairyType)
                        {
                            possiblePokes.Add(poke);
                        }
                        else if (poke.Types[i].Name == fightingType)
                        {
                            possiblePokes.Add(poke);
                        }
                        else if (poke.Types[i].Name == fireType)
                        {
                            possiblePokes.Add(poke);
                        }
                        else if (poke.Types[i].Name == flyingType)
                        {
                            possiblePokes.Add(poke);
                        }
                        else if (poke.Types[i].Name == ghostType)
                        {
                            possiblePokes.Add(poke);
                        }
                        else if (poke.Types[i].Name == grassType)
                        {
                            possiblePokes.Add(poke);
                        }
                        else if (poke.Types[i].Name == groundType)
                        {
                            possiblePokes.Add(poke);
                        }
                        else if (poke.Types[i].Name == iceType)
                        {
                            possiblePokes.Add(poke);
                        }
                        else if (poke.Types[i].Name == normalType)
                        {
                            possiblePokes.Add(poke);
                        }
                        else if (poke.Types[i].Name == poisonType)
                        {
                            possiblePokes.Add(poke);
                        }
                        else if (poke.Types[i].Name == psychicType)
                        {
                            possiblePokes.Add(poke);
                        }
                        else if (poke.Types[i].Name == rockType)
                        {
                            possiblePokes.Add(poke);
                        }
                        else if (poke.Types[i].Name == steelType)
                        {
                            possiblePokes.Add(poke);
                        }
                        else if (poke.Types[i].Name == waterType)
                        {
                            possiblePokes.Add(poke);
                        }
                    }
                }
                ViewBag.possiblePokes = possiblePokes;
                return Redirect("GetSecondType");
            }
            else
            {
                ViewBag.possiblePokes = possiblePokes;
                // CHANGE THIS VIEW TO THE TEAM VIEW ONCE CREATED
                return Redirect("GetSecondType");
            }
        }

        [HttpGet]
        public IActionResult GetSecondType()
        {
            ViewBag.possiblePokes = possiblePokes;
            ViewBag.possiblePokes2Types = possiblePokes2Types;
            return View();
        }

        [HttpPost, Route("/Home/GetSecondType")]
        public IActionResult GetSecondType(string bugType, string darkType, string dragonType, string electricType, string fairyType, string fightingType, string fireType, string flyingType, string ghostType, string grassType, string groundType, string iceType, string normalType, string poisonType, string psychicType, string rockType, string steelType, string waterType)
        {
            if (myTeam.Count < 3)
            {
                foreach (Pokemon poke in possiblePokes)
                {
                    for (int i = 0; i < poke.Types.Count(); i++)
                    {
                        if (poke.Types[i].Name == bugType)
                        {
                            possiblePokes2Types.Add(poke);
                        }
                        else if (poke.Types[i].Name == darkType)
                        {
                            possiblePokes2Types.Add(poke);
                        }
                        else if (poke.Types[i].Name == dragonType)
                        {
                            possiblePokes2Types.Add(poke);
                        }
                        else if (poke.Types[i].Name == electricType)
                        {
                            possiblePokes2Types.Add(poke);
                        }
                        else if (poke.Types[i].Name == fairyType)
                        {
                            possiblePokes2Types.Add(poke);
                        }
                        else if (poke.Types[i].Name == fightingType)
                        {
                            possiblePokes2Types.Add(poke);
                        }
                        else if (poke.Types[i].Name == fireType)
                        {
                            possiblePokes2Types.Add(poke);
                        }
                        else if (poke.Types[i].Name == flyingType)
                        {
                            possiblePokes2Types.Add(poke);
                        }
                        else if (poke.Types[i].Name == ghostType)
                        {
                            possiblePokes2Types.Add(poke);
                        }
                        else if (poke.Types[i].Name == grassType)
                        {
                            possiblePokes2Types.Add(poke);
                        }
                        else if (poke.Types[i].Name == groundType)
                        {
                            possiblePokes2Types.Add(poke);
                        }
                        else if (poke.Types[i].Name == iceType)
                        {
                            possiblePokes2Types.Add(poke);
                        }
                        else if (poke.Types[i].Name == normalType)
                        {
                            possiblePokes2Types.Add(poke);
                        }
                        else if (poke.Types[i].Name == poisonType)
                        {
                            possiblePokes2Types.Add(poke);
                        }
                        else if (poke.Types[i].Name == psychicType)
                        {
                            possiblePokes2Types.Add(poke);
                        }
                        else if (poke.Types[i].Name == rockType)
                        {
                            possiblePokes2Types.Add(poke);
                        }
                        else if (poke.Types[i].Name == steelType)
                        {
                            possiblePokes2Types.Add(poke);
                        }
                        else if (poke.Types[i].Name == waterType)
                        {
                            possiblePokes2Types.Add(poke);
                        }
                    }
                }
                ViewBag.possiblePokes2Types = possiblePokes2Types;
                return Redirect("SecondType");
            }
            ViewBag.possiblePokes2Types = possiblePokes2Types;
            // THIS WILL RETURN THE VIEW OF YOUR TEAM ONCE THAT IS CREATED
            return Redirect("SecondType");
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

// TODO: Return a linked image in the view instead of just the poke name
// TODO: When a pokemon name is clicked add the poke to myList and display a confirmation page with a slightly larger image of the poke
// TODO: Add a "choose next pokemon" button to the confirmation page
// TODO: Add a "go back this is not the poke I meant to choose" button to the confirmation page
// TODO: Put the getType code into a Partial View once it has been refactored.
// TODO: Add a Data Layer to the application

// TODO: Before finishing the app, make sure to find the updated poke list and import it to the app

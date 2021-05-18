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
            }
            ViewBag.possiblePokes = possiblePokes;
            return View("GetSecondType");
        }



        //[HttpPost, Route("/Home/GetType")]
        //public IActionResult GetFirstType(string Bug, string Dark, string Dragon, string Electric, string Fairy, string Fighting, string Fire, string Flying, string Ghost, string Grass, string Ground, string Ice, string Normal, string Poison, string Psychic, string Rock, string Steel, string Water)
        //{
        //    if (myTeam.Count < 3)
        //    {
        //        foreach (Pokemon poke in pokeList)
        //        {
        //            if (Bug != null)
        //            {
        //                for (int i = 0; i < poke.Types.Count(); i++)
        //                {
        //                    if (poke.Types[i].Name == Bug)
        //                    {
        //                        possiblePokes.Add(poke);
        //                    }
        //                }
        //            }
        //            else if (Dark != null)
        //            {
        //                for (int i = 0; i < poke.Types.Count(); i++)
        //                {
        //                    if (poke.Types[i].Name == Dark)
        //                    {
        //                        possiblePokes.Add(poke);
        //                    }
        //                }
        //            }
        //            else if (Dragon != null)
        //            {
        //                for (int i = 0; i < poke.Types.Count(); i++)
        //                {
        //                    if (poke.Types[i].Name == Dragon)
        //                    {
        //                        possiblePokes.Add(poke);
        //                    }
        //                }
        //            }
        //            else if (Electric != null)
        //            {
        //                for (int i = 0; i < poke.Types.Count(); i++)
        //                {
        //                    if (poke.Types[i].Name == Electric)
        //                    {
        //                        possiblePokes.Add(poke);
        //                    }
        //                }
        //            }
        //            else if (Fairy != null)
        //            {
        //                for (int i = 0; i < poke.Types.Count(); i++)
        //                {
        //                    if (poke.Types[i].Name == Fairy)
        //                    {
        //                        possiblePokes.Add(poke);
        //                    }
        //                }
        //            }
        //            else if (Fighting != null)
        //            {
        //                for (int i = 0; i < poke.Types.Count(); i++)
        //                {
        //                    if (poke.Types[i].Name == Fighting)
        //                    {
        //                        possiblePokes.Add(poke);
        //                    }
        //                }
        //            }
        //            else if (Fire != null)
        //            {
        //                for (int i = 0; i < poke.Types.Count(); i++)
        //                {
        //                    if (poke.Types[i].Name == Fire)
        //                    {
        //                        possiblePokes.Add(poke);
        //                    }
        //                }
        //            }
        //            else if (Flying != null)
        //            {
        //                for (int i = 0; i < poke.Types.Count(); i++)
        //                {
        //                    if (poke.Types[i].Name == Flying)
        //                    {
        //                        possiblePokes.Add(poke);
        //                    }
        //                }
        //            }
        //            else if (Ghost != null)
        //            {
        //                for (int i = 0; i < poke.Types.Count(); i++)
        //                {
        //                    if (poke.Types[i].Name == Ghost)
        //                    {
        //                        possiblePokes.Add(poke);
        //                    }
        //                }
        //            }
        //            else if (Grass != null)
        //            {
        //                for (int i = 0; i < poke.Types.Count(); i++)
        //                {
        //                    if (poke.Types[i].Name == Grass)
        //                    {
        //                        possiblePokes.Add(poke);
        //                    }
        //                }
        //            }
        //            else if (Ground != null)
        //            {
        //                for (int i = 0; i < poke.Types.Count(); i++)
        //                {
        //                    if (poke.Types[i].Name == Ground)
        //                    {
        //                        possiblePokes.Add(poke);
        //                    }
        //                }
        //            }
        //            else if (Ice != null)
        //            {
        //                for (int i = 0; i < poke.Types.Count(); i++)
        //                {
        //                    if (poke.Types[i].Name == Ice)
        //                    {
        //                        possiblePokes.Add(poke);
        //                    }
        //                }
        //            }
        //            else if (Normal != null)
        //            {
        //                for (int i = 0; i < poke.Types.Count(); i++)
        //                {
        //                    if (poke.Types[i].Name == Normal)
        //                    {
        //                        possiblePokes.Add(poke);
        //                    }
        //                }
        //            }
        //            else if (Poison != null)
        //            {
        //                for (int i = 0; i < poke.Types.Count(); i++)
        //                {
        //                    if (poke.Types[i].Name == Poison)
        //                    {
        //                        possiblePokes.Add(poke);
        //                    }
        //                }
        //            }
        //            else if (Psychic != null)
        //            {
        //                for (int i = 0; i < poke.Types.Count(); i++)
        //                {
        //                    if (poke.Types[i].Name == Psychic)
        //                    {
        //                        possiblePokes.Add(poke);
        //                    }
        //                }
        //            }
        //            else if (Rock != null)
        //            {
        //                for (int i = 0; i < poke.Types.Count(); i++)
        //                {
        //                    if (poke.Types[i].Name == Rock)
        //                    {
        //                        possiblePokes.Add(poke);
        //                    }
        //                }
        //            }
        //            else if (Steel != null)
        //            {
        //                for (int i = 0; i < poke.Types.Count(); i++)
        //                {
        //                    if (poke.Types[i].Name == Steel)
        //                    {
        //                        possiblePokes.Add(poke);
        //                    }
        //                }
        //            }
        //            else if (Water != null)
        //            {
        //                for (int i = 0; i < poke.Types.Count(); i++)
        //                {
        //                    if (poke.Types[i].Name == Water)
        //                    {
        //                        possiblePokes.Add(poke);
        //                    }
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

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PoGoBattleHelper.Models;
using PoGoBattleHelper.ViewModels;
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
    public class GetTypeController : Controller
    {
        private static readonly string fileString2 = System.IO.File.ReadAllText("pokedex/type.json");
        private static readonly List<Models.Type> typeList = JsonSerializer.Deserialize<List<Models.Type>>(fileString2);
        private static readonly string fileString = System.IO.File.ReadAllText("pokedex/pokemon.json");
        private static readonly List<Pokemon> pokeList = JsonSerializer.Deserialize<List<Pokemon>>(fileString);
        private static List<Pokemon> myTeam = new List<Pokemon>();
        private static List<Pokemon> possiblePokes = new List<Pokemon>();
        private static List<Pokemon> possiblePokes2Types = new List<Pokemon>();

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.possiblePokes = possiblePokes;

            GetTypeViewModel myModel = new GetTypeViewModel();
            myModel.Pokes = pokeList;
            myModel.Types = typeList;
            return View(myModel);
        }

        [HttpPost, Route("/GetType")]
        public IActionResult GetType(string bugType, string darkType, string dragonType, string electricType, string fairyType, string fightingType, string fireType, string flyingType, string ghostType, string grassType, string groundType, string iceType, string normalType, string poisonType, string psychicType, string rockType, string steelType, string waterType)
        {
            ViewBag.possiblePokes = possiblePokes;
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

        [HttpGet, Route("/GetSecondType")]
        public IActionResult GetSecondType()
        {
            ViewBag.possiblePokes = possiblePokes;
            ViewBag.possiblePokes2Types = possiblePokes2Types;
            return View();
        }

        [HttpPost, Route("/GetSecondType")]
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
                // THIS WILL NEED TO BE CHANGED TO A REDIRECT ONCE THE ADDPOKE CONTROLLER IS CREATED
                return View("AddPoke");
            }
            ViewBag.possiblePokes2Types = possiblePokes2Types;
            // THIS WILL RETURN THE VIEW OF YOUR TEAM ONCE THAT IS CREATED
            return View("AddPoke");
        }
    }
}

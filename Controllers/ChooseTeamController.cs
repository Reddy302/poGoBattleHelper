﻿using Microsoft.AspNetCore.Mvc;
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
using Newtonsoft.Json;

namespace PoGoBattleHelper.Controllers
{
    public class ChooseTeamController : Controller
    {
        private static List<Pokemon> myTeam = new List<Pokemon>();
        private static List<Pokemon> possiblePokes = new List<Pokemon>();
        private static List<Pokemon> possiblePokes2Types = new List<Pokemon>();
        public ChooseTeamViewModel myModel = new ChooseTeamViewModel();
        public ChooseMovesViewModel moveModel = new ChooseMovesViewModel();

        [HttpGet, Route("/GetType")]
        public IActionResult Index()
        {
            myModel.Pokes = Pokemon.pokeList;
            myModel.Types = Models.Type.typeList;
            myModel.PossiblePokes = possiblePokes;
            myModel.PossiblePokes2Types = possiblePokes2Types;
            return View(myModel);
        }

        [HttpPost, Route("/GetType")]
        public IActionResult GetType(string type)
        {
            if (myTeam.Count < 3)
            {
                foreach (Pokemon poke in Pokemon.pokeList.ToList())
                {
                    for (int i = 0; i < poke.Types.Count(); i++)
                    {
                        if (poke.Types[i].Name.ToLower() == type)
                        {
                            possiblePokes.Add(poke);
                        }
                    }
                }
                myModel.PossiblePokes = possiblePokes;
                return Redirect("/GetSecondType");
            }
            else
            {
                myModel.PossiblePokes = possiblePokes;
                return Redirect("/MyTeam");
            }
        }

        [HttpGet, Route("/GetSecondType")]
        public IActionResult GetSecondType()
        {
            myModel.Pokes = Pokemon.pokeList;
            myModel.Types = Models.Type.typeList;
            myModel.PossiblePokes = possiblePokes;
            myModel.PossiblePokes2Types = possiblePokes2Types;
            return View(myModel);
        }

        [HttpPost, Route("/GetSecondType")]
        public IActionResult GetSecondType(string type)
        {
            if (myTeam.Count < 3)
            {
                foreach (Pokemon poke in possiblePokes)
                {
                    for (int i = 0; i < poke.Types.Count(); i++)
                    {
                        if (poke.Types[i].Name.ToLower() == type)
                        {
                            possiblePokes2Types.Add(poke);
                        }
                    }
                }
                myModel.PossiblePokes2Types = possiblePokes2Types;
                return Redirect("/AddPoke");
            }
            myModel.PossiblePokes2Types = possiblePokes2Types;
            return Redirect("/MyTeam");
        }

        [HttpGet, Route("/AddPoke")]
        public IActionResult AddPoke()
        {
            myModel.Pokes = Pokemon.pokeList;
            myModel.Types = Models.Type.typeList;
            myModel.PossiblePokes = possiblePokes;
            myModel.PossiblePokes2Types = possiblePokes2Types;
            return View(myModel);
        }

        [HttpPost, Route("/AddPoke")]
        public IActionResult AddPoke(string poke)
        {
            if (myTeam.Count < 3)
            {
                foreach(Pokemon mon in Pokemon.pokeList.ToList())
                {
                    if(mon.Name.ToLower() == poke)
                    {
                        myTeam.Add(mon);
                    }
                }
                myModel.MyTeam = myTeam;
                return Redirect("/MyTeam");
            }
            else
            {
                myModel.MyTeam = myTeam;
                moveModel.MyTeam = myTeam;
                return Redirect("/MyTeam");
            }
        }

        [HttpGet, Route("/MyTeam")]
        public IActionResult MyTeam()
        {
            myModel.MyTeam = myTeam;
            return View(myModel);
        }

        [HttpPost, Route("/MyTeam")]
        public IActionResult MyTeam(string clear, string clearLast, string startOver, string chooseMoves)
        {
            if (clear == "clear" || clearLast == "clearLast" || startOver == "startOver" || chooseMoves == "chooseMoves")
            {
                foreach (Pokemon poke in possiblePokes.ToList())
                {
                    possiblePokes.Remove(poke);
                }

                foreach (Pokemon poke in possiblePokes2Types.ToList())
                {
                    possiblePokes2Types.Remove(poke);
                }

                myModel.PossiblePokes = possiblePokes;
                myModel.PossiblePokes2Types = possiblePokes2Types;
            }
            if (clear == "clear")
            {
                return Redirect("/GetType");
            }
            if (clearLast == "clearLast")
            {
                myTeam.Remove(myTeam[myTeam.Count - 1]);

                myModel.MyTeam = myTeam;
                return Redirect("/GetType");
            }
            if (startOver == "startOver")
            {
                foreach (Pokemon poke in myTeam.ToList())
                {
                    myTeam.Remove(poke);
                }

                myModel.MyTeam = myTeam;
                return Redirect("/GetType");
            }
            if (chooseMoves == "chooseMoves")
            {
                moveModel.MyTeam = myTeam;
                return Redirect("/ChooseMoves");
            }
            return Redirect("/GetType");
        }
    }
}
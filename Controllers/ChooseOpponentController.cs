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
using Newtonsoft.Json;

namespace PoGoBattleHelper.Controllers
{
    public class ChooseOpponentController : Controller
    {
        public ChooseOpponentViewModel myModel = new ChooseOpponentViewModel();
        private static List<Pokemon> possiblePokes = new List<Pokemon>();
        private static List<Pokemon> possiblePokes2Types = new List<Pokemon>();
        public static Pokemon opponent = new Pokemon();
        public static List<Pokemon> myTeam = ChooseTeamController.myTeam;
        public Dictionary<Pokemon, List<Move>> strongPokes = new Dictionary<Pokemon, List<Move>>();
        public Dictionary<Pokemon, List<Move>> neutralPokes = new Dictionary<Pokemon, List<Move>>();

        [HttpGet, Route("/ChooseOpponent")]
        public IActionResult Index()
        {
            myModel.Types = Models.Type.typeList;
            myModel.Pokes = Pokemon.pokeList;
            return View(myModel);
        }

        [HttpPost, Route("/ChooseOpponent")]
        public IActionResult ChooseOpponent(string type)
        {
            foreach (Pokemon poke in Pokemon.pokeList.ToList())
            {
                for (int i = 0; i < poke.Types.Count(); i++)
                {
                    if (poke.Types[i].Name.ToLower().Equals(type))
                    {
                        possiblePokes.Add(poke);
                    }
                }
            }
            myModel.PossiblePokes = possiblePokes;
            return RedirectToAction("GetSecondType");
        }

        [HttpGet, Route("/ChooseOpponent/GetSecondType")]
        public IActionResult GetSecondType()
        {
            myModel.Pokes = Pokemon.pokeList;
            myModel.Types = Models.Type.typeList;
            myModel.PossiblePokes = possiblePokes;
            myModel.PossiblePokes2Types = possiblePokes2Types;
            return View(myModel);
        }

        [HttpPost, Route("/ChooseOpponent/GetSecondType")]
        public IActionResult GetSecondType(string type)
        {
            foreach (Pokemon poke in possiblePokes)
            {
                for (int i = 0; i < poke.Types.Count(); i++)
                {
                    if (poke.Types[i].Name.ToLower().Equals(type))
                    {
                        possiblePokes2Types.Add(poke);
                    }
                }
            }
            myModel.PossiblePokes2Types = possiblePokes2Types;
            return RedirectToAction("AddOpponent");
        }

        [HttpGet, Route("/ChooseOpponent/AddOpponent")]
        public IActionResult AddOpponent()
        {
            myModel.Pokes = Pokemon.pokeList;
            myModel.Types = Models.Type.typeList;
            myModel.PossiblePokes = possiblePokes;
            myModel.PossiblePokes2Types = possiblePokes2Types;
            return View(myModel);
        }

        [HttpPost, Route("/ChooseOpponent/AddOpponent")]
        public IActionResult AddOpponent(string poke)
        {
            foreach (Pokemon mon in Pokemon.pokeList.ToList())
            {
                if (mon.Name.ToLower().Equals(poke))
                {
                    opponent = mon;
                }
            }
            myModel.Opponent = opponent;
            return View("Opponent", myModel);            
        }

        [HttpPost, Route("/ChooseOpponent/Recommendation")]
        public IActionResult Recommendation(string confirm, string clear)
        {
            if (clear == "clear")
            {
                opponent = new Pokemon();
                return RedirectToAction("Index");
            }
            
            if (confirm == "true")
            {
                // FOREACH POKE IN MY TEAM CHECK THE TYPES OF EACH ATTACK AGAINST THE OPPONENT TYPE
                // MAYBE THINK ABOUT ADDING UP A POINTS SYSTEM SO THAT A POKE GETS A POINT FOR EACH MOVE THAT IS STRONG AGAINST THE OPPONENT
                foreach (Pokemon poke in myTeam)
                {
                    int points = 0;
                    List<Move> cMove = new List<Move>();
                    foreach (Move qMove in poke.QuickMoves)
                    {
                        foreach (Damage stat in qMove.PokemonType.Damage)
                        {
                            foreach (Models.Type oppType in opponent.Types)
                            {
                                if (stat.Id == oppType.Id)
                                {
                                    if (stat.AttackScalar > 1)
                                    {
                                        points ++;
                                    }
                                    else if (stat.AttackScalar < 1)
                                    {
                                        points--;
                                    }
                                }
                            }
                        }
                    }
                    foreach (Move chargedMove in poke.CinematicMoves)
                    {
                        foreach (Damage stat in chargedMove.PokemonType.Damage)
                        {
                            foreach (Models.Type oppType in opponent.Types)
                            {
                                if (stat.Id == oppType.Id)
                                {
                                    if (stat.AttackScalar > 1)
                                    {
                                        cMove.Add(chargedMove);
                                        points += 2;
                                    }
                                    else if (stat.AttackScalar < 1)
                                    {
                                        points -= 2;
                                    }
                                }
                            }
                        }
                    }
                    foreach (Models.Type pokeType in poke.Types)
                    {
                        foreach (Damage stat in pokeType.Damage)
                        {
                            foreach (Models.Type oppType in opponent.Types)
                            {
                                if (stat.Id == oppType.Id)
                                {
                                    if (stat.AttackScalar > 1)
                                    {
                                        points++;
                                    }
                                    if (stat.AttackScalar < 1)
                                    {
                                        points = 0;
                                    }
                                }
                            }
                        }
                    }
                    if (points > 1)
                    {
                        strongPokes.Add(poke, cMove);
                    }
                    if (points == 0)
                    {
                        neutralPokes.Add(poke, cMove);
                    }
                }
            }

            myModel.Opponent = opponent;
            myModel.MyTeam = myTeam;
            myModel.StrongPokes = strongPokes;
            myModel.NeutralPokes = neutralPokes;
            return View(myModel);
        }




    }
}

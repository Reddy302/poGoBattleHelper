using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PoGoBattleHelper.Models;
using PoGoBattleHelper.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using System.Web;
using System.Windows;
using Microsoft.AspNetCore.Hosting;

namespace PoGoBattleHelper.Controllers
{
    public class ChooseOpponentController : Controller
    {
        public ChooseOpponentViewModel myModel = new ChooseOpponentViewModel();
        private static List<Pokemon> possiblePokes = new List<Pokemon>();
        private static List<Pokemon> possiblePokes2Types = new List<Pokemon>();
        public static Pokemon opponent = new Pokemon();
        public static List<Pokemon> oppTeam = new List<Pokemon>();
        public static List<Move> cMove = new List<Move>();
        public Dictionary<Pokemon, List<Move>> strongPokes = new Dictionary<Pokemon, List<Move>>();
        public Dictionary<Pokemon, List<Move>> neutralPokes = new Dictionary<Pokemon, List<Move>>();
        

        [HttpGet, Route("/ChooseOpponent")]
        public IActionResult Index()
        {
            if (oppTeam.Count() < 3)
            {
                foreach (Pokemon originalPoke in Pokemon.pokeList)
                {
                    foreach (Pokemon poke in ChooseTeamController.myTeam)
                    {
                        if (originalPoke.Id == poke.Id)
                        {
                            oppTeam.Add(originalPoke);
                        }
                    }
                }
            }
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
        public IActionResult Recommendation(string confirm, string next, string startOver)
        {
            if (confirm == "true")
            {
                foreach (Pokemon poke in oppTeam)
                {
                    cMove = new List<Move>();
                    int points = 0;
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
                    foreach (Models.Type oppType in opponent.Types)
                    {
                        foreach (Move chargedMove in poke.CinematicMoves)
                        {
                            foreach (Damage stat in chargedMove.PokemonType.Damage)
                            {
                                if (stat.Id == oppType.Id)
                                {
                                    if (stat.AttackScalar > 1)
                                    {
                                        if (cMove.Count() > 0)
                                        {
                                            if (cMove.Contains(chargedMove))
                                            {
                                                points += 2;
                                                continue;
                                            }
                                            else
                                            {
                                                cMove.Add(chargedMove);
                                                points += 2;
                                            }
                                        }
                                        else
                                        {
                                            cMove.Add(chargedMove);
                                            points += 2;
                                        }
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
                                        points -= 2;
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
                    cMove = new List<Move>();
                    points = 0;
                }
                
                myModel.Opponent = opponent;
                myModel.MyTeam = oppTeam;
                myModel.StrongPokes = strongPokes;
                myModel.NeutralPokes = neutralPokes;
                strongPokes = new Dictionary<Pokemon, List<Move>>();
                neutralPokes = new Dictionary<Pokemon, List<Move>>();
                return View(myModel);
            }

            if (next == "next")
            {
                opponent = new Pokemon();
                possiblePokes = new List<Pokemon>();
                possiblePokes2Types = new List<Pokemon>();
                cMove = new List<Move>();
                strongPokes = new Dictionary<Pokemon, List<Move>>();
                neutralPokes = new Dictionary<Pokemon, List<Move>>();
                myModel.StrongPokes = strongPokes;
                myModel.NeutralPokes = neutralPokes;
                return RedirectToAction("Index");
            }

            if (startOver == "true")
            {
                Pokemon.pokeList = JsonSerializer.Deserialize<List<Pokemon>>(Pokemon.fileString);
                Move.moveList = JsonSerializer.Deserialize<List<Move>>(Move.fileString);
                Models.Type.typeList = JsonSerializer.Deserialize<List<Models.Type>>(Models.Type.fileString);

                myModel = new ChooseOpponentViewModel();
                possiblePokes = new List<Pokemon>();
                possiblePokes2Types = new List<Pokemon>();
                opponent = new Pokemon();
                oppTeam = new List<Pokemon>();
                strongPokes = new Dictionary<Pokemon, List<Move>>();
                neutralPokes = new Dictionary<Pokemon, List<Move>>();

                return RedirectToAction("ClearTeam", "ChooseTeam");
            }

            return View();            
        }
    }
}

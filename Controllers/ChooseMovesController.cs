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
    public class ChooseMovesController : Controller
    {
        public static ChooseMovesViewModel myModel = new ChooseMovesViewModel();
        public static Pokemon chosenPoke = new Pokemon();
        public static List<Pokemon> tempTeam = new List<Pokemon>();
        public static List<Pokemon> movesTeam = new List<Pokemon>();

        [HttpGet, Route("/ChooseMoves")]
        public IActionResult Index()
        {
            if (movesTeam.Count() < 3)
            {
                foreach (Pokemon originalPoke in Pokemon.pokeList)
                {
                    foreach (Pokemon poke in ChooseTeamController.myTeam)
                    {
                        if (originalPoke.Id == poke.Id)
                        {
                            movesTeam.Add(originalPoke);
                        }
                    }
                }
            }
            if (tempTeam.Count() == 0)
            {
                foreach (Pokemon poke in Pokemon.pokeList)
                {
                    foreach (Pokemon mon in movesTeam)
                    {
                        if (poke.Id == mon.Id)
                        {
                            tempTeam.Add(poke);
                        }
                    }
                }
            }
            myModel.MyTeam = movesTeam;
            myModel.TempTeam = tempTeam;
            return View(myModel);
        }

        [HttpPost, Route("/ChooseMoves")]
        public IActionResult ChooseMoves(string name)
        {
            chosenPoke = new Pokemon();
            foreach (Pokemon poke in movesTeam)
            {
                if (poke.Name.ToLower() == name)
                {
                    chosenPoke = poke;
                }
            }
            myModel.TempTeam = tempTeam;
            myModel.ChosenPoke = chosenPoke;
            myModel.MyTeam = movesTeam;
            return RedirectToAction("QuickMoves");
        }

        [HttpGet, Route("/QuickMoves")]
        public IActionResult QuickMoves()
        {
            myModel.ChosenPoke = chosenPoke;
            return View(myModel);
        }

        [HttpPost, Route("/QuickMoves")]
        public IActionResult QuickMoves(ICollection<string> fastMove)
        {
            foreach (Pokemon mon in movesTeam)
            {
                if (mon.Name == chosenPoke.Name)
                {
                    foreach (string id in fastMove)
                    {
                        if (id == "false")
                        {
                            continue;
                        }
                        else
                        {
                            for (int i = 0; i < mon.QuickMoves.Count(); i++)
                            {
                                Move move = mon.QuickMoves[i];
                                if (id == move.Id)
                                {
                                    continue;
                                }
                                else
                                {
                                    mon.QuickMoves.Remove(move);
                                    i--;
                                }
                            }
                        }
                    }
                }
            }

            return RedirectToAction("ChargedMoves");
        }
        
        [HttpGet, Route("/ChargedMoves")]
        public IActionResult ChargedMoves()
        {
            myModel.ChosenPoke = chosenPoke;
            return View(myModel);
        }

        [HttpPost, Route("/ChargedMoves")]
        public IActionResult ChargedMoves(IList<string> chargedMove, string chooseOpponent)
        {
            if (chooseOpponent == "true")
            {
                return RedirectToAction("Index", "ChooseOpponent");
            }

            foreach (Pokemon mon in movesTeam)
            {
                List<Move> chosenMoves = new List<Move>();
                if (mon.Name == chosenPoke.Name)
                {
                    for (int i = 0; i < mon.CinematicMoves.Count(); i++)
                    {
                        Move move = mon.CinematicMoves[i];
                        for (int j = 0; j < chargedMove.Count(); j++)
                        {
                            string id = chargedMove[j];
                            if (id == move.Id)
                            {
                                chosenMoves.Add(move);
                                chargedMove.Remove(id);
                                j--;
                                continue;
                            }
                            else if (id == "false")
                            {
                                continue;
                            }
                        }
                    }
                    mon.CinematicMoves = chosenMoves;
                }
                else
                {
                    continue;
                }
            }
            if (tempTeam.Count() == 1)
            {
                // RETURN THE VIEW FOR THE NEXT STEP - MAYBE A CONFIRMATION SCREEN WITH ALL POKES AND CHOSEN MOVES
                tempTeam.Remove(chosenPoke);
                myModel.MyTeam = movesTeam;
                myModel.TempTeam = tempTeam;
                return View("ConfirmationScreen", myModel);
            }
            else
            {
                tempTeam.Remove(chosenPoke);
                myModel.TempTeam = tempTeam;
                myModel.MyTeam = movesTeam;
                myModel.Moves = Move.moveList;
                myModel.Pokes = Pokemon.pokeList;
                myModel.Types = Models.Type.typeList;
                return RedirectToAction("Index");
            }
        }

        public IActionResult ClearTeam()
        {
            myModel = new ChooseMovesViewModel();
            chosenPoke = new Pokemon();
            tempTeam = new List<Pokemon>();
            movesTeam = new List<Pokemon>();

            return RedirectToAction("Index", "Home");
        }





    }
}

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
        public ChooseMovesViewModel myModel = new ChooseMovesViewModel();
        public static Pokemon chosenPoke = new Pokemon();
        public static List<Pokemon> tempTeam = new List<Pokemon>();
        public static List<Pokemon> myTeam = ChooseTeamController.myTeam;

        [HttpGet, Route("/ChooseMoves")]
        public IActionResult Index()
        {
            if (tempTeam.Count() == 0)
            {
                foreach (Pokemon poke in Pokemon.pokeList)
                {
                    foreach (Pokemon mon in myTeam)
                    {
                        if (poke.Id == mon.Id)
                        {
                            tempTeam.Add(poke);
                        }
                    }
                }
            }
            myModel.MyTeam = myTeam;
            myModel.TempTeam = tempTeam;
            return View(myModel);
        }

        [HttpPost, Route("/ChooseMoves")]
        public IActionResult ChooseMoves(string name)
        {
            foreach (Pokemon poke in myTeam)
            {
                if (poke.Name.ToLower() == name)
                {
                    chosenPoke = poke;
                }
            }
            myModel.TempTeam = tempTeam;
            myModel.ChosenPoke = chosenPoke;
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
            foreach (Pokemon mon in ChooseTeamController.myTeam)
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
                // THIS WILL RETURN A REDIRECT TO ACTION FOR CHOOSE OPPONENT 
                return RedirectToAction("Index", "ChooseOpponent");
            }

            List<Move> chosenMoves = new List<Move>();
            foreach (Pokemon mon in ChooseTeamController.myTeam)
            {
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
                myModel.MyTeam = ChooseTeamController.myTeam;
                return View("ConfirmationScreen", myModel);
            }
            else
            {
                tempTeam.Remove(chosenPoke);
                myModel.TempTeam = tempTeam;
                myModel.MyTeam = ChooseTeamController.myTeam;
                myModel.Moves = Move.moveList;
                myModel.Pokes = Pokemon.pokeList;
                myModel.Types = Models.Type.typeList;
                return RedirectToAction("Index");
            }

            





        }
    }
}

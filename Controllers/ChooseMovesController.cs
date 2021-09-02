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

        [HttpGet, Route("/ChooseMoves")]
        public IActionResult Index()
        {
            myModel.MyTeam = ChooseTeamController.myTeam;
            return View(myModel);
        }

        [HttpPost, Route("/ChooseMoves")]
        public IActionResult ChooseMoves(string name)
        {
            foreach (Pokemon poke in ChooseTeamController.myTeam)
            {
                if (poke.Name.ToLower() == name)
                {
                    chosenPoke = poke;
                }
            }
            myModel.MyTeam = ChooseTeamController.myTeam;
            myModel.ChosenPoke = chosenPoke;
            //return a view that is dynamic to the pokemon and also shows all available moves in a checkbox form
            return RedirectToAction("QuickMoves");
        }

        [HttpGet, Route("/ChooseMoves/QuickMoves")]
        public IActionResult QuickMoves()
        {
            myModel.ChosenPoke = chosenPoke;
            return View(myModel);
        }

        [HttpPost, Route("/ChooseMoves/QuickMoves")]
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
                                    if (mon.QuickMoves.Count() == 1)
                                    {
                                        i = 0;
                                    }
                                    else if (i >= mon.QuickMoves.Count()-1)
                                    {
                                        i = -1;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            
            myModel.MyTeam = ChooseTeamController.myTeam;
            myModel.Moves = Move.moveList;
            myModel.Pokes = Pokemon.pokeList;
            myModel.Types = Models.Type.typeList;


            // THIS IS HOW YOU RETURN A VIEW WITH A MODEL, IF IT'S FOR A DIFFERENT CONTROLLER YOU HAVE TO PUT THE CONTROLLER NAME FIRST
            // return View("Index", myModel);

            // THIS IS WHERE I WILL ACTUALLY RETURN THE VIEW FOR THE NEXT MOVE CHOICE THIS "return View("Index", myModel);" MUST BE CHANGED
            return View("Index", myModel);
        }











    }
}

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
        //public static List<Pokemon> myTeam = ChooseTeamController.myTeam;
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
        public IActionResult QuickMoves(string fastMove)
        {
            
            foreach (Pokemon mon in ChooseTeamController.myTeam)
            {
                if (mon.Name == chosenPoke.Name)
                {
                    for (int i = 0; i < mon.QuickMoves.Count; i ++)
                    {
                        if (mon.QuickMoves[i].Id != fastMove)
                        {
                            Move moveToRemove = mon.QuickMoves[i];
                            mon.QuickMoves.Remove(moveToRemove);
                        }
                    }










                    //foreach (Move fMove in mon.QuickMoves)
                    //{
                    //    if (fastMove.Equals(fMove.Id))
                    //    {
                    //        continue;
                    //    }
                    //    else if (fastMove.Equals("false"))
                    //    {
                    //        mon.QuickMoves.Remove(fMove);
                    //    }
                    //}

                    //foreach (Move cMove in mon.CinematicMoves)
                    //{
                    //    if (chargedMove.Equals(cMove.Id))
                    //    {
                    //        continue;
                    //    }
                    //    else if (chargedMove.Equals("false"))
                    //    {
                    //        mon.CinematicMoves.Remove(cMove);
                    //    }
                    //}
                }
                
            }
            ChooseTeamViewModel myModel = new ChooseTeamViewModel();
            myModel.MyTeam = ChooseTeamController.myTeam;
            return RedirectToAction("Index", "Home");









        }











    }
}

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
        public static List<Pokemon> myTeam = ChooseTeamController.myTeam;
        public static Pokemon chosenPoke = new Pokemon();

        [HttpGet, Route("/ChooseMoves")]
        public IActionResult Index()
        {
            myModel.MyTeam = myTeam;
            return View(myModel);
        }

        [HttpPost, Route("/ChooseMoves")]
        public IActionResult ChooseMoves(string name)
        {
            foreach (Pokemon poke in myTeam)
            {
                if (poke.Name.ToLower().Equals(name))
                {
                    chosenPoke = poke;
                    // Tie the move information from pokemon.json to the information in move.json
                    foreach (Move move in Move.moveList)
                    {
                        foreach (Move cMove in poke.CinematicMoves)
                        {
                            if (cMove.Id.Equals(move.Id))
                            {
                                cMove.PokemonType = move.PokemonType;
                            }
                        }
                        foreach (Move fMove in poke.QuickMoves)
                        {
                            if (fMove.Id.Equals(move.Id))
                            {
                                fMove.PokemonType = move.PokemonType;
                            }
                        }
                    }
                }
            }
            myModel.MyTeam = myTeam;
            myModel.ChosenPoke = chosenPoke;
            //return a view that is dynamic to the pokemon and also shows all available moves in a checkbox form
            return RedirectToAction("Moves");
        }

        [HttpGet, Route("/ChooseMoves/Moves")]
        public IActionResult Moves()
        {
            myModel.ChosenPoke = chosenPoke;
            return View(myModel);
        }

        [HttpPost, Route("/ChooseMoves/Moves")]
        public IActionResult Moves(string fastMove, string chargedMove, string poke, string submit)
        {
            if (submit.Equals("Submit My Moves"))
            {
                foreach (Pokemon mon in myTeam)
                {
                    if (mon.Name.Equals(poke))
                    {
                        foreach (Move fMove in mon.QuickMoves)
                        {
                            if (fastMove.Equals(fMove.Id))
                            {
                                continue;
                            }
                            else if (fastMove.Equals("false"))
                            {
                                mon.QuickMoves.Remove(fMove);
                            }
                        }

                        foreach (Move cMove in mon.CinematicMoves)
                        {
                            if (chargedMove.Equals(cMove.Id))
                            {
                                continue;
                            }
                            else if (chargedMove.Equals("false"))
                            {
                                mon.CinematicMoves.Remove(cMove);
                            }
                        }
                    }
                }
            }
            
            return RedirectToAction("Index", "Home");









        }











    }
}

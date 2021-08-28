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
        public List<Pokemon> myTeam = ChooseTeamController.myTeam;

        [HttpGet, Route("/ChooseMoves")]
        public IActionResult Index()
        {
            myModel.MyTeam = myTeam;
            return View(myModel);
        }

        [HttpPost, Route("/ChooseMoves")]
        public IActionResult ChooseMoves(string poke)
        {
            foreach (Pokemon mon in myTeam)
            {
                if (mon.Name == poke)
                {
                    //return a view that is dynamic to the pokemon and also shows all available moves in a checkbox form
                    return RedirectToAction("Moves");
                }
            }
            return View();
        }
    }
}

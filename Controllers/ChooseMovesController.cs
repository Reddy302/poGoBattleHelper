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
        private static List<Pokemon> myTeam = new List<Pokemon>();
        public ChooseMovesViewModel myModel = new ChooseMovesViewModel();

        // FIGURE OUT HOW TO GET THE TEAM INTO THIS CONTROLLER
        [HttpGet, Route("/ChooseMoves")]
        public IActionResult Index()
        {
            myTeam = TempData["myTeam"] as List<Pokemon>;
            myModel.MyTeam = myTeam;
            return View(myModel);
        }
    }
}

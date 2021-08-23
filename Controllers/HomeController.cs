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

namespace PoGoBattleHelper.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            ChooseTeamViewModel myModel = new ChooseTeamViewModel();
            myModel.Pokes = Pokemon.pokeList;
            myModel.Types = Models.Type.typeList;
            return View(myModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

// TODO: When a pokemon name is clicked add the poke to myList and display a confirmation page with a slightly larger image of the poke
// TODO: Add a "choose next pokemon" button to the confirmation page
// TODO: Add a "go back this is not the poke I meant to choose" button to the confirmation page
// TODO: Put the getType code into a Partial View once it has been refactored.
// TODO: Add a Data Layer to the application

// TODO: Before finishing the app, make sure to find the updated poke list and import it to the app

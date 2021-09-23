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
            foreach (Pokemon poke in Pokemon.pokeList.ToList())
            {
                foreach (Move move in Move.moveList.ToList())
                {
                    foreach (Models.Type type in Models.Type.typeList.ToList())
                    {
                        if (move.PokemonType.Id == type.Id)
                        {
                            move.PokemonType = type;
                            move.PokemonType.Damage = type.Damage;
                        }

                        foreach (Models.Type pokeType in poke.Types)
                        {
                            if (pokeType.Id == type.Id)
                            {
                                pokeType.Damage = type.Damage;
                            }
                        }
                    }
                    foreach (Move fMove in poke.QuickMoves)
                    {
                        if (fMove.Id == move.Id)
                        {
                            fMove.PokemonType = move.PokemonType;
                            fMove.PokemonType.Damage = move.PokemonType.Damage;
                        }
                    }
                    foreach (Move cMove in poke.CinematicMoves)
                    {
                        if (cMove.Id == move.Id)
                        {
                            cMove.PokemonType = move.PokemonType;
                            cMove.PokemonType.Damage = move.PokemonType.Damage;
                        }
                    }
                }
            }

            List<Pokemon> test = ChooseTeamController.myTeam;
            ChooseTeamViewModel myModel = new ChooseTeamViewModel();
            myModel.Pokes = Pokemon.pokeList;
            myModel.Types = Models.Type.typeList;
            myModel.MyTeam = test;
            myModel.Moves = Move.moveList;

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

// TODO: Refactor the checkbox forms to only accept one input for fast move and two inputs for charged move
// TODO: Find Raticate Alola sprite and add it to the pokes folder as "pokemon_icon_020_61.png"
// TODO: Put the getType code into a Partial View once it has been refactored.
// TODO: Add a Data Layer to the application

// TODO: Before finishing the app, make sure to find the updated poke list and import it to the app

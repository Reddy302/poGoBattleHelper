using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PoGoBattleHelper.Models;

namespace PoGoBattleHelper.ViewModels
{
    public class ChooseMovesViewModel
    {
        public List<Pokemon> Pokes { get; set; }
        public List<Models.Type> Types { get; set; }
        public List<Pokemon> MyTeam { get; set; }
        public List<Move> Moves { get; set; }
        public Pokemon ChosenPoke { get; set; }
    }
}

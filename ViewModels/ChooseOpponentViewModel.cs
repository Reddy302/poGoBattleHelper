using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PoGoBattleHelper.Models;

namespace PoGoBattleHelper.ViewModels
{
    public class ChooseOpponentViewModel
    {
        public List<Models.Type> Types { get; set; }
        public List<Pokemon> Pokes { get; set; }
        public List<Pokemon> PossiblePokes { get; set; }
        public List<Pokemon> PossiblePokes2Types { get; set; }
        public Pokemon Opponent { get; set; }
        public List<Pokemon> MyTeam { get; set; }
        public Dictionary<Pokemon, List<Move>> StrongPokes { get; set; }
        public Dictionary<Pokemon, List<Move>> NeutralPokes { get; set; }
    }
}

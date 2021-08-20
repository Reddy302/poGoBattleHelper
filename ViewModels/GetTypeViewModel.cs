using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PoGoBattleHelper.Models;

namespace PoGoBattleHelper.ViewModels
{
    public class GetTypeViewModel
    {
        public List<Pokemon> Pokes { get; set; }
        public List<PoGoBattleHelper.Models.Type> Types { get; set; }
    }
}

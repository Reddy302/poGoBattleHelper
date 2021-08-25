using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoGoBattleHelper.Models
{
    public class QuickMove
    {
		public int AccuracyChange { get; set; }
		public int AnimationId { get; set; }
		public int Power { get; set; }
		public float CriticalChance { get; set; }
		public float StaminaLossScalar { get; set; }
		public int TrainerLevelMin { get; set; }
		public int TrainerLevelMax { get; set; }
		public string VfxName { get; set; }
		public int DurationMs { get; set; }
		public int DamageWindowStartMs { get; set; }
		public int DamageWindowEndMs { get; set; }
		public float EnergyDelta { get; set; }
		public string Id { get; set; }
		public Models.Type[] PokemonType { get; set; }
		public string Name { get; set; }
		public int InternalId { get; set; }


		public QuickMove()
        {

        }
    }
}

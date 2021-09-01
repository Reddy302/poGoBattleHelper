using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PoGoBattleHelper.Controllers;
using PoGoBattleHelper.Models;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace PoGoBattleHelper.Models
{
    public class Move
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
		public Models.Type PokemonType { get; set; }
		public string Name { get; set; }
		public int InternalId { get; set; }

		private static readonly string fileString = System.IO.File.ReadAllText("pokedex/move.json");
		public static readonly List<Move> moveList = JsonSerializer.Deserialize<List<Move>>(fileString);

		public Move(string id, Models.Type pokemonType, string name)
        {
			Id = id;
			PokemonType = pokemonType;
			Name = name;
        }

		public Move()
        {

        }
    }

	public class PokemonType
	{
        public string Id { get; set; }
        public string Name { get; set; }

		public PokemonType(string id, string name)
        {
			Id = id;
			Name = name;
        }
    }
}
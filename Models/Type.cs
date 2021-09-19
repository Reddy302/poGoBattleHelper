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
    public class Type
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<Damage> Damage { get; set; }

        private static readonly string fileString = System.IO.File.ReadAllText("pokedex/type.json");
        public static readonly List<Models.Type> typeList = JsonSerializer.Deserialize<List<Models.Type>>(fileString);

        public Type(string id, string name, List<Damage> damage)
        {
            Id = id;
            Name = name;
            Damage = damage;
        }

        public Type()
        {

        }
    }

    public class Damage
    {
        public string Id { get; set; }
        public float AttackScalar { get; set; }

        public Damage(string id, float attackScalar)
        {
            Id = id;
            AttackScalar = attackScalar;
        }

        public Damage()
        {

        }
    }
}

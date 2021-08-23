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
        public Damage[] Damage { get; set; }
        private static readonly string fileString2 = System.IO.File.ReadAllText("pokedex/type.json");
        public static readonly List<Models.Type> typeList = JsonSerializer.Deserialize<List<Models.Type>>(fileString2);

        public Type(string id, string name, Damage[] damage)
        {
            Id = id;
            Name = name;
            Damage = damage;
        }

        public Type()
        {

        }
    }
}

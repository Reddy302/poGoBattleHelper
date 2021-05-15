﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoGoBattleHelper.Models
{
    public class Type
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public Type(string name, string id)
        {
            Name = name;
            Id = id;
        }
        public Type()
        {

        }
    }
}

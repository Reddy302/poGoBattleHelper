﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PoGoBattleHelper.Controllers;
using PoGoBattleHelper.Models;

namespace PoGoBattleHelper.Models
{
    public class Type
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Damage[] Damage { get; set; }
    }
}

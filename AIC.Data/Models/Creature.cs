﻿using AIC.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIC.Data.Models
{
    public class Creature
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public DietTypeEnum DietType { get; set; }
    }
}

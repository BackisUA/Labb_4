﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_4
{
    public struct Hair
    {
        public string HairColor {  get; set; }
        public string HairLength { get; set; }

        public override string ToString()
        {
            return $"{HairColor}, {HairLength}";
        }
    }
}

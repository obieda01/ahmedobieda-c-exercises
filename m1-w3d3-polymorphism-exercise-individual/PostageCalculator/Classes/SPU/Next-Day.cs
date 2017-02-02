﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Classes
{
    public class Next_Day : SPU
    {
        public override double calculateRate(int distance, double weight)
        {
            if (distance == 0 || weight == 0) return 0;

            return Math.Round((weight * 0.075 / 16) * distance, 2);
        }
    }
}

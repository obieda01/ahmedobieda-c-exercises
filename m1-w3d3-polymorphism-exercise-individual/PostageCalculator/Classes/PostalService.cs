﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Classes
{
public    class PostalService:IVehichleDriver
    {
        private int ounces;

        public int Ounces
        {
            get { return ounces; }
            set { ounces = value; }
        }

        private int pounds;

        public int Pounds
        {
            get { return pounds; }
            set { pounds = value; }
        }


        public virtual double calculateRate(int distance,double weight)
        {

            return 0;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMax3000BusinessLayer
{
    public class Order
    {
        public List<MenuItem> Item = new List<MenuItem>();

        public double Total
        {
            get
            {
                double calculatedTotal = 0;
                foreach (MenuItem item in Item)
                {
                    calculatedTotal += item.Price;
                }
                return calculatedTotal;
            }
        }


    }
}

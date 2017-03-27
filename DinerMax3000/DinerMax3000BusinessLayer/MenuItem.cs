using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMax3000BusinessLayer
{
    public class MenuItem
    {
        public string Titile;
        public string Description;
        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }else
                {
                    throw new ApplicationException("You cannot have free or negative value items");
                }
            }

        }

        //se acostumbra a llamar las propiedades con un _ al principio
        private double _price;



    }
}

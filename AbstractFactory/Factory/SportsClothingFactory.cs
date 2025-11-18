using AbstractFactory.Product.Hoodies;
using AbstractFactory.Product.Sneakers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    public class SportsClothingFactory : Clothing_Factory
    {
        public Hoodie CreateHoodie()
        {
            return new SportHoodie();
        }

        public Sneaker CreateSneaker()
        {
            return new SportSneaker();
        }
    }
}

using AbstractFactory.Product.Hoodies;
using AbstractFactory.Product.Sneakers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    public interface Clothing_Factory
    {
        Hoodie CreateHoodie();
        Sneaker CreateSneaker();
    }
}

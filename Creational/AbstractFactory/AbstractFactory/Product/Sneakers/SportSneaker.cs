using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Product.Sneakers
{
    public class SportSneaker : Sneaker
    {
        public String Brand { get; set; } = "Unbranded";
        public bool hasDiscount { get; set; } = false;

        public void SetBrand()
        {
            Brand = "Salomon";
        }

        public void SetDiscount()
        {
            hasDiscount = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Product.Sneakers
{
    public class DesignerSneaker : Sneaker
    {
        public String Brand { get; set; } = "Unbranded";
        public bool hasDiscount { get; set; } = false;

        public void SetBrand()
        {
            Brand = "Prada";
        }

        public void SetDiscount()
        {
            hasDiscount = false;
        }
    }
}

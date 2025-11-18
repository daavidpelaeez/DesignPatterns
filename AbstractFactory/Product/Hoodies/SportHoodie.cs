using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Product.Hoodies
{
    public class SportHoodie : Hoodie
    {
        public String Brand { get; set; } = "Unbranded";
        public bool hasDiscount { get; set; } = false;
        public void SetBrand()
        {
            Brand = "Nike";
        }

        public void SetDiscount()
        {
            hasDiscount = true;
        }
    }
}

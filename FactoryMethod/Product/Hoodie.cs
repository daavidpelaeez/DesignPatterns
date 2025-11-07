

namespace FactoryMethod.Product
{
    public class Hoodie : IClothes
    {
        private double Discount;
        private String Color;

        public Hoodie()
        {
            Discount = 0.0;
            Color = string.Empty;
        }

        public void AddColor()
        {
            this.Color = "Red";
        }

        public void AddDiscount()
        {
            this.Discount = 0.12;
        }
    }
}

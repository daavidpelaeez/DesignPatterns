


namespace FactoryMethod.Product
{
    public class Ziphoodie : IClothes
    {
        public double Discount { get; private set; }
        public String Color { get; private set; }

        public Ziphoodie()
        {
            Discount = 0.0;
            Color = String.Empty;
        }

        public void AddColor()
        {
            this.Color = "Blue";
        }

        public void AddDiscount()
        {
            this.Discount = 0.20;
        }
    }
}

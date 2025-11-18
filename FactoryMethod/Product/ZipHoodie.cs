


namespace FactoryMethod.Product
{
    public class Ziphoodie : IClothes
    {
        private double Discount;
        private String Color;

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

        public string GetAttributes()
        {
            return $"Discount: {Discount} Color: {Color} ";
        }
    }
}

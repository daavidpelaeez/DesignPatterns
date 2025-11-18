
namespace AbstractFactory.Product.Hoodies
{
    public class DesignerHoodie : Hoodie
    {
        public String Brand { get; set; } = "Unbranded";
        public bool hasDiscount { get; set; } = false;

        public void SetBrand()
        {
            Brand = "Balenciaga";
        }

        public void SetDiscount()
        {
            hasDiscount = false;
        }
    }
}

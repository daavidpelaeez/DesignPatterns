using FactoryMethod.Product;

namespace FactoryMethod.Factory
{
    public class HoodieFactory : ClothesFactory
    {
        public override IClothes Produce()
        {
           return new Hoodie();
        }
    }
}

using FactoryMethod.Product;

namespace FactoryMethod.Factory
{
    public class ZipHoodieFactory : ClothesFactory
    {
        public override IClothes Produce()
        {
            return new Ziphoodie();
        }
    }
}

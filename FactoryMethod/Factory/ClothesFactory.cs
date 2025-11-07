using FactoryMethod.Product;


namespace FactoryMethod.Factory
{
    public abstract class ClothesFactory
    {
        public abstract IClothes Produce();
    }
}

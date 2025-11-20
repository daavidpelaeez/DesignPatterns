

namespace FactoryMethod.Product
{
    public interface IClothes
    {
        public abstract void AddDiscount();
        public abstract void AddColor();
        public string GetAttributes();
    }
}

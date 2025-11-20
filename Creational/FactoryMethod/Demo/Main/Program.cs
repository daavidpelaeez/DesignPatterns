using FactoryMethod.Factory;
using FactoryMethod.Product;

ClothesFactory clothesFactory = new HoodieFactory();

IClothes hoodie = clothesFactory.Produce();

hoodie.AddColor();
hoodie.AddDiscount();

clothesFactory = new ZipHoodieFactory();

IClothes ziphoodie = clothesFactory.Produce();
ziphoodie.AddColor();
ziphoodie.AddDiscount();

Console.WriteLine($"Hoodie:  { hoodie.GetAttributes()} Ziphoodie: {ziphoodie.GetAttributes()}");

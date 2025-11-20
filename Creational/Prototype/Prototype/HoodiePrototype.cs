

namespace Prototype
{
    public class HoodiePrototype : IPrototype
    {
        public string Brand { get; set; }
        
        public HoodiePrototype() { }

        public HoodiePrototype(HoodiePrototype hoodiePrototype) { 
            this.Brand = hoodiePrototype.Brand;
        }

        public IPrototype Clone()
        {
            return new HoodiePrototype(this);
        }
    }
}

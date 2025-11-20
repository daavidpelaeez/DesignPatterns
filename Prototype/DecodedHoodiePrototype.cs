using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Prototype
{
    public class DecodedHoodiePrototype : HoodiePrototype, IPrototype
    {
        public bool DecodedHood { get; set; }

        public DecodedHoodiePrototype() : base()
        {

        }
        public DecodedHoodiePrototype(DecodedHoodiePrototype decodedHoodiePrototype) : base(decodedHoodiePrototype) 
        {
            this.DecodedHood = decodedHoodiePrototype.DecodedHood;
        }
        public IPrototype Clone()
        {
            return new DecodedHoodiePrototype(this);
        }

    }
}

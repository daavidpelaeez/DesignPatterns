using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Hoodie
    {
        public String Brand { get; set; } = "Unbranded";
        public bool HasHood { get; set; } = false;
        public bool HasBackLogo { get; set; } = false;
        public bool HasPockets { get; set; } = false;
        public bool HasCottonInside { get; set; } = false;
        public bool HasFrontLogo { get; set; } = false;
        public bool HasLaces { get; set; } = false;
    }
}

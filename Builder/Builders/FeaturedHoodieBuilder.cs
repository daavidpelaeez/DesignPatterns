using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builders
{
    public class FeaturedHoodieBuilder : Builder
    {
        private Hoodie FeaturedHoodie;

        public void Reset()
        {
            FeaturedHoodie = new Hoodie();
        }

        public void BuildHood()
        {
            FeaturedHoodie.HasHood = true;
        }

        public void BuildBackLogo()
        {
            FeaturedHoodie.HasBackLogo = true;
        }

        public void BuildPockets()
        {
            FeaturedHoodie.HasPockets = true;
        }

        public void BuildCottonInside()
        {
            FeaturedHoodie.HasCottonInside = true;
        }

        public void BuildFrontLogo()
        {
            FeaturedHoodie.HasFrontLogo = true;
        }

        public void BuildLaces()
        {
            FeaturedHoodie.HasLaces = true;
        }

        public Hoodie GetResult()
        {
            return FeaturedHoodie;
        }
    }
}

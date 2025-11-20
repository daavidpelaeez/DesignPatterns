using Builder.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Director
    {
        private Builders.Builder builder;

        public void setBuilder(Builders.Builder builder)
        {
            this.builder = builder;
        }

        public void buildBasicHoodie()
        {
            builder.Reset();
            builder.BuildHood();
            builder.BuildPockets();
            builder.BuildLaces();
        }

        public void buildFeaturedHoodie()
        {
            builder.Reset();
            builder.BuildHood();
            builder.BuildPockets();
            builder.BuildLaces();
            builder.BuildBackLogo();
            builder.BuildFrontLogo();
            builder.BuildCottonInside();
        }

        public void Make(String type)
        {
            builder.Reset();

            switch (type)
            {
                case "Basic":
                    buildBasicHoodie(); 
                    break;

                case "Featured":
                    buildFeaturedHoodie();
                    break;
                    
            }

            
        }

    }
}

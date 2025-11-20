namespace Builder.Builders
{
    public class BasicHoodieBuilder : Builder
    {
        private Hoodie BasicHoodie;
        public void Reset()
        {
            BasicHoodie = new Hoodie();
        }

        public void BuildHood()
        {
            BasicHoodie.HasHood = true;
        }

        public void BuildBackLogo()
        {
            BasicHoodie.HasBackLogo = false;
        }

        public void BuildPockets()
        {
            BasicHoodie.HasPockets = true;
        }

        public void BuildCottonInside()
        {
            BasicHoodie.HasCottonInside = false;
        }

        public void BuildFrontLogo()
        {
            BasicHoodie.HasFrontLogo = false;
        }

        public void BuildLaces()
        {
            BasicHoodie.HasLaces = true;
        }

        public Hoodie GetResult()
        {
            return BasicHoodie;
        }
    }
}

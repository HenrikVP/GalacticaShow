namespace GalacticaShow
{
    enum PlanetType { Terrestial, Giant, Dwarf, Gas_Giant }
    internal class Planet : SpaceObject
    {
        public PlanetType Type { get; set; }
        public int Diameter { get; set; }
        public int RotationPeriod { get; set; }
        public int RevolutionPeriod { get; set; }
        public List<Moon>? MoonList { get; set; }

        //d=√((x_2-x_1)²+(y_2-y_1)²) 
        public double? Distance()
        {

            if (Pos != null)
                return Math.Sqrt(Math.Pow(Pos.X, 2) + Math.Pow(Pos.Y, 2));
            //return Math.Sqrt(((Math.Abs(Pos.X) ^ 2) + (Math.Abs(Pos.Y) ^ 2)));
            else return null;
        }
    }
}
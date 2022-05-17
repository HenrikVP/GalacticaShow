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
        public double? Distance()
        {
            if (Pos != null)
                return Math.Sqrt(Pos.X ^ 2 + Pos.Y ^ 2);
            else return null;
        }
    }
}
namespace GalacticaShow
{
    enum StarType { YellowDwarf, White, BlueNeutron, RedGiant }
    internal class Star : SpaceObject
    {
        public StarType Type { get; set; }
        public int Temperature { get; set; }
        public List<Planet>? PlanetList { get; set; }
        public override Position? Pos { get; set; } = new Position() { X = 0, Y = 0 };
    }
}

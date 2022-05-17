namespace GalacticaShow
{
    internal sealed class Moon : Planet
    {
        public Planet? Orbiting { get; set; }
        public double? Distance(Planet planet)
        {
            //distance=√((x_2-x_1)²+(y_2-y_1)²)
            if (Pos != null && planet.Pos != null)
                return Math.Sqrt(Math.Pow(Pos.X - planet.Pos.X, 2) + Math.Pow(Pos.Y - planet.Pos.Y, 2));
            else return null;
        }
    }
}

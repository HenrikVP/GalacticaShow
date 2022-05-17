namespace GalacticaShow
{
    internal abstract class SpaceObject
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public virtual Position? Pos { get; set; }
        public class Position
        {
            public int X { get; set; }
            public int Y { get; set; }
        }
        public override string ToString()
        {
            if (Pos!= null) 
                return $"({Pos.X},{Pos.Y})";
            else return string.Empty;
        }
    }
}

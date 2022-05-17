using GalacticaShow;

Data data = new();

if (data.Sun.PlanetList == null) return;

Console.WriteLine("Planets");
foreach (Planet p in data.Sun.PlanetList)
{
    Console.WriteLine($"{p.Name} Type {p.Type} Distance to Sun {p.Distance()} Pos {p} ");
}
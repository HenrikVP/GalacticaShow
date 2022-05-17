using GalacticaShow;

Data data = new();

if (data.Sun.PlanetList == null) return;

Console.WriteLine("Planets");
foreach (Planet p in data.Sun.PlanetList)
{
    Console.WriteLine($"{p.Name}");
}
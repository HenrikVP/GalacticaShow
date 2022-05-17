using GalacticaShow;

Data data = new();

if (data.Sun.PlanetList == null) return;

Console.WriteLine("***Planets***\n");
foreach (Planet p in data.Sun.PlanetList)
{
    Console.WriteLine($"{p.Name} Type {p.Type} Distance to Sun {p.Distance()} Pos {p}\n");
    if (p.MoonList != null)
    {
        Console.WriteLine("\t***Moons***");
        foreach (Moon m in p.MoonList)
        {
            Console.WriteLine($"\t{m.Name} {m.Distance(p)}\n");
        }
    }
}
using GalacticaShow;

//d=√((x_2-x_1)²+(y_2-y_1)²) 

//double d = Math.Sqrt(Math.Pow(1-0, 2) + Math.Pow(0-0, 2));
//Console.WriteLine(d);
//return;

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
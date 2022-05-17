namespace GalacticaShow
{
    internal class Data
    {
        public Star Sun = new Star();

        List<Planet> planets = new List<Planet>()
        {
new Planet(){ Name = "Mercury", Diameter = 4879, RevolutionPeriod = 88, RotationPeriod = 1407, Id = 0, Type = PlanetType.Terrestial,
Pos = new SpaceObject.Position{X = 0, Y = 1 } },
new Planet(){ Name = "Venus", Diameter = 12104, RevolutionPeriod = 224, RotationPeriod = -5832, Id = 1, Type = PlanetType.Terrestial,
Pos = new SpaceObject.Position{X = 3, Y = 4 }},
new Planet(){ Name = "Earth", Diameter = 12756, RevolutionPeriod = 365, RotationPeriod = 24, Id = 2, Type = PlanetType.Terrestial,
Pos = new SpaceObject.Position{X = 6, Y = -8 }},
new Planet(){ Name = "Mars", Diameter = 6792, RevolutionPeriod = 687, RotationPeriod = 24, Id =3, Type = PlanetType.Terrestial,
Pos = new SpaceObject.Position{X = -8, Y = -12 }},
new Planet(){ Name = "Jupiter", Diameter = 142984, RevolutionPeriod = 4331, RotationPeriod = 10, Id =4, Type = PlanetType.Gas_Giant,
Pos = new SpaceObject.Position{X = 4, Y = -20 }},
new Planet(){ Name = "Saturn", Diameter = 120536, RevolutionPeriod = 10747, RotationPeriod = 10, Id =5, Type = PlanetType.Gas_Giant,
Pos = new SpaceObject.Position{X = 32, Y = -10 }},
new Planet(){ Name = "Uranus", Diameter = 51118, RevolutionPeriod = 30589, RotationPeriod = -17, Id =6, Type = PlanetType.Gas_Giant,
Pos = new SpaceObject.Position{X = 38, Y = 58 }},
new Planet(){ Name = "Neptune", Diameter = 49528, RevolutionPeriod = 59800, RotationPeriod = 16, Id =7, Type = PlanetType.Gas_Giant,
Pos = new SpaceObject.Position{X = -75, Y = -82 }},
new Planet(){ Name = "Pluto", Diameter = 2376, RevolutionPeriod = 90560, RotationPeriod = 153, Id =8, Type = PlanetType.Dwarf,
Pos = new SpaceObject.Position{X = 150, Y = 99 }}
        };

        public Data()
        {
            Sun.PlanetList = planets;
        }
        
    }
}

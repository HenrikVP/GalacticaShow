namespace GalacticaShow
{
    internal class Data
    {
        public Star Sun = new Star();

        private List<Planet> planets;

        public Data()
        {
            planets = new List<Planet>()
        {
new Planet(){ Name = "Mercury", Diameter = 4879, RevolutionPeriod = 88, RotationPeriod = 1407, Id = 0, Type = PlanetType.Terrestial,
Pos = new SpaceObject.Position{X = 0, Y = 1 }},
new Planet(){ Name = "Venus", Diameter = 12104, RevolutionPeriod = 224, RotationPeriod = -5832, Id = 1, Type = PlanetType.Terrestial,
Pos = new SpaceObject.Position{X = 3, Y = 4 }},
new Planet(){ Name = "Pluto", Diameter = 2376, RevolutionPeriod = 90560, RotationPeriod = 153, Id =8, Type = PlanetType.Dwarf,
Pos = new SpaceObject.Position{X = 150, Y = 99 }}
        };
            AddPlanets();

            Sun.PlanetList = planets;
        }


        void AddPlanets()
        {

            Planet earth = new Planet()
            {
                Name = "Earth",
                Diameter = 12756,
                RevolutionPeriod = 365,
                RotationPeriod = 24,
                Id = 2,
                Type = PlanetType.Terrestial,
                Pos = new SpaceObject.Position { X = 6, Y = -8 }
            };
            earth.MoonList = new() { new Moon { Name = "Luna", Orbiting = earth, Pos = new SpaceObject.Position() { X = 1, Y = 0 } } };

            Planet mars = new Planet()
            {
                Name = "Mars",
                Diameter = 6792,
                RevolutionPeriod = 687,
                RotationPeriod = 24,
                Id = 3,
                Type = PlanetType.Terrestial,
                Pos = new SpaceObject.Position { X = -8, Y = -12 }
            };
            mars.MoonList = new()
            {
                new Moon { Name = "Phobos", Orbiting = mars, Pos = new SpaceObject.Position() { X = 1, Y = 2 } },
                new Moon { Name = "Deimos", Orbiting = mars, Pos = new SpaceObject.Position() { X = -2, Y = 3 } }
            };

            Planet jupiter = new Planet()
            {
                Name = "Jupiter",
                Diameter = 142984,
                RevolutionPeriod = 4331,
                RotationPeriod = 10,
                Id = 4,
                Type = PlanetType.Gas_Giant,
                Pos = new SpaceObject.Position { X = 4, Y = -20 }
            };

            Planet saturn = new Planet()
            {
                Name = "Saturn",
                Diameter = 120536,
                RevolutionPeriod = 10747,
                RotationPeriod = 10,
                Id = 5,
                Type = PlanetType.Gas_Giant,
                Pos = new SpaceObject.Position { X = 32, Y = -10 }
            };

            Planet uranus = new Planet()
            {
                Name = "Uranus",
                Diameter = 51118,
                RevolutionPeriod = 30589,
                RotationPeriod = -17,
                Id = 6,
                Type = PlanetType.Gas_Giant,
                Pos = new SpaceObject.Position { X = 38, Y = 58 }
            };

            Planet neptune = new Planet()
            {
                Name = "Neptune",
                Diameter = 49528,
                RevolutionPeriod = 59800,
                RotationPeriod = 16,
                Id = 7,
                Type = PlanetType.Gas_Giant,
                Pos = new SpaceObject.Position { X = -75, Y = -82 }
            };

            planets.Add(earth);
            planets.Add(mars);
            planets.Add(jupiter);
            planets.Add(saturn);
            planets.Add(uranus);
            planets.Add(neptune);
        }
    }

}


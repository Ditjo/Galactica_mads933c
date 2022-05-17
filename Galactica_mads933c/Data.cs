namespace Galactica_mads933c
{
    internal class Data
    {
        public Star Sun = new Star();
        List<Planet> planets = new List<Planet>()
        {
        new Planet() { Name = "Mercury", Diameter = 4879000, RevolutionsPeriodeDage = 88, RotationsPeriodeTimer = 1407, Id = 0, Type = PlanetType.Terrestial,
        Pos = new SpaceObjects.Position{X = 0, Y = 1} },
        new Planet() { Name = "Venus", Diameter = 12104000, RevolutionsPeriodeDage = 224, RotationsPeriodeTimer = -5832, Id = 1, Type = PlanetType.Terrestial,
        Pos = new SpaceObjects.Position{X = 3, Y = 4} },
        new Planet() { Name = "Earth", Diameter = 12745591, RevolutionsPeriodeDage = 365, RotationsPeriodeTimer = 24, Id = 2, Type = PlanetType.Terrestial,
        Pos = new SpaceObjects.Position{X = 6, Y = -8} },
        new Planet() { Name = "Mars", Diameter = 6752000, RevolutionsPeriodeDage = 687, RotationsPeriodeTimer = 24, Id = 3, Type = PlanetType.Terrestial,
        Pos = new SpaceObjects.Position{X = -8, Y = -12} },
        new Planet() { Name = "Jupiter", Diameter = 142984000, RevolutionsPeriodeDage = 4331, RotationsPeriodeTimer = 10, Id = 4, Type = PlanetType.Gas_Giant,
            Pos = new SpaceObjects.Position{X = 4, Y = -20} },
        new Planet() { Name = "Saturn", Diameter = 120536000, RevolutionsPeriodeDage = 10747, RotationsPeriodeTimer = 11, Id = 5, Type = PlanetType.Gas_Giant,
        Pos = new SpaceObjects.Position{X = 32, Y = 10} },
        new Planet() { Name = "Uranus", Diameter = 51118000, RevolutionsPeriodeDage = 30589, RotationsPeriodeTimer = -17, Id = 6, Type = PlanetType.Gas_Giant,
        Pos = new SpaceObjects.Position{X = 38, Y = 58} },
        new Planet() { Name = "Neptune", Diameter = 49528000, RevolutionsPeriodeDage = 59800, RotationsPeriodeTimer = 16, Id = 7, Type = PlanetType.Gas_Giant,
        Pos = new SpaceObjects.Position{X = -75, Y = -82} }
        };
        public Data()
        {
            Sun.PlanetList = planets;
        }
        
    }
}

namespace Galactica_mads933c
{
    internal class Input
    {
        internal void InputValue()
        {
            Star star = new();
            Planet planet = new();

            star.Id = 1;
            star.Name = "Sun";
            star.Type = SpaceObjects.Startype.YellowDwarf;
            star.Temperature = 5772;//Kelvin

            planet.Id = 1;
            planet.Name = "Mercury";
            planet.Type = SpaceObjects.PlanetType.Terrestial;
            star.Planet.Add(planet);

        }
    }
}

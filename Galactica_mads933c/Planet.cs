namespace Galactica_mads933c
{
    public enum PlanetType
    {
        Terrestial, Giant, Dwarf, Gas_Giant
    }
    internal class Planet : SpaceObjects
    {
        public int Diameter { get; set; }
        public int RotationsPeriodeTimer { get; set; }
        public int RevolutionsPeriodeDage { get; set; }
        public PlanetType Type { get; set; }
        public List<Moon>? MoonList { get; set; }



        internal double Distance()
        {
            return Math.Sqrt(Math.Pow(Math.Abs(Pos.X) - 0, 2) + Math.Pow(Math.Abs(Pos.Y) - 0, 2));
        }
    }
}

namespace Galactica_mads933c
{
    public enum Startype
    {
        YellowDwarf, White, BlueNeutron, RedGiant
    }
    internal class Star : SpaceObjects
    {
        public Startype Type { get; set; }
        public int Temperature { get; set; }
        public List<Planet>? PlanetList { get; set; }
        public override Position? Pos { get; set; }  = new Position() { X = 0, Y = 0};

    }
}

namespace Galactica_mads933c
{
    internal class Star : SpaceObjects
    {
        public Startype Type { get; set; }
        public int Temperature { get; set; }
        public List<Planet> Planet { get; set; }
        

        internal void SunCoord()
        {
            Star.Position sunCoord = new();
            sunCoord.X = 0;
            sunCoord.Y = 0;
        }
    }
}

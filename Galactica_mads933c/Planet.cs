namespace Galactica_mads933c
{
    internal class Planet : SpaceObjects
    {
        public int Diameter { get; set; }
        public int RotationsPeriodeTimer { get; set; }
        public int RotationsPeriodeDage { get; set; }
        public PlanetType Type { get; set; }
        //public double distance { get; set; }
        public List<string> Moon { get; set; }
        

        internal double Distance(Star.Position starPos, Planet.Position planetPos)
        {
            planetPos = new();
            starPos = new();

            double distance = Math.Sqrt(Math.Pow((planetPos.X - starPos.X), 2) + Math.Pow((planetPos.Y - starPos.Y), 2));
            return distance;
            
        }
    }
}

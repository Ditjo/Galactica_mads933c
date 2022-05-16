namespace Galactica_mads933c
{
    internal sealed class Moon : Planet
    {
        public Planet Orbeting { get; set; }
        internal double Distance(Planet.Position planetPos, Moon.Position moonPos)
        {
            planetPos = new();
            moonPos = new();

            double distance = Math.Sqrt(Math.Pow((moonPos.X - planetPos.X), 2) + Math.Pow((moonPos.Y - planetPos.Y), 2));
            return distance;
        }
    }
}

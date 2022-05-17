namespace Galactica_mads933c
{
    internal sealed class Moon : Planet
    {
        public Planet? Orbeting { get; set; }
        public double? Distance(Planet planet)
        {
            return Math.Sqrt(Math.Pow(Pos.X - planet.Pos.X, 2) + Math.Pow(Pos.Y - planet.Pos.Y, 2));
        }
    }
}

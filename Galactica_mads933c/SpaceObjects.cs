namespace Galactica_mads933c
{
    internal abstract class SpaceObjects
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Position Pos { get; set; }

        public class Position
        {
            public int X { get; set; }
            public int Y { get; set; }

        }
        public override string ToString()
        {
            return $"({Pos.X},{Pos.Y})";
        }

    }
}

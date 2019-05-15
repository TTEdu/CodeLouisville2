namespace ConsoleAppObjects
{
    public class Map
    {
        public readonly int Width;
        public readonly int Height; 

        // constructor method
        public Map(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public bool OnMap(Point point)
        {
            //bool inBounds = point.X >= 0 && point.X < Width && point.Y >= 0 && point.Y < Height;
            //return inBounds;

            //bool outOfBounds = point.X < 0 || point.X >= Width || point.Y < 0 || point.Y >= Height;
            //inBounds = !outOfBounds;

            return point.X >= 0 && point.X < Width && point.Y >= 0 && point.Y < Height;
        }
    }
}
using System;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleAppObjects
{
    public class Point
    {
        public readonly int X;
        public readonly int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int DistanceTo(int x, int y)
        {
            //cartesian distance formula
            int xDiff = X - x;
            int yDiff = Y - y;
            int xDiffSquared = xDiff * xDiff;
            int yDiffSquared = yDiff * yDiff;

            return (int) Math.Sqrt(xDiffSquared + yDiffSquared);

            //vs refatoring and optimizing software 
            return (int) Math.Sqrt(Math.Pow(X - x, 2) + Math.Pow(Y - y, 2));
        }

        // overload a method 
        public int DistanceTo(Point point)
        {
            return DistanceTo(point.X, point.Y);
        }
    }
}
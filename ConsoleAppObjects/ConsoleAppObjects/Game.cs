// Notes 5/15/2019 
// object is an instance of class and you can use them interchangeability
// term creating an object from a class = instantiation 
// 4 core principles to object oriented programming 
//      Encapsulation
//      Ineritance
//      Polymorphism
//      Abstraction

using System;
using System.Reflection;

namespace ConsoleAppObjects
{
    public class Game
    {
        static void Main()
        {
            Tower tower = new Tower();
            Map map = new Map(8, 5);
         
            int area = map.Width * map.Height;

            //Point point = new Point(4, 2);
            //bool isOnMap = map.OnMap(point);
            //Console.WriteLine(isOnMap);

            // zero base counting 
            //point = new Point(8, 5);
            //isOnMap = map.OnMap(point);
            //Console.WriteLine(isOnMap);

            //Console.WriteLine(point.DistanceTo(5, 5));

            Point x = new MapLocation(4, 2);
            Point p = x;
            map.OnMap(new MapLocation(0, 0));

            Console.WriteLine((x.DistanceTo(5,5)));

            Console.WriteLine(x is MapLocation);
            Console.WriteLine(x is Point);

            Point point = new Point(0,0);
            Console.WriteLine(point is MapLocation);

            // pause to read the console
            Console.Write("Pause to read so press any key to contine...");
            Console.ReadKey(true);

        }
    }
}
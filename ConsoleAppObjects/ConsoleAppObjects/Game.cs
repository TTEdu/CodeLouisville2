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
        public static void Main()
        {
         
            Map map = new Map(8, 5);

            try
            {
                MapLocation mapLocation = new MapLocation(20, 20, map);
            }
            catch (OutOfBoundsExceptions ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DefenseException)
            {
                Console.WriteLine("Unhandled DefenseException");
            }
            catch (Exception)
            {
                Console.WriteLine("Unhandled Exception");
            }
            

            // pause to read the console
            Console.Write("Pause to read so press any key to contine...");
            Console.ReadKey(true);

        }
    }
}
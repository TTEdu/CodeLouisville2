using System;

namespace ConsoleAppObjects
{
    //sub class also known as child class or derived class 
    public class MapLocation : Point
    {
        //base class also known as parent class or super class 
        //object is not fully constructed until a constructor is returned
        public MapLocation(int x, int y, Map map) : base(x, y)
        {
            if (!map.OnMap(this))
            {              
                throw new OutOfBoundsExceptions();
            }
        }
    }
}
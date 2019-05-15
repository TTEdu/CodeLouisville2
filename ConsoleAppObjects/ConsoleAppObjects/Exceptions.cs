using System;

namespace ConsoleAppObjects
{
   public class DefenseException : Exception
    {
        public DefenseException() //default constructor
        {
        }

        public DefenseException(string message) : base(message)
        {
        }
    }

    public class OutOfBoundsExceptions : DefenseException
    {
        public OutOfBoundsExceptions()
        {
        }

        public OutOfBoundsExceptions(string message) : base(message)
        {
        }
    }
}
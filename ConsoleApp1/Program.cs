using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            var runningTotal = 0.0;

            while (true)
            {
                // Prompt the user for minutes exercised 
                Console.Write("Enter how many minues you exercised or type \"quit\" to exit: ");
                string entry = Console.ReadLine();

                if (entry.ToLower() == "quit")
                {
                    break;
                }
                
                try
                {
                    // Add minutes exercised to total 
                    var minutes = double.Parse(entry);

                    if (minutes <= 0)
                    {
                        Console.WriteLine(minutes + " is not an acceptable value.");
                        continue;
                    }
                    else if (minutes <= 10)
                    {
                        Console.WriteLine("Better than nothing, am I right?");
                    }
                    else if (minutes <= 30)
                    {
                        Console.WriteLine("Way to go hot stuff!");
                    }
                    else if (minutes <= 60)
                    {
                        Console.WriteLine("You must be a ninja warrior in training!");
                    }
                    else
                    {
                        Console.WriteLine("Okay, now you're just showing off!");
                    }

                    runningTotal += minutes;
                }
                catch (FormatException)
                {
                    Console.WriteLine("That is not valid input.");
                    continue;
                }

            }
                // repeat until the user quits 
            Console.WriteLine("Goodbye");
        }
    }
}
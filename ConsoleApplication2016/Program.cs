using System;

namespace ConsoleApplication2016
{
    class Program
    {
        /// <summary>
        /// Console application to show the fibonacci sequences for 10 and 40.  In reality we'd also include some test
        /// methods, at least a couple.  
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci values for position = 10");
            Console.WriteLine("---------------------------------");
            for(int i = 1; i < 11; i++)
            {
                Console.Write(i + ": ");
                Console.WriteLine(MathFunctions.CalculateFibonacci(i));
            }

            Console.WriteLine("\nFibonacci values for position = 40");
            Console.WriteLine("---------------------------------");
            for (int i = 1; i < 41; i++)
            {
                Console.Write(i + ": ");
                Console.WriteLine(MathFunctions.CalculateFibonacci(i));
            }
            
            Console.WriteLine("\nHit any key to continue..");
            Console.ReadLine();
        }
    }

    static class MathFunctions
    {
        /// <summary>
        /// Simple recursive fibonacci function.  See: https://en.wikipedia.org/wiki/Fibonacci_number
        /// </summary>
        /// <param name="position">Non-negative integer</param>
        /// <returns>Fibonacci value</returns>
        /// 
        static public int CalculateFibonacci(int position)
        {
            if(position < 0)
                throw new ArgumentOutOfRangeException("Position cannot be negative");
            else if (position <= 1)
                    return position;
            else return CalculateFibonacci(position - 1) + CalculateFibonacci(position - 2);
        }
    }
   
}

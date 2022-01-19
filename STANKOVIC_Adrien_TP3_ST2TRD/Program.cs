using System;

namespace STANKOVIC_Adrien_TP3_ST2TRD
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine();
            
            Console.WriteLine("------- Exercise 1 -------");
            Console.WriteLine();
            Exercise1.workOnMovie();
            
            Console.WriteLine();
            
            Console.WriteLine("------- Exercise 2 -------");
            Console.WriteLine();
            Console.WriteLine("Exercise 2 using DateTime: ");
            Exercise2.Ex2WithTime();
            
            /*
            * Not the best solution, the duration doesn't seem to be respected
            
            Console.WriteLine("Exercise 2 using the number of prints during the print duration: ");
            Exercise2.Ex2WithNum();
            Console.WriteLine();
            */
        }
    }
}
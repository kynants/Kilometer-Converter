using System;

namespace Kilometer_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            double kilometers, miles;

            // User Input
            Console.Write("Enter a distance in kilometers: ");
            kilometers = Convert.ToDouble(Console.ReadLine());

            // Calculations
            miles = kilometers * 0.6214;

            // Final Result
            Console.WriteLine(kilometers + " km is " + miles + " mi.");
        }
    }
}

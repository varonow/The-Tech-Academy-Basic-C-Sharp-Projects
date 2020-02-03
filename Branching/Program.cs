using System;
using static System.Console;


// BRANCHING
// Your job is to create a console-based application for getting a shipping quote for a package.

namespace Branching
{
    class Program
    {
        static void Main()
        {           
            WriteLine("Welcome to Package Express. Please follow the instructions below.");
            
            WriteLine("\nPlease enter the package weight:");
            int packageWeight = Convert.ToInt32(ReadLine());
           
            if (packageWeight > 50)
            {
                WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            } 
            else
            {
                WriteLine("\nPlease enter the package width:");
                decimal packageWidth = Convert.ToDecimal(ReadLine());

                WriteLine("\nPlease enter the package height:");
                decimal packageHeight = Convert.ToDecimal(ReadLine());

                WriteLine("\nPlease enter the package length:");
                decimal packageLength = Convert.ToDecimal(ReadLine());
               
                if (packageWidth + packageHeight + packageLength > 50)
                {
                    WriteLine("Package too big to be shipped via Package Express.");
                } 
                else
                {
                    decimal packageQuote = packageWidth * packageHeight * packageLength * packageWeight / 100; 
                    WriteLine($"Your estimated total for shipping this package is: ${string.Format("{0:F2}", packageQuote)}\nThank you.");
                }
            }

            Read();

        }
    }
}

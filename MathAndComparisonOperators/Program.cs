using System;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main()
        {
            // Takes an input from the user, multiplies it by 50, and prints the result to the console.
            // (Note: make sure your code can take inputs larger than 10,000,000).

            Console.WriteLine("Please enter a whole number to multiply it by 50:");
            int toMultiply = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"{toMultiply} * 50 = {toMultiply * 50}\n");

            // Takes an input from the user, adds 25 to it, and prints the result to the console.

            Console.WriteLine("Please enter a whole number to add 25 to it:");
            int toAdd = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"{toAdd} + 25 = {toAdd + 25}\n");

            // Takes an input from the user, divides it by 12.5, and prints the result to the console.

            Console.WriteLine("Please enter a number to divide it by 12.5:");
            double toDivide = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{toDivide} / 12.5 = {toDivide / 12.5}\n");

            // Takes an input from the user, checks if it is greater than 50, and prints the true/false 
            // result to the console.

            Console.WriteLine("Enter a whole number to see if it is greater than 50");
            int toCompareToFifty = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"{toCompareToFifty} > 50 ? {toCompareToFifty > 50}\n");

            // Takes an input from the user, divides it by 7, and prints the remainder to the console 
            // (tip: think % operator).

            Console.WriteLine("Enter a number to see the remainder after dividing by 7");
            double divideBySeven = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{divideBySeven} / 7 has a remainder of {divideBySeven % 7}\n");


            Console.Read();
        }
    }
}

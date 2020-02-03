using System;

// Applicants must be over 15 years old.
// Applicants must not have any DUI’s.
// Applicants must not have more than 3 speeding tickets.



namespace BooleanLogic
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter your age:");
            int userAge = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\nHave you ever had a DUI? Please answer \"True\" or \"False\"");
            bool userHadDUI = bool.Parse(Console.ReadLine());

            Console.WriteLine("\nHow many speeding tickets do you have?");
            int userTickets = Int32.Parse(Console.ReadLine());

            bool userQualified = userAge > 15 && !userHadDUI && userTickets < 3;

            Console.WriteLine($"\nQualified?\n{userQualified}");

            Console.Read();
        }
    }
}

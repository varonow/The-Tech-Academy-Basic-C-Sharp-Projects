using System;

namespace HourlyIncome
{
    class Program
    {
        static void Main()
        {
            // The program must start by printing “Anonymous Income Comparison Program” to the screen.
            Console.WriteLine("Anonymous Income Comparison Program");

            // It must then print “Person 1” to the screen and get the following details:
            // Hourly rate, Hours worked per week
            // It must then print to the screen “Annual salary of Person 1:” and write the exact salary below it.
            Console.WriteLine("Person 1\nHourly Rate?");
            double hourlyRate1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            double hoursWorked1 = Convert.ToDouble(Console.ReadLine());
            double annualSalary1 = hourlyRate1 * hoursWorked1 * 52.0;

            // It must then print “Person 2” to the screen and get the following details:
            // Hourly rate, Hours worked per week
            // It must then print to the screen “Annual salary of Person 1:” and write the exact salary below it.
            Console.WriteLine("Person 2\nHourly Rate?");
            double hourlyRate2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            double hoursWorked2 = Convert.ToDouble(Console.ReadLine());
            double annualSalary2 = hourlyRate2 * hoursWorked2 * 52.0;

            // It must then print to the screen “Annual salary of Person 1:” and write the exact salary below it.
            // It must then print to the screen “Annual salary of Person 2:” and write the exact salary below it.
            Console.WriteLine($"Annual salary of Person 1:\n{annualSalary1}\nAnnual salary of Person 2:\n{annualSalary2}");

            // It must then print to the screen “Does Person 1 make more money than Person 2?” 
            // and write the true or false value of this statement below it.
            Console.WriteLine($"Does Person 1 make more money than Person 2?\n{annualSalary1 > annualSalary2}");

            Console.Read();
        }
    }
}

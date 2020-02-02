using System;


//After all of the questions are asked, print, “Thank you for your answers. 
//    An Instructor will respond to this shortly.Have a great day!” 
//    This would be the end of the program.



    namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy\nStudent Daily Report");

            Console.WriteLine("What course are you on?");
            string userCourse = Console.ReadLine();

            Console.WriteLine("\nWhat page number?");
            int userPageNum = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\nDo you need help with anything? Please answer \"true\" or \"false\".");
            bool userNeedHelp = bool.Parse(Console.ReadLine());

            Console.WriteLine("\nWere there any positive experiences you’d like to share? Please give specifics.");
            string userPositiveInput = Console.ReadLine();

            Console.WriteLine("\nIs there any other feedback you’d like to provide? Please be specific.");
            string userMiscInput = Console.ReadLine();

            Console.WriteLine("\nHow many hours did you study today?");
            int userHoursStudied = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\nThank you for your answers.\nAn Instructor will respond to this shortly.\nHave a great day!");

            Console.ReadLine();
        }
    }
}

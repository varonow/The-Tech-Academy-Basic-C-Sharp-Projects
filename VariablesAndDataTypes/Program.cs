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

            Console.WriteLine("What page number?");
            string userPageNum = Console.ReadLine();

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string userNeedHelp = Console.ReadLine();

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string userPositiveInput = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string userMiscInput = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string userHoursStudied = Console.ReadLine();

            Console.WriteLine("Thank you for your answers.\nAn Instructor will respond to this shortly.\nHave a great day!");

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandlingPractice
{
    class Program
    {
        static void Main()
        {
            try
            {
                List<int> intList = new List<int>() { 15, 34, 889, 4563, 9458 };
                Console.WriteLine("Enter a number to divide each number in the list by");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                foreach (int number in intList)
                {
                    Console.WriteLine($"{number} / {userNumber} = {number / userNumber}");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("\nAnything here still gets run even if there is a return in a catch");  
            }



            Console.WriteLine("\nThis is after the Try/Catch");
            Console.ReadLine();
        }
    }
}

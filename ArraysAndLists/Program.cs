using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main()
        {
            string[] nameArray = {"Joyce", "Danielle", "Jake", "Kimberly", "Stephanie"};
            int[] numArray = { 24, 25, 12, 5, 15 };
            List<string> nameList = new List<string>( ) {"Rebecca", "Nancy", "Susie", "Jennifer", "Teddy"};
            int userIndexNumber;
            bool indexExists = false;
            
            // String Array
            do
            {
                Console.WriteLine("Enter a number between 0 and 4 to see the name at that index in the array:");
                userIndexNumber = Convert.ToInt32(Console.ReadLine());

                if (userIndexNumber < nameArray.Length && userIndexNumber >= 0)
                {
                    Console.WriteLine($"The value at index {userIndexNumber} is {nameArray[userIndexNumber]}");
                    indexExists = true;
                }
                else
                {
                    Console.WriteLine("You did not give a number between 0 and 4!\n");
                }

            } while (indexExists == false);


            // Integer Array
            indexExists = false;

            do
            {
                Console.WriteLine("\nEnter a number between 0 and 4 to see the number at that index in the array:");
                userIndexNumber = Convert.ToInt32(Console.ReadLine());

                if (userIndexNumber < numArray.Length && userIndexNumber >= 0)
                {
                    Console.WriteLine($"The value at index {userIndexNumber} is {numArray[userIndexNumber]}");
                    indexExists = true;
                }
                else
                {
                    Console.WriteLine("You did not give a number between 0 and 4!\n");
                }

            } while (indexExists == false);


            // String List
            indexExists = false;
            
            do
            {
                Console.WriteLine("\nEnter a number between 0 and 4 to see the name at that index in the list:");
                userIndexNumber = Convert.ToInt32(Console.ReadLine());

                if (userIndexNumber < nameList.Count && userIndexNumber >= 0)
                {
                    Console.WriteLine($"The value at index {userIndexNumber} is {nameList[userIndexNumber]}");
                    indexExists = true;
                }
                else
                {
                    Console.WriteLine("You did not give a number between 0 and 4!\n");
                }

            } while (indexExists == false);


            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;

namespace IterationPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stepStrings = { "first", "second", "third", "forth", "fifth" };

            Console.WriteLine("your top 5 desserts:");

            for (int i = 0; i < stepStrings.Length; i++)
            {
                Console.WriteLine($"\nenter your {stepStrings[i].ToLower()} favorite dessert:");
                stepStrings[i] += ": " + Console.ReadLine();
            }

            Console.WriteLine("\nyour favorites:\n");

            foreach (string dessert in stepStrings)
            {
                Console.WriteLine($"{dessert}\n");
            }

            Console.WriteLine("a loop using < comparison: count from 1 to 5\n");
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\na loop using <= comparison: count from 1 to 5\n");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }

            //  Create a List of strings where each item in the list is unique. Ask the user to input text to search for in the List.
            //  Create a loop that iterates through the loop and then displays the index of the array that contains matching text on the screen.
            List<string> uniqueNames = new List<string>() { "rebecca", "victoria", "nancy", "teddy", "susie" };
            int indexMatch = -1;

            Console.WriteLine("\nEnter a name to view its index in the list:");
            string userInput = Console.ReadLine().ToLower();

            for (var i = 0; i < uniqueNames.Count; i++)
            {
                if (uniqueNames[i] == userInput)
                {
                    indexMatch = i;
                    break;
                }
            }

            if (indexMatch > -1)
            {
                Console.WriteLine($"\n\"{userInput}\" is found at index {indexMatch}");
            }
            else
            {
                Console.WriteLine($"\n\"{userInput}\" was not found in the list");
            }

            // Create a List of strings that has at least two identical strings in the List. Ask the user to select text to search for in the List.
            // Create a loop that iterates through the loop and then displays the indices of the array that contain matching text on the screen.
            List<string> duplicatesList = new List<string>() {"apples", "bananas", "pears", "apples", "bananas"};
            List<int> foundIndexList = new List<int>();

            Console.WriteLine("\nEnter a fruit to view its index(es) in the list:");
            userInput = Console.ReadLine().ToLower();

            for (var i = 0; i < duplicatesList.Count; i++)
            {
                if (duplicatesList[i] == userInput)
                {
                   foundIndexList.Add(i);
                }
            }

            if (foundIndexList.Count > 0)
            {
                Console.WriteLine($"\n\"{userInput}\" was found at index(es): ");
                foreach (int fruitIndex in foundIndexList)
                {
                    Console.WriteLine($"{fruitIndex} ");
                }
            }
            else
            {
                Console.WriteLine($"\n\"{userInput}\" was not found in the list");
            }


            // Create a foreach loop that evaluates each item in the list,
            // and displays a message showing the string and whether or not it has already appeared in the list.
            int count = 0;

            Console.WriteLine("\nLooping through List finding if already appeared:");
            foreach (string fruit in duplicatesList)
            {
                if (duplicatesList.IndexOf(fruit) == count)
                {
                    Console.WriteLine($"\n{fruit}: First time in the list");
                }
                else
                {
                    Console.WriteLine($"\n{fruit}: Has already appeared in the list");
                }

                count++;
            }

            Console.ReadLine();
        }
    }
}

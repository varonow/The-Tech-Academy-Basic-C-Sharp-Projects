using System;
using System.Text;

namespace StringPractice
{
    class Program
    {
        static void Main()
        {
            // Concatenate three strings.
            string firstName = "Victoria";
            string lastName = "Aronow";
            Console.WriteLine(firstName + " " + lastName);

            // Convert a string to uppercase.
            Console.WriteLine("\nMy name in all uppercase is " + firstName.ToUpper() + " " + lastName.ToUpper());

            // Create a Stringbuilder and build a paragraph of text, one sentence at a time.
            StringBuilder myStory = new StringBuilder();
            myStory.Append("\n\tOur leadership team is one of our greatest assets.");
            myStory.Append("  Our leaders are not only amazing engineers, finance, sales, marketing and technology professionals; they are hands-on assets to your business.");
            myStory.Append("  With MetTel, you can expect one-on-one time with key executives.");
            myStory.Append("  We lend our experience to craft straightforward solutions to your telecom needs.");
            myStory.Append("  We can help you make smart telecom investments today so that you have flexibility tomorrow.");

            Console.WriteLine(myStory);

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main()
        {
            bool tester = false;
            int counter = 0;
            Console.WriteLine("Count to 10 with a while statement:\n");
            while (!tester)
            {
                counter++;
                Console.WriteLine(counter);
                if (counter >= 10)
                {
                    tester = true;
                }
                
            }

            counter = 0;
            tester = false;
            Console.WriteLine("\nCount to 10 with a do while statement:\n");
            do
            {
                counter++;
                Console.WriteLine(counter);
                if (counter >= 10)
                {
                    tester = true;
                }
            } while (!tester);

            Console.Read();
        }

    }
}

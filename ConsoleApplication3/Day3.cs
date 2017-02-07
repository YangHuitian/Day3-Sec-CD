using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Day3
    {
        public static void Main()
        {
            Console.Write("Pls enter a num: ");
            string input = Console.ReadLine();

            double number;
            bool isParsed = Double.TryParse(input, out number);

            if (!isParsed)
                Console.WriteLine("It's not a num.");
            else
                Console.WriteLine("You can follow ins.");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class ProgramSecD
    {
        public static void Main()
        {
            //D1
            bool yourguess = false;
            string haha = "88";
            while (!yourguess)
            {
                Console.Write("Guess an int: ");
                string num = Console.ReadLine();

                if (num != haha)
                {
                    yourguess = false;
                    Console.WriteLine("Try again!");
                }

                else
                {
                    yourguess = true;
                    Console.WriteLine("Lucky you!");
                }
                
            }



            //D2
            Console.Write("A: ");
            string a = Console.ReadLine();
            double A = Convert.ToDouble(a);
            Console.Write("B: ");
            string b = Console.ReadLine();
            double B = Convert.ToDouble(b);
            double C = A * B;

            while (A != B)
            {
                if (A > B)
                    A = A - B;
                else if (A < B)
                    B = B - A;
            }
                double X = A;
            double Y = C / X;
            Console.WriteLine("HCF: {0} , LCM: {1}", X, Y);



            //D3
            int t = 0;
            Random w = new Random();
            int wnum = w.Next(0, 10);
            string answer = wnum.ToString();
            bool youranswer = false;

            while (!youranswer)
            {
                Console.Write("Pls Guess an int: ");
                string n = Console.ReadLine();
                t += 1;

                if (n != answer)
                {
                    youranswer = false;
                    Console.WriteLine("Try again, bro!");
                }
                else
                {
                    youranswer = true;
                    Console.WriteLine("Cong!");
                    Console.WriteLine("Attempts you took: {0}", t);

                    if (t <= 2)
                        Console.WriteLine("You are a wizard!");
                    else if (t > 2 && t <= 5)
                        Console.WriteLine("You are lousy!");
                }
            }

        
        }
    }
}

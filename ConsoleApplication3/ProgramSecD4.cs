using System;

namespace ConsoleApplication3
{
    class ProgramSecD4
    {
        public static void Main()
        {
            //D4
            Console.Write("N: ");
            string p = Console.ReadLine();
            int N = Convert.ToInt32(p);
            Random rnd = new Random();
            double G = rnd.Next(1, N);
            bool yourg = false;

            while (!yourg)
            {
                if (((G * G) - N ) <= 0.00001)
                {
                    yourg = true;
                    Console.WriteLine("{0}", Math.Round(G, 3));
                }
                else
                {
                    yourg = false;
                    G = ((G + N / G) / 2);
                }

            }
        }
    }
}

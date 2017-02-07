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
                if ((G * G) == N)
                {
                    yourg = true;
                    Console.WriteLine(G);
                }
                else
                {
                    yourg = false;
                    G = Math.Round(((G + N)/ G) / 2, 5);
                }

            }
        }
    }
}

using System;


namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            //C1
            Console.Write("Pls enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Pls enter your gender(M or F): ");
            string gender = Console.ReadLine();

            if (gender == "M")
                Console.WriteLine("Good Morning Mr. " + name);
            else if (gender == "F")
                Console.WriteLine("Good Morning Ms. " + name);
            else
                Console.WriteLine("Wrong input");


            //C2
            Console.Write("Pls enter your age: ");
            string age = Console.ReadLine();
            int ageint = Convert.ToInt32(age);

            if (gender == "M")
                if (ageint >= 40)
                    Console.WriteLine("Good Morning Uncle " + name);
                else
                    Console.WriteLine("Good Morning Mr. " + name);
            else 
                if (ageint >= 40)
                    Console.WriteLine("Good Morning Aunty " + name);
                else
                    Console.WriteLine("Good Morning Ms. " + name);


            //C3
            Console.Write("Your mark is: ");
            string mark = Console.ReadLine();
            int markint = Convert.ToInt32(mark);

            if (markint >= 80 && markint <= 100)
                Console.WriteLine("You scored {0} marks which is A grade.", markint);
            else if (markint >= 60 && markint <= 79)
                Console.WriteLine("You scored {0} marks which is B grade.", markint);
            else if (markint >= 40 && markint <= 59)
                Console.WriteLine("You scored {0} marks which is C grade.", markint);
            else if (markint > 0 && markint <= 39)
                Console.WriteLine("You scored {0} marks which is D grade.", markint);
            else
                Console.WriteLine("Your input is wrong.", markint);

            //C4
            Console.Write("Your distance(in km): ");
            string dist = Console.ReadLine();
            double dist2 = Convert.ToDouble(dist);
            double rounddist = ((Math.Ceiling(dist2 * 10)) / 10);
            //Console.WriteLine(rounddist);
            double charge1 = 2.40 + 10 * (rounddist - 0.5) * 0.04;
            double charge2 = 2.40 + 10 * 8.5 * 0.04 + (rounddist - 9.0) * 10 * 0.05;

            if (rounddist <= 0.5)
                Console.WriteLine("Your charge is $2.40.");
            else if ((rounddist > 0.5) && (rounddist <= 9.0))
                Console.WriteLine("Your charge is ${0:0.00}.", charge1);
            else
                Console.WriteLine("Your charge is ${0:0.00}.", charge2);


            //C5
            Console.Write("Choose a 3-digit num: ");
            string num = Console.ReadLine();
            int numint = Convert.ToInt32(num);

            int a = numint / 100;
            int b = (numint % 100) / 10;
            int c = (numint % 100) % 10;
            int check = a * a * a + b * b * b + c * c * c;
            //Console.WriteLine(check);

            if (numint == check)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");


            //C6
            Console.Write("TV: ");
            String tvq = Console.ReadLine();
            Console.Write("DVD: ");
            String dvdq = Console.ReadLine();
            Console.Write("MP3: ");
            String mp3q = Console.ReadLine();

            int tvqi = Convert.ToInt32(tvq);
            int dvdqi = Convert.ToInt32(dvdq);
            int mp3qi = Convert.ToInt32(mp3q);
            int totaltd = (900 * tvqi) + (500 * dvdqi);
            //Console.WriteLine(totaltd);
            double total;

            if (totaltd >= 5000 && totaltd < 10000)
            {
                total = (0.9 * totaltd) + (mp3qi * 700);
                Console.WriteLine("Discounted price: ${0}", total);
            }
            else if (totaltd >= 10000)
            {
                total = (0.85 * totaltd) + (mp3qi * 700);
                Console.WriteLine("Discounted price: ${0}", total);
            }
            else
            {
                total = totaltd + mp3qi * 700;
                Console.WriteLine("Discounted price: ${0}", total);
            }

            
            }
    }
}

// c# basic
using System;

namespace Project
{
    class Program1
    {
        static void Main(string[] args)
        {
            var r = "Hello, raghod!";
            // استدعاء الميثود من الكلاس 1
            // Console.WriteLine(r);

            // استدعاء الميثود من الكلاس الثاني
            // Program2.SecondMethod();
            //  Program3.SeconddMethodd();
            //  Program4.SeconddMethoddd();
            //  Cond.condd();
            //  Cool.congdd();
            // Griad.user();
            // Sea.sea();
            // Count.count();
           For.fo();

        }
    }

    class Program2
    {
        public static void SecondMethod()
        {
            var ra = "Hello, raghod!!!!";
            Console.WriteLine(ra);
        }
    }

    class Program3
    {
        public static void SeconddMethodd()
        {
            var rag = Console.ReadLine();
            Console.WriteLine(rag);
        }
    }

    class Program4
    {
        public static void SeconddMethoddd()
        {
            string rag = "asxiaxoax";
            Console.WriteLine("{0}", rag);
        }
    }

    class Cond
    {
        public static void condd()
        {
            var age = 9;
            if (age >= 18)
            {
                Console.WriteLine("adult");
            }
            else
            {
                Console.WriteLine("minor");
            }
        }

    }
    class Cool
    {
        public static void congdd()
        {
            var nann = 13;
            if (nann <= 11)
                Console.WriteLine("adada");
            else
            {
                Console.WriteLine("i dont know");
            }
        }
    }
    class Griad
    {
        public static void user()
        {
            var u = 6;
            if (u >= 95)
                Console.WriteLine("u got A+ !!!");
            else if (u >= 90)
                Console.WriteLine("u got A !!!");
            else if (u >= 85)
                Console.WriteLine("u got B+ !!!");
            else
            {
                Console.WriteLine("u fail");
            }

        }
    }

    class Sea
    {
        public static void sea()
        {
            int s = 2;
            switch (s)
            {
                case 1:
                    Console.WriteLine("w");
                    break;

                case 2:
                    Console.WriteLine("s");
                    break;
                case 3:
                    Console.WriteLine("a");
                    break;

                case 4:
                    Console.WriteLine("s");
                    break;
                default:
                    Console.WriteLine("not a season");
                    break;
            }
        }
    }

    class Count
    {
        public static void count()
        {
            var count = 9;
            while (count <= 10)
            {
                Console.WriteLine(count);
                count++;
            }


        }

    }

    class For
    {
        public static void fo()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            
            for (int d = 100; d >= 1; d--)
            {
                Console.WriteLine(d);
            }

        }
    }

}
// This code defines a simple C# console application with two classes.
// The `Program` class contains the `Main` method which prints a greeting message and calls
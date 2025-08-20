// c# basic
using System;
using System.Drawing;

namespace Project
{
    class Program1
    {
        static void Main(string[] args)
        {
            var name = "Hello, raghod!";
            // calling the methods

            // Console.WriteLine(name);
            // Program2.SecondMethod();
            // Program3.ThirdMethod();
            // Program4.FourthMethodd();
            // Age.age();
            // Grade.user();
            // Season.season();
            // Count.count();
            // ForLoop.forloop();
            Array.array();

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
        public static void ThirdMethod()
        {
            var input = Console.ReadLine();
            Console.WriteLine(input);
        }
    }

    class Program4
    {
        public static void FourthMethodd()
        {
            string strings = "the whether is wanderfull today";
            Console.WriteLine("{0}", strings); //format
        }
    }

    class Age
    {
        public static void age()
        {
            var age = 9;
            if (age >= 18)
            {
                Console.WriteLine("adult");
            }
            else
            {
                Console.WriteLine("under age your minor");
            }
        }

    }

    class Grade
    {
        public static void user()
        {
            var u = 6;
            if (u >= 95)
                Console.WriteLine("Excellent got A+");
            else if (u >= 90)
                Console.WriteLine("Nice work you got A");
            else if (u >= 85)
                Console.WriteLine("Good you got B+");
            else
            {
                Console.WriteLine("we are sorry you failed");
            }

        }
    }

    class Season
    {
        public static void season()
        {
            int s = 2;
            switch (s)
            {
                case 1:
                    Console.WriteLine("winter");
                    break;

                case 2:
                    Console.WriteLine("summer");
                    break;
                case 3:
                    Console.WriteLine("autmn");
                    break;

                case 4:
                    Console.WriteLine("spring");
                    break;
                default:
                    Console.WriteLine("its not a season");
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

    class ForLoop
    {
        public static void forloop()
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


        class Array
    {
        public static void array()
        {
            var colors = new string[3];
            colors[0] = "white";
            colors[1] = "black";
            colors[2] = "red";
            Console.WriteLine(colors[0]);
        }
    }
}
// This code defines a simple C# console application classes.
// The `Program` class contains the `Main` method which prints a greeting message and calls
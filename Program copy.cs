using System;
using System.Drawing;
// c# basic 

// الخطوات لإنشاء البرنامج كالتالي:
// يأخذ اسم الطالب ودرجته عن طريق جمل الإدخال في console.
// يكون البرنامج قادر على تحمل أي عدد من الطلاب.
// يعرض أسماء الطلاب ودرجاتهم.
// طباعة الكلمة Failed في حال كانت درجة الطالبة أقل من 60 والكلمة Passed في حال كانت الدرجة 60 أو أكبر.

namespace Project
{
    class Project
    {
        public static void project()
        {
            Console.WriteLine("Welcome to my first project in c#");
            Console.WriteLine("do you want start and add student y/n:");
            var input = Console.ReadLine();
            if (input.ToLower() == "y")
            {
                first();
            }
            else
            {
                no();
            }
        }
        public static void first()
        {
            Console.WriteLine("Enter names separated by space:");
            string input = Console.ReadLine();
            string[] names = input.Split(' ');
            Console.WriteLine("Enter greads separated by space:");
            string gread = Console.ReadLine();
            string[] grades = gread.Split(' ');

            // for (int  i = 0;  i < length;  i++)
            for (int i = 0; i < names.Length; i++) // i= index 
            {
                Console.WriteLine("name : " + names[i] + " \n" + "mark : " + grades[i]);
                if (int.Parse(grades[i]) >= 60) // from string to int
                {
                    Console.WriteLine("Passed");
                }
                else
                {
                    Console.WriteLine("Failed");
                }
            }

            add();
        }
        public static void add()
        {
            Console.WriteLine("do you want add more? y/n");
            var input = Console.ReadLine();
            if (input.ToLower() == "y")
            {
                first();
            }
            else
            {
                no();
            }
        }
        public static void no()
        {
            Console.WriteLine("goodbye");
        }
    }
}
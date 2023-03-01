using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace _1400_exercises
{

    class Chapter1
    {
        public static void Exercise1()
        {
            int x = 31, y = 18, z = 79;

            Console.WriteLine(x.ToString() + " " + y.ToString() + " " + z.ToString());
            Console.ReadLine();
        }
        public static void Exercise2()
        {
            int x = 47, y = 52, z = 150;

            Console.WriteLine(x.ToString()+ "  " + y.ToString()+"  " + z.ToString());
            Console.ReadLine();
        }
        public static void Exercise3()
        {
            int x = 50, y = 10;
            Console.WriteLine(x.ToString());
            Console.WriteLine(y.ToString());
            Console.ReadLine();
        }
        public static void Exercise4()
        {
            int x = 5, y = 10, z = 21;
            Console.WriteLine(x.ToString());
            Console.WriteLine(y.ToString());
            Console.WriteLine(z.ToString());
            Console.ReadLine();
        }
        public static void Exercise5()
        {
            int x = 1, y = 2;
            Console.WriteLine(x.ToString());
            Console.WriteLine(y.ToString());
            Console.ReadLine();
        }
        public static void Exercise6()
        {
            float p = 3.1415926F;

            Console.WriteLine("{0:0.###}", p);
            Console.ReadLine();
        }
        public static void Exercise7()
        {
            float e = 2.71828F;
            Console.WriteLine("{0:0.#}", e);
            Console.ReadLine();
        }
        public static void Exercise8()
        {
            int x;
            Console.WriteLine("Enter the number");
            x= int.Parse(Console.ReadLine());
            Console.WriteLine("You enter {0}", x);
            Console.ReadLine();

        }
        public static void Exercise9()
        {
            int x;
            Console.WriteLine("Enter the number");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} You enter ", x);
            Console.ReadLine();
        }
        public static void Exercise10()
        {
            Console.WriteLine("Enter the name");
            string name = Console.ReadLine();
            Console.WriteLine(name);
            Console.ReadLine();

        }
        public static void Exercise11() 
        {
            Console.WriteLine("Enter the footbal team");
            string name = Console.ReadLine();
            Console.WriteLine(name+" is champion");
            Console.ReadLine();
        }
        public static void Exercise12()
        {
            Console.WriteLine("Enter the name");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, "+name +"!");
            Console.ReadLine();
        }
        public static void Exercise13()
        {
            Console.WriteLine("Enter the number");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Next number after "+x.ToString()+ " number - " + (x+1).ToString());
            Console.WriteLine("For number " + x.ToString() + " previous number - " + (x - 1).ToString());
            Console.ReadLine();
        }
        public static void Exercise14()
        {
            Console.WriteLine("Enter 1 number");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2 number");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 3 number");
            int z = int.Parse(Console.ReadLine());
            Console.WriteLine(x.ToString() + "  " + y.ToString()+ "  "+ z.ToString());
            Console.ReadLine();
        }
        public static void Exercise15()
        {
            Console.WriteLine("Enter 1 number");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2 number");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 3 number");
            int z = int.Parse(Console.ReadLine());
            Console.WriteLine(x.ToString() + " " + y.ToString() + " " + z.ToString());
            Console.ReadLine();
        }
        public static void Exercise16()
        {
            Console.WriteLine("Enter t");
            int t = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter v");
            int v = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter x");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter y");
            int y = int.Parse(Console.ReadLine());

            Console.Write("5 10 ");
            Console.Write("100 " + t.ToString()+ " ");
            Console.Write(x.ToString()+ " 25");
            Console.WriteLine();
            Console.Write("7 cm ");
            Console.Write("1949 " + v.ToString()+ " ");
            Console.Write(x.ToString()+ " "+ y.ToString());
            Console.ReadLine();

             }
        public static void Exercise17()
        {
            Console.WriteLine("Enter a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter x");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter y");
            int y = int.Parse(Console.ReadLine());

            Console.Write("2 kg ");
            Console.Write(a.ToString() + " 1 ");
            Console.Write(x.ToString() + " " + y.ToString());
            Console.WriteLine();
            Console.Write("13 17 ");
            Console.Write("19 " + b.ToString() + " ");
            Console.Write("5 " + y.ToString());
            Console.ReadLine();
        }
    }


    class Program
    {
        static void Mainx(string[] args)
        {
            //Chapter1.Exercise1();
            //Chapter1.Exercise2();
            //Chapter1.Exercise3();
            //Chapter1.Exercise4();
            //Chapter1.Exercise5();
            //Chapter1.Exercise6(); 
            //Chapter1.Exercise7();
            //Chapter1.Exercise8();
            //Chapter1.Exercise9();
            //Chapter1.Exercise10();
            //Chapter1.Exercise11();
            //Chapter1.Exercise12();
            //Chapter1.Exercise13();
            //Chapter1.Exercise14();
            //Chapter1.Exercise15();
            //Chapter1.Exercise16();
            //Chapter1.Exercise17();
        }
    }
}

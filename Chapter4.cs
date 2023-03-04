using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace _1400_exercises
{
    class Chapter4
    {
        public static void Exercise1()
        {
            Console.WriteLine("Enter number a");
            string inputA = Console.ReadLine();
            Console.WriteLine("Enter number b");
            string inputB = Console.ReadLine();

            if (double.TryParse(inputA, out double a) &&  double.TryParse(inputB, out double b))
            {
                if (a>b)
                {
                    Console.WriteLine("number a = {0} and is biggest than number b = {1}", a,b);
                }
                else if (a<b)
                {
                    Console.WriteLine("number a = {0} and is smaller than number b = {1}", a, b);
                }
                else
                {
                    Console.WriteLine("number a = {0} and is equal number b = {1}", a, b);
                }
            }

            else
            {
                Console.WriteLine("a and b shold be numbers");
            }
            Console.ReadLine();
        }

        public static void Exercise2()
        {
            Console.WriteLine("enter x");
            string inputX = Console.ReadLine();

            if (double.TryParse(inputX, out double x))
            {
                if (x>0) 
                   {
                    double res = Math.Pow(Math.Sin(x), 2);
                    
                    Console.WriteLine(" y = {0}", res);
                }

                else
                {
                    double res = 1 - 2* Math.Pow(Math.Sin(x), 2);
                    Console.WriteLine(" y = {0}", res);
                }
                }

            else
            {
                Console.WriteLine("x should be number");
            }
            Console.ReadLine();
        }

        public static void Exercise3()
        {
            Console.WriteLine("enter x");
            string inputX = Console.ReadLine();

            if (double.TryParse(inputX, out double x))
            {
                if (x > 0)
                {
                    double res = Math.Sin(Math.Pow(x,2));

                    Console.WriteLine(" y = {0}", res);
                }

                else
                {
                    double res = 1 + 2 * Math.Pow(Math.Sin(x), 2);
                    Console.WriteLine(" y = {0}", res);
                }
            }

            else
            {
                Console.WriteLine("x should be number");
            }
            Console.ReadLine();

        }
        public static void Exercise4()
        {
            Console.WriteLine("enter x");
            string inputX = Console.ReadLine();
            Console.WriteLine("enter y");
            string inputY = Console.ReadLine();

            if (double.TryParse(inputX, out double x) && double.TryParse(inputY, out double y))
            {
                if (x< 4)
                {
                    Console.WriteLine("Point ({0} , {1}) in Area I", x,y);
                }
                else
                {
                    Console.WriteLine("Point ({0} , {1}) in Area II", x, y);
                }
            }

            else
            {
                Console.WriteLine("x and y should be numbers");
            }
            Console.ReadLine();
        }

        public static void Exercise5()
        {
            Console.WriteLine("enter x");
            string inputX = Console.ReadLine();
            Console.WriteLine("enter y");
            string inputY = Console.ReadLine();

            if (double.TryParse(inputX, out double x) && double.TryParse(inputY, out double y))
            {
                if (y > 3)
                {
                    Console.WriteLine("Point ({0} , {1}) in Area I", x, y);
                }
                else
                {
                    Console.WriteLine("Point ({0} , {1}) in Area II", x, y);
                }
            }

            else
            {
                Console.WriteLine("x and y should be numbers");
            }
            Console.ReadLine();
        }

        public static void Exercise6a()
        {
            Console.WriteLine("enter x");
            string inputX = Console.ReadLine();

            if (double.TryParse(inputX, out double x))
            {
                if (x > 2)
                {
                    Console.WriteLine("y = 2");
                }
                else
                {
                    Console.WriteLine("y = {0}", x);
                }
            
            }
            else {
                Console.WriteLine("x should be number" );

            }
            Console.ReadLine();
           
        }

        public static void Exercise6b()
        {
            Console.WriteLine("enter x");
            string inputX = Console.ReadLine();

            if (double.TryParse(inputX, out double x))
            {
                if (x < 3)
                {
                    Console.WriteLine("y = {0}", -x);
                }
                else
                {
                    Console.WriteLine("y = -3");
                }
            }
            else
            {
                Console.WriteLine("x should be number");

            }
            Console.ReadLine();
        }

        public static void Exercise7() 
        {
            Console.WriteLine("Enter x");
            string inputX = Console.ReadLine();
            double k;

            if (double.TryParse(inputX, out double x))
            {

                if (Math.Sin(x) < 0)
                {
                   k = Math.Pow(x, 2);
                }

                else
                {
                    k = Math.Abs(x);
                    
                }

                if (x>k)
                {
                    double res = k * x;
                    Console.WriteLine("Result k*x = {0}", res);
                }
                else
                {
                    double res = k + x;
                    Console.WriteLine("Result k + x = {0}", res);
                }

            }
            else
            {
                Console.WriteLine("x should be number");
            }
            Console.ReadLine();
        }

        public static void Exercise8()
        {
            Console.WriteLine("Enter x");
            string inputX = Console.ReadLine();
            double k;

            if (double.TryParse(inputX, out double x))
            {

                if (Math.Sin(x) >= 0)
                {
                    k = Math.Pow(x, 2);
                }

                else
                {
                    k = Math.Abs(x);

                }

                if (x >= k)
                {
                    double res = k * x;
                    Console.WriteLine("Result k*x = {0}", res);
                }
                else
                {
                    double res = Math.Abs(x);
                    Console.WriteLine("Result abs(x) = {0}", res);
                }

            }
            else
            {
                Console.WriteLine("x should be number");
            }
            Console.ReadLine();

        }

        public static void Exercise9()
        {
            Console.WriteLine("Enter a");
            string inputA = Console.ReadLine();
            Console.WriteLine("Enter b");
            string inputB = Console.ReadLine();

            if (double.TryParse(inputA, out double a) && double.TryParse(inputB, out double b))
            {
                string res = (a > b) ? "a>b" : "a<b";
                Console.WriteLine(res);

                
            }
            else
            {
                Console.WriteLine(" a and b should be numbers");
            }

            Console.ReadLine();
        }

        public static void Exercise10()
        {
            Console.WriteLine("Enter distance1 in meters");
            string inputM = Console.ReadLine();
            Console.WriteLine("Enter distance2 in foots");
            string inputF = Console.ReadLine();

            if (double.TryParse(inputM, out double m) && double.TryParse(inputF, out double f))
            {
                string result = (m > 3.28084 * f) ? "distance 1 is longer than distance 2" : "distance 1 is shorter than distance 2";
                Console.WriteLine(result);
            }

            else { Console.WriteLine("distances should be numbers"); }

            Console.ReadLine();
        }
        
        
    }

    class Program4 
        {
        static void Main(string[] args)
    {
            //Chapter4.Exercise1();
            //Chapter4.Exercise2();
            //Chapter4.Exercise3();
            //Chapter4.Exercise4();
            //Chapter4.Exercise5();
            //Chapter4.Exercise6a();
            //Chapter4.Exercise6b();
            //Chapter4.Exercise7();
            //Chapter4.Exercise8();
            //Chapter4.Exercise9();
            Chapter4.Exercise10();

        }
         }
}
        



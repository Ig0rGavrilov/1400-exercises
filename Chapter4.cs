using _1400_exercises;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Principal;
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

            if (double.TryParse(inputA, out double a) && double.TryParse(inputB, out double b))
            {
                if (a > b)
                {
                    Console.WriteLine("number a = {0} and is biggest than number b = {1}", a, b);
                }
                else if (a < b)
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
                if (x > 0)
                {
                    double res = Math.Pow(Math.Sin(x), 2);

                    Console.WriteLine(" y = {0}", res);
                }

                else
                {
                    double res = 1 - 2 * Math.Pow(Math.Sin(x), 2);
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
                    double res = Math.Sin(Math.Pow(x, 2));

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
                if (x < 4)
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
            else
            {
                Console.WriteLine("x should be number");

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

                if (x > k)
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

        public static void Exercise11()
        {
            Console.WriteLine("Enter speed 1 in km/h");
            string inputSpeed1 = Console.ReadLine();
            Console.WriteLine("Enter speed 2 in m/s");
            string inputSpeed2 = Console.ReadLine();
            if (double.TryParse(inputSpeed1, out double speed1) &&
               double.TryParse(inputSpeed2, out double speed2) && speed1 >= 0 && speed2 >= 0)
            {

                string result = (speed1 * 100 / 3600 > speed2) ? "Speed 1 is bigger" : "Speed 2 is bigger";
                Console.WriteLine(result);


            }
            else { Console.WriteLine("Speed should be positive number"); }

            Console.ReadLine();
        }

        public static void Exercise12()
        {
            Console.WriteLine("Enter radius");
            string inputRadius = Console.ReadLine();
            Console.WriteLine("Enter side length");
            string inputLength = Console.ReadLine();

            if (double.TryParse(inputLength, out double length) &&
                double.TryParse(inputRadius, out double radius) &&
                length >= 0 && radius >= 0)
            {
                string res = (2 * Math.PI * Math.Pow(radius, 2) > Math.Pow(length, 2)) ? "Area of circle is bigger" : "Area of square is bigger";
                Console.WriteLine(res);
            }

            else
            {
                Console.WriteLine("Should be postive numbers");
            }
            Console.ReadLine();
        }

        public static void Exercise13()
        {
            Console.WriteLine("Enter V1");
            string inputV1 = Console.ReadLine();
            Console.WriteLine("Enter W1");
            string inputW1 = Console.ReadLine();
            Console.WriteLine("Enter V2");
            string inputV2 = Console.ReadLine();
            Console.WriteLine("Enter W2");
            string inputW2 = Console.ReadLine();

            if (double.TryParse(inputV1, out double v1) &&
                double.TryParse(inputV1, out double w1) &&
                double.TryParse(inputV2, out double v2) &&
                double.TryParse(inputW2, out double w2) &&
                v1 > 0 && w1 > 0 && v2 > 0 && w2 > 0)
            {
                string res = (w1 / v1 > w2 / v2) ? " 1 is weighter than 2" : " 2 is weighter than 1";

                Console.WriteLine(res);
            }

            else { Console.WriteLine("V1, W1, V2 and W2 >0 !"); }


            Console.ReadLine();
        }

        public static void Exercise14()
        {

            Console.WriteLine("enter resistance R1");
            string inputR1 = Console.ReadLine();
            Console.WriteLine("enter resistance R2");
            string inputR2 = Console.ReadLine();

            if (double.TryParse(inputR1, out double r1) &&
                double.TryParse(inputR2, out double r2) &&
                r1 > 0 && r2 > 0)
            {
                string result = (r1 > r2) ? "Current I1 is lower than I2" : "Current I1 is higher than I2";
                Console.WriteLine(result);
            }
            else { Console.WriteLine("Resistances should be grater than 0"); }

            Console.ReadLine();
        }

        public static void Exercise15()
        {
            Console.WriteLine("a:");
            string inputA = Console.ReadLine();
            Console.WriteLine("b:");
            string inputB = Console.ReadLine();
            Console.WriteLine("c:");
            string inputC = Console.ReadLine();

            if (double.TryParse(inputA, out double a) &&
                double.TryParse(inputB, out double b) &&
                double.TryParse(inputC, out double c) && a != 0)
            {
                string result = (Math.Pow(b, 2) - 4 * a * c >= 0) ? "function has roots" : "function doesnt have roots";
                Console.WriteLine(result);
            }

            else { Console.WriteLine("a , b and c should be numbers. a!=0"); }
            Console.ReadLine();

        }

        public static void Exercise16()
        {
            Console.WriteLine("a:");
            string inputA = Console.ReadLine();
            Console.WriteLine("b:");
            string inputB = Console.ReadLine();
            Console.WriteLine("c:");
            string inputC = Console.ReadLine();

            if (double.TryParse(inputA, out double a) &&
                double.TryParse(inputB, out double b) &&
                double.TryParse(inputC, out double c) && a != 0)
            {
                double d = (Math.Pow(b, 2) - 4 * a * c);

                if (d > 0)
                {
                    double root1 = (-b - Math.Pow(d, 0.5)) / (2 * a);
                    double root2 = (-b + Math.Pow(d, 0.5)) / (2 * a);
                    Console.WriteLine("Root 1 = {0:0.00}, Root 2 = {1:0.00}", root1, root2);
                }

                else
                {
                    Console.WriteLine("function doesnt have roots");
                }

            }

            else { Console.WriteLine("a , b and c should be numbers. a!=0"); }
            Console.ReadLine();
        }

        public static void Exercise17()
        {
            Console.WriteLine("Enter birth year ");
            string inputY = Console.ReadLine();
            Console.WriteLine("Enter birth month");
            string inputM = Console.ReadLine();



            string currentM = (DateTime.Now.Month.ToString());
            int.TryParse(currentM, out int currentMonth);
            string currentY = (DateTime.Now.ToString("yyyy"));
            int.TryParse(currentY, out int currentYear);


            if (int.TryParse(inputY, out int birthYear) &&
                int.TryParse(inputM, out int birthMonth) &&
                birthYear >= 0 && birthMonth >= 1 && birthMonth <= 12)
            {

                int result = currentYear - birthYear;


                if (birthMonth > currentMonth)
                {
                    result--;
                }

                Console.WriteLine("Total age (years) {0}", result);

            }
            else
            {
                Console.WriteLine("Year and month should be intereg month ffrom 1 to 12");

            }
            Console.ReadLine();
        }

        public static void Exercise18()
        {
            Console.WriteLine("Enter area of circle");
            string sareaCircle = Console.ReadLine();
            Console.WriteLine("Enter area of square");
            string sareaSquare = Console.ReadLine();

            if (double.TryParse(sareaCircle, out double areaCircle) &&
                double.TryParse(sareaSquare, out double areaSquare) &&
                areaCircle > 0 && areaSquare > 0)
            {
                double r = Math.Pow(areaCircle / Math.PI, 0.5);
                double a = Math.Pow(areaSquare, 0.5);

                string answerA = (a > r) ? "Circle could be in Square" : "Circle cannt be in Square";
                Console.WriteLine(answerA);
                string answerB = (a < r) ? "Square could be in Circle" : "Square cannt be in Circle";
                Console.WriteLine(answerB);

            }

            else { Console.WriteLine("Area should be grater than 0"); }


            Console.ReadLine();
        }

        public static void Exercise19()
        {
            Console.WriteLine("Enter area of circle");
            string sareaCircle = Console.ReadLine();
            Console.WriteLine("Enter area of Triangle");
            string sareaTriangle = Console.ReadLine();

            if (double.TryParse(sareaCircle, out double areaCircle) &&
                double.TryParse(sareaTriangle, out double areaTriangle) &&
                areaCircle > 0 && areaTriangle > 0)
            {
                double r = Math.Pow(areaCircle / Math.PI, 0.5);
                double a = (Math.Pow((4 * areaTriangle) / Math.Pow(3, 0.5), 0.5));
                double R = Math.Pow(3, 0.5) / a;

                string answerA = (r < a / (2 * Math.Pow(2, 0.5))) ? "Circle could be in Triangle" : "Circle cannt be in Triangle";
                Console.WriteLine(answerA);
                string answerB = (r > R) ? "Triangle could be in Circle" : "Triangle cannt be in Circle";
                Console.WriteLine(answerB);

            }

            else { Console.WriteLine("Area should be grater than 0"); }


            Console.ReadLine();
        }

        public static void Exercise20()
        {
            Console.WriteLine("Enter x for point A, first square");
            string inputfirstA_x = Console.ReadLine();
            Console.WriteLine("Enter y for point A, first square");
            string inputfirstA_y = Console.ReadLine();
            Console.WriteLine("Enter x for point B, first square");
            string inputfirstB_x = Console.ReadLine();
            Console.WriteLine("Enter y for point B, first square");
            string inputfirstB_y = Console.ReadLine();
            Console.WriteLine("Enter x for point A, second square");
            string inputsecondA_x = Console.ReadLine();
            Console.WriteLine("Enter y for point A, second square");
            string inputsecondA_y = Console.ReadLine();
            Console.WriteLine("Enter x for point B, second square");
            string inputsecondB_x = Console.ReadLine();
            Console.WriteLine("Enter y for point B, second square");
            string inputsecondB_y = Console.ReadLine();

            if (double.TryParse(inputfirstA_x, out double first_a_x) &&
                double.TryParse(inputfirstA_y, out double first_a_y) &&
                double.TryParse(inputfirstB_x, out double first_b_x) &&
                double.TryParse(inputfirstB_y, out double first_b_y) &&
                double.TryParse(inputsecondA_x, out double second_a_x) &&
                double.TryParse(inputsecondA_y, out double second_a_y) &&
                double.TryParse(inputsecondB_x, out double second_b_x) &&
                double.TryParse(inputsecondB_y, out double second_b_y))
            {

                // Compare A first and B second by x coordinate , min x should be left low and right high max x

                double[] coordX = new double[4];
                coordX[0] = first_a_x;
                coordX[1] = first_b_x;
                coordX[2] = second_a_x;
                coordX[3] = second_b_x;

                double x_min = coordX[0];
                double x_max = coordX[0];
                for (int i = 0; i < coordX.Length; i++)
                {
                    if (coordX[i] > x_max)
                    {
                        x_max = coordX[i];
                    }
                    if (coordX[i] < x_min)
                    {
                        x_min = coordX[i];
                    }
                }

                double[] coordY = new double[4];

                coordY[0] = first_a_y;
                coordY[1] = first_b_y;
                coordY[2] = second_a_y;
                coordY[3] = second_b_y;

                double y_min = coordY[0];
                double y_max = coordY[0];
                for (int i = 0; i < coordY.Length; i++)
                {
                    if (coordX[i] > y_max)
                    {
                        y_max = coordY[i];
                    }
                    if (coordY[i] < y_min)
                    {
                        y_min = coordY[i];
                    }
                }

                Console.WriteLine("Coordinates A{0},{1} - low left, B-{2},{3} - right high", x_min, y_min, x_max, y_max);
            }

            else
            {
                Console.WriteLine("Coordinates should be numbers");
            }

            Console.ReadLine();

        }

        public static void Exercise21()
        {

            Console.WriteLine("Enter x for point A, first square");
            string inputfirstA_x = Console.ReadLine();
            Console.WriteLine("Enter y for point A, first square");
            string inputfirstA_y = Console.ReadLine();
            Console.WriteLine("Enter side length a first square");
            string inputfirstSideA = Console.ReadLine();
            Console.WriteLine("Enter side length b first square");
            string inputfirstSideB = Console.ReadLine();
            Console.WriteLine("Enter x for point A, second square");
            string inputsecondA_x = Console.ReadLine();
            Console.WriteLine("Enter y for point A, second square");
            string inputsecondA_y = Console.ReadLine();
            Console.WriteLine("Enter side length a second square");
            string inputsecondSideA = Console.ReadLine();
            Console.WriteLine("Enter side length b second square");
            string inputsecondSideB = Console.ReadLine();

            if (double.TryParse(inputfirstA_x, out double first_a_x) &&
                double.TryParse(inputfirstA_y, out double first_a_y) &&
                double.TryParse(inputfirstSideA, out double firstSideA) &&
                double.TryParse(inputfirstSideB, out double firstSideB) &&
                double.TryParse(inputsecondA_x, out double second_a_x) &&
                double.TryParse(inputsecondA_y, out double second_a_y) &&
                double.TryParse(inputsecondSideA, out double secondSideA) &&
                double.TryParse(inputsecondSideB, out double secondSideB)
                )
            {

                // Compare A first and B second by x coordinate , min x should be left low and right high max x

                double[] coordX = new double[4];
                coordX[0] = first_a_x;
                coordX[1] = first_a_x + firstSideA;
                coordX[2] = second_a_x;
                coordX[3] = second_a_x + secondSideA;

                double x_min = coordX[0];
                double x_max = coordX[0];
                for (int i = 0; i < coordX.Length; i++)
                {
                    if (coordX[i] > x_max)
                    {
                        x_max = coordX[i];
                    }
                    if (coordX[i] < x_min)
                    {
                        x_min = coordX[i];
                    }
                }

                double[] coordY = new double[4];

                coordY[0] = first_a_y;
                coordY[1] = first_a_y + firstSideB;
                coordY[2] = second_a_y;
                coordY[3] = second_a_y + secondSideB;

                double y_min = coordY[0];
                double y_max = coordY[0];
                for (int i = 0; i < coordY.Length; i++)
                {
                    if (coordX[i] > y_max)
                    {
                        y_max = coordY[i];
                    }
                    if (coordY[i] < y_min)
                    {
                        y_min = coordY[i];
                    }
                }

                Console.WriteLine("Coordinates A-{0},{1} - low left, B-{2},{3} - right high", x_min, y_min, x_max, y_max);
            }

            else
            {
                Console.WriteLine("Coordinates should be numbers");
            }

            Console.ReadLine();

        }

        public static void Exercise22()
        {
            Console.WriteLine("Enter integer m");
            string stringM = Console.ReadLine();
            Console.WriteLine("Enter integer n");
            string stringN = Console.ReadLine();

            if (int.TryParse(stringM, out int m) &&
                int.TryParse(stringN, out int n))
            {
                if (m % n == 0)
                {
                    Console.WriteLine("Res {0}", m / n);
                }

                else
                {
                    Console.WriteLine("m%n != 0");
                }
            }

            else { Console.WriteLine("m and n should be integer"); }
            Console.ReadLine();
        }

        public static void Exercise23()
        {
            Console.WriteLine("Enter n");
            string stringN = Console.ReadLine();
            Console.WriteLine("Enter a");
            string stringA = Console.ReadLine();

            if (double.TryParse(stringN, out double n) &&
                double.TryParse(stringA, out double a))
            {
                if (n % a == 0)
                {
                    Console.WriteLine("Res n%a==0");
                }

                else
                {
                    Console.WriteLine("n%a != 0");
                }
            }

            else { Console.WriteLine("n and a should be numbers"); }
            Console.ReadLine();
        }

        public static void Exercise24()
        {
            Console.WriteLine("Enter integer positive number");
            string inputN = Console.ReadLine();

            if (int.TryParse(inputN, out int n) && n > 0)
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine("Yes  n%2==0");
                }
                else { Console.WriteLine("n%2!=0"); }
                if ((n + 3) % 10 == 0)
                {
                    Console.WriteLine("Last digit is 7");
                }
                else
                {
                    Console.WriteLine("Last digit is not 7");
                }
            }

            else { Console.WriteLine("Number should be positive and integer"); }
            Console.ReadLine();
        }

        public static void Exercise25()
        {
            Console.WriteLine("Enter number divided by 2");
            string inputN = Console.ReadLine();

            if (int.TryParse(inputN, out int n) && n % 2 == 0)
            {
                Console.WriteLine("Next divideed by 2 = number {0}", n + 2);
            }

            else
            {
                Console.WriteLine("n should be number divided by 2");
            }



        }

        public static void Exercise26()
        {
            Console.WriteLine("Enter two digits number");
            string inputN = Console.ReadLine();

            if (int.TryParse(inputN, out int n)&& n >=10 && n <= 99)
            {
                int firstDigit = n / 10;
                int secondDigit = n - 10*(firstDigit);

                if (firstDigit > secondDigit)
                {
                    Console.WriteLine("First digit {0} > Second digit {1}", firstDigit, secondDigit);
                }
                else if (firstDigit == secondDigit)
                {
                    Console.WriteLine("First digit {0} = Second digit {1}", firstDigit, secondDigit);
                }
                else
                {
                    Console.WriteLine("First digit {0} < Second digit {1}", firstDigit, secondDigit);
                }
            }

            else
            {
                Console.WriteLine("n should be number between 10 and 99");

            }
            Console.ReadLine();
        }

        public static void Exercise27()
        {
            Console.WriteLine("Enter two digits number");
            string inputN = Console.ReadLine();

            if (int.TryParse(inputN, out int n) && n >= 10 && n <= 99)
            {
                int firstDigit = n / 10;
                int secondDigit = n - 10 * (firstDigit);

                if (Math.Pow(n,2) == 4*(Math.Pow(firstDigit,3) + Math.Pow(secondDigit, 3)))
                {
                    Console.WriteLine("(ab)2 == 4*(a**3+ b**3)");
                }
                
                else
                {
                    Console.WriteLine("(ab)2 != 4*(a**3+ b**3)");
                }
            }

            else
            {
                Console.WriteLine("n should be number between 10 and 99");

            }
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
            //Chapter4.Exercise10();
            // Chapter4.Exercise11();
            //Chapter4.Exercise12();
            //Chapter4.Exercise13();
            //Chapter4.Exercise14();
            //Chapter4.Exercise15();
            //Chapter4.Exercise16();
            //Chapter4.Exercise17();
            //Chapter4.Exercise18();
            //Chapter4.Exercise19();
            //Chapter4.Exercise20();
            //Chapter4.Exercise21();
            //Chapter4.Exercise22();
            //Chapter4.Exercise23();
            //Chapter4.Exercise24();
            //Chapter4.Exercise25();
            //Chapter4.Exercise26();
            Chapter4.Exercise27();


        }
    }
}

        



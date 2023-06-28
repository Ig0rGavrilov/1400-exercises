using _1400_exercises;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Transactions;

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

            if (int.TryParse(inputN, out int n) && n >= 10 && n <= 99)
            {
                int firstDigit = n / 10;
                int secondDigit = n - 10 * (firstDigit);

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

                if (Math.Pow(n, 2) == 4 * (Math.Pow(firstDigit, 3) + Math.Pow(secondDigit, 3)))
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

        public static void Exercise28()
        {
            Console.WriteLine("Enter two digits number");
            string inputN = Console.ReadLine();
            Console.WriteLine("Enter a number");
            string inputA = Console.ReadLine();

            if (int.TryParse(inputN, out int n) &&
                int.TryParse(inputA, out int a) &&
                n >= 10 && n <= 99)
            {
                int firstDigit = n / 10;
                int secondDigit = n - 10 * (firstDigit);

                bool res;
                if ((firstDigit + secondDigit) / 10 > 0) { res = true; }
                else { res = false; }

                Console.WriteLine("sum digits is two digits number {0}", res);
                string result = ((firstDigit + secondDigit) > a) ? "sum digits < a" : "sum digits > a";
                Console.WriteLine(result);
            }

            else
            {
                Console.WriteLine("n should be between 10 and 99, a  - integer");
            }

        }

        public static void Exercise29()
        {
            Console.WriteLine("Enter two digits number");
            string inputN = Console.ReadLine();
            Console.WriteLine("Enter a number");
            string inputA = Console.ReadLine();

            if (int.TryParse(inputN, out int n) &&
                int.TryParse(inputA, out int a) &&
                n >= 10 && n <= 99)
            {
                int firstDigit = n / 10;
                int secondDigit = n - 10 * (firstDigit);

                bool res;
                if ((firstDigit + secondDigit) / 3 == 0) { res = true; }
                else { res = false; }

                Console.WriteLine("sum digits is divided by 3 {0}", res);


                if ((firstDigit + secondDigit) % a == 0) { res = true; }
                else { res = false; }

                Console.WriteLine("sum digits is divided by a {0}", res);
            }

            else
            {
                Console.WriteLine("n should be between 10 and 99, a  - integer");
            }

        }

        public static void Exercise30()
        {
            Console.WriteLine("Enter 3 digits number");
            string inputN = Console.ReadLine();

            if (int.TryParse(inputN, out int n) && n >= 100 && n <= 999)
            {
                int num100 = n / 100;
                int num10 = (n % 100) % 10;

                string res = (num100 == num10) ? "Palindrom" : "isnt palindrom";
                Console.WriteLine(res);
            }
            else
            {
                Console.WriteLine("n should be integer number between 100 and 999");
            }
            Console.ReadLine();
        }

        public static void Exercise31()
        {
            Console.WriteLine("Enter 3 digits number");
            string inputN = Console.ReadLine();

            if (int.TryParse(inputN, out int n) && n >= 100 && n <= 999)
            {
                int num100 = n / 100;
                int num10 = (n - 100 * num100) / 10;
                int num1 = (n % 100) % 10;

                string resA = (num100 > num1) ? "First digit > last digit" : "First digit <= last digit";
                Console.WriteLine(resA);
                string resB = (num100 > num10) ? "First digit > second digit" : "First digit <= second digit";
                Console.WriteLine(resB);
                string resC = (num10 > num1) ? "Second digit > last digit" : "Second digit > last digit";
                Console.WriteLine(resC);
            }
            else
            {
                Console.WriteLine("n should be integer number between 100 and 999");
            }
            Console.ReadLine();

        }

        public static void Exercise32()
        {
            Console.WriteLine("Enter 3 digits number");
            string inputN = Console.ReadLine();

            if (int.TryParse(inputN, out int n) && n >= 100 && n <= 999)
            {
                int num100 = n / 100;
                int num10 = (n - 100 * num100) / 10;
                int num1 = (n % 100) % 10;

                string res = (Math.Pow(n, 3) == (Math.Pow(num100, 3) + Math.Pow(num10, 3) + Math.Pow(num1, 3))) ? "==" : "!=";
                Console.WriteLine("({0}{1}{2})**2 {3} {0}**3+{1}**3+{2}**3", num100, num10, num1, res);

            }
            else
            {
                Console.WriteLine("n should be integer number between 100 and 999");
            }
            Console.ReadLine();
        }
        public static void Exercise33()
        {
            Console.WriteLine("Enter 3 digits number");
            string inputN = Console.ReadLine();
            Console.WriteLine("Enter a number");
            string inputA = Console.ReadLine();

            if (int.TryParse(inputN, out int n) &&
                int.TryParse(inputA, out int a) &&
                n >= 100 && n <= 999)
            {
                int num100 = n / 100;
                int num10 = (n - 100 * num100) / 10;
                int num1 = (n % 100) % 10;

                string resA = ((num100 + num10 + num1) / 10 != 0) ? "sum numbers is two digits number" : "sum numbers isnt two digits number";
                Console.WriteLine(resA);
                string resB = ((num100 * num10 * num1) / 100 != 0) ? "multplication numbers is three digits number" : "multplication numbers isnt three digits number";
                Console.WriteLine(resB);
                string resC = ((num100 * num10 * num1) > a) ? "multplication numbers > a" : "multplication numbers <= a";
                Console.WriteLine(resC);
                string resD = ((num100 + num10 + num1) % 5 == 0) ? "sum numbers %5==0" : "sum numbers %5!=0";
                Console.WriteLine(resD);
                string resE = ((num100 + num10 + num1) % a == 0) ? "sum numbers %a ==0" : "sum numbers %a !=0";
                Console.WriteLine(resE);
            }
            else
            {
                Console.WriteLine("n should be integer number between 100 and 999");
            }
            Console.ReadLine();

        }

        public static void Exercise34()
        {
            Console.WriteLine("Enter 3 digits number");
            string inputN = Console.ReadLine();


            if (int.TryParse(inputN, out int n) &&
                n >= 100 && n <= 999)
            {
                int num100 = n / 100;
                int num10 = (n - 100 * num100) / 10;
                int num1 = (n % 100) % 10;

                string resA = ((num100 == num10 && num1 == num10)) ? "all digits are equal " : "all digits are not equal";
                Console.WriteLine(resA);

                if (num100 == num10) { Console.WriteLine("First and second digits are equal"); }
                if (num100 == num1) { Console.WriteLine("First and last digits are equal"); }
                if (num10 == num1) { Console.WriteLine("Second and last digits are equal"); }


            }
            else
            {
                Console.WriteLine("n should be integer number between 100 and 999");
            }
            Console.ReadLine();

        }

        public static void Exercise35()
        {
            Console.WriteLine("Enter 4 digits number");
            string inputN = Console.ReadLine();
            Console.WriteLine("Enter number a");
            string inputA = Console.ReadLine();



            if (int.TryParse(inputN, out int n) &&
                int.TryParse(inputA, out int a) &&
                n >= 1000 && n <= 9999)
            {
                int num1000 = n / 1000;
                int num100 = (n - 1000 * num1000) / 100;
                int num10 = ((n - 1000 * num1000) - num100 * 100) / 10;
                int num1 = n - 1000 * num1000 - 100 * num100 - 10 * num10;

                string resA = ((num100 + num100 == num10 + num1)) ? "sum first and seccond digits == sum third and fourth digits " : "sum first and seccond digits != sum third and fourth digits";
                Console.WriteLine(resA);
                string resB = ((num100 + num100 + num10 + num1) % 3 == 0) ? "sum digits %3 == 0 " : "sum digits %3 != 0";
                Console.WriteLine(resB);
                string resC = ((num100 * num100 * num10 * num1) % 4 == 0) ? "multiply digits %4 == 0 " : "multiply digits %4 == 0 ";
                Console.WriteLine(resC);
                string resD = ((num100 * num100 * num10 * num1) % a == 0) ? "multiply digits %a == 0 " : "multiply digits %a == 0 ";
                Console.WriteLine(resD);

            }

            else { Console.WriteLine("n should be integer number between 1000 and 9999"); }

            Console.ReadLine();
        }

        public static void Exercise36()
        {
            Console.WriteLine("Enter natural number");
            string inputN = Console.ReadLine();

            if (int.TryParse(inputN, out int n) && n > 0)
            {
                Console.WriteLine((n % 2 == 0) ? "last digit is  2" : "last digit isnt  2");

            }
            else { Console.WriteLine("n should be positive integer number"); }
            Console.ReadLine();
        }

        public static void Exercise37()
        {
            Console.Write("Enter number a: ");
            string inputA = Console.ReadLine();
            Console.Write("Enter number b: ");
            string inputB = Console.ReadLine();

            if (double.TryParse(inputA, out double a) &&
                double.TryParse(inputB, out double b) && a != 0 && b != 0)
            {
                Console.WriteLine((a % b == 0) ? "a is divided by b" : "a isnt divided by b");
                Console.WriteLine((b % a == 0) ? "b is divided by a" : "b isnt divided by a");
            }
            else
            {
                Console.WriteLine("a and b should be non zero numbers");
            }
            Console.ReadLine();


        }

        public static void Exercise38()
        {

            Console.Write("enter a:");
            string inputA = Console.ReadLine();
            Console.Write("enter b (b<a): ");
            string inputB = Console.ReadLine();
            Console.Write("enter c:");
            string inputC = Console.ReadLine();
            Console.Write("enter d (d<c):");
            string inputD = Console.ReadLine();



            if (int.TryParse(inputA, out int a) &&
                int.TryParse(inputB, out int b) &&
                int.TryParse(inputC, out int c) &&
                int.TryParse(inputD, out int d) &&
                a > 0 && b > 0 && c > 0 && d > 0 && a > b)
            {
                Console.WriteLine(" a||c {0}", (a / c) * (b / d));
                Console.WriteLine(" a||d {0}", (a / d) * (b / c));
            }




            else { Console.WriteLine("a, b, c and d should be non zero positive integer numbers"); }
            Console.Read();

        }

        public static void Exercise39()
        {
            Console.Write("Ënter time n in minutes: ");
            string inputT = Console.ReadLine();

            if (int.TryParse(inputT, out int t) && t >= 0)
            {

                if ((t - 5 * (t / 5) <= 2)) { Console.WriteLine("Green"); }
                else { Console.WriteLine("Red"); }


            }
            else { Console.WriteLine("t should be non negative integer"); }
        }

        public static void Exercise40()
        {
            Console.WriteLine("Enter number n: ");
            string inputN = Console.ReadLine();

            if (double.TryParse(inputN, out double n))
            {
                if (n >= -5 && n < -3)
                {
                    Console.WriteLine("n={0} in interval (-5,3)", n);
                }
                else { Console.WriteLine("n={0} outside interval (-5,3)", n); }
            }

            else { Console.WriteLine("n should be number"); }
            Console.ReadLine();
        }

        public static void Exercise41()
        {
            Console.WriteLine("Enter integer number:");
            string inputN = Console.ReadLine();

            if (int.TryParse(inputN, out int n))
            {
                string res = (n / 10 > 0 && n / 10 < 10) ? "two digits number" : "non two digits number";
                Console.WriteLine(res);
            }
        }

        public static void Exercise42()
        {
            Console.WriteLine("Enter x: ");
            string inputX = Console.ReadLine();
            Console.WriteLine("Enter y: ");
            string inputY = Console.ReadLine();

            if (double.TryParse(inputX, out double x) &&
                double.TryParse(inputY, out double y))
            {
                string varA = (x > 2 && y > 2) ? "Point in Area I" : "Point not in Area I";
                Console.WriteLine("Variant a: " + varA);
                string varB = (x < -2 && y < -4) ? "Point in Area I" : "Point not in Area I";
                Console.WriteLine("Variant b: " + varB);
            }

            else
            {
                Console.WriteLine("x and y should be numbers");

            }
            Console.ReadLine();
        }

        public static void Exercise43()
        {
            Console.WriteLine("Enter x: ");
            string inputX = Console.ReadLine();
            Console.WriteLine("Enter y: ");
            string inputY = Console.ReadLine();

            if (double.TryParse(inputX, out double x) &&
                double.TryParse(inputY, out double y))
            {
                string res = (x > 3 && y > 2) ? "Point in Area I" : "Point not in Area I";
                Console.WriteLine(res);

            }

            else
            {
                Console.WriteLine("x and y should be numbers");

            }
            Console.ReadLine();
        }

        public static void Exercise44()
        {
            Console.WriteLine("Enter x: ");
            string inputX = Console.ReadLine();
            Console.WriteLine("Enter y: ");
            string inputY = Console.ReadLine();

            if (double.TryParse(inputX, out double x) &&
                double.TryParse(inputY, out double y))
            {
                switch (x)
                {
                    case > 5:
                        Console.WriteLine("Area I");
                        break;
                    case (< -1):
                        Console.WriteLine("Area III");
                        break;
                    default:
                        Console.WriteLine("Area II");
                        break;
                }

            }

            else
            {
                Console.WriteLine("x and y should be numbers");

            }
            Console.ReadLine();
        }

        public static void Exercise45()
        {
            Console.WriteLine("Enter x: ");
            string inputX = Console.ReadLine();

            if (double.TryParse(inputX, out double x))
            {
                if (x <= 5.7 && x >= -2.4) { Console.WriteLine("x**2 = {0}", Math.Pow(x, 2)); }
                else { Console.WriteLine("Result: 4"); }
            }
            else { Console.WriteLine("x should be number"); }
            Console.ReadLine();
        }

        public static void Exercise46()
        {
            Console.WriteLine("Enter x: ");
            string inputX = Console.ReadLine();

            if (double.TryParse(inputX, out double x))
            {
                if (x <= 0.9 && x >= 0.2) { Console.WriteLine("sin(x) = {0:0.00}", Math.Sin(x)); }
                else { Console.WriteLine("Result: 1"); }
            }
            else { Console.WriteLine("x should be number"); }
            Console.ReadLine();
        }

        public static void Exercise47()
        {
            Console.WriteLine("Enter number a: ");
            string inputA = Console.ReadLine();
            Console.WriteLine("Enter number b: ");
            string inputB = Console.ReadLine();
            Console.WriteLine("Enter number c: ");
            string inputC = Console.ReadLine();

            if (double.TryParse(inputA, out double a) &&
                double.TryParse(inputB, out double b) &&
                double.TryParse(inputC, out double c))
            {
                bool resA;
                bool resB;
                if (a < b && b < c) { resA = true; ; } else { resA = false; }
                if (b > a && a > c) { resB = true; } else { resB = false; }
                Console.WriteLine("Answer a: {0}", resA);
                Console.WriteLine("Answer b: {0}", resB);
            }
            else { Console.WriteLine("a, b and c should be numbers"); }
            Console.ReadLine();
        }

        public static void Exercise48()
        {
            Console.WriteLine("Enter number 1");
            string inputA = Console.ReadLine();
            Console.WriteLine("Enter number 2");
            string inputB = Console.ReadLine();

            if (int.TryParse(inputA, out int a) &&
                int.TryParse(inputB, out int b))
            {
                if (a % b == 0 || b % a == 0) { Console.WriteLine("division can be a/b or b/a"); }
                else { Console.WriteLine("cannt be divided one by another"); }
            }

            else
            {
                Console.WriteLine("Numbers should be non zero integer");
            }
        }

        public static void Exercise49()
        {
            Console.WriteLine("Enter number between 10 and 99");
            string inputN = Console.ReadLine();
            Console.WriteLine("Enter number a");
            string inputA = Console.ReadLine();

            if (int.TryParse(inputN, out int n) &&
                int.TryParse(inputA
                , out int a) && n > 9 && n < 100)
            {
                if ((n / 10) == 3 || (n - 10 * (n / 10)) == 3)
                {
                    Console.WriteLine("number has 3");
                }
                if ((n / 10) == a || (n - 10 * (n / 10)) == a)
                {
                    Console.WriteLine("number has {0}", a);
                }
            }

            else { Console.WriteLine("Number should be integer and between 10 and 99"); }
            Console.ReadLine();
        }

        public static void Exercise50()
        {
            Console.WriteLine("Enter number between 10 and 99");
            string inputN = Console.ReadLine();


            if (int.TryParse(inputN, out int n)
              && n > 9 && n < 100)
            {
                if ((n / 10) == 4 || (n - 10 * (n / 10)) == 4 || (n / 10) == 7 || (n - 10 * (n / 10)) == 7)
                {
                    Console.WriteLine("number has 4 or 7");
                }
                if ((n / 10) % 3 == 0 || (n - 10 * (n / 10)) % 3 == 0)
                {
                    Console.WriteLine("number has 3,6 or 9");
                }
            }

            else { Console.WriteLine("Number should be integer and between 10 and 99"); }
            Console.ReadLine();
        }

        public static void Exercise51()
        {
            Console.WriteLine("Enter number between 100 and 999");
            string inputN = Console.ReadLine();
            Console.WriteLine("Enter number a");
            string inputA = Console.ReadLine();

            if (int.TryParse(inputN, out int n) &&
                int.TryParse(inputA, out int a) &&
                n > 99 && n < 1000)
            {
                int num100 = n / 100;
                int num10 = (n - 100 * num100) / 10;
                int num1 = (n - 100 * num100) % 10;

                if (num100 == 6 || num10 == 6 || num1 == 6) { Console.WriteLine("Number has 6"); } else { Console.WriteLine("Number doesnt have 6"); }
                if (num100 == a || num10 == a || num1 == a) { Console.WriteLine("Number has {0}", a); } else { Console.WriteLine("Number doesnt have {0}", a); }
            }
            else { Console.WriteLine("Number should be integer between 100 and 999"); }
            Console.ReadLine();
        }

        public static void Exercise52()
        {
            Console.WriteLine("Enter number between 100 and 999");
            string inputN = Console.ReadLine();


            if (int.TryParse(inputN, out int n) &&
                n > 99 && n < 1000)
            {
                int num100 = n / 100;
                int num10 = (n - 100 * num100) / 10;
                int num1 = (n - 100 * num100) % 10;

                if (num100 == 6 || num10 == 6 || num1 == 6) { Console.WriteLine("Number has 6"); } else { Console.WriteLine("Number doesnt have 6"); }
            }
            else { Console.WriteLine("Number should be integer between 100 and 999"); }
            Console.ReadLine();
        }

        public static void Exercise53()
        {
            Console.WriteLine("Enter number between 100 and 999");
            string inputN = Console.ReadLine();


            if (int.TryParse(inputN, out int n) &&
                n > 99 && n < 1000)
            {
                int num100 = n / 100;
                int num10 = (n - 100 * num100) / 10;
                int num1 = (n - 100 * num100) % 10;

                if (num100 == 4 || num10 == 4 || num1 == 4 || num100 == 7 || num10 == 7 || num1 == 7) { Console.WriteLine("Number has 4 or 7"); } else { Console.WriteLine("Number doesnt have 4 or 7"); }
                if (num100 % 3 == 0 && num100 != 0 || num10 % 3 == 0 && num10 != 0 || num10 % 3 == 0 && num1 != 0) { Console.WriteLine("Number has 3,6 or 9"); } else { Console.WriteLine("Number doesnt have 3,6 or 9"); }
            }
            else { Console.WriteLine("Number should be integer between 100 and 999"); }
            Console.ReadLine();
        }

        public static void Exercise54()
        {
            Console.WriteLine("Enter number between 1000 and 9999");
            string inputN = Console.ReadLine();
            Console.WriteLine("Enter number b between 0 and 9 ");
            string inputB = Console.ReadLine();

            if (int.TryParse(inputN, out int n) && n >= 1000 && n <= 9999 &&
                int.TryParse(inputB, out int b) && b >= 0 && b <= 9)
            {
                int num1000 = n / 1000;
                int num100 = (n - 1000 * num1000) / 100;
                int num10 = ((n - 1000 * num1000) - 100 * num100) / 10;
                int num1 = n % 10;

                if (num1000 == 4 || num100 == 4 || num10 == 4 || num1 == 4 || num1000 == 7 || num100 == 7 || num10 == 7 || num1 == 7) { Console.WriteLine("Number {0} has digit 4 or 7", n); } else { Console.WriteLine("Number {0} doesnt have digit 4 or 7", n); }
                if (num1000 == b || num100 == b || num10 == b || num1 == b) { Console.WriteLine("Number {0} has digit {1}", n, b); } else { Console.WriteLine("Number {0} doesnt have digit {1}", n, b); }
            }
            else { Console.WriteLine("Number n should be between 1000 and 9999");
                Console.WriteLine("Number b should be between 0 and 9");
            }
            Console.ReadLine();
        }

        public static void Exercise55()
        {
            Console.WriteLine("Enter number between 1000 and 9999");
            string inputN = Console.ReadLine();
            Console.WriteLine("Enter number b between 0 and 9 ");
            string inputB = Console.ReadLine();

            if (int.TryParse(inputN, out int n) && n >= 1000 && n <= 9999 &&
                int.TryParse(inputB, out int b) && b >= 0 && b <= 9)
            {
                int num1000 = n / 1000;
                int num100 = (n - 1000 * num1000) / 100;
                int num10 = ((n - 1000 * num1000) - 100 * num100) / 10;
                int num1 = n % 10;

                if (num1000 == 2 || num100 == 2 || num10 == 2 || num1 == 2 || num1000 == 7 || num100 == 7 || num10 == 7 || num1 == 7) { Console.WriteLine("Number {0} has digit 4 or 7", n); } else { Console.WriteLine("Number {0} doesnt have digit 4 or 7", n); }
                if (num1000 % 3 == 0 && num1000 != 0 || num100 % 3 == 0 && num100 != 0 || num10 % 3 == 0 && num10 != 0 || num1 % 3 == 0 && num1 != 0) { Console.WriteLine("Number {0} has digit {1}", n, b); } else { Console.WriteLine("Number {0} doesnt have digit {1}", n, b); }
            }
            else
            {
                Console.WriteLine("Number n should be between 1000 and 9999");
                Console.WriteLine("Number b should be between 0 and 9");
            }
            Console.ReadLine();
        }

        public static void Exercise56()
        {
            Console.WriteLine("Enter number between 1000 and 9999");
            string inputN = Console.ReadLine();


            if (int.TryParse(inputN, out int n) && n >= 1000 && n <= 9999)
            {
                int num1000 = n / 1000;
                int num100 = (n - 1000 * num1000) / 100;
                int num10 = ((n - 1000 * num1000) - 100 * num100) / 10;
                int num1 = n % 10;

                string result = (num1000 == num1 && num100 == num10) ? "Number is symmetrical" : "Number is not symmetrical";
                Console.WriteLine(result);


            }
            else
            {
                Console.WriteLine("Number n should be between 1000 and 9999");

            }
            Console.ReadLine();
        }

        public static void Exercise57()
        {
            Console.WriteLine("Enter number a:");
            string inputA = Console.ReadLine();
            Console.WriteLine("Enter number b:");
            string inputB = Console.ReadLine();
            Console.WriteLine("Enter number c:");
            string inputC = Console.ReadLine();
            Console.WriteLine("Enter number d:");
            string inputD = Console.ReadLine();

            if (int.TryParse(inputA, out int a) && a>0 &&
                int.TryParse(inputB, out int b) && b > 0 &&
                int.TryParse(inputC, out int c) && c > 0 &&
                int.TryParse(inputD, out int d) && d > 0)
            {
                //bool result1 = (a%b==c) ? true : false;
                Console.WriteLine("variant a :"  + (a % b == c));
                Console.WriteLine("variant b :" + (a % b == d));

            }

            else { Console.WriteLine("a, b , c and d should be positive integer numbers"); }
        }

        public static void Exercise58()
        {
            Console.WriteLine("Enter number a:");
            string inputA = Console.ReadLine();
            Console.WriteLine("Enter number b:");
            string inputB = Console.ReadLine();
            Console.WriteLine("Enter number c:");
            string inputC = Console.ReadLine();

            if (double.TryParse(inputA, out double a) &&
                double.TryParse(inputB, out double b) &&
                double.TryParse(inputC, out double c))
            {

                if (a==b || a==c || b == c) { Console.WriteLine("one pair or more same numbers exists"); } else { { Console.WriteLine("one pair or more same numbers doesnt exist"); } }
            }
            else { Console.WriteLine("a, b and c should be numbers"); }
            Console.ReadLine();
        }

        public static void Exercise59()
        {
            Console.WriteLine("Enter number a:");
            string inputA = Console.ReadLine();
            Console.WriteLine("Enter number b:");
            string inputB = Console.ReadLine();
            Console.WriteLine("Enter number c:");
            string inputC = Console.ReadLine();

            if (double.TryParse(inputA, out double a) &&
                double.TryParse(inputB, out double b) &&
                double.TryParse(inputC, out double c))
            {
                
                if (a == b && a == c ) { Console.WriteLine("Triangle has 3 side with same length"); }
                else if (a == b || a == c || b == c) { Console.WriteLine("Triangle has 2 side with same length"); }

            }
            else { Console.WriteLine("a, b and c should be numbers"); }
            Console.ReadLine();

        }

        public static void Exercise60()
        {
            Console.WriteLine("Enter height of person 1:");
            string inputPerson1 = Console.ReadLine();
            Console.WriteLine("Enter height of person 2:");
            string inputPerson2 = Console.ReadLine();
            Console.WriteLine("Enter height of person 3");
            string inputPerson3 = Console.ReadLine();

            if (double.TryParse(inputPerson1, out double p1) &&
                double.TryParse(inputPerson2, out double p2) &&
                double.TryParse(inputPerson3, out double p3) &&
                p1>0 && p2>0 && p3>0)
            {
                string result = (p1 == p2 && p2 == p3) ? "They are have same height" : "They are not have same height";
                Console.WriteLine(result);
            }
            else { Console.WriteLine("heights should be non zero positive numbers"); }
            Console.ReadLine();
        }
        public static void Exercise61()
        {
            Console.WriteLine("Enter a:");
            string inputA = Console.ReadLine();
            Console.WriteLine("Enter b:");
            string inputB = Console.ReadLine();
            Console.WriteLine("Enter c:");
            string inputC = Console.ReadLine();

            if (double.TryParse(inputA, out double a) && a > 0 &&
                double.TryParse(inputB, out double b) &&
                double.TryParse(inputC, out double c)                ) 
            {
                double D = Math.Pow(b, 2) - 4 * a * c;

                if (D==0) { Console.WriteLine("root 1 = root 2 = {0}",  ((-b)/(2*a))); }
                else if (D>0) { Console.WriteLine("root 1 = {0:0.00} root 2 = {1:0.00}", ((-b -Math.Pow(D, 0.5)) / (2 * a)), ((-b + Math.Pow(D, 0.5)) / (2 * a))); }
                else { Console.WriteLine("Doesnt have real roots"); }
            }
            else { Console.WriteLine("a should be non zero, b and c should be numbers"); }
        }
        public static void Exercise62()
        {
            Console.WriteLine("Enter a:");
            string inputA = Console.ReadLine();
            Console.WriteLine("Enter b:");
            string inputB = Console.ReadLine();
            Console.WriteLine("Enter c:");
            string inputC = Console.ReadLine();
            Console.WriteLine("Enter d:");
            string inputD = Console.ReadLine();

            if (double.TryParse(inputA, out double a) && 
                double.TryParse(inputB, out double b) &&
                double.TryParse(inputC, out double c) &&
                double.TryParse(inputD, out double d) &&
                a>0 && b>0 && c>0 && d > 0)
            {
                if ((a >= c && b >= d) || (a >= d && b >= c)) { Console.WriteLine("AxB could be in CxD"); } else { Console.WriteLine("AxB cannt be in CxD"); }
            }
 
            else { Console.WriteLine("a,b,c and d should be non zero numbers"); }
         }


        public static void Exercise63()
        {
            Console.WriteLine("Enter a:");
            string inputA = Console.ReadLine();
            Console.WriteLine("Enter b:");
            string inputB = Console.ReadLine();
            Console.WriteLine("Enter c:");
            string inputC = Console.ReadLine();
            Console.WriteLine("Enter d:");
            string inputD = Console.ReadLine();

            if (double.TryParse(inputA, out double a) &&
                double.TryParse(inputB, out double b) &&
                double.TryParse(inputC, out double c) &&
                double.TryParse(inputD, out double d) &&
                a > 0 && b > 0 && c > 0 && d > 0)
            {
                if ((a >= c+1 && b >= d+1) || (a >= d+1 && b >= c+1)) { Console.WriteLine("AxB could be in CxD"); } else { Console.WriteLine("AxB cannt be in CxD"); }
            }

            else { Console.WriteLine("a,b,c and d should be non zero numbers"); }
            Console.ReadLine();
        }

        public static void Exercise64()
        {
            Console.WriteLine("Enter a:");
            string inputA = Console.ReadLine();
            Console.WriteLine("Enter b:");
            string inputB = Console.ReadLine();
            Console.WriteLine("Enter d:");
            string inputD = Console.ReadLine();

            if (double.TryParse(inputA, out double a) &&
                double.TryParse(inputB, out double b) &&
                double.TryParse(inputD, out double d) &&
                a > 0 && b > 0 && d > 0)
            {
                if (d+1<=a || d+1<=b) { Console.WriteLine("d could be insert in a,b"); } else  { Console.WriteLine("d could be insert in a,b"); } 
            }
            else { Console.WriteLine("a,b and d should be non zero numbers"); }
            Console.ReadLine();
        }

        public static void Exercise65()
        {
            Console.WriteLine("Enter a:");
            string inputA = Console.ReadLine();
            Console.WriteLine("Enter b:");
            string inputB = Console.ReadLine();
            Console.WriteLine("Enter c:");
            string inputC = Console.ReadLine();
            Console.WriteLine("Enter x:");
            string inputX = Console.ReadLine();
            Console.WriteLine("Enter y:");
            string inputY = Console.ReadLine();

            if (double.TryParse(inputA, out double a) &&
                double.TryParse(inputB, out double b) &&
                double.TryParse(inputC, out double c) &&
                double.TryParse(inputX, out double x) &&
                double.TryParse(inputY, out double y) &&
                a > 0 && b > 0 && c > 0 && x > 0 && y>0)
            {
                if (x >= a && (y >=b  || y>=c)) { Console.WriteLine("Brick {0}x{1}x{2} can be insert to {3}x{4}", a,b,c,x,y); }
                
                else if (x >= b && (y >= a || y >= c)) { Console.WriteLine("Brick {0}x{1}x{2} can be insert to {3}x{4}", a, b, c, x, y); }
                
                else if (x >= c && (y >= a || y >= b)) { Console.WriteLine("Brick {0}x{1}x{2} can be insert to {3}x{4}", a, b, c, x, y); }
                else { Console.WriteLine("Brick {0}x{1}x{2} can be insert to {3}x{4}", a, b, c, x, y); }

            }

            else { Console.WriteLine("a,b,c and x,y should be non zero numbers"); }
            Console.ReadLine();
        }

        public static void Exercise66()
        {
            Console.WriteLine("Enter a1:");
            string inputA1 = Console.ReadLine();
            Console.WriteLine("Enter a2:");
            string inputA2 = Console.ReadLine();
            Console.WriteLine("Enter a3:");
            string inputA3 = Console.ReadLine();
            Console.WriteLine("Enter b1:");
            string inputB1 = Console.ReadLine();
            Console.WriteLine("Enter b2:");
            string inputB2 = Console.ReadLine();
            Console.WriteLine("Enter b3:");
            string inputB3 = Console.ReadLine();

            if (double.TryParse(inputA1, out double a1) &&
                double.TryParse(inputA2, out double a2) &&
                double.TryParse(inputA3, out double a3) &&
                double.TryParse(inputB1, out double b1) &&
                double.TryParse(inputB2, out double b2) &&
                double.TryParse(inputB3, out double b3) &&
                a1>0 && a2>0 && a3>0 && b1>0 && b2>0 && b3>0)
            {
                if ((a1>=b1 && a2>=b2 && a3>=b3) || (a1 >= b2 && a2 >= b1 && a3 >= b3) || (a1 >= b1 && a2 >= b3 && a3 >= b2)) { Console.WriteLine("Could be"); }
                else { Console.WriteLine("b1xb2xb3 cannt be in a1xa2xa3"); }



            }

            else { Console.WriteLine("a1,a2,a3 and b1,b2,b3 should be non zero numbers"); }
            Console.ReadLine();
        }

        public static void Exercise67()
        {
            Console.WriteLine("Enter 6-digit number");
            string inputN = Console.ReadLine();

            int[] digits = new int[6];

            for (int i=0; i<digits.Length; i++)
            {
                digits[i] = inputN[i];
            }

            if (digits[0]+ digits[1]+ digits[2]== digits[3] + digits[4] + digits[5]) { Console.WriteLine("Lucky number"); }
            else { Console.WriteLine("usual number"); }
        }

        public static void Exercise68()
        {
            int year;

            Console.WriteLine("Enter year");
            year = int.Parse(Console.ReadLine());

            Console.WriteLine(check_y(year));
        }

        static bool check_y(int year)
        {
            bool b;
            if (year % 100 == 0 && year % 400 == 0)
            {
                b = true;
                return b;
            }
            else if (year % 4 == 0 && year % 100 != 0)
            {
                b = true;
                return b;
            }
            else
            {
                b = false;
                return b;
            }
        }

        public static void Exercise69()
        {
            Console.WriteLine("Enter a:");
            string inputA = Console.ReadLine();
            Console.WriteLine("Enter b:");
            string inputB = Console.ReadLine();
            Console.WriteLine("Enter c:");
            string inputC = Console.ReadLine();
            Console.WriteLine("Enter d:");
            string inputD = Console.ReadLine();
            Console.WriteLine("Enter e:");
            string inputE = Console.ReadLine();
            

            if (int.TryParse(inputA, out int a) &&
                int.TryParse(inputB, out int b) &&
                int.TryParse(inputC, out int c) &&
                int.TryParse(inputD, out int d) &&
                int.TryParse(inputE, out int e) &&
                a > 0 && b > 0 && c > 0 && d > 0 && e > 0 && 
                a>b && c>d && d > e)
            {
                int cd = (a / c) * (b / d);
                int dc = (a / d) * (b / d);
                int ce = (a / c) * (b / e);
                int ec = (a / e) * (b / c);
                int de = (a / d) * (b / e);
                int ed = (a / e) * (b / d);

                int res = Math.Max(ed, Math.Max(de, Math.Max(ec, Math.Max(ce, Math.Max(cd, dc))))); // just for fun

                Console.WriteLine("Max possible : {0}", res);





            }
            else { Console.WriteLine("a,b,c,d,e should be positive non zero integer numbers"); }
            Console.ReadLine();
        }

        public static void Exercise70()
        {
            Console.WriteLine("Enter k  between 1 and 365");
            string inputK = Console.ReadLine();

            if (int.TryParse(inputK, out int k))
            {
                int day;
                if (k > 7) { day = k / 7; } else { day = k; }
                switch (day)
                {
                    case 1:                        
                        Console.WriteLine("Monday");break;
                    case 2:
                        Console.WriteLine("Tuesday"); break;
                    case 3:
                        Console.WriteLine("Wednesday"); break;
                    case 4:
                        Console.WriteLine("Thursday"); break;
                    case 5:
                        Console.WriteLine("Friday"); break;
                    case 6:
                        Console.WriteLine("Saturday"); break;
                    case 7:
                        Console.WriteLine("Sunday"); break;
                }
            }
            else
            {
                Console.WriteLine("K should be integer between 1 and 365");
            }
            Console.ReadLine();
        }

        public static void Exercise71()
        {
            Console.WriteLine("Enter alpha");
            string inputA = Console.ReadLine();
            Console.WriteLine("Enter V0");
            string inputV0 = Console.ReadLine();
            Console.WriteLine("Enter R");
            string inputR = Console.ReadLine();
            Console.WriteLine("Enter H");
            string inputH = Console.ReadLine();
            Console.WriteLine("Enter P");
            string inputP = Console.ReadLine();

            if (double.TryParse(inputA, out double a) &&
                double.TryParse(inputV0, out double v0) &&
                double.TryParse(inputR, out double R) &&
                double.TryParse(inputH, out double H) &&
                double.TryParse(inputP, out double P) &&
                a>0&& v0>0 && R>0 && H>0 && P > 0)
            {

            }
            else
            {
                Console.WriteLine("variables should be non negative numbers");

            }
            Console.ReadLine();

        }

        public static void Exercise72()
        {
            Console.WriteLine("Enter x first rectangle");
            string inputR1X = Console.ReadLine();
            Console.WriteLine("Enter y second rectangle");
            string inputR1Y = Console.ReadLine();
            Console.WriteLine("Enter length side 1: ");
            string inputR1D1 = Console.ReadLine();
            Console.WriteLine("Enter length side 2: ");
            string inputR1D2 = Console.ReadLine();
            Console.WriteLine("Enter x second rectangle");
            string inputR2X = Console.ReadLine();
            Console.WriteLine("Enter y second rectangle");
            string inputR2Y = Console.ReadLine();
            Console.WriteLine("Enter length side 1: ");
            string inputR2D1 = Console.ReadLine();
            Console.WriteLine("Enter length side 2: ");
            string inputR2D2 = Console.ReadLine();

            if (double.TryParse(inputR1X, out double r1x) &&
                double.TryParse(inputR1Y, out double r1y) &&
                double.TryParse(inputR1D1, out double r1d1) &&
                double.TryParse(inputR1D2, out double r1d2) &&
                double.TryParse(inputR2X, out double r2x) &&
                double.TryParse(inputR2Y, out double r2y) &&
                double.TryParse(inputR2D1, out double r2d1) &&
                double.TryParse(inputR2D2, out double r2d2) &&
                r1d1>0 && r1d2>0 && r2d1>0 && r2d2 > 0)
            {
                // First quest A in B
                if (r1d1*r1d2<=r2d1*r2d2)
                {
                    // Check 
                    if (r2x <=r1x && r2y <= r1y && r2x+r2d1 >= r1x+r1d1 && r2y + r2d2 >= r1y+r1d2 ) { Console.WriteLine("Rectangle A in Rectangle B"); }
                    else { Console.WriteLine("Rectangle A not in Rectangle B"); }
                }
                else { Console.WriteLine("Rectangle A not in Rectangle B"); }

                // First quest B in A
                if (r1d1 * r1d2 >= r2d1 * r2d2)
                {
                    // Check 
                    if (r2x >= r1x && r2y >= r1y && r2x + r2d1 <= r1x + r1d1 && r2y + r2d2 <= r1y + r1d2) { Console.WriteLine("Rectangle A in Rectangle B"); }
                    else { Console.WriteLine("Rectangle A not in Rectangle B"); }
                }

                else { Console.WriteLine("Rectangle B not in Rectangle A"); }

               
            }

            else
            {
                Console.WriteLine("Input should be number and distances could be >0");
            }
            Console.ReadLine();
                

        }

        public static void Exercise73()
        {
            Console.WriteLine("Enter 2-digit number a2a1");
            string inputN = Console.ReadLine();
            Console.WriteLine("Enter 1-number b");
            string inputB = Console.ReadLine();

            if (int.TryParse(inputN, out int n) &&
                int.TryParse(inputB, out int b) &&
                n>=10 && n<=99 &&b>=0 && b <= 9)
            {
                Console.WriteLine("Subtract {0}-{1}-{2} = {3}", n/10, n%10, b, n/10 - n%10 -b);
            }

            else { Console.WriteLine("numbers should be integer , 10<=a2a1<=99, 0<=b<=9"); }
            Console.ReadLine();
        }

        public static void Exercise74()
        {
            Console.WriteLine("Enter 2-digit number a2a1");
            string inputA = Console.ReadLine();
            Console.WriteLine("Enter 2-number b2b1");
            string inputB = Console.ReadLine();

            if (int.TryParse(inputA, out int a) &&
                int.TryParse(inputB, out int b) &&
                a >= 10 && b <= 99 && b >= 10 && b <= 99)
            {
                Console.WriteLine("Subtract {0}-{1}-{2}-{3}= {4}", a / 10, a % 10, b/10, b%10, a / 10 - a % 10 - b / 10-b % 10);
            }

            else { Console.WriteLine("numbers should be integer , 10<=a2a1<=99, 10<=b<=99"); }
            Console.ReadLine();
        }

        public static void Exercise75()
        {
            //Console.WriteLine("Eneter number a3a2a1");
            //string inputA3A2A1 = Console.ReadLine();
            //Console.WriteLine("Eneter number b2b1");
            //string inputB2B1 = Console.ReadLine();

            //if (int.TryParse(inputA3A2A1, out int a3a2a1) &&
            //    int.TryParse(inputB2B1, out int b2b1) &&
            //    a3a2a1 >=100 && a3a2a1<=999 && b2b1>=10 && b2b1 <= 99)
            //{
            //    Console.WriteLine(999/100);
            //    Console.WriteLine(100 / 100);
            //}

            //else
            //{
            //    Console.WriteLine("a3a2a1 shoudl be integer between 100 and 999, b2b1 should be integer between 10 and 99");
            //}

            // Dont understand task ?????

            int a3 = 1;
            int a2 = 0;
            int a1 = 0;
            int b2 = 1;
            int b1 = 0;
            for (a3=0; a3<=9; a3++)
            {
                for (a2 = 0; a2 <= 9; a2++)
                {
                    for (a1 = 0; a1 <= 9; a1++)
                    {
                        for (b2 = 0; b2 <= 9; b2++)
                        {
                            for (b1 = 0; b1 <= 9; b1++)
                            {
                                if ((a3*100+a2*10+a1+b2*10+b1)>=100 && (a3 * 100 + a2 * 10 + a1 + b2 * 10 + b1) <= 999 && (b2 * 10 + b1)>=10 && (a3 * 100 + a2 * 10 + a1)>=100)
                                        { Console.WriteLine("a3a2a1 - {0}{1}{2} b2b1 - {3}{4}, sum numbers = {5}" , a3,a2,a1,b2,b1, (a3 * 100 + a2 * 10 + a1 + b2 * 10 + b1)); }
                            }
                        }
                    }
                }
            }
            Console.ReadLine();
        }

        public static void Exercise76()
        {
            Console.WriteLine("Enter a from 1 to 8");
            string inputA = Console.ReadLine();
            Console.WriteLine("Enter b from 1 to 8");
            string inputB = Console.ReadLine();
            Console.WriteLine("Enter c from 1 to 8");
            string inputC = Console.ReadLine();
            Console.WriteLine("Enter d from 1 to 8");
            string inputD = Console.ReadLine();

            if (int.TryParse(inputA, out int a) &&
                int.TryParse(inputB, out int b) &&
                int.TryParse(inputC, out int c) &&
                int.TryParse(inputD, out int d) &&
                a>=1 && a<=8 && b>=1 &&b<=8&& c>=1 &&c<=8 && c>=1 && c <= 8)
            {

                bool answ_d = false;

                if (a==c || b == d) 
                { Console.WriteLine("answ a: rook is dangerous");
                    answ_d = true;
                } 
                
                else { Console.WriteLine("answ a: rook isnt dangerous"); }

                int tmp_a = a;
                int tmp_b = b;

                

                while (tmp_a <= 8 && tmp_b <= 8)
                    {
                        if (tmp_a == c && tmp_b == d)
                        { Console.WriteLine("answ b: bishop is dangerous");
                        answ_d = true;
                    }


                    tmp_a++;
                    tmp_b++;
                    }   


                for (int i=Math.Max(1,a-1); i<=Math.Min(8, a+1); i++)
                {                    
                    for  (int j = Math.Max(1, b - 1); j <= Math.Min(8, b + 1); j++){

                        if (i==c && j == d) { Console.WriteLine("answ c: king could be in c,d"); }
                }
                }

                // Part D
                if (answ_d) { Console.WriteLine("answ d: queen is dangerous"); } else { Console.WriteLine("answ d: queen isnt dangerous"); }

                // Part E
                if (a+1==c && a<=7) { Console.WriteLine("answ e: white pawn could be in next step in c,d"); }

                // Part F
                if (a - 1 == c && a >=1) { Console.WriteLine("answ f: black pawn could be in next step in c,d"); }

                //Part G
                int tmp = 5;
                for (int i = Math.Max(1,a-2); i<=Math.Min(8, a+2); i++)
                {
                    for (int j = Math.Max(1, b - 2); j <= Math.Min(8, b + 2); j++)
                    {
                        if (i!=j && i!=tmp && i!=a && j!=b)   //
                        
                            {
                            Console.WriteLine("{0}, {1}", i,j);
                             }
                         
                    }
                    tmp--;
                }


            }
            else { Console.WriteLine("a,b,c,and d should be integer between 1 to 8"); }
        }




        class Program4
        {
            static void Main(string[] args)
            {
                Chapter4.Exercise76();
                //Chapter4.Exercise75();
                //Chapter4.Exercise74();
                //Chapter4.Exercise73();
                //Chapter4.Exercise72();
                //Chapter4.Exercise71();
                //Chapter4.Exercise70();
                //Chapter4.Exercise69();
                //Chapter4.Exercise68();
                //Chapter4.Exercise67();
                //Chapter4.Exercise66();
                //Chapter4.Exercise65();
                //Chapter4.Exercise64();
                //Chapter4.Exercise63();
                //Chapter4.Exercise62();
                //Chapter4.Exercise61();
                //Chapter4.Exercise60();
                //Chapter4.Exercise59();
                //Chapter4.Exercise58();
                //Chapter4.Exercise57();
                //Chapter4.Exercise56();
                //Chapter4.Exercise55();
                //Chapter4.Exercise54();
                //Chapter4.Exercise53();
                //Chapter4.Exercise52();
                //Chapter4.Exercise51();
                //Chapter4.Exercise50();
                //Chapter4.Exercise49();
                //Chapter4.Exercise48();
                //Chapter4.Exercise47();
                //Chapter4.Exercise46();
                //Chapter4.Exercise45();
                //Chapter4.Exercise44();
                //Chapter4.Exercise43();
                //Chapter4.Exercise42();
                //Chapter4.Exercise41();
                //Chapter4.Exercise40();
                //Chapter4.Exercise39();
                //Chapter4.Exercise38();
                //Chapter4.Exercise37();
                //Chapter4.Exercise36();
                //Chapter4.Exercise35();
                //Chapter4.Exercise34();
                //Chapter4.Exercise33();
                //Chapter4.Exercise32();
                //Chapter4.Exercise31();
                //Chapter4.Exercise30();
                //Chapter4.Exercise29();
                //Chapter4.Exercise28();
                //Chapter4.Exercise27();
                //Chapter4.Exercise26();
                //Chapter4.Exercise25();
                //Chapter4.Exercise24();
                //Chapter4.Exercise23();
                //Chapter4.Exercise22();
                //Chapter4.Exercise21();
                //Chapter4.Exercise20();
                //Chapter4.Exercise19();
                //Chapter4.Exercise18();
                //Chapter4.Exercise17();
                //Chapter4.Exercise16();
                //Chapter4.Exercise15();
                //Chapter4.Exercise14();
                //Chapter4.Exercise13();
                //Chapter4.Exercise12();
                // Chapter4.Exercise11();
                //Chapter4.Exercise10();
                //Chapter4.Exercise9();
                //Chapter4.Exercise8();
                //Chapter4.Exercise7();
                //Chapter4.Exercise6b();
                //Chapter4.Exercise6a();
                //Chapter4.Exercise5();
                //Chapter4.Exercise4();
                //Chapter4.Exercise3();
                //Chapter4.Exercise2();
                //Chapter4.Exercise1();



            }
        }
    }
}







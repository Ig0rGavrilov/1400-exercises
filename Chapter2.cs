using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _1400_exercises
{
    class Chapter2
    {
        public static void Exercise1a()
        {
            Console.WriteLine("Enter x");
            double x = double.Parse(Console.ReadLine());
            double y = 17 * Math.Pow(x, 2) - 6 * x + 13;
            Console.WriteLine("Result {0}", y);
            Console.ReadLine();
        }
        public static void Exercise1b()
        {
            Console.WriteLine("Enter a");
            double a = double.Parse(Console.ReadLine());
            double y = 3 * Math.Pow(a, 2) + 5 * a - 21;
            Console.WriteLine("Result {0}", y);
            Console.ReadLine();
        }
        public static void Exercise2() 
        {
            Console.WriteLine("Enter a");
            double a= double.Parse(Console.ReadLine());
            double y = (Math.Pow(a, 2) + 10) / Math.Pow((Math.Pow(a, 2) + 1), 0.5);
            Console.WriteLine("Result {0}", y);
            Console.ReadLine();          
        }
        public static void Exercise3a()
        {
            Console.WriteLine("Enter a");
            double a = double.Parse(Console.ReadLine());
            double y = Math.Pow(((2 * a + Math.Sin(Math.Abs(3 * a))) / 3.56), 0.5);

            Console.WriteLine("Result {0}", y);
            Console.ReadLine();

            
        }
        public static void Exercise3b() 
        {
            Console.WriteLine("Enter x");
            double x = double.Parse(Console.ReadLine());

            double y = Math.Sin((3.2 + Math.Pow((1 + x), 0.5)) / Math.Abs(5 * x));
            Console.WriteLine("Result {0}", y);
                


        }
        public static void Exercise4()
        {
            Console.WriteLine("Enter the lenght side of square");
            string input = Console.ReadLine();
            if (double.TryParse(input, out double x))
            {
                Console.WriteLine("Length: {0}", 4*x );
            }
            else
            {
                Console.WriteLine("Not a number");
            }

            Console.ReadLine();
        }
        public static void Exercise5()
        {
            Console.WriteLine("Enter radius");
            string input = Console.ReadLine();

            if (double.TryParse(input, out double x))
            {
                Console.WriteLine("Diametr: {0}", 2*x);
            }
            else
            {
                Console.WriteLine("Enter the number again");
            }
        }

        public static void Exercise6()
        {
            const int radius = 6350;

            Console.WriteLine("Enter the distance from surface");
            string input = Console.ReadLine();

            if (double.TryParse(input, out double x))
            {
                Console.WriteLine("Distance {0}", Math.Pow((Math.Pow((radius + x), 2) - Math.Pow(radius, 2)), 0.5));
            }
            else 
            {
                Console.WriteLine("Error , input only number"); 
            }

        }

        public static void Exercise7()
        {
            Console.WriteLine("Enter the length side");
            string input = Console.ReadLine();

            if (double.TryParse(input, out double x))
            {
                Console.WriteLine("Volume: {0}", x*x*x);
                Console.WriteLine("Square {0}", x*x);
            }
            else
            {
                Console.WriteLine("Input only numbers");
            }
        }

        public static void Exercise8()
        {
            Console.WriteLine("Enter radius");
            string input = Console.ReadLine();  

            if (double.TryParse(input, out double x))
            {
                Console.WriteLine("Cirlce Length {0}", Math.PI*2*x);
                Console.WriteLine("Area of a circle {0}", Math.PI * x * x);
            }
            else
            {
                Console.WriteLine("Input only numbers");
            }
            Console.ReadLine();
        }

        public static void Exercise9a()
        {
            Console.WriteLine("Enter x");
            string inputx = Console.ReadLine();
            Console.WriteLine("Enter y");
            string inputy = Console.ReadLine();

            if (double.TryParse(inputx, out double x) && double.TryParse(inputy, out double y))
            {
                Console.WriteLine("Result: {0}", 2 * Math.Pow(x, 3) - 3.44 * x * y + 2.3 * Math.Pow(x, 2) - 7.1 * y + 2);

                
            }
            else
            {
                Console.WriteLine("x and y should be numbers");
            }
            Console.ReadLine();
        }

        public static void Exercise9b()
        {
            Console.WriteLine("Enter a");
            string inputa = Console.ReadLine();
            Console.WriteLine("Enter b");
            string inputb = Console.ReadLine();

            if (double.TryParse(inputa, out double a) && double.TryParse(inputb, out double b))
            {
                double x = 3.14 * Math.Pow((a + b), 3) + 2.75 * Math.Pow(b, 2) - 12.7 * a - 4.1;

                Console.WriteLine("Result: {0}", x);
            }
            else
            {
                Console.WriteLine("a and b should be numbers !!");
            }
        }

        public static void Exercise10()
        {
            Console.WriteLine("Enter 1 number");
            string inputx = Console.ReadLine();
            Console.WriteLine("Enter 2 number");
            string inputy = Console.ReadLine();

            if (int.TryParse(inputx, out int x) && int.TryParse(inputy, out int y))
            {
                Console.WriteLine("arithmetic average {0}", (x+y)/2);
                Console.WriteLine("geometric average {0}", Math.Pow(Math.Pow(x, 2) + Math.Pow(y, 2), 0.5));

                
            }
            else
            {
                Console.WriteLine("Error, x and y should be integer numbers");
            }
        }

        public static void Exercise11()
        {
            Console.WriteLine("Enter Volume:");
            string inputVolume = Console.ReadLine();
            Console.WriteLine("Enter Weight:");
            string inputWeight = Console.ReadLine();

            if (double.TryParse(inputVolume, out double v) && double.TryParse(inputWeight, out double w) && w>=0 && v>=0)
            {

                Console.WriteLine("Result {0}", w/v);
            }
            else
            {
                Console.WriteLine("Volume and Weight should be positive mumbers");
            }

            Console.ReadLine();
        }

        public static void Exercise12() 
        {
            Console.WriteLine("Enter the population:");
            string inputPopulation = Console.ReadLine();
            Console.WriteLine("Enter Area:");
            string inputArea = Console.ReadLine();

            if (int.TryParse(inputPopulation, out int population) &&
                double.TryParse(inputArea, out double area) &&
                area>0 && 
                population >0
                )
            {
                Console.WriteLine("Density {0}", population/area);
            }
            else
            {
                Console.WriteLine("Area and population shoud be positive not Null numbers");
            }

        }
        public static void Exercise13()
        {
            Console.WriteLine("Enter a:");
            string inputA= Console.ReadLine();
            Console.WriteLine("Enter b:");
            string inputB = Console.ReadLine();

            if (double.TryParse(inputA, out double a) && double.TryParse(inputB, out double b) && a != 0)
            {
                Console.WriteLine("ax+b=0 x={0}", -b/a);
            }
            else
            {
                Console.WriteLine("a!=0 , a and b should be numbers");
            }
            Console.ReadLine();
        }

        public static void Exercise14()
        {
            Console.WriteLine("Enter a");
            string inputA = Console.ReadLine();
            Console.WriteLine("Enter b");
            string inputB = Console.ReadLine();

            if (double.TryParse(inputA, out double a) && double.TryParse(inputB, out double b) && a> 0 && b > 0)
            {
                Console.WriteLine("c = {0}", Math.Pow((Math.Pow(a, 2) + Math.Pow(b, 2)), 0.5));

                
            }

            else
            {
                Console.WriteLine("a and b should be positive numbers");
            }
        }

        public static void Exercise15()
        {
            Console.WriteLine("Enter outside radius");
            string inputR1 = Console.ReadLine();
            Console.WriteLine("Enter inside radius");
            string inputR2 = Console.ReadLine();

            if (double.TryParse(inputR1, out double r1) &&
                double.TryParse(inputR2, out double r2) &&
                r1 >= r2 && r1 > 0 && r2 > 0)
            {
                Console.WriteLine("Area {0}", (2 * Math.PI * Math.Pow(r1, 2) - 2 * Math.PI * Math.Pow(r2, 2)));

            }
            else 
            {
                Console.WriteLine("Outside Radius should be positive and bigger than inside Radius");
            }

            Console.ReadLine();
        }

        public static void Exercise16()
        {
            Console.WriteLine("Enter a");
            string inputA = Console.ReadLine();
            Console.WriteLine("Enter b");
            string inputB = Console.ReadLine();
            if (double.TryParse(inputA, out double a) &&
                double.TryParse(inputB, out double b) &&
                a>0 && b>0)
            {
                Console.WriteLine("Perimeter of triangle {0}",
                    a + b + Math.Pow((Math.Pow(a, 2) + Math.Pow(b, 2)), 0.5));
            }
            else 
            {
                Console.WriteLine("a and b should be non zero positive numbes");
            }

            Console.ReadLine();
        }

        public static void Exercise17()
        {
            Console.WriteLine("Enter base 1 of trapezoid :");
            string inputA = Console.ReadLine();
            Console.WriteLine("Enter base 2 of trapezoid :"); 
            string inputB = Console.ReadLine();
            Console.WriteLine("Enter High of trapezoid");
            string inputH = Console.ReadLine();

            if (double.TryParse(inputA, out double a) &&
                double.TryParse(inputB, out double b) &&
                double.TryParse(inputH, out double h) &&
                a >0 && b > 0 && h>0)
            {
                Console.WriteLine("Perimeter {0}", a+b+2* Math.Pow((Math.Pow((a - b) / 2, 2) + Math.Pow(h, 2)), 0.5));             
            }

            else 
            {
                Console.WriteLine("Bases and heigth soul be non-zero positive numbers");
            }
        }

        public static void Exercise18()
        {
            Console.WriteLine("Enter x:");
            string inputX = Console.ReadLine();
            Console.WriteLine("Enter y:");
            string inputY = Console.ReadLine();

            if (double.TryParse(inputX, out double x) &&
                double.TryParse(inputY, out double y))
            {
                Console.WriteLine("z: {0}", (x + ((2 + y) / Math.Pow(x, 2))) / (y + (1 / Math.Pow((x * x + 10), 0.5))));
                Console.WriteLine("q: {0}", 7.25 * Math.Sin(x) - Math.Abs(y));
            }
            else
            {
                Console.WriteLine("x and y should be numbers");
            }
            Console.ReadLine();
        }

        public static void Exercise19()
        {
            Console.WriteLine("Enter a:");
            string inputA = Console.ReadLine();
            Console.WriteLine("Enter b:");
            string inputB = Console.ReadLine();

            if (double.TryParse(inputA, out double a) &&
                double.TryParse(inputB, out double b) &&
                a!=0) 
            {
                Console.WriteLine("x: {0}", ((2 / (Math.Pow(a, 2) + 25)) + b) / (Math.Pow(b, 0.5) + ((a + b) / 2)));
                Console.WriteLine("y: {0}", (Math.Abs(a) + 2 * Math.Sin(b)) / (5.5 * a));
            }

            else
            {
                Console.WriteLine("a and d  should be numbers");
            }
            Console.ReadLine();
        }

        public static void Exercise20()
        {
            Console.WriteLine("Enter e:");
            string inputE = Console.ReadLine();
            Console.WriteLine("Enter f:");
            string inputF = Console.ReadLine();
            Console.WriteLine("Enter g:");
            string inputG = Console.ReadLine();
            Console.WriteLine("Enter h:");
            string inputH = Console.ReadLine();

            if (double.TryParse(inputE, out double e) &&
                double.TryParse(inputF, out double f) &&
                double.TryParse(inputG, out double g) &&
                double.TryParse(inputH, out double h) 
                )
            {
                Console.WriteLine("a: {0}", Math.Pow((Math.Pow(Math.Abs(e - (3 / f)), 3) + g), 0.5));
                Console.WriteLine("b: {0}", Math.Sin(e) + Math.Pow(Math.Sin(h), 2));
                Console.WriteLine("c: {0}", (33*g)/(e*f-3));

                
                
            }
            else
            {
                Console.WriteLine("e, f, g and h should be numbers");
            }
        }
        public static void Exercise21()
        {
            Console.WriteLine("Enter e:");
            string inputE = Console.ReadLine();
            Console.WriteLine("Enter f:");
            string inputF = Console.ReadLine();
            Console.WriteLine("Enter g:");
            string inputG = Console.ReadLine();
            Console.WriteLine("Enter h:");
            string inputH = Console.ReadLine();

            if (double.TryParse(inputE, out double e) &&
                double.TryParse(inputF, out double f) &&
                double.TryParse(inputG, out double g) &&
                double.TryParse(inputH, out double h)
                )
            {
                Console.WriteLine("a: {0}", (e+(f/2))/3);
                Console.WriteLine("b: {0}", Math.Abs(Math.Pow(h, 2) - g));
                Console.WriteLine("c: {0}", Math.Pow((Math.Pow((g - h), 2) - 3 * Math.Sin(e)), 0.5));
                
                
                    
                    
            }
            else
            {
                Console.WriteLine("e,f,g and h should be numbers");
            }
            Console.ReadLine();
        }
        public static void Exercise22()
        {
            Console.WriteLine("Enter fisrt number");
            string inputX = Console.ReadLine();
            Console.WriteLine("Enter second number");
            string inputY = Console.ReadLine();

            if (double.TryParse(inputX, out double x) &&
                double.TryParse(inputY, out double y))
            {
                Console.WriteLine("average absolute arithmetic {0}", (Math.Abs(x) + Math.Abs(y)) / 2);
                Console.WriteLine("average absolute geometric {0}", Math.Pow((Math.Pow(Math.Abs(x), 2) + Math.Pow(Math.Abs(y), 2)), 0.5));

                    
            } 
            else
            {
                Console.WriteLine("x and y should be numbers");
            }
            Console.ReadLine();
        }

        public static void Exercise23()
        {
            Console.WriteLine("Enter a");
            string inputA = Console.ReadLine();
            Console.WriteLine("Enter b");
            string inputB = Console.ReadLine();
            
            if (double.TryParse(inputA, out double a) &&
                double.TryParse(inputB, out double b) 
                
                && a>0 && b>0 )
            {
                Console.WriteLine("Perimeter {0}", 2*(a+b));
                Console.WriteLine("Rectangle diagonal {0}", Math.Pow((Math.Pow(a, 2) + Math.Pow(b, 2)), 0.5));    
            }
            else
            {
                Console.WriteLine("a, b should be non negative numbers");
            }
            
        }

        public static void Exercise24()
        {
            Console.WriteLine("Enter a");
            string inputA = Console.ReadLine();
            Console.WriteLine("Enter b");
            string inputB = Console.ReadLine();

            if (double.TryParse(inputA, out double a) &&
                double.TryParse(inputB, out double b))
            {
                Console.WriteLine("sum : {0}", a+b);
                Console.WriteLine("subtract {0}", a-b);
                Console.WriteLine("multiply {0}", a*b);
                Console.WriteLine("reminder {0}", a%b);
            }

            else
            {
                Console.WriteLine("a and b should be numbers");
            }
            Console.ReadLine();
        }

        public static void Exercise25()
        {
            Console.WriteLine("enter a");
            string inputA = Console.ReadLine();
            Console.WriteLine("enter b");
            string inputB = Console.ReadLine();
            Console.WriteLine("enter c");
            string inputC = Console.ReadLine();

            if (double.TryParse(inputA, out double a) &&
                double.TryParse(inputB, out double b) &&
                double.TryParse(inputC, out double c) &&
                a>0 && b>0 && c > 0)
            {
                Console.WriteLine("Volume {0}", a*b*c);
                Console.WriteLine("Area {0}", a*b);
            }

            else
            {
                Console.WriteLine("a, b and c should be non negative numbers ");
            }
            Console.ReadLine();
        }

        public static void Exercise26()
        {
            Console.WriteLine("Enter x1");
            string inputX1 = Console.ReadLine();
            Console.WriteLine("Enter y1");
            string inputY1 = Console.ReadLine();
            Console.WriteLine("Enter x2");
            string inputX2 = Console.ReadLine();
            Console.WriteLine("Enter y2");
            string inputY2 = Console.ReadLine();

            if (double.TryParse(inputX1, out double x1) &&
                double.TryParse(inputX1, out double y1) &&
                double.TryParse(inputX2, out double x2) &&
                double.TryParse(inputY2, out double y2) )
            {
                Console.WriteLine("distance between points {0}", Math.Pow((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)), 0.5));
                
            }
            else
            {
                Console.WriteLine("x1,y1 and x2,y2 should be numbers");
            }

            Console.ReadLine();


        }

        public static void Exercise27()
        {
            Console.WriteLine("length of trapezoid base:");
            string inputA = Console.ReadLine();
            Console.WriteLine("length of trapezoid base:");
            string inputB = Console.ReadLine();
            Console.WriteLine("hight of trapezoid");
            string inputH = Console.ReadLine();

            if (double.TryParse(inputA, out double a) &&
                double.TryParse(inputB, out double b) &&
                double.TryParse(inputH , out double h) &&
                a>0 && b>0 && h> 0)
                {
                
                Console.WriteLine("Perimeter {0}", a + b + 2 * Math.Pow((Math.Pow((a - b) / 2, 2) + Math.Pow(h, 2)), 0.5));

            }

            else
            {
                Console.WriteLine("lengths and high should be non negative numbers");
            }
            Console.ReadLine();
        }

        public static void Exercise28()
        {
            Console.WriteLine("length of trapezoid base:");
            string inputA = Console.ReadLine();
            Console.WriteLine("length of trapezoid base:");
            string inputB = Console.ReadLine();
            Console.WriteLine("angle of trapezoid");
            string inputX = Console.ReadLine();

            if (double.TryParse(inputA, out double a) &&
                double.TryParse(inputB, out double b) &&
                double.TryParse(inputX, out double x) &&
                a > 0 && b > 0 && x > 0)
            {
                Console.WriteLine("Perimeter {0}", (2 * a / Math.Cos(x)) + a + b);

            }

            else
            {
                Console.WriteLine("All values must be non zero and positive numbers");
            }

            Console.ReadLine();
        }

        public static void Exercise29()
        {
            Console.WriteLine("Enter x1");
            string inputX1 = Console.ReadLine();
            Console.WriteLine("Enter y1");
            string inputY1 = Console.ReadLine();
            Console.WriteLine("Enter x2");
            string inputX2 = Console.ReadLine();
            Console.WriteLine("Enter y2");
            string inputY2 = Console.ReadLine();
            Console.WriteLine("Enter x3");
            string inputX3 = Console.ReadLine();
            Console.WriteLine("Enter y3");
            string inputY3 = Console.ReadLine();

            if (double.TryParse(inputX1, out double x1) &&
                double.TryParse(inputY1, out double y1) &&
                double.TryParse(inputX2, out double x2) &&
                double.TryParse(inputY2, out double y2) &&
                double.TryParse(inputX3, out double x3) &&
                double.TryParse(inputY3, out double y3))
            {
                double sideA = Length(x3, y3, x1, y1);
                double sideB = Length(x3, y3, x2, y2);
                double sideC = Length(x2, y2, x1, y1);
                double perimeter = sideA + sideB + sideC;
                Console.WriteLine("Perimeter {0}", perimeter);
                Console.WriteLine("Area of trinagle {0}", Math.Pow(((perimeter / 2) * ((perimeter / 2) - sideA) * ((perimeter / 2) - sideB) * ((perimeter / 2) - sideC)), 0.5));

                //(perimeter/2)*((perimeter / 2)-sideA)*((perimeter / 2)-sideB)*((perimeter / 2)-sideC)  Heron's formula
                    
            }

            else
            {
                Console.WriteLine("Coordinates must be numbers");
            }
            Console.ReadLine();


            
        }

        private static double Length( double a1, double b1, double a2, double b2)
        {
            double length = Math.Pow((Math.Pow(a2 - a1, 2) + Math.Pow(b2 - b1, 2)), 0.5);

            return length;
                
        }

        public static void Exercise30()
        {
            const float x = 2.5F;
            const float y = 3.2F;
            const float z = 1.4F;

            Console.WriteLine("Enter weight of bonbons");
            string inputA = Console.ReadLine();
            Console.WriteLine("Enter weight of biscuits");
            string inputB = Console.ReadLine();
            Console.WriteLine("Enter weight of apple");
            string inputC= Console.ReadLine();

            if (double.TryParse(inputA, out double a) &&
                double.TryParse(inputB, out double b) &&
                double.TryParse(inputC, out double c) &&
                a>0 &&b>0 && c>0)
            {
                Console.WriteLine("Cost of bonbons {0}", x*a);
                Console.WriteLine("Cost of biscuits {0}", y*b);
                Console.WriteLine("Cost of apple {0}", z*c);
                Console.WriteLine("________________________");
                Console.WriteLine("Total Cost {0}", a*x+b*y+c*z);
            }

            else
            {
                Console.WriteLine("Weight should be non negative");
            }
            Console.ReadLine();

        }

        public static void Exercise32()
        {
            const int priceDisplay = 1000;
            const int priceComputer = 3000;
            const int priceMouse = 500;

            Console.WriteLine("Enter the number of computers");
            string inputN = Console.ReadLine();

            if (int.TryParse(inputN , out int n) && n > 0)
            {
                Console.WriteLine("Cost 3 computers {0}", 3*(priceComputer+priceDisplay+priceMouse));
                Console.WriteLine("Cost {0} computers {1}", n, n * (priceComputer + priceDisplay + priceMouse));
            }

            else
            {
                Console.WriteLine("numer of computers should be positive integer");
            }

            Console.ReadLine();

        }

        public static void Exercise33()
        {
            Console.WriteLine("Tanya's age:");
            string inputT = Console.ReadLine();
            Console.WriteLine("Mitya's age");
            string inputM = Console.ReadLine();

            if (float.TryParse(inputT, out float t) &&
                float.TryParse(inputM, out float m) && t>0 && m > 0)
            {
                Console.WriteLine("Average age {0}", (m+t)/2);
                Console.WriteLine("Different Tanya's age from average: {0}", t- (m+t)/2);
                Console.WriteLine("Different Mitya's age from average: {0}", m - (m + t) / 2);
            }

            else
            {
                Console.WriteLine("Ages should be positive numbers");
            }

            Console.ReadLine();
        }

        public static void Exercise34() 
        {
            Console.WriteLine("Enter speed of Car1");
            string inputCar1 = Console.ReadLine();
            Console.WriteLine("Enter speed of Car2");
            string inputCar2 = Console.ReadLine();
            Console.WriteLine("Enter distance between Cars");
            string inputDist = Console.ReadLine();

            if (double.TryParse(inputCar1, out double speedCar1) &&
                double.TryParse(inputCar2, out double speedCar2) &&
                double.TryParse(inputDist, out double distance) &&
                speedCar1>=0 && speedCar2>=0 && distance>0) 
            {
                Console.WriteLine("Time: {0}", distance/(speedCar1+speedCar2));
            }

            else
            {
                Console.WriteLine("Speed and distance cannt be negative");
            }

            Console.ReadLine();

        }

        public static void Exercise35()
        {
            Console.WriteLine("Enter speed of Car1");
            string inputCar1 = Console.ReadLine();
            Console.WriteLine("Enter speed of Car2");
            string inputCar2 = Console.ReadLine();
            

            if (double.TryParse(inputCar1, out double speedCar1) &&
                double.TryParse(inputCar2, out double speedCar2) &&
               
                speedCar1 >= 0 && speedCar2 >= 0 && speedCar1>speedCar2)
            {
                Console.WriteLine("Distance after 30 min {0}",  0.5*(speedCar1 - speedCar2));
            }

            else
            {
                Console.WriteLine("Speed and distance cannt be negative, speed Car1 > than speed Car2");
            }

            Console.ReadLine();

        }

        public static void Exercise36()
        {
            Console.WriteLine("Enter temperature in Celsius");
            string inputTempC = Console.ReadLine();

            if (double.TryParse(inputTempC, out double tempC))
            {
                Console.WriteLine("Temperature {0} F", tempC*1.8+32);
                Console.WriteLine("Temperature {0} K", tempC +(-273.15));

            }

            else
            {
                Console.WriteLine("Temperatura should be integer , float of double");
            }
            Console.ReadLine();
        }

        public static void Exercise37()
        {
            Console.WriteLine("450F - {0:0.00} C", (450-50)/1.8);
            Console.ReadLine();
        }
        
        public static void Exercise38()
        {
            Console.WriteLine("Enter x");
            string inputX = Console.ReadLine();
            Console.WriteLine("Enter y");
            string inputY = Console.ReadLine();

            if (double.TryParse(inputX, out double x) &&
                double.TryParse(inputY, out double y))
            {
                Console.WriteLine("Sum {0} + {1} = {2}", x,y,x+y);
                Console.WriteLine("Subtract {0}-{1}={2}", x,y,x-y);
                Console.WriteLine("Division   {0}/{1}={2:0.00}", x, y, x / y);
                Console.WriteLine("Average ({0}+{1})/2={2}", x,y,(x+y)/2);

                Console.ReadLine();
            }

        }

    }

    class Program2

    {
        static void Main2(string[] args)
        {
            //Chapter2.Exercise1a();
            //Chapter2.Exercise1b();
            //Chapter2.Exercise2();
            //Chapter2.Exercise3a();
            //Chapter2.Exercise3b();
            //Chapter2.Exercise4();
            //Chapter2.Exercise5();
            //Chapter2.Exercise6();
            //Chapter2.Exercise7();
            //Chapter2.Exercise8();
            //Chapter2.Exercise9a();
            //Chapter2.Exercise9b();
            //Chapter2.Exercise10();
            //Chapter2.Exercise11();
            //Chapter2.Exercise12();
            //Chapter2.Exercise13();
            //Chapter2.Exercise14();
            //Chapter2.Exercise15();
            //Chapter2.Exercise16();
            //Chapter2.Exercise17();
            //Chapter2.Exercise18();
            //Chapter2.Exercise19();
            //Chapter2.Exercise20();
            // Chapter2.Exercise21();
            //Chapter2.Exercise22();
            //Chapter2.Exercise23();
            //Chapter2.Exercise24();
            //Chapter2.Exercise25();
            //Chapter2.Exercise26();
            //Chapter2.Exercise27();
            //Chapter2.Exercise28();
            //Chapter2.Exercise29();
            //Chapter2.Exercise30();
            //Chapter2.Exercise32();
            //Chapter2.Exercise33();
            //Chapter2.Exercise34();
            //Chapter2.Exercise35();
            //Chapter2.Exercise36();
            //Chapter2.Exercise37();
            Chapter2.Exercise38();



        }
    }

}

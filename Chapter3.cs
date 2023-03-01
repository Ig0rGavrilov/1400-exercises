using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _1400_exercises
{
    internal class Chapter3
    {
        public static void Exercise1()
        {
            Console.WriteLine("Enter length in cm");
            string inputX = Console.ReadLine();

            if (double.TryParse(inputX, out double x) && x > 0)
            {
                Console.WriteLine("full meters {0}", (int)x / 100);
            }

            else
            {
                Console.WriteLine("Length should be non negative numebr ");
            }
            Console.ReadLine();

        }
        public static void Exercise2()
        {
            Console.WriteLine("Enter weight in kg");
            string inputX = Console.ReadLine();

            if (double.TryParse(inputX, out double x) && x > 0)
            {
                Console.WriteLine("full cent {0}", (int)x / 100);
            }

            else
            {
                Console.WriteLine("Weight should be non negative numebr ");
            }
            Console.ReadLine();

        }

        public static void Exercise3()
        {
            Console.WriteLine("Enter days");
            string inputX = Console.ReadLine();

            if (double.TryParse(inputX, out double x) && x > 0)
            {
                Console.WriteLine("full weeks {0}", (int)x / 7);
            }

            else
            {
                Console.WriteLine("Days should be non negative numebr ");
            }
            Console.ReadLine();

        }

        public static void Exercise4()
        {
            Console.WriteLine("Enter num classmates");
            string inputClassMates = Console.ReadLine();
            Console.WriteLine("Enter num apples");
            string inputApples = Console.ReadLine();

            if ((int.TryParse(inputClassMates, out int classMates) &&
                int.TryParse(inputApples, out int apples) && classMates > 0 && apples > 0))
            {
                Console.WriteLine("For each student -{0} apple(s)", (int)apples / classMates);
                Console.WriteLine("rest of apples {0}", apples % classMates);

            }

            else
            {
                Console.WriteLine("Classmates and aplles should be non negative integer numbers");
            }
            Console.ReadLine();

        }

        public static void Exercise5()
        {
            Console.WriteLine("Num squares {0}", (int)543 / 130);
        }

        public static void Exercise6()
        {
            Console.WriteLine("Enter seat number");
            string inputSitNumber = Console.ReadLine();

            if (int.TryParse(inputSitNumber, out int sitNumber) && sitNumber > 0 && sitNumber <= 36)
            {
                Console.WriteLine("Cabin number {0}", (int)sitNumber / 4); ;
            }
            else
            {
                Console.WriteLine("Sit number should be integer and max 36");
            }
            Console.ReadLine();
        }

        public static void Exercise7()
        {
            Console.WriteLine("Enter flat number");
            string inputFlatNumber = Console.ReadLine();

            if (int.TryParse(inputFlatNumber, out int flatNumber) && flatNumber > 0 && flatNumber <= 15)
            {
                Console.WriteLine("Floor number {0}", (int)flatNumber / 3); ;
            }
            else
            {
                Console.WriteLine("Flat number should be integer and max 15");
            }
            Console.ReadLine();

        }

        public static void Exercise8()
        {
            Console.WriteLine("Enter ticket number");
            string inputTicket = Console.ReadLine();

            if (int.TryParse(inputTicket, out int ticket) && ticket >= 01643 && ticket < 01943)
            {
                int n = 1 + (ticket - 01643) / 15;
                Console.WriteLine("Row number {0}", n);
            }


            else
            {
                Console.WriteLine("Ticket number should be integer , starts from 01643 to 01942");
            }

        }

        public static void Exercise9()
        {
            Console.WriteLine("Enter secunds");
            string inputSec = Console.ReadLine();

            if (int.TryParse(inputSec, out int sec) && sec >= 0)
            {
                Console.WriteLine("Full hours :{0}", sec / (3600));
                Console.WriteLine("Full minutes:{0}", sec / 60);
                Console.WriteLine("Sec after minute :{0}", sec % 60);
            }
            else
            {
                Console.WriteLine("Secunds cannt be negative");
            }
        }

        public static void Exercise10a()
        {
            Console.WriteLine("Enter k between 1 and 365");

            string inputK = Console.ReadLine();

            if (int.TryParse(inputK, out int k))
            {
                int startYear = 1;
                int dayOfWeek = (k) % 7;


                Console.WriteLine("Day of week :{0}", dayOfWeek);


                switch (dayOfWeek)
                {
                    case 1: Console.WriteLine("Monday"); break;
                    case 2: Console.WriteLine("Tuesday"); break;
                    case 3: Console.WriteLine("Wednesday"); break;
                    case 4: Console.WriteLine("Thursday"); break;
                    case 5: Console.WriteLine("Friday"); break;
                    case 6: Console.WriteLine("Satuday"); break;
                    case 0: Console.WriteLine("Sunday"); break;

                }
            }



            else
            {
                Console.WriteLine("k should be integer between 1 and 365");
            }
        }

        public static void Exercise10b()
        {
            Console.WriteLine("Enter k between 1 and 365");

            string inputK = Console.ReadLine();

            if (int.TryParse(inputK, out int k))
            {
                int startYear = 1;  // day of week -1
                int dayOfWeek = (k + startYear) % 7;


                Console.WriteLine("Day of week :{0}", dayOfWeek);


                switch (dayOfWeek)
                {
                    case 1: Console.WriteLine("Monday"); break;
                    case 2: Console.WriteLine("Tuesday"); break;
                    case 3: Console.WriteLine("Wednesday"); break;
                    case 4: Console.WriteLine("Thursday"); break;
                    case 5: Console.WriteLine("Friday"); break;
                    case 6: Console.WriteLine("Satuday"); break;
                    case 0: Console.WriteLine("Sunday"); break;

                }
            }



            else
            {
                Console.WriteLine("k should be integer between 1 and 365");
            }
        }

        public static void Exercise10c()
        {
            Console.WriteLine("Enter k between 1 and 365");
            string inputK = Console.ReadLine();
            Console.WriteLine("Enter strat of week, where:");
            Console.WriteLine("1 - Monday");
            Console.WriteLine("2 - Tuesday");
            Console.WriteLine("3 - Wednesday");
            Console.WriteLine("4 - Thursday");
            Console.WriteLine("5 - Friday");
            Console.WriteLine("6 - Satuday");
            Console.WriteLine("0 - Sunday");
            string inputN = Console.ReadLine();


            if (int.TryParse(inputK, out int k) && int.TryParse(inputN, out int n))
            {
                int startYear = n - 1;  // day of week -1
                int dayOfWeek = (k + startYear) % 7;


                Console.WriteLine("Day of week :{0}", dayOfWeek);


                switch (dayOfWeek)
                {
                    case 1: Console.WriteLine("Monday"); break;
                    case 2: Console.WriteLine("Tuesday"); break;
                    case 3: Console.WriteLine("Wednesday"); break;
                    case 4: Console.WriteLine("Thursday"); break;
                    case 5: Console.WriteLine("Friday"); break;
                    case 6: Console.WriteLine("Satuday"); break;
                    case 0: Console.WriteLine("Sunday"); break;

                }
            }



            else
            {
                Console.WriteLine("k should be integer between 1 and 365");
            }
        }

        public static void Exercise11()
        {
            Console.WriteLine("Enter n:");
            string inputN = Console.ReadLine();

            if (int.TryParse(inputN, out int n) && n >= 0)
            {
                if (n <= 12)
                {
                    Console.WriteLine("x: {0}", (n + 1));
                }
                else
                {
                    Console.WriteLine("x: {0}", (n + 1) % 12);
                }


            }

            else
            {
                Console.WriteLine("n should be non negative integer value");
            }
        }


        public static void Exercise12()
        {
            Console.WriteLine("Enter flat number max(20)");

            string inputX = Console.ReadLine();

            if (int.TryParse(inputX, out int x))
            {
                Console.WriteLine("Floor: {0}", ((x-1) / 4)+1 );  // strat from 1 not from 0
                Console.WriteLine("Order number: {0}", x%(((x - 1) / 4) + 1) +1);  // same as previuos
                
            }
            else
            {
                Console.WriteLine("Flat should be non negative integer number");
            }
        }

        public static void Exercise13()
        {
            Console.WriteLine("enter n");
            string inputN = Console.ReadLine();

            if (int.TryParse(inputN, out int n) && n >= 0)
            {
                Console.WriteLine("Row nunmber: {0}", ((n) / 5) + 1);
                Console.WriteLine("Order number in row: {0}", n +1- 5*(((n) / 5)));
            }

            else
            {
                Console.WriteLine("n should be nonnegative integer");
            }
        }

        public static void Exercise14()
        {
            Console.WriteLine("Enter flat number");
            
            string inputN = Console.ReadLine();

            if (int.TryParse(inputN, out int n) && n > 0)
            {
                int entrance = 1 + (n - 1) / 54;
                Console.WriteLine("Entrance: {0}", entrance);  //54 flat in Entrance  (1+(n-1)/54)

                int floor = 1 + (n - ((n - 1) / 54) * 54) / 6;
                Console.WriteLine("Floor {0}", floor); // 6 flats on Floor

                int order = n - (entrance - 1) * 54 - (floor -1)* 6;
                Console.WriteLine("Flat order on the floor {0}", order);
                
            }
            else
            {
                Console.WriteLine("n should be nonnegative integer");
            }

            Console.ReadLine();

        }

        public static void Exercise15()
        {
            Console.WriteLine("Enter storage number");

            string inputN = Console.ReadLine();

            if (int.TryParse(inputN, out int n) && n > 0)
            {
                // Start from 1 , not from 0!!
                
                int row = 1+ (n-1) / (120);
                Console.WriteLine("Row: {0}", row);

                int column = (n-(row-1)*120)/15 + 1;
                Console.WriteLine("Column: {0}", column);
            }

            else
            {
                Console.WriteLine("n should be non negative integer number");
            }

            Console.ReadLine();
        }

        public static void Exercise16()
        {
            Console.WriteLine("Enter number between 0 and 99");
            string inputX = Console.ReadLine();

            if (int.TryParse(inputX,out int x) && x>=0 && x<=99)
                {
                Console.WriteLine("10 x {0}", x/10);
                Console.WriteLine(" 1 x {0}", x%10);

            }
            else
            {
                Console.WriteLine("Should benon negative integer number");
            }
            Console.ReadLine();
        }

        
        public static void Exercise17()
        {
            Console.WriteLine("Enter number between 0 and 99");
            string inputX = Console.ReadLine();

            if (int.TryParse(inputX, out int x) && x >= 0 && x <= 99)
            {
                
                Console.WriteLine("Sum numbers of {0} = {1}", x, (x / 10 + x % 10));

            }
            else
            {
                Console.WriteLine("Should benon negative integer number");
            }
            Console.ReadLine();
        }

        public static void Exercise18()
        {
            Console.WriteLine("Enter number between 0 and 999");
            string inputX = Console.ReadLine();

            if (int.TryParse(inputX, out int x) && x >= 0 && x <= 999)
            {
                Console.WriteLine("{0}, {1}, {2}", 
                    x / 100,
                    (x - 100 * (x / 100)) / 10,
                    x - 100 * (x / 100) - 10 * ((x - 100 * (x / 100)) / 10)
                    );
                //Console.WriteLine("{0}", (x/100));
                //Console.WriteLine("{0}", (x-100*(x / 100))/10);
                //Console.WriteLine("{0}", x - 100*(x / 100) - 10*((x - 100 * (x / 100)) / 10));

            }
            else
            {
                Console.WriteLine("Should benon negative integer number");
            }
            Console.ReadLine();
        }

        public static void Exercise19()
        {
            Console.WriteLine("Input number between 10 and 99");
            string inputX = Console.ReadLine();

            if (int.TryParse(inputX, out int x) && x>=10 && x<=99) 
            {
                Console.WriteLine("New number {0}", 10*(x%10)+ x/10);

            } 

            else
            {
                Console.WriteLine("number should be integer between 10 and 99");
            }
        }

        public static void Exercise20()
        {
            Console.WriteLine("Enter number between 100 and 999");
            string inputX = Console.ReadLine();

            if (int.TryParse(inputX,out int x) && x>=100 && x<=999) 
            {
                
                Console.WriteLine("{0}", x-100*(x/100)-10*((x - 100 * (x / 100)) / 10))  ;
                Console.WriteLine("{0}", (x- 100*(x/100))/10);
                Console.WriteLine("Sum digits {0}",  (x / 100) +(x - 100 * (x / 100) - 10 * ((x - 100 * (x / 100)) / 10)) +((x - 100 * (x / 100)) / 10));

            }

            else
            {
                Console.WriteLine("Number should be integer between 100 and 999");
            }


        }

        public static void Exercise21()
        {
            Console.WriteLine("Enter number between 100 and 999");
            string inputX = Console.ReadLine();

            if (int.TryParse(inputX, out int x) && x >= 100 && x <= 999)
            {

                
                //Console.WriteLine("Sum digits {0}", (x / 100) + (x - 100 * (x / 100) - 10 * ((x - 100 * (x / 100)) / 10)) + ((x - 100 * (x / 100)) / 10));

                Console.WriteLine("{0}", (x / 100) + 100*(x - 100 * (x / 100) - 10 * ((x - 100 * (x / 100)) / 10)) + 10*((x - 100 * (x / 100)) / 10));

            }

            else
            {
                Console.WriteLine("Number should be integer between 100 and 999");
            }
            Console.ReadLine();
        }

        public static void Exercise22()
        {
            Console.WriteLine("Enter number between 100 and 999");
            string inputX = Console.ReadLine();

            if (int.TryParse(inputX, out int x) && x>=100 && x <= 999)
            {
                
                int num = 100 * ((x - 100 * (x / 100)) / 10);
                num = num + 10 * (x - 100 * (x / 100) - 10 * ((x - 100 * (x / 100)) / 10));
                num = num + x / 100;
    
                Console.WriteLine("{0}",  num);
            }

            else
            {
                Console.WriteLine("number should be integer between 100 and 999");
            }

            Console.ReadLine();
        }

        public static void Exercise23()
        {
            Console.WriteLine("Enter number between 100 an 999");
            string inputX = Console.ReadLine();

            if (int.TryParse(inputX, out int x) && x>=100 && x <= 999)
            {
                int num100 = x / 100;
                int num10 = (x - 100 * num100) / 10;
                int num1 = x - 100 * num100 - 10 * ((x - 100 * num100) / 10);

                int res = num10*100 + num1*10 + num100;

                Console.WriteLine("{0}", res);
                

            }

            else
            {
                Console.WriteLine("Number should be integer between 100 and 999");
            }
        }

        public static void Exercise24() 
        {
            Console.WriteLine("Enter number between 100 an 999");
            string inputX = Console.ReadLine();

            if (int.TryParse(inputX, out int x) && x >= 100 && x <= 999)
            {
                int num100 = x / 100;
                int num10 = (x - 100 * num100) / 10;
                int num1 = x - 100 * num100 - 10 * ((x - 100 * num100) / 10);

                int res = num10 * 100 + num100 * 10 + num1;

                Console.WriteLine("{0}", res);


            }

            else
            {
                Console.WriteLine("Number should be integer between 100 and 999");
            }

        }

        public static void Exercise25()
        {
            Console.WriteLine("Enter number between 100 an 999");
            string inputX = Console.ReadLine();

            if (int.TryParse(inputX, out int x) && x >= 100 && x <= 999)
            {
                int num100 = x / 100;
                int num10 = (x - 100 * num100) / 10;
                int num1 = x - 100 * num100 - 10 * ((x - 100 * num100) / 10);

                int res = num100 * 100 + num1 * 10 + num10;

                Console.WriteLine("{0}", res);

            }

            else
            {
                Console.WriteLine("Number should be integer between 100 and 999");
            }
        }

        public static void Exercise26()
        {
            Console.WriteLine("Enter number from  100 to 999");

            string inputX = Console.ReadLine();
            
            if (int.TryParse(inputX, out int x) && x>=100 && x<=999)
            {
                int num100 = x / 100;
                int num10 = (x - num100 * 100) / 10;
                int num1 = (x - num100 * 100) % 10;

                
                 int[]  numArray = { num100, num10, num1};

                Console.WriteLine("____________________________________");
                
                for (int i=0; i<numArray.Length; i++)

                {
                    for (int j=0; j<numArray.Length; j++)
                    {
                        for (int k=0; k<numArray.Length; k++)
                        {
                            if (i!= k && k!= j && i!= j)
                            {
                                Console.WriteLine(numArray[i].ToString() + numArray[j].ToString() + numArray[k].ToString());
                            }
                            
                        }
                    }
                }
                
            }
            else
            {
                Console.WriteLine("Number should be integer between 100 and 999");
            }

            Console.ReadLine();
        }

        public static void Exercise27()
        {
            Console.WriteLine("Enter 4 digits number");

            string inputx = Console.ReadLine();

            if (int.TryParse(inputx, out int x) && x>=1000 && x<=9999)
            {
                int num1000 = x / 1000;
                int num100 = (x - num1000 * 1000)/100;
                int num10 = (x - num1000 * 1000 - num100 * 100) / 10;
                int num1 = x % 10;

                Console.WriteLine("Sum of digits {0}", num1000+num100+num10+num1);
            }

            else
            {
                Console.WriteLine("Number should be between 1000 and 9999");
            }
        }

        public static void Exercise28()
        {
            Console.WriteLine("Enter 4 digits number");

            string inputx = Console.ReadLine();

            if (int.TryParse(inputx, out int x) && x >= 1000 && x <= 9999)
            {
                int num1000 = x / 1000;
                int num100 = (x - num1000 * 1000) / 100;
                int num10 = (x - num1000 * 1000 - num100 * 100) / 10;
                int num1 = x % 10;

                Console.WriteLine("Part a {0}", 1000*num1 + 100*num10 + 10*num100 + num1000);
                Console.WriteLine("Part b {0}", num100*1000+ 100*num1000 + 10*num1 + num10);
                Console.WriteLine("Part c {0}", num1000*1000+ num10*100+ num100*10+ num1);                 
                Console.WriteLine("Part d {0}", 1000*num10 + 100*num1+10*num1000+num100);
            }

            else
            {
                Console.WriteLine("Number should be between 1000 and 9999");
            }
        }

        public static void Exercise29()
        {
            Console.WriteLine("Enter number n>9");
            string inputN = Console.ReadLine();

            if (int.TryParse(inputN, out int n)&& n > 9)
            {
                Console.WriteLine("10x - {0}", n/10);
                Console.WriteLine("1x - {0}", n % 10);
            }

            else
            {
                Console.WriteLine("n should be positive integer and biggest than 9");
            }

            Console.ReadLine();
        }

        public static void Exercise30()
        {
            Console.WriteLine("Enter number n>99");
            string inputN = Console.ReadLine();

            if (int.TryParse(inputN, out int n) && n > 99)
            {
                Console.WriteLine("10x - {0}", (n - 100*(n/100))/10);
                Console.WriteLine("100x - {0}", n / 100);
            }

            else
            {
                Console.WriteLine("n should be positive integer and biggest than 99");
            }

            Console.ReadLine();
        }

        public static void Exercise31()
        {
            Console.WriteLine("Enter number n>999");
            string inputN = Console.ReadLine();

            if (int.TryParse(inputN, out int n) && n > 999)
            {
                Console.WriteLine("100x - {0}", (n - 1000 * (n / 1000)) / 100);
                Console.WriteLine("1000x - {0}", n / 1000);
            }

            else
            {
                Console.WriteLine("n should be positive integer and biggest than 999");
            }

            Console.ReadLine();
        }

        public static void Exercise32()
        {
            int n = 237;

            int x = 237 / 100 + (237 - (237 / 100) * 100) * 10;

            Console.WriteLine("Number x: {0}", x);
        }


        public static void Exercise33()
        {
            Console.WriteLine("Input x: ");
            string inputX = Console.ReadLine();

            if (int.TryParse(inputX, out int x))
            {
                int lastDigit = (x - (x / 100) * 100) - 10 * ((x - (x / 100) * 100) / 10);

                int n = (x - lastDigit) / 10 + 100 * lastDigit;
                Console.WriteLine("n: {0}",n);

            }

            else { Console.WriteLine("Should be integer number between 100 and 999"); }
            Console.ReadLine();
        }

        public static void Exercise34()
        {
            int x = ((564 - (564 / 100) * 100) - ((564 - (564 / 100) * 100) / 10) * 10) * 100 + (564 - ((564 - (564 / 100) * 100) - ((564 - (564 / 100) * 100) / 10) * 10)) / 10;

            Console.WriteLine("x = {0}", x);

        }

        public static void Exercise35()
        {
            Console.WriteLine("Enter n");
            string inputN  = Console.ReadLine();

            if (int.TryParse(inputN, out int n) && n>=1 && n<=999)
            {
                int x = ((564 - (564 / 100) * 100) - ((564 - (564 / 100) * 100) / 10) * 10) * 100 + (564 - ((564 - (564 / 100) * 100) - ((564 - (564 / 100) * 100) / 10) * 10)) / 10;

                Console.WriteLine("x = {0}", x);
            }

            else
            {
                Console.WriteLine("n should be between 1 and 999");
            }

            Console.ReadLine();

        }

        public static void Exercise36()
        {
            int x = 100 * ((546 - 100 * (546 / 100)) / 10) + 10 * (546 / 100) + (546 - 100 * (546 / 100)) - 10 * ((546 - 100 * (546 / 100)) / 10);
            Console.WriteLine("x: {0}", x);
            Console.ReadLine();
        }

        public static void Exercise37()
        {

            Console.WriteLine("Enter n:");
            string inputN = Console.ReadLine();

            if(int.TryParse(inputN, out int n) && n>=0 && n<=999)
            {
                int x = 100 * ((n - 100 * (n / 100)) / 10) + 10 * (n / 100) + (n - 100 * (n / 100)) - 10 * ((n - 100 * (n / 100)) / 10);
                Console.WriteLine("x: {0}", x);
            }

            else { Console.WriteLine("n should be between 10 and 999"); }
            
            Console.ReadLine();
        }


    }


    class Program3
    {
        static void Main(string[] args)
        {
            //Chapter3.Exercise1();
            //Chapter3.Exercise2();
            //Chapter3.Exercise3();
            //Chapter3.Exercise4();
            //Chapter3.Exercise5();
            //Chapter3.Exercise6();
            //Chapter3.Exercise7();
            //Chapter3.Exercise8();
            //Chapter3.Exercise9();
            //Chapter3.Exercise10a();
            //Chapter3.Exercise10b();
            //Chapter3.Exercise10c();
            //Chapter3.Exercise11();
            //Chapter3.Exercise12();
            //Chapter3.Exercise13();
            //Chapter3.Exercise14();
            //Chapter3.Exercise15();
            //Chapter3.Exercise16();
            //Chapter3.Exercise17();
            //Chapter3.Exercise18();
            //Chapter3.Exercise19();
            //Chapter3.Exercise20();
            //Chapter3.Exercise21();
            //Chapter3.Exercise22();
            //Chapter3.Exercise23();
            //Chapter3.Exercise24();
            //Chapter3.Exercise25();
            //Chapter3.Exercise26();
            //Chapter3.Exercise27();
            //Chapter3.Exercise28();
            //Chapter3.Exercise29();
            //Chapter3.Exercise30();
            //Chapter3.Exercise31();
            //Chapter3.Exercise32();
            //Chapter3.Exercise33();
            //Chapter3.Exercise34();
            //Chapter3.Exercise35();
            //Chapter3.Exercise36();
            Chapter3.Exercise37();
        }
    }
}

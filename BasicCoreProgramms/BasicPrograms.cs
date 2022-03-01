using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramms
{
    public class BasicPrograms
    {
        public int head;
        public int tail;
        public int count;
        Random random = new Random();
        public void Check()
        {
            int count = 0;
            int headCount = 0;
            int tailCount = 0;
            float headPercent = 0;
            float tailPercent = 0;
            double toss = 0;
            Console.WriteLine("******** Tail and Head *********");
            do
            {
                Console.Write("Enter a positive integer: ");
                count = Convert.ToInt32(Console.ReadLine());
            } while (count < 0);
            for (int i = 0; i < count; i++)
            {
                toss = random.NextDouble();
                if (toss < 0.5)
                    headCount++;
                else
                    tailCount++;
            }
            headPercent = (float)headCount / (float)(headCount + tailCount);
            tailPercent = (float)tailCount / (float)(tailCount + headCount);
            Console.WriteLine("Head count: " + headCount + " Head Percent: " + headPercent);
            Console.WriteLine("Tail count: " + tailCount + " Tail Percent: " + tailPercent);
        }

        //Leap Year
        public void IsLeapYear()
        {
            int year;
            Console.WriteLine("******** Leap Year *********");
            Console.WriteLine("Enter the year");
            year = Convert.ToInt32(Console.ReadLine());

            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine("{0} Year is Leap year:", year);
            }
            else
            {
                Console.WriteLine("{0} Not leap year:", year);
            }

        }

        //power of 2
        public void isPowerOfTwo()
        {
            int no;
            int remainder;
            Console.WriteLine("******** Power Of Two *********");
            Console.WriteLine("Enter a no to check");
            no = Convert.ToInt32(Console.ReadLine());
            if (no == 1)
                Console.Write("It is power of 2.");
            else
            {
                while (no > 1)
                {
                    remainder = no % 2;
                    if (remainder != 0)
                        break;
                    no /= 2;
                }
                if (no == 1)
                    Console.WriteLine("It is a power of 2");
                else
                    Console.WriteLine("It is not a power of 2");
            }
        }
        //Harmonic No
       public static void HarmonicNo()
        {
            float harmonic = 0;
            Console.WriteLine("******** Harmonic Number **********");

            Console.WriteLine("Enter the number");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
                harmonic += (float)1 / (float)i;
            Console.WriteLine("Harmonic no of " + n + ": " + harmonic);
        }

        //Calulating Factors
        public static void Factors()
        {
            Console.WriteLine("******** Factors *********");
            Console.WriteLine("Enter the value of n:");
            int n = Convert.ToInt32(Console.ReadLine());
            bool prime = true;
            Console.WriteLine("The prime factors are: ");
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    prime = true;
                    for (int j = 2; j <= i / 2; j++)
                    {
                        if (i % j == 0)
                        {
                            prime = false;
                            break;
                        }
                    }
                    if (prime is true)
                        Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }

        //C# Program to Compute Quotient and Remainder

        public void division()
        {
            //Taking input from user
            Console.WriteLine("******** Quotient and Remainder *********");
            Console.WriteLine("Enter the value of divident");
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of divisor");
            int divisor = Convert.ToInt32(Console.ReadLine());
            int quotient = (dividend / divisor);
            int reminder = (dividend % divisor);
            Console.WriteLine("-----------Answer-----------");
            Console.WriteLine("The Quotient: " + quotient);
            Console.WriteLine("The Remainder are: " + reminder);

        }
    }
}


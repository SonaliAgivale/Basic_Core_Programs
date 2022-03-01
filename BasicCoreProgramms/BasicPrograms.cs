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
         static void HarmonicNo()
        {
            float harmonic = 0;
            Console.WriteLine("******** Harmonic Number **********");

            Console.WriteLine("Enter the number");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
                harmonic += (float)1 / (float)i;
            Console.WriteLine("Harmonic no of " + n + ": " + harmonic);
        }

        //Factors
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

        //C# Program to Swap Two Numbers
        public void SwapNo()
        {
            int num1 = 2;
            int num2 = 1;
            int temp = 0;
            Console.WriteLine("******** Swap Two Numbers *********");
            Console.WriteLine();
            Console.WriteLine("--------Before Swapping----------");
            Console.WriteLine("The value of num1 is: " + num1);
            Console.WriteLine("The value of num2 is: " + num2);
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("---------After Swapping--------");
            Console.WriteLine("The value of num1 is: " + num1);
            Console.WriteLine("The value of num1 is: " + num2);
        }

        //C# Program to Check Whether a Number is Even or Odd
        public void checkEvenOdd()
        {
            Console.WriteLine("******** Even or Odd Number ********");
            Console.WriteLine("Enter the number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 % 2 == 0)
            {
                Console.WriteLine("Entered number is Even");
            }
            else
            {
                Console.WriteLine("Entered number is odd");
            }
        }

        //C# Program to Check Whether an Alphabet is Vowel or Consonant
        public void checkVowel()
        {
            char ch;
            Console.WriteLine("******* Vowel or Consonant **********");
            Console.WriteLine("Enter any character: ");
            ch = Convert.ToChar(Console.ReadLine());


            // Condition for vowel checking
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {

                Console.WriteLine(ch + " is Vowel.");

            }
            else if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine(ch + " is Consonant.");
            }
        }

        //Largest number
        public void LargestNo()
        {
            int num1, num2, num3;
            Console.WriteLine("******* Largest Number *********");
            Console.Write("\n\n");
            Console.Write("Find the largest of three numbers:\n");
            Console.Write("------------------------------------");
            Console.WriteLine();
            Console.Write("Input the 1st number :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the  2nd number :");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the 3rd  number :");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("The 1st Number is the greatest among three. \n\n");
                }
                else
                {
                    Console.Write("The 3rd Number is the greatest among three. \n\n");
                }
            }
            else if (num2 > num3)
                Console.Write("The 2nd Number is the greatest among three \n\n");
            else
                Console.Write("The 3rd Number is the greatest among three \n\n");
        }
    }
    
}

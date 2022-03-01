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
    }
}


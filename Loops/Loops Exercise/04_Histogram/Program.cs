using System;

namespace _04_Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int counterGroupOne = 0;
            int counterGroupTwo = 0;
            int counterGroupThree = 0;
            int counterGroupFour = 0;
            int counterGroupFive = 0;

            for (int number = 1; number <= n; number++)
            {
                int value = int.Parse(Console.ReadLine());

                if (value < 200)
                {
                    counterGroupOne++;
                }

                else if (value >= 200 && value <= 399)
                {
                    counterGroupTwo++;
                }

                else if (value >= 400 && value <= 599)
                {
                    counterGroupThree++;
                }
                else if (value >= 600 && value <= 799)
                {
                    counterGroupFour++;
                }
                else
                {
                    counterGroupFive++;
                }
            }

            double p1 = counterGroupOne * 1.0 / n * 100;
            double p2 = counterGroupTwo * 1.0 / n * 100;
            double p3 = counterGroupThree * 1.0 / n * 100;
            double p4 = counterGroupFour * 1.0 / n * 100;
            double p5 = counterGroupFive * 1.0 / n * 100;

            Console.WriteLine($"{p1:F2}%");
            Console.WriteLine($"{p2:F2}%");
            Console.WriteLine($"{p3:F2}%");
            Console.WriteLine($"{p4:F2}%");
            Console.WriteLine($"{p5:F2}%");
        }
    }
}

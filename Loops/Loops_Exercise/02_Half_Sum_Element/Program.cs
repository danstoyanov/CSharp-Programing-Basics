using System;

namespace _02_Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int maxNum = int.MinValue;

            for (int i = 1; i <= n; i++)
            {
                int value = int.Parse(Console.ReadLine());
                sum += value;

                if (value > maxNum)
                {
                    maxNum = value;
                }
            }
            int numOther = sum - maxNum;

            if (numOther == maxNum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {maxNum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(maxNum - numOther)}");
            } 
        }
    }
}

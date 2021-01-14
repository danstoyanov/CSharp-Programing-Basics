using System;

namespace _06_Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int sum = 0;

            for (int counter = 0; counter < input.Length; counter++)
            { 
                if (input[counter] == 'a')
                {
                    sum += 1;
                }
                if (input[counter] == 'e')
                {
                    sum += 2;
                }
                if (input[counter] == 'i')
                {
                    sum += 3;
                }
                if (input[counter] == 'o')
                {
                    sum += 4;
                }
                if (input[counter] == 'u')
                {
                    sum += 5;
                }
            }
            Console.WriteLine(sum);
        }
    }
} 

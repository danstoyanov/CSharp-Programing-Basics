﻿using System;

namespace _08_Number_sequence
{
    class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            int maxNumber = int.MinValue;
            int minNumber = int.MaxValue;

            for (int i = 1; i <= input; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number > maxNumber)
                {
                    maxNumber = number;
                }

                if (number < minNumber)
                {
                    minNumber = number;
                }
            }
            Console.WriteLine($"Max number: {maxNumber}");
            Console.WriteLine($"Min number: {minNumber}");
        }
    } 
}  

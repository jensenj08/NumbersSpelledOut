﻿using System;
using EKJensen.NumbersSpelledOut;

namespace EKJensen.NumbersSpelledOut.Ui
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your number to be converted: ");
            string input = Console.ReadLine();
            var number = Convert.ToInt64(input);

            Console.WriteLine("The number you entered was: ");
            var fullNumberText = number.ToNumberString();
            Console.WriteLine(fullNumberText);

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
}

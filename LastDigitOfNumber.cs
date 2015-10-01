using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class LastDigitOfNumber
    {
        static void Main()
        {
            Console.Write("Please, enter your number: ");
            int number = int.Parse(Console.ReadLine());

            
            Console.WriteLine("The last digit of your integer number in english is {0}", GetLastDigitAsWord(number));
        }

        private static string GetLastDigitAsWord(int num)
        {
            string[] digitAsWord = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            int digit = num % 10;

            return digitAsWord[digit];
        }
    }


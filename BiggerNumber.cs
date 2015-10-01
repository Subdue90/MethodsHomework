using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class BiggerNumber
    {
        static void Main()
        {
            Console.WriteLine("Please, enter two numbers, each on a seperate line:");
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int max = GetMax(firstNumber, secondNumber);

            Console.WriteLine("The larger number is:");
            Console.WriteLine(max);
        }

        private static int GetMax(int a, int b)
        {
            int maxNum = (a > b) ? a : b;
            return maxNum;
        }
    }


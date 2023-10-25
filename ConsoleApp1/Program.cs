using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////1
            //int number = 10;
            //if (number % 7 == 0 || number % 3 == 0)
            //{
            //    Console.WriteLine("true");
            //}
            //else
            //{
            //    Console.WriteLine("false");
            //}
            ////1

            ////2
            //int number = 235;
            //int sum = (number / 100) + ((number / 10) % 10) + (number % 10);

            //Console.WriteLine(sum);
            ////2

            ////3
            //int number = 2853;
            //Console.WriteLine((number % 10) + "" + ((number / 10) % 10) + "" + ((number / 100) % 10) + "" + (number / 1000));
            ////3

            ////4
            //int number = 234;
            //Console.WriteLine(number % 10);
            ////4

            //5
            int num1 = 3;
            int num2 = 80;
            int result = 0;
            char digit = '*';

            if (digit == '+' || digit == '-' || digit == '*' || digit == '/')
            {
                switch (digit)
                {
                    case '+':
                        result = num2 + num1;
                        break;
                    case '-':
                        result = num2 - num1;
                        break;
                    case '*':
                        result = num2 * num1;
                        break;
                    case '/':
                        result = num2 / num1;
                        break;
                }
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("invalid input");
            }
            //5           
        }
    }
}

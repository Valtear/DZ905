using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            /*
            int input = 0;
            int even = 0, odd = 0;
            int evenSum = 0, oddSum = 0;

            input = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                if(i % 2 == 0)
                {
                    even++;
                    evenSum += i;
                }
                else
                {
                    odd++;
                    oddSum += i;
                }
            }

            Console.WriteLine($"even - {even}, evenSum - {evenSum}\nodd - {odd}, oddSum - {oddSum}");
            Console.ReadKey();
            */

            //2
            /*
            int[] arr = new int[5];
            int even = 0;
            int min = 0;

            Console.WriteLine("Fill array with 5 int numbers");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    even += arr[i];
                }
            }
            Console.WriteLine($"evenSumm - {even}");

            min = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            Console.WriteLine($"min - {min}");
            Console.ReadKey();
            */

            //3
            /*
            int num1 = 0, num2 = 0;
            char symb = ' ';
            int rez = 0;           

            Console.WriteLine("enter num1:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter +,-,*,/");
            symb = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("enter num2:");
            num2 = Convert.ToInt32(Console.ReadLine());

            //switch (symb)
            //{
            //    case '+':
            //        rez = num1 + num2;
            //        break;
            //    case '-':
            //        rez = num1 - num2;
            //        break;
            //    case '*':
            //        rez = num1 * num2;
            //        break;
            //    case '/':
            //        rez = num1 / num2;
            //        break;
            //    default:
            //        break;
            //}

            if(symb == '+')
            {
                rez = num1 + num2;
            }
            else if(symb == '-')
            {
                rez = num1 - num2;
            }
            else if (symb == '*')
            {
                rez = num1 * num2;
            }
            else if(symb == '/')
            {
                rez = num1 / num2;
            }

            Console.WriteLine($"{num1} {symb} {num2} = {rez}");
            Console.ReadKey();
            */
        }
    }
}

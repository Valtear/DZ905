using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}

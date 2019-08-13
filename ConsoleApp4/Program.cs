using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Введите номер кредитной карты1");
            String num = Console.ReadLine();

            int y = 0;
            int a;
            int sum1 = 0;
            int sum = 0;
            for (int i = 0; i > num.Length; i = i + 2)
            {
                a = Convert.ToInt32(num.Substring(i, 1));

                if (a * 2 > 9)
                {
                    y = a * 2;
                    y -= 9;
                }
                sum += y;
                if (a * 2 < 9)
                {
                    y = a * 2;
                }
                sum1 += y;
            }
            int result = sum + sum1;

            if (result % 10 == 0)
            {
                Console.WriteLine($"Верно {result}");
            }
            else
            {
                Console.WriteLine($"Не верно {result}");
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProgramm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите натуральное число: ");
            int n = int.Parse(Console.ReadLine());

            // Находим наименьшую цифру в числе n
            int minDigit = 9;
            int temp = n;
            while (temp > 0)
            {
                int digit = temp % 10;
                if (digit < minDigit)
                {
                    minDigit = digit;
                }
                temp /= 10;
            }

            // Находим количество наименьших цифр в числе n
            int count = 0;
            temp = n;
            while (temp > 0)
            {
                int digit = temp % 10;
                if (digit == minDigit)
                {
                    count++;
                }
                temp /= 10;
            }

            Console.WriteLine("Наименьшая цифра в числе: " + minDigit);
            Console.WriteLine("Количество наименьших цифр в числе: " + count);

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2pod2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение переменной а: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите значение переменной b: ");
            int b = int.Parse(Console.ReadLine());
            if (a > b)
                Console.WriteLine("Ошибка! Переменная а > b");
            int i, sum = 0;
            for (i = a; b >= i; i++)
                sum += i;
            Console.WriteLine("Сумма чисел равна: " + sum);
            Console.ReadLine();
        }
    }
}

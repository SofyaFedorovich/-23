using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Занятие_23
{
    class Program
    {
        
        //асинхронный код  для вычисления факториала числа
        static int a;
        static void Main(string[] args)
        {
            Console.WriteLine("Ввести целое число для вычисления факториала: ");
            a = Convert.ToInt32(Console.ReadLine());
            FactorialAsync();
            Console.ReadKey();
        }
        static int Factorial()
        {
            int factorial = 1;
            Console.WriteLine("Расчет выполняется");
            for (int i = 1; i <= a; i++)
            {
                factorial *= i;
            }
            Console.WriteLine($"{a}! = {factorial}");
            return factorial;
        }
        static async void FactorialAsync()
        {
            Console.WriteLine("Начало расчета");
            await Task.Run(() => Factorial());
            Console.WriteLine($"Факториал числа {a} найден!");
        }
    }
}

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
        //    //    static void Main(string[] args)
        //    //    {
        //    //        Console.Write("Введите число, факториал которого нужно найти ");
        //    //        int number = Convert.ToInt32(Console.ReadLine());

        //    //        BigInteger result = FactorialAsync(number).Result;
        //    //        Console.WriteLine("Факториал числа {0:0,0}", result);

        //    //        Console.ReadKey();
        //    //    }
        //    //    static BigInteger Factorial(int number) //метод возаращает значение
        //    //    {
        //    //        BigInteger fact = 0;
        //    //        Console.WriteLine("Идет расчет...");
        //    //        for (int i = 1; i <= number; i++)
        //    //        {
        //    //            fact *= (BigInteger)i;
        //    //            Thread.Sleep(500);
        //    //        }
        //    //        return (fact);
        //    //    }
        //    //    static async Task<BigInteger> FactorialAsync(int number)
        //    //    {
        //    //        Console.WriteLine(" Расчет запущен: ");
        //    //        BigInteger result = await Task.Run(() => Factorial(number));
        //    //        Console.WriteLine(" Расчет закончен");
        //    //        return result;
        //    //    }
        //    //}
        //    //асинхронный код  для вычисления факториала числа
        //    static int n;
        //    static void Main(string[] args)
        //    {
        //        Console.WriteLine("Ввести целое число для нахождения факториала: ");
        //        int n = Convert.ToInt32(Console.ReadLine());
        //        FactorialAsync();

        //        //BigInteger factorial = FactorialAsync(n).factorial;

        //        //Console.WriteLine($"{n}!={factorial}");
        //        Console.ReadKey();
        //    }
        //    static int Factorial (int n)

        //    {
        //        int factorial = 1;
        //        //Console.WriteLine("Начало расчета");
        //        for (int i = 1; i <= n; i++)
        //        {
        //            factorial *= i;
        //            //Thread.Sleep(100);
        //        }
        //        Console.WriteLine($"{n}!={factorial}");
        //        return factorial;

        //    }
        //    static async void FactorialAsync()

        //    {
        //        //Console.WriteLine("Расчет идет");
        //        await Task.Run(() => FactorialAsync());
        //        //FactorialAsync factorial = await Task.Run(() => factorial(n));
        //        //Console.WriteLine("Расчет выполнен");
        //        //return factorial;
        //    }


        //}
        static int n;
        static void Main(string[] args)
        {
            Console.WriteLine("Ввести целое число для нахождения факториала: ");
            n = Convert.ToInt32(Console.ReadLine());
            FactorialAsync();
            Console.ReadKey();
        }
        static int Factorial()
        {
            int fac = 1;
            for (int i = 1; i <= n; i++)
            {
                fac *= i;
            }
            Console.WriteLine($"{n}! = {fac}");
            return fac;
        }
        static async void FactorialAsync()
        {
            await Task.Run(() => Factorial());
        }
    }
}

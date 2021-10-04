using System;

namespace Homework_1_Task_1._1
{
    class Program
    {
        static long GetSqr(long num)
        {
            return num * num;
        }

        static void Main(string[] args)
        {
            long num;
            Console.Write("Введите число: ");

            while (!long.TryParse(Console.ReadLine(), out num) || num < -1_000_000 || num > 1_000_000)
            {
                Console.Error.WriteLine("Что-то пошло не так, повторите попытку!");
                Console.Write("Введите число: ");
            }

            Console.WriteLine("Квадрат " + num + " равен: " + GetSqr(num));
        }


    }
}

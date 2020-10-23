using System;

namespace Hometask2
{
    class Program
    {
        //Приходько. 2) Написать метод подсчета количества цифр числа.
        static int DigNumber(int num)
        {
            if (num / 10 == 0) return 1; else return (1 + DigNumber(num / 10));
        }
        static void IODigNumber()
        {
            Console.WriteLine("Введите число");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine(DigNumber(d));
        }
        //Приходько. 3) С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
        static int Sum()
        {
            int d = int.Parse(Console.ReadLine());
            if (d == 0) return d; else return (d + Sum());
        }


        static void Main(string[] args)
        {
           // IODigNumber();
            Console.WriteLine(Sum());
            Console.WriteLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;

namespace homeTask6
{
    class Program
    {
        #region task1
        /*Приходько. 1. Изменить программу вывода функции так, чтобы можно было передавать функции 
         * типа double (double, double). Продемонстрировать работу на функции с функцией 
         * a* x^2 и функцией a* sin(x)*/
        delegate double Func(double x, double a);

        static void Table(Func f, double x, double a, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, f(x,a));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }
        static double Func1(double x, double a)
        {
            return x + a * a;
        }
        static double Func2(double x, double a)
        {
            return a * Math.Sin(x);
        }
        #endregion
        #region task2
       /* Приходько. Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
        а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке 
       находить минимум.Использовать массив(или список) делегатов, в котором хранятся различные функции.
б) *Переделать функцию Load, чтобы она возвращала массив считанных значений.
       Пусть она возвращает минимум через параметр (с использованием модификатора out). */

        #region menu
        static void Menu()
        {
            Console.WriteLine("1 - f(x) = 3x^3 - 2x + 5;");
            Console.WriteLine("2 - f(x) = 2x^2-2x + 5");
            Console.WriteLine("3 - f(x) = sin(x)");
            Console.WriteLine("4 - f(x) = cos(2x)");
            Console.WriteLine("5 - f(x) = ax^2");
            Console.WriteLine("6 - f(x) = a sin(x)");
            Console.WriteLine("7 - выход");
        }
        static void IOMenu()
        {
            Function[] functions = {f1, f2, f4, f3, f5, f6}; //Function - prototype (see below)
            ConsoleKeyInfo choise;              //switcher
            do                                  //do in loop
            {
                Console.Clear();
                bool o; double a; double b;
                
                do                          //in loop
                {
                    Console.WriteLine("Введите нижнюю границу");
                    o = IONumber(out a); 
                }
                while (!o);             //to input number, but not other
                
                do                  //the same but with high border
                {
                    Console.WriteLine("Введите верхнюю границу");
                    o = IONumber(out b);
                }
                while (!o);
                Menu();
                choise = Console.ReadKey();
                if (choise.KeyChar != '7')      //7 is halt
                {
                    OutputFunc(functions[(int)Char.GetNumericValue(choise.KeyChar) - 1], a, b); //returns list (isn't implementated - redundant operation)
                    Console.WriteLine("Ваши данные записаны в файл sin.dat");
                    LookingForMin(out double min);  //returns min as out parametr
                    Console.WriteLine("{0:00.00}", min);
                    Console.ReadLine();
                }
            }
            while (choise.KeyChar != '7');
        }
        static bool IONumber(out double p)  //auxiliary method
        {
            bool o = double.TryParse(Console.ReadLine(), out p);
            if (!o) Console.WriteLine("Нужно было ввести число");
            return o;
        }
        #endregion
        #region Ввод-вывод в-из файла
        static List<double> OutputFunc(Function Sinus, double a, double b)
        {
            List<double> VCont = new List<double>();
            FileStream fs = new FileStream(AppDomain.CurrentDomain.BaseDirectory + @"\for files\sin.dat", FileMode.Create, FileAccess.Write);
            BinaryWriter f = new BinaryWriter(fs);
            double x=a; 
            while (x<=b)
            {
                f.Write(Sinus(x,a));
                VCont.Add(Sinus(x, a));
                x += 0.1;
            }
            f.Close();
            fs.Close();
            return VCont;
        }
        static void LookingForMin(out double min)
        {
            using (FileStream fs = new FileStream(AppDomain.CurrentDomain.BaseDirectory + @"\for files\sin.dat", FileMode.Open, FileAccess.Read))
            { 
                BinaryReader f = new BinaryReader(fs);
                min = f.ReadDouble(); double x;
                while (f.BaseStream.Position != f.BaseStream.Length)
                {
                    x = f.ReadDouble();
                    if (x < min) min = x;
                }
            }
        }
        #endregion
        #region functions
        delegate double Function(double x, double a);
        static double f1(double x, double a)
        {
            return 3 * Math.Pow(x, 3) - 2 * x + 5;
        }
        static double f2(double x, double a)
        {
            return 2*x*x-2*x + 5;
        }
        static double f3(double x, double a)
        {
            return Math.Cos(2 * x);
        }
        static double f4(double x, double a)
        {
            return Math.Sin( x);
        }
        static double f5(double x, double a)
        {
            return a * x * x;
        }
        static double f6(double x, double a)
        {
            return a*Math.Sin(x);
        }
        #endregion
        #endregion

        static void Main(string[] args)
        {
            /*Table(Func2, 3.1, 3*Math.PI/4, 4);
            Table(Func1, 3.1, 2, 9.1);
            OutputFunc(Math.Sin, -Math.PI, Math.PI / 2);
            Console.WriteLine("{0:0.0000}",LookingForMin());*/
            IOMenu();
            Console.ReadKey();
        }
    }
}

using Microsoft.VisualBasic.CompilerServices;
using System;

namespace Hometask3
{
    class Program
    {
        //Дописать структуру Complex, добавив метод вычитания комплексных чисел. 
        //Продемонстрировать работу структуры;
        #region struct
        /* struct complex
         {
             public double a;
             public double b;
             public complex add(complex x)
             {
                 complex y;
                 y.a = a + x.a;
                 y.b = b + x.b;
                 return y;
             }
             public complex mul(complex x)
             {
                 complex y;
                 y.a = a * x.a - b * x.b;
                 y.b = b * x.a + a * x.b;
                 return y;
             }
             public complex sub(complex x)
             {
                 complex y;
                 y.a = a - x.a;
                 y.b = b - x.b;
                 return y;
             }
             public override string ToString()
             {
                 return $"({a},{b}i)";
             }

         }
         static void InitComplex()
         {
             complex x; complex y; complex z;
             x.a = -5; x.b = -3;
             y.a = 17; y.b = -6;
             z = x;
             z = z.add(y);
             Console.WriteLine(z.ToString());
             z = x;
             z = z.sub(y);
             Console.WriteLine(z.ToString());
             z = x;
             z = z.mul(y);
             Console.WriteLine(z.ToString());

         }*/
        #endregion
        /*С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке).
         * Требуется подсчитать сумму всех нечетных положительных чисел.Сами числа и сумму
         * вывести на экран, используя tryParse;
        б) Добавить обработку исключительных ситуаций на то, что могут быть введены 
        некорректные данные.При возникновении ошибки вывести сообщение.Напишите 
        соответствующую функцию;*/
        #region tryParce
        static double Sum()
        {
            double d;
            bool o=double.TryParse(Console.ReadLine(), out d);
            if (!o) 
            {
                Console.WriteLine("Некорректный ввод");
                return Sum();
            } else
            {
                if (Math.Round(d) == 0) return 0;
                else
                if ((d > 0) && (d % 2 != 0))
                    return (d + Sum());
                else
                    return Sum();
            }
        }
        #endregion
        /*Описать класс дробей - рациональных чисел, являющихся отношением двух 
         * целых чисел.Предусмотреть методы сложения, вычитания, умножения и деления 
         * дробей. Написать программу, демонстрирующую все разработанные элементы класса.
         * Достаточно решить 2 задачи.Все программы сделать в одном решении.*/
            #region class_Fractions_Fields
        class fraction
        {
            public int a;
            private int b;
            public int c = 0;
            public int _b
            {
                get { return b; }
                set
                {
                    if (value == 0) throw new ArgumentException("Нулевой знаменатель");
                    else b = value;
                }
            }
            #endregion
            #region Fractions_Utilites
            private int NOD(int A, int B)
            {
                if (A < B) return NOD(A, B - A);
                else
                if (A > B) return NOD(A - B, B);
                else
                    return A;
            }
            private int NOK(int A, int B)
            {
                return A * B / NOD(A, B);
            }
            #endregion
            #region Fractions_Methods
            public void add(fraction x, fraction y)
            {
                x.toIncorrect(); y.toIncorrect();
                int nok = NOK(x.b, y.b);
                int mult1 = nok / x.b; int mult2 = nok / y.b;
                //fraction z = new fraction();
                a = x.a * mult1 + y.a * mult2;
                b = nok;
            }

            public void sub(fraction x, fraction y)
            {
                y.a = -y.a;
                add(x, y);
            }
            public void mul(fraction x, fraction y)
            {
                x.toIncorrect(); y.toIncorrect();
                a = x.a * y.a;
                b = x.b * y.b;
            }
            public void div(fraction x, fraction y)
            {
                int k = y.a; y.a = y.b; y.b = y.a; //swaping numerator and denominator
                mul(x, y);
            }
            public void toProper()
            {
                c = a / b;
                a = a % b;
            }
            public void toIncorrect()
            {
                a = c * b + a;
                c = 0;
            }
            public void toReduce()
            {
                int nod = NOD(a, b);
                a = a / nod;
                b = b / nod;
            }
            #endregion
            #region Fracitons_Operators
            public static fraction operator +(fraction x, fraction y)
            {
                fraction z = new fraction();
                z.add(x, y);
                return z;
            }
            public static fraction operator -(fraction x, fraction y)
            {
                fraction z = new fraction();
                z.sub(x, y);
                return z;
            }
            public static fraction operator *(fraction x, fraction y)
            {
                fraction z = new fraction();
                z.mul(x, y);
                return z;
            }
            public static fraction operator /(fraction x, fraction y)
            {
                fraction z = new fraction();
                z.div(x, y);
                return z;
            }
            #endregion
            public override string ToString()
            {

                if ((a < 0) && (b < 0)) { a = -a; b = -b; } //to delete excess '-'
                if (c == 0) return $"{a} / {b}";
                else
                {
                    if (a * b < 0) { c = -c; if (a < 0) a = -a; else b = -b; }//to remove '-' into whole part
                    return $"{c} {a} / {b}";
                }
            }
        }
        #region Menu
        static void Menu()
        {
            Console.WriteLine("1 - сложить 2 дроби");
            Console.WriteLine("2 - вычесть из одной дроби другую");
            Console.WriteLine("3 - умножить 2 дроби");
            Console.WriteLine("4 - разделить одну дробь на другую");
            Console.WriteLine("5 - упростить дробь");
            Console.WriteLine("6 - правратить дробь в правильную");
            Console.WriteLine("7 - превратить дробь в неправильную");
            Console.WriteLine("8 - выход");
        }
        static bool IONumber(out int p)
        {
            bool o = int.TryParse(Console.ReadLine(), out p);
            if (!o) Console.WriteLine("Нужно было ввести число");
            return o;
        }
        static void IOFract(fraction f)
        {
            bool o; int bb;
            do
            {
                Console.Write("Введите целую часть дроби --->");
                o = IONumber(out f.c);
            } while (!o);
            do
            {
                Console.Write("Введите числитель дроби --->");
                o = IONumber(out f.a);
            } while (!o);
            do
            {
                Console.Write("Введите знаменатель дроби --->");
                o = IONumber(out bb);
                f._b = bb;
            } while (!o);
        }
        static void IOMenu()
        {
            ConsoleKeyInfo choise;
            do
            {
                fraction x = new fraction();
                fraction y = new fraction();
                //fraction z = new fraction();
                Console.Clear();
                Menu();
                choise = Console.ReadKey();
                switch (choise.KeyChar)
                {
                    case '1':
                        IOFract(x);
                        IOFract(y);
                        Console.WriteLine(x + y);
                        break;
                    case '2':
                        IOFract(x);
                        IOFract(y);
                        Console.WriteLine(x - y);
                        break;
                    case '3':
                        IOFract(x);
                        IOFract(y);
                        Console.WriteLine(x * y);
                        break;
                    case '4':
                        IOFract(x);
                        IOFract(y);
                        Console.WriteLine(x / y);
                        break;
                    case '5':
                        IOFract(x);
                        x.toReduce();
                        Console.WriteLine(x);
                        break;
                    case '6':
                        IOFract(x);
                        x.toProper();
                        Console.WriteLine(x);
                        break;
                    case '7':
                        IOFract(x);
                        x.toIncorrect();
                        Console.WriteLine(x);
                        break;
                    default: continue;
                }
                Console.WriteLine("Нажмите любую клавишу, чтобы продолжить...");
                Console.ReadLine();
            }
            while (choise.KeyChar != '8');
        }
        #endregion
        static void Main(string[] args)
        {
            //InitComplex();  // for structures
            /*Complex x = new Complex(-5, -3);      //for class Complex
            Complex y = new Complex(17, -6);    //for class Complex
            Console.WriteLine(x + y);       //for demo addition of Complex numbers
            Console.WriteLine(x * y);       //for demo multiplication of Complex numbers
            y.sub(x);                       //for demo substraction of Complex numbers
            Console.WriteLine(y);*/
            IOMenu();                   //for demonstration of class fractions
            Console.ReadLine();

            
        }
    }
}

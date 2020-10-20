using System;

namespace Hometask1
{
    class Program
    {
        static void Survey()
        {
            /*Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес).В результате вся информация выводится в одну строчку:
            а) используя склеивание;
            б) используя форматированный вывод;
            в) используя вывод со знаком $.*/

            Console.WriteLine("Введите ваше имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите вашу фамилию");
            string fam = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст");
            string age = Console.ReadLine();
            Console.WriteLine("Введите ваш рост");
            string haight = Console.ReadLine();
            Console.WriteLine("Введите ваш вес");
            string weight = Console.ReadLine();
            Console.WriteLine("1) -> " + name + fam + age + haight + weight);
            Console.WriteLine("2) -> {0}, {1}, {2}, {3}, {4})", name, fam, age, haight, weight);
            Console.WriteLine($"3) -> Имя:{name}, Фамилия:{fam}, Возраст:{age}, Рост:{haight}, Вес:{weight})");
        }
        //-------------------------------------------------------------------
        static void IOIndex()
        {
            /*Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле I = m / (h * h); где m — масса тела в килограммах, h — рост в метрах.*/

            static float BodyWeightIndex(float height, float weight)
            {
                return weight * 10000 / (height * height);
            }

            Console.WriteLine("Введите рост и вес");
            int h = Convert.ToInt32(Console.ReadLine());
            int w = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0:f2}", BodyWeightIndex(h, w));
        }
        //-------------------------------------------------------------------

        static void IOPointDistance()
        {
            /*а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
            б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.*/

            static double PointDistance(double x1, double y1, double x2, double y2)
            {
                return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            }
            double xx1; double xx2; double yy1; double yy2;
            Console.WriteLine("Введите координаты первой точки (x, y)");
            xx1 = Convert.ToDouble(Console.ReadLine());
            yy1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты второй точки (x, y)");
            xx2 = Convert.ToDouble(Console.ReadLine());
            yy2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0:2f}", PointDistance(xx1, yy1, xx2, yy2));
        }
        //--------------------------------------------------------------------
        static void OutputMyPers() 
        {
         // а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            Console.WriteLine("Тимофей Приходько");
            Console.WriteLine("г. Оренбург");   
        }
        //б) *Сделать задание, только вывод организовать в центре экрана.
        static void CenterOut()
        {
            Console.SetCursorPosition(Console.WindowWidth/2, Console.WindowHeight/2);
            Console.WriteLine("Тимофей Приходько");
            Console.SetCursorPosition(Console.WindowWidth/2, Console.WindowHeight/2+1);
            Console.WriteLine("г. Оренбург");
        }
        // **Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).
        
        static void OutText(string what, int whereX, int WhereY)
        {
            Console.SetCursorPosition(whereX, WhereY);
            Console.WriteLine(what);
        }

        static void Main(string[] args)
        {
            //Survey();
            //IOIndex();
            //IOPointDistance();
            //OutputMyPers() ;
            //CenterOut();
            //OutText("Мама мыла раму", 10, 20);

            Console.WriteLine();

        }
    }
}

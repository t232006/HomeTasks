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
            if (d == 0) return d; else
            if ((d < 0) || (d % 2 == 0)) return Sum(); else
                return (d + Sum());
        }

        /*Приходько. Реализовать метод проверки логина и пароля.На вход метода подается 
        логин и пароль. На выходе истина, если прошел авторизацию, и ложь,
        если не прошел (Логин: root, Password: GeekBrains). Используя 
        метод проверки логина и пароля, написать программу: пользователь 
        вводит логин и пароль, программа пропускает его дальше или не 
        пропускает.С помощью цикла do while ограничить ввод пароля тремя 
        попытками.*/

        static void Check()
        {
            const byte AN = 3;  // AttemptNumber
            byte t = 0;
            string log; string pass;
            do
            {
                if (++t == AN + 1) break;
                Console.Write("Введите логин:   ");
                log = Console.ReadLine();
                Console.Write("Введите пароль:   ");
                pass = Console.ReadLine();
            } while (!(PasswordCheck(log, pass)));
            if (t == AN + 1) Console.WriteLine("Не пропускаю дальше"); //user has tried more then 3 times
            else Console.WriteLine("Пропускаю дальше");
        }
        static bool PasswordCheck(string login, string password)
        {
            if ((login == "root") && (password == "GeekBrains"))
                return true;
            else
            {
                Console.WriteLine("Что-то не так, где-то ошибка."); //prompt for faulted user
                return false;
            }
        }
        /*а) Приходько. Написать программу, которая запрашивает массу и рост человека, 
         * вычисляет его индекс массы и сообщает, нужно ли человеку похудеть,
         * набрать вес или всё в норме.*/
        static float Index(float weight, float height)
        {
            return weight / ((height / 100) * (height / 100));
        }
        /*Возражение по прошлому замечанию касаемое переноса делителя в числитель (Ind =weight * 10000 / (height*height))
        Я согласен с тем, что программы нужно делать как можно более простыми для понимания. Одновременно с этим,
        я также придерживаюсь другого принципа - не плодить лишних сущностей. Желательно не заводить лишних переменных там,
        где это не сильно нужно. Балансируя между этими принципами в этом конкретном случае я бы выбрал второй.
        В решении, показанном выше, присутствует дополнительное арифметическое действие, что в общем случае лучше избегать*/
        static string DefineInd(float Ind)
        {
            if (Ind < 16) return "Выраженный дифицит массы тела"; else
            if (Ind < 18.5) return "Недостаточная масса тела"; else
            if (Ind < 25) return "Норма"; else
            if (Ind < 30) return "Избыточная масса тела"; else
            if (Ind < 35) return "Ожирение"; else
            if (Ind < 40) return "Ожирение резкое"; else
                return "Очень резкое ожирение";
        }
        /*Приходько. Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.*/
        static string Correction(float Weight,float Height, float currentInd)
        {
            if (currentInd < 18.5)
            {
                float normWeight = (float)(18.5) * Height * Height / (100 * 100);    
                return ($"Необходимо добрать {Math.Ceiling(normWeight - Weight)} килограмм"); //to add as least 1 kg
            }
            if (currentInd > 25)
            {
                float normWeight = 25 * Height * Height / (100 * 100);
                return ($"Необходимо сбросить {Math.Ceiling( Weight - normWeight)} килограмм");//to drop as least 1 kg
            }
            else return ("Ничего не надо делать, вроде, всё в норме");
        }

        static void MainDefInd()
        {
            Console.Write("Введите рост:    ");
            float height1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите вес:     ");
            float weight1 = Convert.ToSingle(Console.ReadLine());
            float index = Index(weight1, height1);
            Console.WriteLine($"Индекс массы тела равен {index:f2}");
            Console.WriteLine(DefineInd(index));
            Console.WriteLine(Correction(weight1,height1, index));
        }

        /*Приходько Написать программу подсчета количества «хороших» чисел в диапазоне 
         * от 1 до 1 000 000 000. «Хорошим» называется число, которое делится 
         * на сумму своих цифр.Реализовать подсчёт времени выполнения программы, 
         * используя структуру DateTime.*/

        const int HighLimit = 1000000000;
        static uint SumDig(uint Dig)
        {
            if (Dig == 0) return 0;
            else
            {
                return ((Dig % 10)+ SumDig(Dig / 10));
            }
        }

        static uint GoodDigRecursion(uint i)
        {
            if (i == 1) return 1; else
            {
                if (i % SumDig(i) == 0) 
                return (1 + GoodDigRecursion(i - 1));
                    else
                return GoodDigRecursion(i - 1);
            }
        }

         static uint GoodDigBar()       //для интереса, насколько дольше будет выполняться при добавлении
            {                               //8 действий
                ushort Sum = 0;
            for (uint i = 0; i <= 99; i++)
            {
                for (uint j = 1; j <= 10000000; j++)    
                    if ((i * 10000000 + j) % SumDig(i * 10000000 + j) == 0) Sum++;
                Console.SetCursorPosition(1, 2);
                Console.WriteLine(i+1 + "% готово"); 
            }
                return Sum;
            
            }
        static uint GoodDig()
        {
            ushort Sum = 0;
            for (uint i = 1; i <= HighLimit; i++)
            {
                    if (i % SumDig(i) == 0) Sum++;
            }
            return Sum;
        }


        static void Main(string[] args)
        {

            // IODigNumber();
            //Console.WriteLine(Sum());
            //Check();
            //MainDefInd();
            DateTime Start = DateTime.Now;
            Console.WriteLine(GoodDigBar());
            Console.WriteLine($"Выполнено за {DateTime.Now-Start:hh\\:mm\\:ss} секунд");

            Start = DateTime.Now;
            Console.WriteLine(GoodDig());
            Console.WriteLine($"Выполнено за {(DateTime.Now - Start):hh\\:mm\\:ss} секунд");

            /*Start = DateTime.Now;             //рекурсивный вообще выпал на 10000
            Console.WriteLine(GoodDigRecursion(HighLimit));
            Finish = DateTime.Now;
            Console.WriteLine($"Выполнено за {(Finish - Start):hh\\:mm\\:ss} секунд");*/
            Console.WriteLine();

        }
    }
}

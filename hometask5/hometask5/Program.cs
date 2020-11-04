using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace hometask5
{
    #region class Message
    /*Приходько. Разработать класс Message, содержащий следующие статические методы для обработки
текста:*/

    class Message
    {
        string s;
        string[] ss;
        public Message(string mess)
        {
            s = mess;
        }
        private void separator()
        {
            char[] sep = { ' ' };
            ss = s.Split(sep);
        }
        //а) Вывести только те слова сообщения, которые содержат не более n букв.
        public string NotMore(byte n)
        {
            string S = "";
            separator();
            foreach (string temp in ss)
                if (temp.Length <= n) S = S + ' ' + temp;
            return S;
        }
        //б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
        public string StartsWith(char letter)
        {
            separator();
            for (int i = 0; i < ss.Length; i++)
                if (ss[i][0] == letter) ss[i] = "";
            s = string.Join(' ', ss);
            return s;
        }
        //в) Найти самое длинное слово сообщения.
        public string Longest(out byte max)     //out - for next task for universality
        {
            separator();
            max = (byte)ss[0].Length;
            string temp = ss[0];
            for (int i = 0; i < ss.Length; i++)
                if (ss[i].Length > max)
                {
                    temp = ss[i];
                    max = (byte)ss[i].Length;
                }
            return temp;
        }
        //г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
        public StringBuilder SomeLongest()
        {
            StringBuilder col = new StringBuilder();
            byte _max;
            { string temp = Longest(out _max); } // temp - is just only plug, then kill the variable
            foreach (string temp in ss)         //temp - is the stame name of another variable
                if (temp.Length == _max) col.Append(temp);
            return col;
        }
    }
    #endregion
    class Program
    {
        #region login
        /* Приходько
         * Создать программу, которая будет проверять корректность ввода логина.
         * Корректным логином будет строка от 2 до 10 символов, содержащая только 
         * буквы латинского алфавита или цифры, при этом цифра не может быть первой:
        а) без использования регулярных выражений;*/
        static bool login1(string s)
        {
            char[] cc = s.ToCharArray();
            if ((s.Length < 2) || (s.Length > 10)) return false; else
            {
                foreach (char c in cc)
                    if (!char.IsLetterOrDigit(c)) return false; else
                    if (c > '\u007b') return false;
            }
            if (char.IsDigit(cc[0])) return false; else return true;
        }

        /*б) с использованием регулярных выражений*/
        static bool login2 (string s)
        {
            Regex reg = new Regex("^[a-z][a-z0-9]{1,9}$",RegexOptions.IgnoreCase);
            if (reg.IsMatch(s)) return true; else return false;
        }
        #endregion
        #region textfile Message
        /*Приходько
         * Продемонстрируйте работу программы на текстовом файле с вашей программой*/
        static void TextDemonstration(string textfilename)
        {
            string MyMessage = Console.ReadLine();
            
            Message mes = new Message(MyMessage);
            StreamWriter f = new StreamWriter(textfilename,false);
            f.WriteLine(MyMessage);
            f.Write("Самое длинное слово в сообщении: ");
            byte n;
            f.WriteLine(mes.Longest(out n));
            f.WriteLine("Формирую StringBuilder со всеми словами этой же длины:");
            f.WriteLine(mes.SomeLongest());
            Console.Write("вывести слова не более --->");
            byte.TryParse(Console.ReadLine(), out n);
            f.WriteLine(mes.NotMore(n));
            Console.Write("удалить слова на букву --->");
            char c = Console.ReadKey().KeyChar;
            f.WriteLine("Удалены слова на букву " + c);
            f.WriteLine(mes.StartsWith(c));
            Console.WriteLine("Посмотрите файл " + textfilename + ", там результат выполнения");
            f.Close();
        }
        #endregion
        #region comparation
        /*Приходько
         * *Для двух строк написать метод, определяющий, является ли одна строка перестановкой 
         * другой.Регистр можно не учитывать:*/
        //разработать свой собственный алгоритм
        static ushort[] LettersCount(string s)
        {
            ushort[] mas=new ushort[1104]; //every cell has addres which is equal with
            foreach (char let in s)     //symbol's unicode, and 1103 - last cell for 
                mas[let]++;             //я - letter
            return mas;
        }
        static bool Comparison1(string s1, string s2)    
        {
            if (s1.Length != s2.Length) return false; //strings have different length
            ushort[] mas1 = LettersCount(s1);       //they consist of the same letters
            ushort[] mas2 = LettersCount(s2);   //and their amount is equal
            for (short i = 0; i <= 1103; i++)
                if (mas1[i] != mas2[i]) return false;
            return true;
        }
        static bool Comparison2(string s1, string s2)
        {
            char[] cs1 = s1.ToCharArray();
            char[] cs2 = s2.ToCharArray();
            Array.Sort(cs1); Array.Sort(cs2);
            string ss1=cs1.ToString(); string ss2 = cs2.ToString();
            return ss1.Equals(ss2);
        }
        #endregion
        #region ЕГЭ
        //Приходько Задача ЕГЭ
        struct pupil
        {
            public string name;
            public string last;
            public byte opr1;
            public byte opr2;
            public byte opr3;
            public float everage()
            {
                return (float)(opr1 + opr2 + opr3) / 3;
            }      
        }
        static void readFile(string filename)
        {
            StreamReader f = new StreamReader(filename);
            byte col = byte.Parse(f.ReadLine());
            pupil[] pupils = new pupil[col];
            for (byte i=0; i<col; i++)      //moving all records to array of struct
            {
                string s = f.ReadLine();
                string[] data = s.Split(' ');
                pupils[i].name = data[0];
                pupils[i].last = data[1];
                pupils[i].opr1 = byte.Parse(data[2]);
                pupils[i].opr2 = byte.Parse(data[3]);
                pupils[i].opr3 = byte.Parse(data[4]);
            }
            float min = (float)5.1;     //min is exactly more every record
            for (byte ii = 1; ii <= 3; ii++)    //searching 3 min record
            {
                for (byte i = 0; i < col; i++)
                    if (pupils[i].everage() <= min)
                        min = pupils[i].everage();  //have found min everage
                for (byte i = 0; i < col; i++)      //searching same everages
                    if (min.CompareTo(pupils[i].everage()) == 0)
                    {
                        Console.WriteLine($"{pupils[i].name} {pupils[i].last}");
                        pupils[i].opr1 = 100;   //excluding found record
                    }
                min = (float)5.1;
            }
        }
        #endregion
        struct quest
        {
            public string question;
            public bool answer;
        }
        
        static quest[] readfile1(string filename)
        {
            quest[] mas = new quest[5];     //conteiner for 5 questions
            List<byte> cont = new List<byte>(); //conteiner for unique selection
            Random d = new Random(); byte dd;   //generator of questions
            for (byte i = 0; i < 5; i++)    //5 iterations
            {
                using (StreamReader f = new StreamReader(filename)) //to kill variable
                {
                    do
                        dd = (byte)d.Next();    //generating another question
                    while (cont.Contains(dd));  //controlling unique question
                    cont.Add(dd);           //have found unique, adding to conteiner-it has stopped be unique
                    for (byte ii = 0; ii < dd; ii++)    //moving along file to appropriate string according number
                    {
                        f.ReadLine();       //dropping through 2 strings
                        f.ReadLine();
                    }
                    mas[i].question = f.ReadLine();
                    mas[i].answer = (f.ReadLine() == "верно" ? true : false);
                }
            }
            return mas;
        }
        static void InputQuest(string filename)
        {
            byte score = 0;
            quest[] mas = new quest[5];
            mas = readfile1(filename);
            for (byte i = 0; i < 5; i++)
            {
                Console.WriteLine(mas[i].question);
                Console.WriteLine("1-Верно \n 2-Неверно");
                char key; bool youranswer;
                do
                { 
                    key = Console.ReadKey().KeyChar;
                    youranswer = key == '1' ? true : false; 
                }
                while (key != '1' && key != '2');
                if (youranswer == mas[i].answer) score++;
                Console.Clear();
            }
            Console.WriteLine("Вы правильно ответили на "+score+" вопросов");
        }
        static void Main(string[] args)
        {
            /*string log = Console.ReadLine();
            Console.WriteLine(login1(log));
            Console.WriteLine(login2(log));*/
            //TextDemonstration("DemoText.txt");
            /*string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            
            Console.WriteLine(Comparison1(s1, s2));
            Console.WriteLine(Comparison2(s1, s2));*/
            //readFile("Pupils.txt");
            InputQuest("Believe.txt");
            Console.ReadKey();
        }
    }
}

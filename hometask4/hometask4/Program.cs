using System;
using System.IO;

namespace hometask4
{
    class Program
    {
       /**Добавьте статический метод для считывания массива из текстового файла.
        * Метод должен возвращать массив целых чисел;
        в)**Добавьте обработку ситуации отсутствия файла на диске.*/

        static int[] ReadFromFile(string filename)
        {
            try
            {
                string[] ss = File.ReadAllLines(filename);
                int[] mas = new int[ss.Length];
                for (int i = 0; i < ss.Length; i++)
                    mas[i] = int.Parse(ss[i]);
                return mas;
            }
            catch (Exception e)
            { throw e; }
            finally { };
        }

       /* static void WriteToFile(int[] mas, string filename)
        {
            StreamWriter f = new StreamWriter(filename);
            foreach (int i in mas)
                f.WriteLine(i);
            f.Close();

        }*/
        
        static void Main(string[] args)
        {
            //MyArray m = new MyArray(20,-10,10);
            //MyArray m = new MyArray(20, -50, -30);
            LoginCheck lch = new LoginCheck();
            lch.Check();
            /*Console.WriteLine(m.CheckPairs(3));
            m.OutMas();
            m.PrintJournal();
            //int[] mm = ReadFromFile("MasFile.txt");
            //WriteToFile(mm, "MasFile1.txt");*/
            Console.WriteLine();
        }

    }
}

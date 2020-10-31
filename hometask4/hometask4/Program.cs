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
            //MyArray m = new MyArray(20,-10,10);               //constructor for 1st task
            //MyArray m = new MyArray(20, -50, (short)-30);     //constructor for 2nd task

            /*Console.WriteLine(m.CheckPairs(3));               //Outputs amount of pairs
            m.OutMas();                                         //Outputs array     
            m.PrintJournal();                                   //Outputs list of elemtnts and them amount
            //int[] mm = ReadFromFile("MasFile.txt");           //Static method for file reading
            //WriteToFile(mm, "MasFile1.txt");*/                //For previous method validation
            LoginCheck lch = new LoginCheck();
            lch.Check();                                        //Login Check
            Console.WriteLine();
        }

    }
}

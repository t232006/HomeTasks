using System;
using System.Collections.Generic;
using System.Text;

namespace hometask4
{
    public class MyArray
    {
        int[] mas;
        Dictionary<int, int> Journal;

        /*Дан целочисленный  массив из 20 элементов.Элементы массива  могут принимать  целые значения  
         * от –10 000 до 10 000 включительно.Заполнить случайными числами.*/
        public MyArray(short amaunt, int LoLim, int HiLim)
        {
            mas = new int[amaunt];
            Random rand = new Random();
            for (int i = 0; i < amaunt; i++)
                mas[i] = rand.Next(LoLim, HiLim);
        }
        public MyArray(short amaunt, int Start, short Step)
        {
            mas = new int[amaunt];
            Random rand = new Random();
            for (int i = 0; i < amaunt; i++)
                mas[i] = Start + i * Step;
        }
        /*Написать программу, позволяющую 
         * найти и вывести количество пар элементов массива, в которых только одно число делится на 3. 
         * В данной задаче под парой подразумевается два подряд идущих элемента массива.Например, для 
         * массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2. */
        public short CheckPairs(short divisor)
        {
            short c = 0;
            for (int i = 0; i < mas.Length - 1; i++)
            {
                if (mas[i] % divisor == 0) c++;
                else if (mas[i + 1] % divisor == 0) c++;
            }
            return c;
        }
        private void CreateJournal()
        {
            Journal = new Dictionary<int, int>();
            for (int i = 0; i < mas.Length; i++)
            {
                if (Journal.ContainsKey(mas[i])) Journal[mas[i]]++;
                else
                    Journal.Add(mas[i], 1);
            }
        }
        public void PrintJournal()
        {
            CreateJournal();
            foreach (KeyValuePair<int,int> keyValue in Journal)
            {
                Console.WriteLine($"{keyValue.Key} ===> {keyValue.Value}");
            }
        }

        public void OutMas()
        {
            foreach (int k in mas)
                Console.Write($"{k} ");
            Console.WriteLine();
        }
    }
}

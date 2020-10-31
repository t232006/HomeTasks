using System;
using System.Collections.Generic;
using System.IO;

namespace hometask4
{
    /*Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив.
     * Создайте структуру Account, содержащую Login и Password.*/

    public class LoginCheck
    {
        struct account
        {
           public string login;
           public string password;
        }
        account[] entitys;
        
        private void LoadFromFile()
        {
            StreamReader  f = new StreamReader("logins.txt");
            entitys = new account[sbyte.Parse(f.ReadLine())];
            for (sbyte i=0; i < entitys.Length; i++)
            {
                string ss = f.ReadLine();
                entitys[i].login = ss.Substring(0, ss.IndexOf(' '));  //from 1st to space;
                entitys[i].password = ss.Substring(ss.IndexOf(' ') + 1);
            }
        }

        private sbyte SeekRec(string login)
        {
            for (sbyte i = 0; i < entitys.Length; i++)
                if (login == entitys[i].login) return i;
            return -1;
        }
        public void Check()
        {
            LoadFromFile();
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
        bool PasswordCheck(string login, string password)
        {
            sbyte ii = SeekRec(login);
            if ((ii != -1) && (entitys[ii].password == password)) return true;
            else
            {
                Console.WriteLine("Что-то не так, где-то ошибка."); //prompt for faulted user
                return false;
            }
        }   
    }

    


    /*static void Check()
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
    */
}

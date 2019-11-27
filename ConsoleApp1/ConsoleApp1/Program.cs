using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
  Console.Write("Введите свою электронную почту:");  // Решение АИ
            var str = Console.ReadLine();
            var index = str.IndexOf('@');
            var mailBox = str.Substring(0, index);
            var mailservice = str.Substring(index + 1);


            Console.WriteLine("Ваш почтовый ящик {0} находиться на сервисе {1}", mailBox, mailservice); // 2 вариант вывода

            //Console.WriteLine("Ваш почтовый ящик " + mailBox  //1 вариант вывода
            //   + " находиться на сервисе  " + mailservice);




            //string[] words = str.Split(new char[] { '@' });  // Мое решение
            //foreach (string s in words)
            //{

            //    Console.WriteLine(s);
            //}


        }
    }
}
    
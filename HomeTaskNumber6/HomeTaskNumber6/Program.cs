using System;

namespace HomeTaskNumber6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите логическое значение x");
            //bool x = bool.Parse(Console.ReadLine());
            //Console.WriteLine("Введите логическое значение y");
            //bool y = bool.Parse(Console.ReadLine());

            var x = GetLogical("x");
            var y = GetLogical("y");
            Print("x ={0}", x);
            Print("y={0}", y);
            Print("!x= {0}", !y);
            Print("!y={0}", !y);
            Print("x | y={0},x || y");
            Print("x ^ y={0},x ^ y");

            Console.ReadKey();
        }

        static bool GetLogical(string message)
        {
            Console.WriteLine( " Введите логическое значение " + message);
            return bool.Parse(Console.ReadLine());
        }


        static void Print(string template, bool value )
        {
            Console.WriteLine(template, value);
        }
    }
}

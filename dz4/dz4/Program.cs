using System;

namespace dz4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите символ");
            char x = char.Parse(Console.ReadLine());
            int hex = Convert.ToInt32(x);
            Console.WriteLine("0x{ 0},0x{1}", hex, hex + 1);
            Console.ReadKey();
       
           
            
                
            
           

        }
    }
}

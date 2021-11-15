using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4._1
{
    class Program
    {
        string a, b;
        static void Main(string[] args)
        {
            sniffconsole();
            sniffmenu();
        }
        static void sniffconsole()
        {
            Console.WriteLine("menu:");
            Console.WriteLine("Numpad 1:Введи А");
            Console.WriteLine("Numpad 2:Введи B");
            Console.WriteLine("Numpad 3:Сложение");
            Console.WriteLine("Numpad 4:Вычетание");
            Console.WriteLine("Numpad 5:Умножение");
            Console.WriteLine("Numpad 6:Деление");
        }
        static void sniffmenu()
        {
            var input = Console.ReadKey();
            switch (input.Key) //Switch on Key enum
            {
                case ConsoleKey.NumPad1:
                    Console.WriteLine("menu:1");
                    sniffmenu();
                    break;
                case ConsoleKey.NumPad2:
                    Console.WriteLine("menu:2");
                    sniffmenu();
                    break;
                case ConsoleKey.NumPad3:
                    Console.WriteLine("menu:3");
                    sniffmenu();
                    break;
                case ConsoleKey.NumPad4:
                    Console.WriteLine("menu:4");
                    sniffmenu();
                    break;
                case ConsoleKey.NumPad5:
                    Console.WriteLine("menu:5");
                    sniffmenu();
                    break;
                case ConsoleKey.NumPad6:
                    Console.WriteLine("menu:6");
                    sniffmenu();
                    break;

            }
            Console.ReadKey();
        }
    }
}

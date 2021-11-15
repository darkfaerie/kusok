using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4._1
{
    class Program
    {
        public static string ads, bd;
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
                    Console.WriteLine("Введи А");
                    ads = Console.ReadLine();
                    sniffmenu();
                    break;
                case ConsoleKey.NumPad2:
                    Console.WriteLine("Введи B");
                    bd = Console.ReadLine();
                    sniffmenu();
                    break;
                case ConsoleKey.NumPad3:
                    Console.WriteLine($"Получили что-то такое:{Convert.ToInt32(ads) + Convert.ToInt32(bd)}");
                    sniffmenu();
                    break;
                case ConsoleKey.NumPad4:                   
                    Console.WriteLine($"Получили что-то такое:{Convert.ToInt32(ads) - Convert.ToInt32(bd)}");
                    sniffmenu();
                    break;
                case ConsoleKey.NumPad5:
                    Console.WriteLine($"Получили что-то такое:{Convert.ToInt32(ads) * Convert.ToInt32(bd)}");
                    sniffmenu();
                    break;
                case ConsoleKey.NumPad6:
                    Console.WriteLine($"Получили что-то такое:{Convert.ToInt32(ads) / Convert.ToInt32(bd)}");
                    sniffmenu();
                    break;

            }
            Console.ReadKey();
        }
    }
}

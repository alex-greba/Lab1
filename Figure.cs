using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLab1
{
    public abstract class Figure
    {
        public int ColorNumber;
        public int ChoiceColor()//выбор цвета в МЕНЮ
        {
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "9": Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine("Blue"); break;
                case "10": Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Green"); break;
                case "11": Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine("Cyan"); break;
                case "12": Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Red"); break;
                case "13": Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("Magenta"); break;
                case "14": Console.ForegroundColor = ConsoleColor.Yellow; Console.WriteLine("Yellow"); break;
                default: Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("Default"); return 15;
            }
            return Convert.ToInt32(choice);
        }
        public void ColorForPrint(int c)//установка цвета для печати
        {
            switch (c)
            {
                case 9: Console.ForegroundColor = ConsoleColor.Blue; break;
                case 10: Console.ForegroundColor = ConsoleColor.Green; break;
                case 11: Console.ForegroundColor = ConsoleColor.Cyan; break;
                case 12: Console.ForegroundColor = ConsoleColor.Red; break;
                case 13: Console.ForegroundColor = ConsoleColor.Magenta; break;
                case 14: Console.ForegroundColor = ConsoleColor.Yellow; break;
                default: Console.ForegroundColor = ConsoleColor.White; break;
            }
        }
        public abstract string PrintName();
        public abstract string Print();

    }

}

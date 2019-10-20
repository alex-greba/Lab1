using System;

namespace ConsoleAppLab1
{
    class Program
    {
        static void Main(string[] args)
        {

            var array = new Figure[5];
            array[0] = new Pr();
            array[1] = new Tr();
            array[2] = new Rmb();
            array[3] = new Prll();
            array[4] = new MnUg();

            Console.WriteLine("Blue = 9 | Green = 10 | Cyan = 11\n" +
                "Red = 12 | Magenta = 13 | Yellow = 14\n" +
                "         DEFAULT = White\n" +
                "ВЫБЕРИТЕ ЦВЕТА ДЛЯ ПРЕДЛОЖЕННЫХ ФИГУР");
            foreach (Figure fig in array)//для МЕНЮ
            {
                Console.ResetColor();
                Console.WriteLine(fig.PrintName() + " = ");
                fig.ColorNumber = fig.ChoiceColor();
                Console.ResetColor();
            }
            Console.Clear();
            foreach (Figure fig in array)//для вывода результата
            {
                fig.ColorForPrint(fig.ColorNumber);
                Console.WriteLine(fig.PrintName());
                Console.WriteLine(fig.Print());
                Console.WriteLine("");
            }
            Console.ResetColor();
        }
    }
}

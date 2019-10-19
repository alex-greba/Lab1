using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLab1
{
    public class Pr : Figure
    {
        public override string Print()
        {
            return
            "\n******\n*    *\n*    *\n*    *\n*    *\n******";
        }
        public override string PrintName()
        {
            return "Прямоугольник";
        }
    }
}

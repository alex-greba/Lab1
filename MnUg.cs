using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLab1
{
    public class MnUg : Figure
    {
        public override string Print()
        {
            return
                "\n    ***    " +
                "\n  *     *  " +
                "\n*         *" +
                "\n*         *" +
                "\n  *     *  " +
                "\n    ***    \n";
        }
        public override string PrintName()
        {
            return "Многоугольник";
        }
    }
}

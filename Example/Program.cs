using System;
using System.Collections.Generic;
using static System.Console;

namespace Example
{
    class Program
    {
        static void Pause() => ReadLine();

        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 3, '#');
            p2.Draw();

            HorizontalLine hLine = new HorizontalLine(7, 10, 2, '$');
            hLine.Draw();

            Pause();
        }
    }
}
using System;
using static System.Console;

namespace Example
{
    class Program
    {
        static void Pause() => ReadLine();

        static void Main(string[] args)
        {
            HorizontalLine upLine = new HorizontalLine(0, 79, 0, '-');
            HorizontalLine downLine = new HorizontalLine(0, 79, 22, '-');
            VerticalLine leftLine = new VerticalLine(1, 0, 22, '+');
            VerticalLine rightLine = new VerticalLine(78, 0, 22, '+');
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();

            SetCursorPosition(10, 10);
            Pause();
        }
    }
}
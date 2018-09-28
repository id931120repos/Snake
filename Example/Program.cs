using System;
using static System.Console;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 1;
            int y1 = 3;
            char sym1 = '*';

            //SetCursorPosition(x1, y1);
            //WriteLine(sym1);
            Draw(x1, y1, sym1);

            int x2 = 4;
            int y2 = 5;
            char sym2 = '#';

            //SetCursorPosition(x2, y2);
            //WriteLine(sym2);
            Draw(x2, y2, sym2);

            Pause();
        }

        static void Pause() => ReadLine();

        static void Draw(int x, int y, char sym)
        {
            SetCursorPosition(x, y);
            WriteLine(sym);
        }
    }
}
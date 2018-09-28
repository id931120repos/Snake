using System;
using static System.Console;

namespace Example
{
    public class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point(int x, int y, char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }

        public void Draw()
        {
            SetCursorPosition(x, y);
            WriteLine(sym);
        }
    }
}
using System;
using System.Threading;
using static System.Console;

namespace Example
{
    class Program
    {
        static void Pause() => ReadLine();

        static void Main(string[] args)
        {
            //SetBufferSize(80, 24);

            //HorizontalLine upLine = new HorizontalLine(0, 79, 0, '+');
            //HorizontalLine downLine = new HorizontalLine(0, 79, 22, '+');
            //VerticalLine leftLine = new VerticalLine(1, 0, 22, '+');
            //VerticalLine rightLine = new VerticalLine(78, 0, 22, '+');
            //upLine.Draw();
            //downLine.Draw();
            //leftLine.Draw();
            //rightLine.Draw();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            while (true)
            {
                if (KeyAvailable)
                {
                    ConsoleKeyInfo key = ReadKey();
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }
        }
    }
}
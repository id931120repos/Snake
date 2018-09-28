using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Example
{
    public class Snake : Figure
    {
        public Direction direction;

        public Snake(Point tail, int leight, Direction direction)
        {
            this.direction = direction;
            pList = new List<Point>();

            for (int i = 0; i < leight; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        public void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            //Thread.Sleep(1000);
            tail.Clear();
            //Thread.Sleep(1000);
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextpoint = new Point(head);
            nextpoint.Move(1, direction);
            return nextpoint;
        }

        public void HandleKey(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.RightArrow:
                    direction = Direction.RIGHT;
                    break;
                case ConsoleKey.LeftArrow:
                    direction = Direction.LEFT;
                    break;
                case ConsoleKey.UpArrow:
                    direction = Direction.UP;
                    break;
                case ConsoleKey.DownArrow:
                    direction = Direction.DOWN;
                    break;
                case ConsoleKey.Spacebar:
                    direction = Direction.STOP;
                    break;
            }
        }
    }
}
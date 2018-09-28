using System;
using System.Collections.Generic;

namespace Example
{
    public class Snake : Figure
    {
        public Snake(Point tail, int leight, Direction direction)
        {
            pList = new List<Point>();
            for (int i = 0; i < leight; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }
    }
}
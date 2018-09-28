﻿using System;
using System.Collections.Generic;
using System.Linq;

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

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            //System.Threading.Thread.Sleep(1000);
            tail.Clear();
            //System.Threading.Thread.Sleep(1000);
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextpoint = new Point(head);
            nextpoint.Move(1, direction);
            return nextpoint;
        }
    }
}
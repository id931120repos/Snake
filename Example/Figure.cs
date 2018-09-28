using System;
using System.Collections.Generic;

namespace Example
{
    public class Figure
    {
        public List<Point> pList;

        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
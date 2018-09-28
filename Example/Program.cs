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

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            //List<int> numList = new List<int>
            //{
            //    0,
            //    1
            //};
            //numList.Add(2);

            //int x = numList[0];
            //int y = numList[1];
            //int z = numList[2];

            //foreach (int i in numList)
            //{
            //    WriteLine(i);
            //}

            //numList.RemoveAt(0);

            //foreach (int i in numList)
            //{
            //    WriteLine(i);
            //}

            List<Point> pList = new List<Point>
            {
                p1
            };
            pList.Add(p2);

            Pause();
        }
    }
}
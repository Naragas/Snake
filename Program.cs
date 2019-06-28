﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1,3,'*');
            p1.PrintSymbol();

            Point p2 = new Point(4, 5, '#');
            p2.PrintSymbol();

            HorizontalLine hLine = new HorizontalLine(5,10,8,'+');
            VertikalLine vLine = new VertikalLine(15, 2, 14, '-');

            hLine.Draw();
            vLine.Draw();


            Console.ReadKey();
        }


    }
}

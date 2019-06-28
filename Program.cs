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

            Console.SetWindowSize(80, 25);
            

            // Draw Border
            HorizontalLine upLine = new HorizontalLine(1, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(1, 78, 24, '+');
            VertikalLine leftLine = new VertikalLine(0, 0, 24, '+');
            VertikalLine rightLine = new VertikalLine(78, 0, 24, '+');

            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            Console.ReadKey();
        }


    }
}

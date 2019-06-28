using System;
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
            //int x1 = 1;
            //int y1 = 3;
            //char sym1 = '*';

            Point p1 = new Point();
            p1.x = 1;
            p1.y = 3;
            p1.symbol = '*';

            Point p2 = new Point(4, 5, '#');

            p2.PrintSymbol();
            Console.ReadKey();
            p1.PrintSymbol();
            Console.ReadKey();
        }


    }
}

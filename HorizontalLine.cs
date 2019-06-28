using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine
    {
        List<Point> plist;
        public HorizontalLine(int xLeft, int xRight, int y, char symbol)
        {
            plist = new List<Point>();
            for (int i = xLeft; i <= xRight; i++)
            {
                Point p = new Point(i, y, symbol);
                plist.Add(p);
            }

        }
        public void Draw()
        {
            foreach (Point p in plist)
            {
                p.PrintSymbol();
            }
        }

    }
}

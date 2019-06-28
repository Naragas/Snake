using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VertikalLine : Figure
    {
        public VertikalLine(int x, int yTop, int yBot, char symbol)
        {
            pList = new List<Point>();
            for (int i = yTop; i <= yBot; i++)
            {
                Point p = new Point(x, i, symbol);
                pList.Add(p);
            }
        }
    }
}

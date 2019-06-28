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
            int x1 = 1;
            int y1 = 3;
            char sym1 = '*';
            int x2 = 4;
            int y2 = 5;
            char sym2 = '#';

            PrintSymbol(x1, y1, sym1);
            PrintSymbol(x2, y2, sym2);
            Console.ReadKey();

        }

        private static void PrintSymbol(int x, int y, char symbol)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }
    }
}

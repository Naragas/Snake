using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreator
    {
        int mapWidth;
        int mapHeight;
        char symbol;

        Random random = new Random();

        public  FoodCreator(int mapWidth, int mapHeight, char symbol)
        {
            this.mapWidth = mapWidth;
            this.mapHeight = mapHeight;
            this.symbol = symbol;
        }
        public Point CreateFood(Snake snake)
        {
            Point p;
            do
            {
                int x = random.Next(2, mapWidth - 2);
                int y = random.Next(2, mapHeight - 2);
                p = new Point(x, y, symbol);

            } while (snake.IsOnSnake(p));
            p.Draw();
            return p;

        }
    }
}

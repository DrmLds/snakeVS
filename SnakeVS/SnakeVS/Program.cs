using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SnakeVS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(188, 125);

            // отрисовка рамки
            HorizontalLine upline = new HorizontalLine(0, 118, 0, '+');
            HorizontalLine downline = new HorizontalLine(0, 118, 27, '+');
            VerticalLine leftlne = new VerticalLine(0, 0, 27, '+');
            VerticalLine rightlne = new VerticalLine(118, 0, 27, '+');
            leftlne.Drow();
            rightlne.Drow();
            upline.Drow();
            downline.Drow();

            // отрисовка точек
            Point p = new Point(4,13, '*');
            Snake snake = new Snake(p, 10, Direction.RIGHT);
            snake.Drow();

            // еда змейки
            FoodCreator foodCreator = new FoodCreator(100, 25, '*');
            Point food = foodCreator.CreateFood();
            food.Draw();

            // поедание еды змейки
            while (true)
            {
                if(snake.Eat (food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();
                
            }
    
            
        }
        
    }
}

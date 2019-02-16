using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            Point p = new Point(4,5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();
            snake.Move();

            Console.ReadLine();
            
        }
        
    }
}

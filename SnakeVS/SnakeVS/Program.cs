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

            HorizontalLine upline = new HorizontalLine(0, 118, 0, '+');
            HorizontalLine downline = new HorizontalLine(0, 118, 27, '+');
            VerticalLine leftlne = new VerticalLine(0, 0, 27, '+');
            VerticalLine rightlne = new VerticalLine(118, 0, 27, '+');
            leftlne.Drow();
            rightlne.Drow();
            upline.Drow();
            downline.Drow();


            Point p1 = new Point(1,5, '*');
            p1.Draw();
                       
            Point p2 = new Point(3,5, '@');
            p2.Draw();
                                                       
            Console.ReadLine();

        }
        
    }
}

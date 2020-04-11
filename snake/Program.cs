using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            HorizontalLine UpLine = new HorizontalLine(0, 78, 0, '+');
            UpLine.DrawLine();
            HorizontalLine DownLine = new HorizontalLine(0, 78, 24, '+');
            DownLine.DrawLine();
            VerticalLine LeftLine = new VerticalLine(0, 24, 0, '+');
            LeftLine.DrawLine();
            VerticalLine RightLine = new VerticalLine(0, 24, 78, '+');
            RightLine.DrawLine();

            Point p = new Point(4, 5, '*');
            p.Draw();
            Console.ReadLine();
        }
    }
}

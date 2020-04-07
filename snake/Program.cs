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

            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            Move(p1, 10, 10);
            Console.WriteLine($"Move(p1, 10, 10) p1.x = {p1.x}, p1.y = {p1.y}");

            Reset(p2);
            Console.WriteLine($"Reset(p2) p2.x = {p2.x}, p2.y = {p2.y}");

            Console.ReadKey();
        }

        private static void Reset(Point p)
        {
            p = new Point(6, 7, '@');
            //  Здесь переменная p2 останется без изменений.
        }

        private static void Move(Point p, int dx, int dy)
        {
            p.x = p.x + dx;
            p.y = p.y + dy;
        }
    }
}

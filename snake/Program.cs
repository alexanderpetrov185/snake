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

            List<int> numlist = new List<int>
            {
                3,
                4,
                5
            };

            int x = numlist[0];
            int y = numlist[1];
            int z = numlist[2];

            foreach (int i in numlist)
            {
                Console.WriteLine(i);
            }

            numlist.RemoveAt(0);

            List<Point> plist = new List<Point>
            {
                p1,
                p2
            };
            

            Console.ReadLine();
        }
    }
}

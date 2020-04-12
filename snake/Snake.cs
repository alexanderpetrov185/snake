using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Snake : Figure
    {
        directions direction;

        public Snake(Point tail, int lenght, directions _direction)
        {
            direction = _direction;
            pList = new List<Point>();
            for (int i = 0; i < lenght; i++ )
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point Head = pList.Last();
            Point nextPoint = new Point(Head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        public void HandleKey (ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction = directions.LEFT;
            else if (key == ConsoleKey.RightArrow)
                direction = directions.RIGHT;
            else if (key == ConsoleKey.UpArrow)
                direction = directions.UP;
            else if (key == ConsoleKey.DownArrow)
                direction = directions.DOWN;
        }

        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                pList.Add(food);
                return true;
            }
            else
                return false;
        }
    }
}

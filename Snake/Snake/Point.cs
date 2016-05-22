﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char symb;

        public Point()
        {
        }

        public Point(int _x, int _y, char _symb)
        {
            x = _x;
            y = _y;
            symb = _symb;
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            symb = p.symb;
        }

        // отрисовка точки
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(symb);
        }

        // перемещение точки
        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.RIGTH) { x = x + offset; }
            else if (direction == Direction.LEFT) { x = x - offset; }
            else if (direction == Direction.UP) { y = y - offset; }
            else if (direction == Direction.DOWN) { y = y + offset; }
        }

        public override string ToString()
        {
            return x + ", " + y + ", " + symb;
        }

        public void Clear()
        {
            symb = ' ';
            Draw();
        }
    }
}

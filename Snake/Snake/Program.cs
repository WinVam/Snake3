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
            int x = 1;

            func1(x);
            Console.WriteLine("Вызов функции func1   x = " + x);

            func2(x);
            Console.WriteLine("Вызов функции func2   x = " + x);

            func3(x);
            Console.WriteLine("Вызов функции func3   x = " + x);

            Point p1 = new Point(1, 3, '*');
            Move(p1, 10, 10);
            Console.WriteLine("Вызов функции Move p1.x = " + p1.x + ", p1.y = " + p1.y);

            Point p2 = new Point(4, 5, '#');
            Console.WriteLine("Создание новой точки p2. p2.x = " + p2.x + ", p2.y = " + p2.y + ", p2.symb = " + p2.symb);

            Reset(p2);
            Console.WriteLine("Перезагрузка точки p2. p2.x = " + p2.x + ", p2.y = " + p2.y + ", p2.symb = " + p2.symb);

            p1 = p2;
            p2.x = 8;
            p2.y = 8;
            Console.WriteLine("p1 = p2. p1.x = " + p1.x + ", p1.y = " + p1.y + ", p2.x = " + p2.x + ", p2.y = " + p2.y);

            Console.ReadLine();

        }

        public static void  func1(int value)
        {
        }

        public static void func2(int value)
        {
            value = value + 1;
        }

        public static void func3(int X)
        {
            X = X + 1;
        }

        public static void Move(Point p, int dx, int dy)
        {
            p.x = p.x + dx;
            p.y = p.y + dy;
        }

        public static void Reset(Point p)
        {
            p = new Point();
        }
    }
}

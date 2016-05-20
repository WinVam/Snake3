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
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            HorizontalLines lineH = new HorizontalLines(1, 10, 6, '^');
            lineH.Drow();

            VerticalLines lineV = new VerticalLines(1, 7, 15, '$');
            lineV.Drow();

            Console.ReadLine();
        }
    }
}

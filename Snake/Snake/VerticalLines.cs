using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLines : Figura
    {
       public VerticalLines (int x, int yTop, int yLow, char symb)
        {
            pList = new List<Point>();
            for (int y = yTop; y <= yLow; y++)
            {
                Point p = new Point(x, y, symb);
                pList.Add(p);
            }
        }
    }
}

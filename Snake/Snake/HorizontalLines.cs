using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLines : Figura
    {
       public HorizontalLines(int xLeft, int xRigth, int y, char symb)
        {
            pList = new List<Point>();
            for (int x = xLeft; x <= xRigth; x++)
            {
                Point p = new Point(x, y, symb);
                pList.Add(p);
            }
        }
    }
}

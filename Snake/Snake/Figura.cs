using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figura
    {
        protected List<Point> pList;

        // отрисовка фигуры(гориз. и вертик. линии, змейка)
        public void Drow()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}

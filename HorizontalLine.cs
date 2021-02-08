using System;
using System.Collections.Generic;
using System.Text;

namespace Osnovy_OOP
{
    class HorizontalLine

    {
        List<Point> pList;

        public HorizontalLine(int xleft, int xright, int y, char sm)
        {
            pList = new List<Point>();
            for (int x = xleft; x <= xright; x++)
            {
                Point p = new Point(x, y, sm);
                pList.Add(p);
            }
            
        }

        /* {
         pList = new List<Point>();
         Point p1 = new Point(6, 8, '&');
         Point p2 = new Point(7, 8, '&');
         Point p3 = new Point(8, 8, '&');
         pList.Add( p1 );
         pList.Add( p2 );
         pList.Add( p3 );*/

        public void Drow()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }


    }
}
    


using System;
using System.Collections.Generic;

namespace Osnovy_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> symList = new List<char>();

            symList.Add('*');
            symList.Add('#');
            symList.Add('&');

            Random rnd = new Random();
            int numbr = rnd.Next(symList.Count);


            Point p1 = new Point(1, 3, symList[numbr]);
            // p1.Draw();

            numbr = rnd.Next(3);
            Point p2 = new Point(4, 5, symList[numbr]);
                    // p2.Draw();

                    /* List<int> numList = new List<int>();
                     numList.Add(0);
                     numList.Add(1);
                     numList.Add(2);

                     foreach (int i in numList)
                     {
                         Console.WriteLine(i);
                     }*/

                    List<Point> pList = new List<Point>();
                    {
                        pList.Add(p1);
                        pList.Add(p2);
                    }

                    foreach (Point a in pList)
                    {
                        a.Draw();
                    
                
            }
            Console.ReadLine();
        }    
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace lab6
{
    class Rectangle
    {
        private double dlinaarect;
        private double dlinabrect;
        private ObjectInfo another_info;

        public Rectangle setrect(Rectangle rect)
        {
            Console.WriteLine("Длина стороны а: ");
            dlinaarect = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Длина стороны b: ");
            dlinabrect = Convert.ToDouble(Console.ReadLine());
            return rect;
        }
        public void printrect(Rectangle rect)
        {
            Console.Write("Длины сторон а и b соответственно: %lf, %lf", dlinaarect, dlinabrect);
        }
        public double rectperimeter(Rectangle rect)
        {
            double perimetrrect;
            perimetrrect = (dlinaarect + dlinabrect) * 2;
            return perimetrrect;
        }
        public double rectsurf(Rectangle rect)
        {
            double surfrect;
            surfrect = dlinaarect * dlinabrect;
            return surfrect;
        } 
        public void addAnotherInfo(ObjectInfo someinfo)
        {
            another_info = someinfo;
        }
    }
}

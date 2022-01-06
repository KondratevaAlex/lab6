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

        public Rectangle()
        {
            dlinaarect = dlinabrect = 0.0;
        }

        public Rectangle(double noll)
        {
            dlinaarect = dlinabrect = noll;
        }

        public Rectangle(double dlinaarect, double dlinabrect)
        {
            this.dlinaarect = dlinaarect;
            this.dlinabrect = dlinabrect;
        }
        public Rectangle setrect(Rectangle rect)
        {
            Console.WriteLine("Длина стороны а: ");
            try
            {
                dlinaarect = Convert.ToDouble(Console.ReadLine());
                if (dlinaarect < 0)
                {
                    throw new Exception("Некорректный ввод");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Исключение: {ex.Message}");
            }
            Console.WriteLine("Длина стороны b: ");
            try
            {
                dlinabrect = Convert.ToDouble(Console.ReadLine());
                if (dlinabrect < 0)
                {
                    throw new Exception("Некорректный ввод");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Исключение: {ex.Message}");
            }
            return rect;
        }
        public void printrect(Rectangle rect)
        {
            Console.Write("Длины сторон а и b соответственно: ");
            Console.Write(dlinaarect + "," + dlinabrect);
        }
        public void rectperimeter(out double perimetrrect)
        {
            perimetrrect = (dlinaarect + dlinabrect) * 2;
        }
        public void rectsurf(ref double surfrect)
        {
            surfrect = dlinaarect * dlinabrect;
        } 
        public void addAnotherInfo(ObjectInfo someinfo)
        {
            another_info = someinfo;
        }
        public static Rectangle operator +(Rectangle a, Rectangle b)
        {
            Rectangle result = new Rectangle();
            result.dlinaarect = a.dlinaarect + b.dlinaarect;
            result.dlinabrect = a.dlinabrect + b.dlinabrect;
            return result;
        }
        public static Rectangle operator ++(Rectangle a)
        {
            Rectangle result = new Rectangle();
            result.dlinaarect = a.dlinaarect++;
            result.dlinabrect = a.dlinabrect++;
            return result;
        }
    }
}

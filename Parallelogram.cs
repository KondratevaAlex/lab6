using System;
using System.Collections.Generic;
using System.Text;

namespace lab6
{
    class Parallelogram
    {
        private double dlinaapar;
        private double dlinabpar;
        private double ygolalppar;
        private ObjectInfo another_info;

        public Parallelogram()
        {
            dlinaapar = dlinabpar = ygolalppar = 0.0;
        }

        public Parallelogram(Double noll)
        {
            dlinaapar = dlinabpar = ygolalppar = noll;
        }

        public Parallelogram(double dlinaapar, double dlinabpar, double ygolalppar)
        {
            this.dlinaapar = dlinaapar;
            this.dlinabpar = dlinabpar;
            this.ygolalppar = ygolalppar;
        }
        public Parallelogram setpar(Parallelogram paral)
        {
            Console.WriteLine("Длина стороны а: ");
            dlinaapar = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Длина стороны b: ");
            dlinabpar = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Угол между сторонами a и b (в градусах): ");
            ygolalppar = Convert.ToDouble(Console.ReadLine());
            return paral;
        }
        public void printpar(Parallelogram par)
        {
            Console.WriteLine("Длины сторон а, b и угол в градусах между ними соответственно: ");
            Console.Write(dlinaapar + "," + dlinabpar + "," + ygolalppar);
        }
        public void parperimeter(out double perimetrpar)
        {
            perimetrpar = (dlinaapar + dlinabpar) * 2;
        }
        public void parsurf(ref double surfpar)
        {
            surfpar = dlinaapar * dlinabpar * ygolalppar;
        }
        public void addAnotherInfo(ObjectInfo someinfo)
        {
            another_info = someinfo;
        }
    }
}

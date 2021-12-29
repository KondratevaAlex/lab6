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
            Console.Write("Длины сторон а, b и угол в градусах между ними соответственно: %lf, %lf, %lf", dlinaapar, dlinabpar, ygolalppar);
        }
        public double parperimeter(Parallelogram par)
        {
            double perimetrpar;
            perimetrpar = (dlinaapar + dlinabpar) * 2;
            return perimetrpar;
        }
        public double parsurf(Parallelogram par)
        {
            double surfpar;
            surfpar = dlinaapar * dlinabpar * ygolalppar;
            return surfpar;
        }
        public void addAnotherInfo(ObjectInfo someinfo)
        {
            another_info = someinfo;
        }
    }
}

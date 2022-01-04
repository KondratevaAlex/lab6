using System;
using System.Collections.Generic;
using System.Text;

namespace lab6
{
    class Circle
    {
        private double dlinarcirc;
        private ObjectInfo another_info;

        public Circle setcirc(Circle circ)
        {
            Console.Write("Длина радиуса r: ");
            dlinarcirc = Convert.ToDouble(Console.ReadLine());
            return circ;
        }
        public void printcirc(Circle circ)
        {
            Console.WriteLine("Длина радиуса r: ");
            Console.Write(dlinarcirc);
        }
        public void circperimeter(out double perimetrcirc)
        {
            perimetrcirc = 2 * Math.PI * dlinarcirc;
        }
        public void circsurf(ref double surfcirc)
        {
            surfcirc = Math.PI * Math.Pow(dlinarcirc, 2);
        }
        public void addAnotherInfo(ObjectInfo someinfo)
        {
            another_info = someinfo;
        }
    }
}

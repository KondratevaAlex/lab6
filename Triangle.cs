﻿using System;
using System.Collections.Generic;
using System.Text;

namespace lab6
{
    class Triangle
    {
        private double dlinaatri;
        private double dlinabtri;
        private double dlinactri;
        private ObjectInfo anotherinfo;

        public Triangle settri(Triangle tri)
        {
            Console.WriteLine("Длина стороны а: ");
            dlinaatri = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Длина стороны b: ");
            dlinabtri = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Длина стороны c: ");
            dlinactri = Convert.ToDouble(Console.ReadLine());
            return tri;
        }
        public void printtri(Triangle trian)
        {
            Console.WriteLine("Длины сторон а, b и c соответственно: ");
            Console.Write(dlinaatri + "," + dlinabtri + "," + dlinactri);
        }
        public double triperimeter(Triangle trian)
        {
            double perimetrtri;
            perimetrtri = dlinaatri + dlinabtri + dlinactri;
            return perimetrtri;
        }
        public double trisurf(Triangle trian)
        {
            double surftri;
            double perim;
            perim = (dlinaatri + dlinabtri + dlinactri) / 2;
            surftri = Math.Sqrt(perim * (perim - dlinaatri) * (perim - dlinabtri) * (perim - dlinactri));
            return surftri;
        }

    }

}


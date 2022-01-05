using System;
using System.Collections.Generic;
using System.Text;

namespace lab6
{
    class Trapezoid
    {
        private double dlinaatrap;
        private double dlinabtrap;
        private double dlinactrap;
        private double dlinadtrap;
        private double dlinahtrap;
        private ObjectInfo another_info;

        public Trapezoid()
        {
            dlinaatrap = dlinabtrap = dlinactrap = dlinadtrap = dlinahtrap = 0.0;
        }

        public Trapezoid(double noll)
        {
            dlinaatrap = dlinabtrap = dlinactrap = dlinadtrap = dlinahtrap = noll;
        }

        public Trapezoid(double dlinaatrap, double dlinabtrap, double dlinactrap, double dlinadtrap, double dlinahtrap)
        {
            this.dlinaatrap = dlinaatrap;
            this.dlinabtrap = dlinabtrap;
            this.dlinactrap = dlinactrap;
            this.dlinadtrap = dlinadtrap;
            this.dlinahtrap = dlinahtrap;
        }

        public Trapezoid settrap(Trapezoid trap)
        {
            Console.WriteLine("Длина стороны а: ");
            dlinaatrap = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Длина стороны b: ");
            dlinabtrap = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Длина стороны c: ");
            dlinactrap = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Длина стороны d: ");
            dlinadtrap = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Длина высоты h: ");
            dlinahtrap = Convert.ToDouble(Console.ReadLine());
            return trap;
        }
        public void printtrap(Trapezoid trap)
        {
            Console.WriteLine("Длина оснований a и b, сторон c и d и высоты h соответственно: ");
            Console.Write(dlinaatrap + "," + dlinabtrap + "," + dlinactrap + "," + dlinadtrap + "," + dlinahtrap);
        }
        public void trapperimeter(out double perimetrtrap)
        {
            perimetrtrap = dlinaatrap + dlinabtrap + dlinactrap + dlinadtrap;
        }
        public void trapsurf(ref double surftrap)
        {
            surftrap = ((dlinaatrap * dlinabtrap) / 2) * dlinahtrap;
        }
        public void addAnotherInfo(ObjectInfo someinfo)
        {
            another_info = someinfo;
        }
    }

}


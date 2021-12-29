﻿using System;
using System.Collections.Generic;
using System.Text;

namespace lab6
{
    class ObjectInfo
    {
        private int colour;
        private int day;
        private int month;
        private int year;

        public ObjectInfo()
        {
            colour = day = month = year = 0;
        }
        public ObjectInfo(int _colour, int _day, int _month, int _year)
        {
            colour = _colour;
            day = _day;
            month = _month;
            year = _year;
        }
        public ObjectInfo setInfo(ObjectInfo obj)
        {
            Console.WriteLine("\nВведите цвет фигуры (1-красный, 2-синий, 3-зеленый, 4-желтый): ");
            colour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nВведите сегодняшний день: ");
            day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nВведите нынешний месяц: ");
            month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nВведите нынешний год: ");
            year = Convert.ToInt32(Console.ReadLine());
            return obj;
        }
        public void printInfo(ObjectInfo obj)
        {
            Console.WriteLine("\nЦвет фигуры(1-красный, 2-синий, 3-зеленый, 4-желтый): ");
            Console.Write(colour);
            Console.WriteLine("\nДата работы: " + day + "/" + month + "/" + year);
        }
    }
}

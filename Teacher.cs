using System;
using System.Collections.Generic;
using System.Text;

namespace lab6
{
    class Teacher : Student
    {
        private int mark;
        public void estimate()
        {
            Console.Write("\nОценка за работу: ");
            mark = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(name + " " + patronymic + " " + surname + "." + "Оценка за работу: " + mark);
        }
    }
}
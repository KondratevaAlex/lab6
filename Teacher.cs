using System;
using System.Collections.Generic;
using System.Text;

namespace lab6
{
    class Teacher : Student
    {
        protected int mark;
        protected int experience;
        public void estimate()
        {
            Console.Write("\nОценка за работу: ");
            mark = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(name + " " + patronymic + " " + surname + "." + "Оценка за работу: " + mark);
        }
        public void set(string name, string patronymic, string surname, int experience)
        {
            set(name, patronymic, surname);
            this.experience = experience;
        }
    }
}
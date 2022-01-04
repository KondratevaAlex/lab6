using System;
using System.Collections.Generic;
using System.Text;

namespace lab6
{
    class Student
    {
        private String name;
        private String patronymic;
        private String surname;
        public Student()
        {
            name = "Unknown";
            patronymic = "Unknown";
            surname = "Unknown";
        }
        public Student(String name, String patronymic, String surname)
        {
            this.name = name;
            this.patronymic = patronymic;
            this.surname = surname;
        }
        public void set()
        {
            Console.Write("Введите имя: ");
            name = Console.ReadLine();
            Console.Write("Введите отчество: ");
            patronymic = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            surname = Console.ReadLine();
        }

        public void printInfo()
        {
            String info = name + " " + patronymic + " " + surname;
            Console.WriteLine("Студент: " + info);
        }
        public void getFIO()
        {
            char[] fio = new char[3];
            fio[0] = surname[0];
            fio[1] = patronymic[0];
            fio[2] = name[0];

            Console.WriteLine("ФИО: " + fio[0] + fio[1] + fio[2]);
        }
    }
}


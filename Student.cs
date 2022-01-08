using System;
using System.Collections.Generic;
using System.Text;

namespace lab6
{
    class Student : People, WReview, ICloneable
    {
        private static int count = 0;
        private string group;

        public Student()
        {
            name = "None";
            patronymic = "None";
            surname = "None";
            count++;
        }

        public Student(String name)
        {
            this.name = name;
            patronymic = "None";
            surname = "None";
            count++;
        }

        public Student(String name, String patronymic, String surname)
        {
            this.name = name;
            this.patronymic = patronymic;
            this.surname = surname;
            count++;
        }
        public string Name
        {
            set
            {
                name = Name;
            }
            get
            {
                return name;
            }
        }
        public string Patronymic
        {
            set
            {
                patronymic = Patronymic;
            }
            get
            {
                return patronymic;
            }
        }
        public string Surname
        {
            set
            {
                surname = Surname;
            }
            get
            {
                return surname;
            }
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

        public override string ToString()
        {
            string s = "";
            s += name + " " + patronymic + " " + surname;
            return s;
        }
        public void getFIO()
        {
            char[] fio = new char[3];
            fio[0] = surname[0];
            fio[1] = patronymic[0];
            fio[2] = name[0];

            Console.WriteLine("ФИО: " + fio[0] + fio[1] + fio[2]);
        }
        public static int getCount()
        {
            return count;
        }
        public void set(string name, string patronymic, string surname)
        {
            this.name = name;
            this.patronymic = patronymic;
            this.surname = surname;
        }
        public override void setAnotherInformation()
        {
            Console.Write("Группа студента: ");
            group = Console.ReadLine();
        }

        public override void getAnotherInformation()
        {
            Console.WriteLine("Группа: " + group);
        }
        public string WriteReview()
        {
            string review;
            Console.Write("Комментраий студента: ");
            review = Console.ReadLine();
            return review;
        }
        public object Clone()
        {
            return new Student(name, patronymic, surname);
        }
    }
}


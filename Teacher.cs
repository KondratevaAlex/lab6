using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab6
{
    class Teacher : Student, WReview, ICloneable
    {
        protected int mark;
        protected int experience;
        protected string AcademicDegree;
        public Student student = new Student();
        public Teacher(String name, String patronymic, String surname, int experience, Student student) : base(name, patronymic, surname)
        {
            this.experience = experience;
            this.student = student;
        }
        public Teacher(String name, String patronymic, String surname, int experience) : base(name, patronymic, surname)
        {
            this.experience = experience;

        }
        public void estimate()
        {
            Console.Write("\nОценка за работу: ");
            mark = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(name + " " + patronymic + " " + surname + "." + "Оценка за работу: " + mark);
        }
        public void set(string name, string patronymic, string surname, int experience, Student student)
        {
            base.set(name, patronymic, surname);
            this.experience = experience;
            this.student = student;
        }
        public override string ToString() 
        {
            string s = "";
            s += name + " " + patronymic + " " + surname + ", " + " стаж в годах: " + Convert.ToString(experience) + " Студент: " + student.Name + " " + student.Surname;
            return s;
        }
        public override void setAnotherInformation()
        {
            Console.Write("Ученая степень преподавателя: ");
            AcademicDegree = Console.ReadLine();
        }

        public override void getAnotherInformation()
        {
            Console.WriteLine("Ученая степень: " + AcademicDegree);
        }
        public string WriteReview()
        {
            Console.Write("Оценка преподавателя: ");
            this.mark = Convert.ToInt32(Console.ReadLine());
            string review;
            Console.Write("Отзыв преподавателя: ");
            review = Console.ReadLine();
            return review;
        }
        public object Clone()
        {
            Teacher c = new Teacher(name, patronymic, surname, experience);
            student = (Student)student.Clone();
            return c;
        }
    }
}
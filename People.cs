using System;
using System.Collections.Generic;
using System.Text;

namespace lab6
{
    abstract class People
    {
        protected string name;
        protected string patronymic;
        protected string surname;
        public abstract void setAnotherInformation();
        public abstract void getAnotherInformation();
    }
}
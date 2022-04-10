using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class Teacher : Person
    {
        public int id;
        public static int Id;
        private int _experience;

        public int Experience
        {
            get
            {
                return _experience;
            }
            set
            {
                if (value >0 && value<=80)
                {
                    _experience = value;
                }
            }
        }

        public Teacher(string name, string surname, int age, int experience ) : base(name, surname, age)
        {

            Id++;
            id = Id;
            Experience = experience;
        }
        public string Info()
        {
            return $"Name : {Name}, Surname : {Surname}, Age : {Age}, Experience : {Experience}, Id : {id}";
        }
    }
}

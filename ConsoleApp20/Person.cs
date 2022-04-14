using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class Person
    {
        public string Name;
        public string Surname;
        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value>0)
                {
                    _age = value;
                }
            }
        }

        public Person(string name,string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
    }
}

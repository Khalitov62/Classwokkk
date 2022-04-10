using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class Student : Person
    {
        public int Id;
        public static int StudentId;
        public string [] Lessons = new string [0];

        public Student(string name, string surname, int age) : base(name, surname, age)
        {
            StudentId++;
            Id = StudentId;
            
        }
        public string Info()
        {
            return $"Name : {Name}, Surname : {Surname}, Age : {Age}, Id : {Id}";
        }
    }
}

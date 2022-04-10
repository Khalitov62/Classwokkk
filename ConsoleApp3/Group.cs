using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class Group
    {
        public string[] fullName = new string[0];
        public Student[] array = new Student[0];
        public string GroupNo;


        //public void AddStudent(string student)
        //{
        //    Array.Resize(ref fullName, fullName.Length +1);
        //    fullName[fullName.Length-1] = student;

        //}

        public void AddStudent(Student student)
        {

            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = student;
        }
    }
}

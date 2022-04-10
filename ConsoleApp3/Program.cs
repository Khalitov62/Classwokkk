using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Teacher teacher = new Teacher("Islam", "Xalitov", 20,1);
            //Teacher teacher1 = new Teacher("Islam", "Xalitov", 20,1);
            //Console.WriteLine(teacher.Info());
            //Console.WriteLine(teacher1.Info());
            //Student student = new Student("Islam", "Xalitov", 20);
            //Student student1 = new Student("Islam", "Xalitov", 20);
            //Console.WriteLine(student.Info());
            //Console.WriteLine(student1.Info());
            //int experience;
            //int age;
            //do
            //{
            //    Console.WriteLine("Experience daxil edin");
            //    experience = Convert.ToInt32(Console.ReadLine());

            //} while (experience < 1 || experience > 80);


            //do
            //{
            //    Console.WriteLine("Age daxil edin");
            //    age = Convert.ToInt32(Console.ReadLine());

            //} while (age < 0);

            //Teacher teacher = new Teacher("Islam", "Xalitov", age, experience);
            //Console.WriteLine(teacher.Info());

            //int age1;
            //do
            //{
            //    Console.WriteLine("Age daxil edin");
            //    age1 = Convert.ToInt32(Console.ReadLine());

            //} while (age1 < 0);

            Student student = new Student("Islam", "Xalitov", 10);
            Student student1 = new Student("Kamal", "Xalitov", 10);
            Console.WriteLine(student.Info());
            Console.WriteLine(student1.Info());

            Group group = new Group();
            group.AddStudent(student);
            group.AddStudent(student1);
            foreach (var item in group.array)
            {
                item.Info();
            }

            

        }
    }
}

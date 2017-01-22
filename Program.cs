using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Program
    {
        public class Student
        {
            public string name;
            public string surname;
            public int age;

            public Student(string name, string surname, int age)
            {
                this.name = name;
                this.surname = surname;
                this.age = age;
            }
        }
        public static void Main(string[] args)
        {
            Student a = new Student("Aisultan", "Akhzhan", 99);
            Student b = new Student("Arsen", "Zhumashev", 17);
            Console.WriteLine(a.name + " " + b.surname);
            Console.ReadKey();

        }
    }
}

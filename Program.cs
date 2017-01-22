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
            public double gpa;

            public Student(string name, string surname, double gpa)
            {
                this.name = name;
                this.surname = surname;
                this.gpa = gpa;
            }
            public void Write()
            {
                return this.name + " " + this.surname + " " + this.gpa;
            }
        }
        public static void Main(string[] args)
        {
            Student a = new Student("Aisultan", "Akhzhan", 3.0);
            Student b = new Student("Arsen", "Zhumashev", 3.55);
            Console.WriteLine(a.Write());
            Console.ReadKey();

        }
    }
}

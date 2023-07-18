using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    public struct Student
    {
        int id;
        string name;
        public Student(int id,string name)
        {
            this.id = id;
            this.name = name;
        }
        public void display()
        {
            Console.WriteLine($"Student Id : {id} \n Student Name : {name};");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stud = new Student(23, "Raj");
            stud.display();
            Student stud1 = new Student(12, "Ravi");
            stud1.display();
        }
    }
}

using System;

namespace OOP.Models
{
    public class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string classRom { get; set; }

        public Student()
        {

        }
        public Student(int id, string name, int age, int classRom)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.classRom = classRom;
        }

        public void EnterData()
        {
            System.Console.WriteLine("Enter ID: ");
            this.id = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter Name: ");
            this.name = Console.ReadLine();
            System.Console.WriteLine("Enter Age: ");
            this.age = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter Classroom: ");
            this.classRom = Console.ReadLine();
        }

        public void Display()
        {
            System.Console.WriteLine("ID: " + this.id);
            System.Console.WriteLine(this.name);
            System.Console.WriteLine("Age: " + this.age);
            System.Console.WriteLine("Classroom: " + this.classRom);
        }
    }
}




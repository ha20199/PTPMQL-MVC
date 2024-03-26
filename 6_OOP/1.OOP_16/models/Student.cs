using System;

namespace OOP.Models
{
    public class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string classRom { get; set; }


        public void EnterData()
        {
            System.Console.WriteLine("Enter ID: ");
            this.id = Convert.ToInt32(System.ReadLine());
            System.Console.WriteLine("Enter Name: ");
            this.name = System.ReadLine();
            System.Console.WriteLine("Enter Age: ");
            this.age = Convert.ToInt32(System.ReadLine());
            System.Console.WriteLine("Enter Salary: ");
            this.classRom = System.ReadLine();
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




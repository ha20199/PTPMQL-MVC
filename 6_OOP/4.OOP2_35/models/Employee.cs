using System;

namespace OOP.Models
{
    public class Employee
    {
        public int employeeId { get; set; }
        public string employeeName { get; set; }
        public int age { get; set; }
        public int salary { get; set; }

        public Employee()
        {
        }
        public Employee(int a, string b, int c, int d)
        {
            this.employeeId = a;
            this.employeeName = b;
            this.age = c;
            this.salary = d;
        }

        public void EnterData()
        {
            System.Console.WriteLine("Enter ID: ");
            this.employeeId = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter Name: ");
            this.employeeName = Console.ReadLine();
            System.Console.WriteLine("Enter Age: ");
            this.age = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter Salary: ");
            this.salary = Convert.ToInt32(Console.ReadLine());
        }

        public void Display()
        {
            System.Console.WriteLine("ID: " + this.employeeId);
            System.Console.WriteLine(this.employeeName);
            System.Console.WriteLine("Age: " + this.age);
            System.Console.WriteLine("Salary: " + this.salary);
        }
    }
}




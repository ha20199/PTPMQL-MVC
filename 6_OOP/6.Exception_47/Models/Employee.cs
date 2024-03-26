using System;
using OBJECT.Models.Person;
namespace OBJECT.Models
{
    public class Employee : Person
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
            try
            {
                this.employeeId = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                this.employeeId = 0;
            }

            System.Console.WriteLine("Enter Name: ");
            try
            {
                this.employeeName = Console.ReadLine();
            }
            catch (Exception e)
            {
                this.employeeName = "";
            }

            System.Console.WriteLine("Enter Age: ");
            try
            {
                this.age = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                this.age = 0;
            }

            System.Console.WriteLine("Enter Salary: ");
            try
            {
                this.salary = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                this.salary = 0;
            }

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




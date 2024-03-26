using System;
namespace OBJECT.Models 
{
    public class Person
    {
        public string FullName { get; set; }
        public string Address { get; set; }

        public void EnterData()
        {
            System.Console.WriteLine("Enter FullName: ");
            this.FullName = System.ReadLine();
            System.Console.WriteLine("Enter Address: ");
            this.Address = System.ReadLine();
        }

        public void Display()
        {
            System.Console.WriteLine("{0} - {1}",this.FullName, this.Address);
        }
    }
}



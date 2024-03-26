using System;

namespace OOP.Models
{
    public class Fuit
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public int price { get; set; }

        public void EnterData()
        {
            System.Console.WriteLine("Enter ID: ");
            this.id = Convert.ToInt32(System.ReadLine());
            System.Console.WriteLine("Enter Name: ");
            this.name = System.ReadLine();
            System.Console.WriteLine("Enter Age: ");
            this.type = System.ReadLine();
            System.Console.WriteLine("Enter Salary: ");
            this.price = Convert.ToInt32(System.ReadLine());
        }

        public void Display()
        {
            System.Console.WriteLine("ID: " + this.id);
            System.Console.WriteLine(this.name);
            System.Console.WriteLine("Type: " + this.type);
            System.Console.WriteLine("Price: " + this.price);
        }
    }
}




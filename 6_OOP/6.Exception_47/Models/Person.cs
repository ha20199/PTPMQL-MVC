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
            try
            {
                this.FullName = Console.ReadLine();
            }
            catch (Exception ex)
            {
                this.FullName = "";
            }

            System.Console.WriteLine("Enter Address: ");
            try
            {
                this.Address = Console.ReadLine();
            }
            catch (Exception ex)
            {
                this.Address = "";
            }

        }

        public void Display()
        {
            System.Console.WriteLine("{0} - {1}", this.FullName, this.Address);
        }
    }
}



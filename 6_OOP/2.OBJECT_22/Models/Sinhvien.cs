using System;
namespace OBJECT.Models 
{
    public class SinhVien
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public void EnterData()
        {
            System.Console.WriteLine("Enter FullName: ");
            this.FullName = System.ReadLine();
            System.Console.WriteLine("Enter Address: ");
            this.Address = System.ReadLine();
            System.Console.WriteLine("Enter Age: ");
            this.FullName = Convert.ToInt32(System.ReadLine());
            System.Console.WriteLine("Enter PhoneNumber: ");
            this.Address = System.ReadLine();
        }

        public void Display()
        {
            System.Console.WriteLine("{0} - {1}",this.FullName, this.Address);
            System.Console.WriteLine("Age: {0} - Phone: {1}", this.Age, this.PhoneNumber);
        }
    }
}



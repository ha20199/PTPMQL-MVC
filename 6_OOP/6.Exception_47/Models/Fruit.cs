﻿using System;

namespace OBJECT.Models
{
    public class Fuit
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public int price { get; set; }

        public Fuit()
        {

        }
        public Fuit(int a, string b, string c, int d)
        {
            this.id = a;
            this.name = b;
            this.type = c;
            this.price = d;
        }
        public void EnterData()
        {
            System.Console.WriteLine("Enter ID: ");
            try
            {
                this.id = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                this.id = 0;
            }

            System.Console.WriteLine("Enter Name: ");
            try
            {
                this.name = Console.ReadLine();
            }
            catch (Exception ex)
            {
                this.name = "";
            }

            System.Console.WriteLine("Enter Age: ");
            try
            {
                this.type = Console.ReadLine();
            }
            catch (Exception ex)
            {
                this.type = "";
            }

            System.Console.WriteLine("Enter Salary: ");
            try
            {
                this.price = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                this.price = 0;
            }

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




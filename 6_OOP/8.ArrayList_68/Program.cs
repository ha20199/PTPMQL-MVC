using System.Collections;

public class Program
{
    private static void Main(string[] args)
    {
        int option = 0;
        ArrayList students = new ArrayList();
        
        do
        {
            Console.WriteLine("Otion: 1 Create StudentArrayList | 2 Edit student | 3 Delete student from ArrayList | 4 Display list | 5 exit");
            option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    {
                        Console.WriteLine("Enter number of students: ");
                        int number = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < number; i++)
                        {
                            students.Add(new Student());
                        }
                        foreach (Student student in students)
                        {
                            student.EnterData();
                        }
                        Console.WriteLine("**************");
                        Console.WriteLine("Inital Data:");
                        foreach (Student std in students)
                        {
                            Console.WriteLine("______________");
                            std.Display();
                        }
                        Console.WriteLine("**************");

                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Enter index to edit: ");
                        int index = Convert.ToInt32(Console.ReadLine());
                        try
                        {
                            Student std = (Student)students[index];
                            int id = 0;
                            string name = "";
                            int age = 0;
                            string classRom = "";
                            System.Console.WriteLine("Enter ID: ");
                            try
                            {
                                id = Convert.ToInt32(Console.ReadLine());
                            }
                            catch (Exception e)
                            {
                                id = 0;
                            }

                            System.Console.WriteLine("Enter Name: ");
                            try
                            {
                                name = Console.ReadLine();
                            }
                            catch (Exception e)
                            {
                                name = "";
                            }

                            System.Console.WriteLine("Enter Age: ");
                            try
                            {
                                age = Convert.ToInt32(Console.ReadLine());
                            }
                            catch (Exception e)
                            {
                                age = 0;
                            }

                            System.Console.WriteLine("Enter Classroom: ");
                            try
                            {
                                classRom = Console.ReadLine();
                            }
                            catch (Exception e)
                            {
                                classRom = "";
                            }

                            std.EditStudent(id, name, age, classRom);

                        }
                        catch (Exception ex) { Console.WriteLine(ex.Message); }

                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Enter index to delete: ");
                        int index = Convert.ToInt32(Console.ReadLine());
                        students.RemoveAt(index);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("**************");
                        Console.WriteLine("Final Data");
                        foreach (Student std in students)
                        {
                            Console.WriteLine("______________");
                            std.Display();
                        }
                        break;
                    }
                default: break;
            }
        } while (option != 5);
        

    }
}

public class Person
{
    public string? FullName { get; set; }
    public string? Address { get; set; }

    public Person() { }
    public Person(string FullName, string Address)
    {
        this.FullName = FullName;
        this.Address = Address;
    }
    public void EditPerson(string FullName, string Address)
    {
        this.FullName = FullName;
        this.Address = Address;
    }
    public virtual void EnterData()
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

    public virtual void Display()
    {
        System.Console.WriteLine("{0} - {1}", this.FullName, this.Address);
    }
}

public class Employee : Person
{
    public int? employeeId { get; set; }
    public string? employeeName { get; set; }
    public int? age { get; set; }
    public int? salary { get; set; }

    public Employee()
    {
    }
    public Employee(int a, string b, int c, int d, string e, string f)
    {
        this.employeeId = a;
        this.employeeName = b;
        this.age = c;
        this.salary = d;
        this.FullName = e;
        this.Address = f;
    }

    public void EditEmployee(int a, string b, int c, int d, string e, string f)
    {
        this.employeeId = a;
        this.employeeName = b;
        this.age = c;
        this.salary = d;
        this.FullName = e;
        this.Address= f;
    }

    public override void EnterData()
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

        System.Console.WriteLine("Enter FullName: ");
        try
        {
            this.FullName = Console.ReadLine();
        }
        catch (Exception ex)
        {
            this.FullName = "";
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

        System.Console.WriteLine("Enter Address: ");
        try
        {
            this.Address = Console.ReadLine();
        }
        catch (Exception ex)
        {
            this.Address = "";
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

    public override void Display()
    {

        System.Console.WriteLine("ID: " + this.employeeId);
        System.Console.WriteLine("Name " + this.employeeName);
        System.Console.WriteLine("Full name " + this.FullName);
        System.Console.WriteLine("Address " + this.Address);
        System.Console.WriteLine("Age: " + this.age);
        System.Console.WriteLine("Salary: " + this.salary);
    }
}

public class Student
{
    public int? id { get; set; }
    public string? name { get; set; }
    public int? age { get; set; }
    public string? classRom { get; set; }

    public Student()
    {

    }
    public Student(int id, string name, int age, string classRom)
    {
        this.id = id;
        this.name = name;
        this.age = age;
        this.classRom = classRom;
    }

    public void EditStudent(int id, string name, int age, string classRom)
    {
        this.id = id;
        this.name = name;
        this.age = age;
        this.classRom = classRom;
    }

    public void EnterData()
    {
        System.Console.WriteLine("Enter ID: ");
        try
        {
            this.id = Convert.ToInt32(Console.ReadLine());
        }
        catch (Exception e)
        {
            this.id = 0;
        }

        System.Console.WriteLine("Enter Name: ");
        try
        {
            this.name = Console.ReadLine();
        }
        catch (Exception e)
        {
            this.name = "";
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

        System.Console.WriteLine("Enter Classroom: ");
        try
        {
            this.classRom = Console.ReadLine();
        }
        catch (Exception e)
        {
            this.classRom = "";
        }

    }

    public void Display()
    {
        System.Console.WriteLine("ID: " + this.id);
        System.Console.WriteLine(this.name);
        System.Console.WriteLine("Age: " + this.age);
        System.Console.WriteLine("Classroom: " + this.classRom);
    }
}

public class Customer
{
    public int? id { get; set; }
    public string? name { get; set; }
    public Customer() { }
    public Customer(int id, string name)
    {
        this.id = id;
        this.name = name;
    }
    public void EditCustomer(int id, string name)
    {
        this.id = id;
        this.name = name;
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

        System.Console.WriteLine("Enter Customer Name: ");
        try
        {
            this.name = Console.ReadLine();
        }
        catch (Exception ex)
        {
            this.name = "";
        }

    }

    public void Display()
    {
        System.Console.WriteLine("Customer {0} - {1}", this.id, this.name);
    }
}
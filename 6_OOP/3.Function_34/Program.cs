

public class Program
{
    private static void Main(string[] args)
    {
        int option = 0;
        int a, b, c;
        Console.WriteLine("Enter 1: Phuong trinh bac 1 | 2: Phuong trinh bac 2");
        option = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter a - b - c");
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        c = Convert.ToInt32(Console.ReadLine());
        SolveFuntion solver = new SolveFuntion();
        switch (option)
        {
            case 1:
                {
                    solver.GetResult_Bac1(a,b,c);
                    break;
                }
            case 2:
                {
                    solver.GetResult_Bac2(a,b,c);
                    break;
                }
            default: break;
                
        }

    }


}

public class SolveFuntion
{
    //------------------------------------------------------PhuongtrinhBac1-----------------------------------------------------------------------//
    public int a1 { get; set; }
    public int b1 { get; set; }
    public int c1 { get; set; }
    // ax + b = c
    public double result_bac1 { get; set; }
    public void GetResult_Bac1(int a, int b, int c)
    {
        this.a1 = a;
        this.b1 = b;
        this.c1 = c;
        this.result_bac1 = (double)(c1 - b1) / a1;
        Console.WriteLine("Result: " + this.result_bac1);
    }

    //------------------------------------------------------PhuongtrinhBac2-----------------------------------------------------------------------//
    public int a { get; set; }
    public int b { get; set; }
    public int c { get; set; }

    public double d { get; set; }   // Declaration of double variables d, x1, and x2 for discriminant and roots
    public double x1 { get; set; }
    public double x2 { get; set; }

    public void GetResult_Bac2(int a, int b, int c)
    {
        this.a = a;
        this.b = b;
        this.c = c;

        d = b * b - 4 * a * c;  // Calculating the discriminant
        if (d == 0)  // Checking if the discriminant is equal to 0
        {
            Console.Write("Both roots are equal.\n");  // Printing a message if both roots are equal
            x1 = -b / (2.0 * a);  // Calculating the root when discriminant is zero
            x2 = x1;  // Assigning the same root to x2
            Console.Write("First Root Root1= {0}\n", x1);  // Printing the root when discriminant is zero
            Console.Write("Second Root Root2= {0}\n", x2);  // Printing the root when discriminant is zero
        }
        else if (d > 0)  // Checking if the discriminant is greater than 0
        {
            Console.Write("Both roots are real and different.\n");  // Printing a message if roots are real and different

            x1 = (-b + Math.Sqrt(d)) / (2 * a);  // Calculating the first root
            x2 = (-b - Math.Sqrt(d)) / (2 * a);  // Calculating the second root

            Console.Write("First Root Root1= {0}\n", x1);  // Printing the first root
            Console.Write("Second Root Root2= {0}\n", x2);  // Printing the second root
        }
        else
        {
            Console.Write("Roots are imaginary;\nNo Solution. \n\n");  // Printing a message if roots are imaginary
        }
    }

}


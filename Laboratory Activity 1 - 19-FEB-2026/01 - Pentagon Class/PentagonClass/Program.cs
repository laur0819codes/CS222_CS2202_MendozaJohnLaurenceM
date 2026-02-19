using System;

class PentagonClass
{
    private double side;

    public PentagonClass()
    {
        side = 0;
    }
     
    public PentagonClass(double side)
    {
        this.side = side; 
    }

    public double GetPerimeter()
    {
        return 5 * side;
    }

    double GetArea()
    {
        double area = Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * Math.Pow(side, 2) / 4;
        return area;
    }

    public void Display()
    {
        Console.WriteLine("Side length: " + side);
        Console.WriteLine("Perimeter: " + GetPerimeter().ToString("0.000"));
        Console.WriteLine("Area: " + GetArea().ToString("0.000"));
    }


        }

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Pentagon p1");
        Console.WriteLine("--------------");
        PentagonClass p1 = new PentagonClass();
        p1.Display();

        Console.WriteLine("\nPentagon p2");
        Console.WriteLine("--------------");
        PentagonClass p2 = new PentagonClass(5);
        p2.Display();

        Console.ReadLine();



    }
}

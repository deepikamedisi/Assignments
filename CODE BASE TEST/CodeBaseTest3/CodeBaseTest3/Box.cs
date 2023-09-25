using System;

class Box
{
    public double Length { get; set; }
    public double Breadth { get; set; }

    public Box(double Length, double Breadth)
    {
       this. Length = Length;
       this.Breadth = Breadth;
    }

    public static Box Add(Box b1, Box b2)
    {
        double sumLength = b1.Length + b2.Length;
        double sumBreadth = b1.Breadth + b2.Breadth;
        return new Box(sumLength, sumBreadth);
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Length: {Length}, Breadth: {Breadth}");
    }
}

class BoxTest
{
    static void Main(string[] args)
    {
        Console.Write("Enter the length of Box 1: ");
        double Length1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the breadth of Box 1: ");
        double Breadth1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of Box 2: ");
        double Length2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the breadth of Box 2: ");
        double Breadth2 = Convert.ToDouble(Console.ReadLine());

        Box box1 = new Box(Length1, Breadth1);
        Box box2 = new Box(Length2, Breadth2);

        Box box3 = Box.Add(box1, box2);

        Console.WriteLine("Box 3 : Sum of Box 1 and Box 2 ");
        box3.DisplayDetails();
        Console.ReadLine();
    }
}
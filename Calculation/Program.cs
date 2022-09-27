using CalculationLib;
public class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Welcome ! Let's calculate the area of the figures \nLet's start with a triangle:");
        Console.WriteLine("Enter a, b, c:");

        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());

        Triangle triangle =  new Triangle(a, b, c);
        triangle.GetInfo();
        Console.WriteLine("OK, now let's calculate the area of the circle \nEnter radius:");

        double r = Convert.ToDouble(Console.ReadLine());

        Circle circle = new Circle(r);
        circle.GetInfo();
    }
}
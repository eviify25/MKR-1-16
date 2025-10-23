using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Введіть довжину сторони квадрата (A): ");
        double side = Convert.ToDouble(Console.ReadLine());
        IShape square = new Square(side);

        Console.Write("Введіть радіус кола (R): ");
        double radius = Convert.ToDouble(Console.ReadLine());
        IShape circle = new Circle(radius);

        Console.WriteLine($"Площа квадрата: {square.GetArea()}");
        Console.WriteLine($"Площа кола: {circle.GetArea()}");
    }
}
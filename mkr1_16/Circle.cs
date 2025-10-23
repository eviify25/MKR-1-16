using System;
public class Circle : IShape
{
    private double radiusR;

public Circle(double r)
    {
        this.radiusR = r;
    }

    public double GetArea()
    {
        return Math.PI * radiusR * radiusR;
    }
}
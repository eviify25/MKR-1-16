public class Square : IShape
{
    private double sideA;

    public Square(double a)
    {
        this.sideA = a;
    }

    public double GetArea()
    {
        return sideA * sideA;
    }
}
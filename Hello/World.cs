using System.Formats.Asn1;

public class Circle{
    public double centreX = 0.0;
    public double centreY = 0.0;
    public double radius = 0.0;

    public Circle()
    {
        centreX = centreY = radius = 0.0;
    }
    public Circle(double x, double y, double r)
    {
        centreX = x;
        centreY = y;
        radius = r;
    }
}
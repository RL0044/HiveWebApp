// See https://aka.ms/new-console-template for more information
public class Program
{
    static void Main()
    {
        Circle circle = new Circle();
        Circle circle2 = new Circle(1,2,3);
        Circle circle3 = new Circle(){
            centreX = 1, centreY = 2, radius = 3
        };
        circle.centreX = 1;
        circle.centreY = 2;
        circle.radius = 3;
    }
}
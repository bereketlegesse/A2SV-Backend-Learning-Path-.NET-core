public class Shape
{
    public string name;
    public virtual double calculateArea()
    {
        return 1;
    }
}

public class circle : Shape
{
    double radius;
    public circle(double Radius)
    {
        base.name = "circle";
        radius = Radius;
    }
    public override double calculateArea()
    {
        double pi = System.Math.PI;
        return pi * (Math.Pow(radius, 2));
    }
}

public class rectangles : Shape
{
    double width;
    double heigth;
    public rectangles(double Width, double Heigth)
    {
        base.name = "rectangle";
        width = Width;
        heigth = Heigth;
    }

    public override double calculateArea()
    {
        return width * heigth;
    }
}

public class triangles : Shape
{
    double base_;
    double heigth;
    public triangles(double Base, double Heigth)
    {
        base.name = "triangle";
        base_ = Base;
        heigth = Heigth;
    }
    public override double calculateArea()
    {
        return 0.5 * base_ * heigth;
    }
}
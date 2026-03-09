using System;
using System.Drawing;

// README.md를 읽고 코드를 작성하세요.
Console.WriteLine("코드를 작성하세요.");

Console.WriteLine("===도형 분류기===");
Shape Shape1 = new Circle(5);
Shape Shape2 = new Circle(15);
Rectangle rectangle1 = new Rectangle(4, 6);
Rectangle rectangle2 = new Rectangle(5, 5);
Square square = new Square(7);


Console.WriteLine($"원(반지름: 5): {((Circle)Shape1).ClassifyShape()}," +
    $"넓이: {((Circle)Shape1).CalculateArea():F2}");
Console.WriteLine($"원(반지름: 15): {((Circle)Shape2).ClassifyShape()}," +
    $"넓이: {((Circle)Shape2).CalculateArea():F2}");
Console.WriteLine($"직사각형(4*6): {((Rectangle)rectangle1).ClassifyShape()}," +
    $"넓이: {((Rectangle)rectangle1).CalculateArea():F2}");
Console.WriteLine($"직사각형(5*5): {((Rectangle)rectangle2).ClassifyShape()}," +
    $"넓이: {((Rectangle)rectangle2).CalculateArea():F2}");
Console.WriteLine($"정사각형(7): {((Square)square).ClassifyShape()}," +
    $"넓이: {((Square)square).CalculateArea():F2}");




class Shape
{
}

class Circle : Shape
{ 
    double Radius { get; set; }
    public Circle(double radius)
    {
        Radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI* Radius*Radius;
    }
    public string ClassifyShape() => Radius switch
    {
        >= 10 => "큰 원",
        _ => "작은 원"
    };
}
class Rectangle : Shape
{
    double Width { get; set; }
    double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width=width;
        Height=height;
    }
    public double CalculateArea()
    {
        return Width * Height;
    }
    public string ClassifyShape() => (Width, Height) switch
    {
        var (w, h) when w == h => "정사각형 모양의 직사각형",
        _ => "일반 직사각형"
    };
}
class Square : Shape
{
    double Side { get; set; }

    public Square(double side)
    {
        Side = side;
    }
    public double CalculateArea()
    {
        return Side * Side;
    }
    public string ClassifyShape() => "정사각형";

}
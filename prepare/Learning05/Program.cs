using System;
using System.Drawing;
using System.Formats.Asn1;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //create empty list
        List<Shape> shapes = new List<Shape>();
        
        Square square1 = new Square("blue", 3);
        shapes.Add(square1);

        Rectangle rectangle1 = new Rectangle("green", 2, 4);
        shapes.Add(rectangle1);
        
        Circle circle1 = new Circle("red", 1);
        shapes.Add(circle1);

        foreach (Shape item in shapes)
        {
            string color = item.GetColor();
            double area = item.GetArea();

            Console.WriteLine($"color: {color} area: {area}");
        }
    }
}
using Shapes.Models;
using System;
using System.Collections.Generic;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle tr = new Triangle(5, 9);
            Rectangle r = new Rectangle(6, 7);
            Square s = new Square(8);

            List<Shape> shapesList = new List<Shape>();

            shapesList.Add(tr);
            shapesList.Add(r);
            shapesList.Add(s);

            foreach (var shape in shapesList)
            {
                Console.WriteLine($"Surface is {shape.CalculateSurface()}");
            }
        }
    }
}

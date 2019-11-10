using System;

namespace Shapes
{
    public abstract class Shape
    {
        protected int _width;
        protected int _height;

        public Shape(int h, int w)
        {
            this.Height = h;
            this.Width = w;
        }
        public abstract double CalculateSurface();

        public int Width
        {
            get => _width;
            set => _width = value;
        }

        public int Height
        {
            get => _height;
            set => _height = value;
        }

        public virtual void Print()
        {
            Console.WriteLine($"Surface is {CalculateSurface()}");
        }
    }
}
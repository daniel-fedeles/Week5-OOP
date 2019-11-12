namespace Shapes.Models
{
    public abstract class Shape
    {
        protected int _width;
        protected int _height;

        protected Shape(int width, int height)
        {
            _width = width;
            _height = height;
        }

        public abstract double CalculateSurface();


    }
}
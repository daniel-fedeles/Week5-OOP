namespace Shapes.Models
{
    public class Square : Shape
    {
        public Square(int width) : base(width, width)
        {
        }

        public override double CalculateSurface()
        {
            return _width * _width;
        }
    }
}
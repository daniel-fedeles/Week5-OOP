namespace Shapes.Models
{
    public class Triangle : Shape
    {
        public Triangle(int width, int height) : base(width, height)
        {
        }

        public override double CalculateSurface()
        {
            return _height * (_width / 2);
        }
    }
}
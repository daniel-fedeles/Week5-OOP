namespace Shapes
{
    public class Triangle : Shape
    {
        public Triangle(int h, int w) : base(h, w)
        {
        }
        public override double CalculateSurface()
        {
            return Height * Width / 2;
        }


    }
}
namespace Shapes
{
    public class Rectangle : Shape
    {
        public Rectangle(int h, int w) : base(h, w)
        {
        }
        public override double CalculateSurface()
        {
            return Height * Width;
        }


    }
}
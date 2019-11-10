namespace Shapes
{
    public class Square : Shape
    {

        public Square(int l) : base(l, l)
        {

        }
        public override double CalculateSurface()
        {
            return Height * Height;
        }

    }
}
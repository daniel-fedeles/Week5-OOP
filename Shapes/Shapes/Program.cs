namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            var rectangle = new Rectangle(25, 36);

            var square = new Square(25);
            var triangle = new Triangle(25, 36);

            rectangle.CalculateSurface();
            rectangle.Print();

            square.CalculateSurface();
            square.Print();

            triangle.CalculateSurface();
            triangle.Print();


        }
    }
}

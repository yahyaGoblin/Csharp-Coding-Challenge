namespace Ans_57
{
    internal abstract class Shape
    {
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
    }

    internal class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (Width + Height);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(5.0, 3.0);
            Console.WriteLine($"Area: {rect.CalculateArea()}");
            Console.WriteLine($"Perimeter: {rect.CalculatePerimeter()}");
        }
    }
}
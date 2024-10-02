namespace Ans_53
{
    public class AreaOfRectangle
    {
        public int Length { get; set; }
        public int Breadth { get; set; }

        public AreaOfRectangle(int length, int breadth)
        {
            Length = length;
            Breadth = breadth;
        }

        public void Display()
        {
            Console.WriteLine("Length: " + Length);
            Console.WriteLine("Breadth: " + Breadth);
            Console.WriteLine("Area: " + Length * Breadth);
        }
    }

    public class Perimeter
    {
        public int Length { get; set; }
        public int Breadth { get; set; }

        public Perimeter(int length, int breadth)
        {
            Length = length;
            Breadth = breadth;
        }

        public void Display()
        {
            Console.WriteLine("Length: " + Length);
            Console.WriteLine("Breadth: " + Breadth);
            Console.WriteLine("Perimeter: " + 2 * (Length + Breadth));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AreaOfRectangle areaOfRectangle = new AreaOfRectangle(10, 20);
            areaOfRectangle.Display();
            Perimeter perimeter = new Perimeter(10, 20);
            perimeter.Display();
        }
    }
}

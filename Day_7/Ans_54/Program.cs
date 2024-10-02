namespace Ans_54
{
    public class AreaOfCircle
    {
        public double Radius { get; set; }

        public AreaOfCircle(double radius)
        {
            Radius = radius;
        }

        public void Display()
        {
            Console.WriteLine("Radius: " + Radius);
            Console.WriteLine("Area: " + Math.PI * Radius * Radius);
        }
    }

    public class circumferenceOfCircle
    {
        public double Radius { get; set; }

        public circumferenceOfCircle(double radius)
        {
            Radius = radius;
        }

        public void Display()
        {
            Console.WriteLine("Radius: " + Radius);
            Console.WriteLine("Circumference: " + 2 * Math.PI * Radius);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AreaOfCircle areaOfCircle = new AreaOfCircle(10);
            areaOfCircle.Display();
            circumferenceOfCircle circumferenceOfCircle = new circumferenceOfCircle(10);
            circumferenceOfCircle.Display();
        }
    }
}

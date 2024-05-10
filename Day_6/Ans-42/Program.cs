namespace Ans_42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Area of Circle Calculation");
            Console.WriteLine("Enter Radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Area of Circle: " + AreaOfCircle(radius));

        }

        public static double AreaOfCircle(double radius)
        {
            return Math.PI * radius * radius;
        }
    }
}

namespace Ans_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Volume of a Cylinder Program");

            Console.WriteLine("Enter the radius of the cylinder");
            double radius = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Enter the height of the cylinder");
            double height = Convert.ToDouble(Console.ReadLine());

            double volume = Math.PI * Math.Pow(radius, 2) * height;

            Console.WriteLine("Volume of the cylinder is: " + volume);
        }
    }
}
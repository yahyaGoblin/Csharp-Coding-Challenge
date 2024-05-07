namespace Ans_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Area of Circle Program");
            
            Console.WriteLine("Enter the radius of the circle");
            double radius = Convert.ToDouble(Console.ReadLine());

            double area = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine("Area of the circle is: " + area);
        
        }
    }
}
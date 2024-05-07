namespace Ans_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("distance between two points:");
            
            Console.WriteLine("Enter the value of x1:");
            double x1 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Enter the value of y1:");
            double y1 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Enter the value of x2:");
            double x2 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Enter the value of y2:");
            double y2 = Convert.ToDouble(Console.ReadLine());
            
            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            
            Console.WriteLine("Distance: " + distance);

        }
    }
}
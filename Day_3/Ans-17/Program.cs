namespace Ans_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Area of Triangle Calculator by its lenghts of all three sides");
            
            Console.WriteLine("Enter the base of the triangle: ");
            double b = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Enter the height of the triangle: ");
            double h = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Enter the hypotenuse of the triangle: ");
            
            double c = Convert.ToDouble(Console.ReadLine());
            double s = (b + h + c) / 2;
            double area = Math.Sqrt(s * (s - b) * (s - h) * (s - c));
            
            Console.WriteLine("The area of the triangle is: " + area);
            
        }
    }
}
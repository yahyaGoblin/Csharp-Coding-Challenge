namespace Ans_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CALCULATING AREA OF RECTANGLE ");
            Console.WriteLine("Enter the length of the rectangle");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the height of the rectangle");
            int height = Convert.ToInt32(Console.ReadLine());

            int area = length * height;

            Console.WriteLine($"The area of the rectangle is {area}");
            
        }
    }
}
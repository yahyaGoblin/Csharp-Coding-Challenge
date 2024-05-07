namespace Ans_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inches to Centimeters Program");

            Console.WriteLine("Enter the length in inches");
            double inches = Convert.ToDouble(Console.ReadLine());

            double centimeters = inches * 2.54;

            Console.WriteLine("Length in centimeters is: " + centimeters);
        }
    }
}
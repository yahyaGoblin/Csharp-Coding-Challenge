namespace Ans_31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary to Decimal Conversion");
            Console.WriteLine("Enter a binary number to convert it into decimal");
            string input = Console.ReadLine();
            Console.WriteLine($"Decimal of {input} is {BinaryToDecimal(input)}");
        }

        public static int BinaryToDecimal(string input)
        {
            int decimalValue = 0;
            for (int i = 0; i < input.Length; i++)
            {
                decimalValue += (int) (int.Parse(input[i].ToString()) * Math.Pow(2, input.Length - i - 1));
            }
            return decimalValue;
        }
    }
}
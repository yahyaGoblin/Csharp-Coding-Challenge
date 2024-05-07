namespace Ans_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Random Password Generator");
            Console.WriteLine("Enter the length of the password");
            int length = Convert.ToInt32(Console.ReadLine());
            string password = "";
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                int ascii = random.Next(33, 126);
                password += Convert.ToChar(ascii);
            }
            Console.WriteLine("Password: " + password);
            
        }
    }
}
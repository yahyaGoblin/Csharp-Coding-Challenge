namespace Ans_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number Guessing Game");
            Console.WriteLine("Guess a number between 1 and 100");
            Random random = new Random();
            int randomNumber = random.Next(1, 101);
            int guess = 0;
            int attempts = 0;
            while (guess != randomNumber)
            {
                guess = Convert.ToInt32(Console.ReadLine());
                attempts++;
                if (guess < randomNumber)
                {
                    Console.WriteLine("Too low. Try again.");
                }
                else if (guess > randomNumber)
                {
                    Console.WriteLine("Too high. Try again.");
                }
                else
                {
                    Console.WriteLine($"Congratulations! You guessed the number in {attempts} attempts.");
                }
            }
        }
    }
}
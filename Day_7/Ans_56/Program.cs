namespace Ans_56
{
    public class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }

        public Customer(string name, string email, long phone)
        {
            Name = name;
            Email = email;
            Phone = phone;
        }

        public void Display()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("Phone: " + Phone);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer("John Doe", "ABC.123@XYZ.COM", 1234567890);
            customer.Display();
        }
    }
}

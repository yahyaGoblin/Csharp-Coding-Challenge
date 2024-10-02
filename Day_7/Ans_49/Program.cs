
namespace Ans_49
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public Person(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public void Display()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Gender: " + Gender);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("John Doe", 30, "Male");
            person.Display();
        }
    }
}
namespace Ans_51
{
    public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Grade { get; set; }

    public Student(string name, int age, string grade)
    {
        Name = name;
        Age = age;
        Grade = grade;
    }

    public void Display()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Grade: " + Grade);
    }
}

    class Program
{
    static void Main(string[] args)
    {
        Student student = new Student("John Doe", 20, "A");
        student.Display();
    }
}
}

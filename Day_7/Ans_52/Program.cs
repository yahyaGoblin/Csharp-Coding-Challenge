namespace Ans_52
{
    public class Car
{
    public string Make { get; set; }
    public int Model { get; set; }
    public int Year { get; set; }

    public Car(string make, int model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }

    public void Display()
    {
        Console.WriteLine("Make: " + Make);
        Console.WriteLine("Model: " + Model);
        Console.WriteLine("Year: " + Year);
    }
}

    class Program
{
    static void Main(string[] args)
    {
        Car car = new Car("Toyota", 2020, 2020);
        car.Display();
    }
}
}

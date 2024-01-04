namespace Garage;

public class Vehicle
{
    public string MainColor { get; set; }
    public string Name { get; set; }
    public int MaximumOccupancy { get; set; }

    public virtual void Drive()
    {
        Console.WriteLine("Vroom");
    }

    public virtual void Turn(string direction)
    {
        Console.WriteLine("But then it went BACKWARDS!!");
    }
    public virtual void Stop()
    {
        Console.WriteLine("Finally, it screeched to a stop...");
    }

}


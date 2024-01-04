namespace Garage;

public class Cessna : Vehicle
{
    public double FuelCapacity { get; set; }

    public void RefuelTank()
    {
        // method definition omitted
    }

    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} {Name} drove by like Screeeeeech!");
    }

    public override void Turn(string direction)
    {
        Console.WriteLine($"Then it went {direction}!");
    }

    public override void Stop()
    {
        Console.WriteLine("It never stopped...");
    }
}
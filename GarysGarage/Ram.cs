namespace Garage;

public class Ram : Vehicle  // Gas powered truck
{
    public double FuelCapacity { get; set; }

    public void RefuelTank()
    {
        // method definition omitted
    }

    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} {Name} drove by like WooWooWoo!");
    }
    public override void Turn(string direction)
    {
        Console.WriteLine($"Then it went {direction}!");
    }
    public override void Stop()
    {
        Console.WriteLine("Finally, it stopped... or did it?");
    }
}
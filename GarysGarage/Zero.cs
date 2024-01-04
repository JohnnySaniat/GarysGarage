﻿namespace Garage;

public class Zero : Vehicle  // Electric motorcycle
{
    public double BatteryKWh { get; set; }

    public void ChargeBattery()
    {
        // method definition omitted
    }
    public override void Drive()
    {
        Console.WriteLine($"The {MainColor} {Name} drove by like Screeeeeeeee!");
    }
    public override void Turn(string direction)
    {
        Console.WriteLine($"Then it went {direction}!");
    }
    public override void Stop()
    {
        Console.WriteLine("Goodbye!");
    }
}

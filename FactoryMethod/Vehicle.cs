namespace FactoryMethod;

public interface IVehicle
{
    void DisplayInfo();
    double CalculateCost(double distance);
}

public class Car : IVehicle
{
    public void DisplayInfo()
    {
        Console.WriteLine("This is a Car.");
    }

    public double CalculateCost(double distance)
    {
        var costPerMile = 0.5;
        return distance * costPerMile;
    }
}

public class Truck : IVehicle
{
    public void DisplayInfo()
    {
        Console.WriteLine("This is a Truck.");
    }

    public double CalculateCost(double distance)
    {
        var costPerMile = 1.2;
        return distance * costPerMile;
    }
}
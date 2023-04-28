namespace FactoryMethod;

public abstract class VehicleFactory
{
    public abstract IVehicle CreateVehicle();

    public static VehicleFactory GetFactory(string vehicleType)
    {
        return vehicleType switch
        {
            "Car" => new CarFactory(),
            "Truck" => new TruckFactory(),
            _ => throw new ArgumentException("Invalid vehicle type.")
        };
    }
}

public class CarFactory : VehicleFactory
{
    public override IVehicle CreateVehicle()
    {
        return new Car();
    }
}

public class TruckFactory : VehicleFactory
{
    public override IVehicle CreateVehicle()
    {
        return new Truck();
    }
}
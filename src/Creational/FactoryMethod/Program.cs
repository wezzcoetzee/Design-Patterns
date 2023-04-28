using FactoryMethod;

Console.WriteLine("Enter vehicle type (Car/Truck): ");
var vehicleType = Console.ReadLine();

try
{
    if (string.IsNullOrEmpty(vehicleType))
        throw new ArgumentNullException();

    var factory = VehicleFactory.GetFactory(vehicleType);
    var vehicle = factory.CreateVehicle();

    vehicle.DisplayInfo();
    var cost = vehicle.CalculateCost(100);
    Console.WriteLine($"The cost for 100 miles is: {cost}");
}
catch (ArgumentException e)
{
    Console.WriteLine(e.Message);
}
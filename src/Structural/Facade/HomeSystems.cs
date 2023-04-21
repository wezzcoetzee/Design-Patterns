namespace Facade;

public class Lights
{
    public static void On() => Console.WriteLine("Lights are turned on.");
    public static void Off() => Console.WriteLine("Lights are turned off.");
}

public class Heating
{
    public void SetTemperature(int temperature) => Console.WriteLine($"Heating temperature set to {temperature}°C.");
}

public class Security
{
    public static void Arm() => Console.WriteLine("Security system armed.");
    public static void Disarm() => Console.WriteLine("Security system disarmed.");
}
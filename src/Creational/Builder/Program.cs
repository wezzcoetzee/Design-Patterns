using Builder;

var car = new Car.CarBuilder()
    .SetMake("Toyota")
    .SetModel("Camry")
    .SetYear(2023)
    .SetColor("Blue")
    .Build();

Console.WriteLine($"Car details: {car.Make}, {car.Model}, {car.Year}, {car.Color}");
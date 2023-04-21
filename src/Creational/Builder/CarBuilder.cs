namespace Builder;

public class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }

    public Car(CarBuilder builder)
    {
        Make = builder.Make;
        Model = builder.Model;
        Year = builder.Year;
        Color = builder.Color;
    }

    public class CarBuilder
    {
        public string Make { get; private set; } = "";
        public string Model { get; private set; } = "";
        public int Year { get; private set; }
        public string Color { get; private set; } = "";

        public CarBuilder SetMake(string make)
        {
            Make = make;
            return this;
        }

        public CarBuilder SetModel(string model)
        {
            Model = model;
            return this;
        }

        public CarBuilder SetYear(int year)
        {
            Year = year;
            return this;
        }

        public CarBuilder SetColor(string color)
        {
            Color = color;
            return this;
        }

        public Car Build()
        {
            return new Car(this);
        }
    }
}
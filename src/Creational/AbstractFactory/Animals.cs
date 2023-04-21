namespace AbstractFactory;

public interface IAnimal
{
    string Speak();
}

public class Dog : IAnimal
{
    public string Speak()
    {
        return "Woof";
    }
}

public class Cat : IAnimal
{
    public string Speak()
    {
        return "Meow";
    }
}
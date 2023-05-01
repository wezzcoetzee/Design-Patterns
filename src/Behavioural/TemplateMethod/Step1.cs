namespace TemplateMethod;

public abstract class FoodPreparation
{
    public void PrepareFood()
    {
        GatherIngredients();
        Cook();
        Serve();
    }

    protected abstract void GatherIngredients();
    protected abstract void Cook();
    protected virtual void Serve()
    {
        Console.WriteLine("Serving the food.");
    }
}
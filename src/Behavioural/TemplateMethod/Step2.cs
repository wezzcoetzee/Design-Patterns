namespace TemplateMethod;

public class PizzaPreparation : FoodPreparation
{
    protected override void GatherIngredients()
    {
        Console.WriteLine("Gathering ingredients for pizza: dough, sauce, cheese, toppings.");
    }

    protected override void Cook()
    {
        Console.WriteLine("Baking the pizza in the oven.");
    }
}

public class SaladPreparation : FoodPreparation
{
    protected override void GatherIngredients()
    {
        Console.WriteLine("Gathering ingredients for salad: lettuce, tomatoes, cucumbers, dressing.");
    }

    protected override void Cook()
    {
        Console.WriteLine("Mixing the salad ingredients.");
    }
}
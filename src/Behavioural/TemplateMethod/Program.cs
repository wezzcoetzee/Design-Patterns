using TemplateMethod;

var pizzaPreparation = new PizzaPreparation();
var saladPreparation = new SaladPreparation();

Console.WriteLine("Preparing pizza:");
pizzaPreparation.PrepareFood();

Console.WriteLine("\nPreparing salad:");
saladPreparation.PrepareFood();
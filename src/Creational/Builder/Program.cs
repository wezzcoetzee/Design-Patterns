using Builder;

var myPizza = new Pizza.PizzaBuilder()
    .WithDough("Thin crust")
    .WithSauce("Marinara")
    .WithToppings("Pepperoni, Olives")
    .AddExtraCheese(true)
    .Build();

Console.WriteLine($"Pizza details: {myPizza.Dough}, {myPizza.Sauce}, {myPizza.Toppings}, Extra cheese: {myPizza.IsExtraCheese}");
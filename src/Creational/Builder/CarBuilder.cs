namespace Builder;

public class Pizza
{
    public string Dough { get; private set; }
    public string Sauce { get; private set; }
    public string Toppings { get; private set; }
    public bool IsExtraCheese { get; private set; }

    private Pizza(PizzaBuilder builder)
    {
        Dough = builder.Dough;
        Sauce = builder.Sauce;
        Toppings = builder.Toppings;
        IsExtraCheese = builder.IsExtraCheese;
    }

    public class PizzaBuilder
    {
        public string Dough { get; private set; } = "";
        public string Sauce { get; private set; } = "";
        public string Toppings { get; private set; } = "";
        public bool IsExtraCheese { get; private set; }

        public PizzaBuilder WithDough(string dough)
        {
            Dough = dough;
            return this;
        }

        public PizzaBuilder WithSauce(string sauce)
        {
            Sauce = sauce;
            return this;
        }

        public PizzaBuilder WithToppings(string toppings)
        {
            Toppings = toppings;
            return this;
        }

        public PizzaBuilder AddExtraCheese(bool isExtraCheese)
        {
            IsExtraCheese = isExtraCheese;
            return this;
        }

        public Pizza Build()
        {
            return new Pizza(this);
        }
    }
}
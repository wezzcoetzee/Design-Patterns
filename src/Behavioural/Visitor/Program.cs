using Visitor;

var items = new List<Item>
{
    new Book { Title = "The Art of Computer Programming", Price = 100 },
    new Food { Name = "Cheeseburger", Price = 10 }
};

var percentageDiscountVisitor = new PercentageDiscountVisitor(0.1);
var fixedDiscountVisitor = new FixedDiscountVisitor(5);

foreach (var item in items)
{
    item.Accept(percentageDiscountVisitor);
    Console.WriteLine($"New price after percentage discount: {item.Price}");

    item.Accept(fixedDiscountVisitor);
    Console.WriteLine($"New price after fixed discount: {item.Price}");
}
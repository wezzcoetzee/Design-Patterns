namespace Visitor;

public class PercentageDiscountVisitor : IVisitor
{
    private double _discount;

    public PercentageDiscountVisitor(double discount)
    {
        _discount = discount;
    }

    public void Visit(Book book)
    {
        book.Price *= (1 - _discount);
    }

    public void Visit(Food food)
    {
        food.Price *= (1 - _discount);
    }
}

public class FixedDiscountVisitor : IVisitor
{
    private double _discount;

    public FixedDiscountVisitor(double discount)
    {
        _discount = discount;
    }

    public void Visit(Book book)
    {
        book.Price -= _discount;
    }

    public void Visit(Food food)
    {
        food.Price -= _discount;
    }
}
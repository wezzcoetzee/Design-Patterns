namespace Visitor;

public abstract class Item
{
    public double Price { get; set; }
    public abstract void Accept(IVisitor visitor);
}

public class Book : Item
{
    public string Title { get; set; }

    public override void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}

public class Food : Item
{
    public string Name { get; set; }

    public override void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}
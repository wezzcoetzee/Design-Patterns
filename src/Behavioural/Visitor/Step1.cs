namespace Visitor;

public interface IVisitor
{
    void Visit(Book book);
    void Visit(Food food);
}
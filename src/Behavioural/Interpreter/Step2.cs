namespace Interpreter;

public class Number : Expression
{
    private readonly int _value;

    public Number(int value)
    {
        _value = value;
    }

    public override int Interpret()
    {
        return _value;
    }
}

public class Add : Expression
{
    private readonly Expression _left;
    private readonly Expression _right;

    public Add(Expression left, Expression right)
    {
        _left = left;
        _right = right;
    }

    public override int Interpret()
    {
        return _left.Interpret() + _right.Interpret();
    }
}

public class Subtract : Expression
{
    private readonly Expression _left;
    private readonly Expression _right;

    public Subtract(Expression left, Expression right)
    {
        _left = left;
        _right = right;
    }

    public override int Interpret()
    {
        return _left.Interpret() - _right.Interpret();
    }
}
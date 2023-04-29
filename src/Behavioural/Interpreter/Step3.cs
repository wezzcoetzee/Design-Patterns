namespace Interpreter;

public class Parser
{
    public Expression Parse(string input)
    {
        var stack = new Stack<Expression>();

        foreach (var token in input.Split(' '))
        {
            if (int.TryParse(token, out int value))
            {
                stack.Push(new Number(value));
            }
            else
            {
                var right = stack.Pop();
                var left = stack.Pop();

                switch (token)
                {
                    case "+":
                        stack.Push(new Add(left, right));
                        break;
                    case "-":
                        stack.Push(new Subtract(left, right));
                        break;
                }
            }
        }

        return stack.Pop();
    }
}
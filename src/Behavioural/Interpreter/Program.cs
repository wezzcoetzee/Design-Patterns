using Interpreter;

var input = "3 4 + 2 -";
var parser = new Parser();
var expression = parser.Parse(input);
Console.WriteLine($"{input} = {expression.Interpret()}");
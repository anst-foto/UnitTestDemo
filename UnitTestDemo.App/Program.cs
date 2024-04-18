using UnitTestDemo.Core;

var x = 1.0;
var y = 0.0;

var result = Calculate.Add(x, y);
Console.WriteLine($"{x} + {y} = {result}");

result = Calculate.Sub(x, y);
Console.WriteLine($"{x} - {y} = {result}");

result = Calculate.Mul(x, y);
Console.WriteLine($"{x} * {y} = {result}");

result = Calculate.Div(x, y);
Console.WriteLine($"{x} / {y} = {result}");
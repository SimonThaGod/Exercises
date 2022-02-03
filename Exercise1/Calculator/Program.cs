// See https://aka.ms/new-console-template for more information


Console.WriteLine("Hello, World!");
Calculator.Calculator calc = new();

const double one = -12;
const double two = -2;

Console.WriteLine($"{one} * {two} = {calc.Multiply(one, two)}");
Console.WriteLine($"{one}^{two} = {calc.Power(one, two)}");
Console.WriteLine($"{one} + {two} = {calc.Add(one, two)}");
Console.WriteLine($"{one} - {two} = {calc.Subtract(one, two)}");
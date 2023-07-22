// See https://aka.ms/new-console-template for more information

using Study.Exponential;

var unit = Calculator.UNIT;
var zero = Calculator.Times(0, unit);
var one = Calculator.Times(1, unit);
var three = Calculator.Times(3, unit);

Console.WriteLine(Calculator.Print(zero));
Console.WriteLine(Calculator.Print(one));
Console.WriteLine(Calculator.Print(three));
Console.WriteLine(Calculator.Print(Calculator.Times(4, three)));
Console.WriteLine(Calculator.Print(Calculator.Power(3, 0)));
Console.WriteLine(Calculator.Print(Calculator.Power(3, 1)));
Console.WriteLine(Calculator.Print(Calculator.Power(3, 2)));
Console.WriteLine(Calculator.Print(Calculator.Power(3, 3)));
Console.WriteLine(Calculator.Print(Calculator.Power(0, 3)));
Console.WriteLine(Calculator.Print(Calculator.Power(0, 0)));

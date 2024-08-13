using System.Numerics;

double aVal, bVal, result;

Console.WriteLine("-----------------");
Console.WriteLine("Input your numbers");
Console.WriteLine("a=");
string a = Console.ReadLine();

Console.WriteLine("b=");
string b = Console.ReadLine();

if (double.TryParse(a, out aVal) == false | double.TryParse(b, out bVal) )
    { Console.WriteLine("invalid input"); }


Console.WriteLine("Select operation: +,-,*,/,^ ");
string op = Console.ReadLine();

switch (op)
{
        case "+":
            result = addOp(aVal,bVal);
            break;
        case "-":
            result = subtractOp(aVal,bVal);
            break;
        case "*":
            result = multiplyOp(aVal,bVal);
            break;
        case "/":
            result = divideOp(aVal,bVal);
            break;
        case "^":
            result = powerOp(aVal,bVal);
            break;
default:
        break;
}

double addOp(double a, double b)
{
    return a + b;
}

double subtractOp(double a, double b)
{
    return a - b;
}

double multiplyOp(double a, double b)
{
    return a * b;
}

double divideOp(double a, double b)
{
    return a / b;
}

double powerOp(double a, double b)
{
    return Math.Pow(a, b);
}


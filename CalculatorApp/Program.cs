bool running = true;

while (running == true)
{   try
    {
        double aVal, bVal, result;

        Console.WriteLine("-----------------");
        Console.WriteLine("Input your numbers");
        Console.WriteLine("a=");
        string a = Console.ReadLine();

        Console.WriteLine("b=");
        string b = Console.ReadLine();

        if (double.TryParse(a, out aVal) == false || double.TryParse(b, out bVal) == false)
        {
            Console.WriteLine("invalid input");
            continue;
        }


        Console.WriteLine("Select operation: +,-,*,/,^ ");
        string op = Console.ReadLine();

        switch (op)
        {
            case "+":
                result = AddOp(aVal, bVal);
                break;
            case "-":
                result = SubtractOp(aVal, bVal);
                break;
            case "*":
                result = MultiplyOp(aVal, bVal);
                break;
            case "/":
                result = DivideOp(aVal, bVal);
                break;
            case "^":
                result = PowerOp(aVal, bVal);
                break;
            default:
                Console.WriteLine("Invalid operation selected");
                result = double.NaN;
                break;
        }
        result = Math.Round(result);
        Console.WriteLine("the result of the {0} {1} {2} operation is {3}", a, op, b, result);
        Console.WriteLine("do you wish to continue? (Y/n)");
        string decision = Console.ReadLine();
        if(decision == "n")
            running = false;

    }
    catch(Exception e)
    {

    }
}


double AddOp(double a, double b)
{
    return a + b;
}

double SubtractOp(double a, double b)
{
    return a - b;
}

double MultiplyOp(double a, double b)
{
    return a * b;
}

double DivideOp(double a, double b)
{
    if( b == 0)
    {
        Console.WriteLine("Can't divide by 0");
        return double.NaN;
    }
    return a / b;
}

double PowerOp(double a, double b)
{
    return Math.Pow(a, b);
}


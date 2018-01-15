using System;


class Calc
{
    static double GetDoubleFromConsole() {
        double x;

        Console.WriteLine("Enter a number:");
        while (!double.TryParse(Console.ReadLine(), out x)) {
            Console.WriteLine("Invalid value, please enter a number.");
        }
        return x;
    }

    static void Main()
    {
        double x, y, result;
        string op;

        x = GetDoubleFromConsole();
        y = GetDoubleFromConsole();

        Console.WriteLine("Enter an operator:");
        op_input:
        op = Console.ReadLine();

        switch(op)
        {
            case "+":
                result = x + y;
                break;
            case "-":
                result = x - y;
                break;
            case "*":
                result = x*y;
                break;
            case "/":
                result = x / y;
                break;
            default:
                Console.WriteLine("Invalid operator, must be +, -, *, or /:");
                goto op_input;
        }

        Console.WriteLine("{0} {1} {2} = {3}", x, op, y, result);

        Console.WriteLine("\n<Press Return to quit>");
        Console.Read();
    }
}
PrintArithmeticResult(6,6,"add");
PrintArithmeticResult(6,6,"subtract");
PrintArithmeticResult(6,6,"multiply");
PrintArithmeticResult(6,6,"divide");

return;

double Arithmetic(double a, double b, string op)
{
    return op switch
    {
        "add" => a + b,
        "subtract" => a - b,
        "multiply" => a * b,
        "divide" => b != 0 ? a / b : throw new DivideByZeroException(),
        _ => throw new Exception("Unsupported operation, check code.")
    };
}

void PrintArithmeticResult(double a, double b, string op)
{
    try
    {
        var result = Arithmetic(a, b, op);
        var operation = op switch
        {
            "add" => "+",
            "subtract" => "-",
            "multiply" => "*",
            "divide" => "^",
            _ => ""
        };

        Console.WriteLine($"{a} {operation} {b} = {result}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
}
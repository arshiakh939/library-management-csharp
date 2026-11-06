Console.Write("Enter your first number: ");
string? input1 = Console.ReadLine();

Console.Write("Enter your second number: ");
string? input2 = Console.ReadLine();

Console.Write("Please enter an operation (+, -, *, /): ");
string? op = Console.ReadLine();

if (int.TryParse(input1, out int number1))
{
    if (int.TryParse(input2, out int number2))
    {
        int answer = 0;

        if (op == "+")
        {
            answer = number1 + number2;
        }
        else if (op == "-")
        {
            answer = number1 - number2;
        }
        else if (op == "*")
        {
            answer = number1 * number2;
        }
        else if (op == "/")
        {
            if (number2 != 0)
            {
                answer = number1 / number2;
            }
            else
            {
                Console.WriteLine("Cannot divide by zero!");
                return;
            }
        }
        else
        {
            Console.WriteLine("Enter a valid operation");
            return;
        }

        Console.WriteLine($"The answer is {answer}");
    }
    else
    {
        Console.WriteLine("Please enter a valid second number");
    }
}
else
{
    Console.WriteLine("Please enter a valid first number");
}
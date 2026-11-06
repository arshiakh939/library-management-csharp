using System.Globalization;
string? input1;
string? input2;
string? op;
string? check;
double number1;
double number2;
do
{
    

    do
    {
        Console.Write("Enter your first valid number:");
        input1 = Console.ReadLine();
    }
    while(!double.TryParse(input1,out number1));


    do
    {
        Console.Write("Enter your second valid number:");
        input2 = Console.ReadLine();
    }
    while(!double.TryParse(input2, out number2));

    
    Console.Write("Enter your valid oper:");
    op = Console.ReadLine();

    switch (op)
    {
        case "+":
            Console.WriteLine(number1 + number2);
            break;
        
        case "-":
            Console.WriteLine(number1 + number2);
            break;

        case "*":
            Console.WriteLine(number1 * number2);
            break;

        case "/":
            if (number2 == 0)
            {
                Console.WriteLine("Zero division");
                break;
            }
            else
            {
                Console.WriteLine(number1 / number2);
                break;
            }
    }



Console.Write("Do you want to continuie? (y/n)");
check = Console.ReadLine();


    
}
while (check == "y");
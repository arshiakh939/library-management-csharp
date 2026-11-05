Console.Write("Enter your age:");

String? input = Console.ReadLine();

if(int.TryParse(input, out int age)){
    int n_age = age + 1;
    Console.WriteLine($"Next year Your age is {n_age}");
}
else{
    Console.WriteLine("Please enter a valid number");
}
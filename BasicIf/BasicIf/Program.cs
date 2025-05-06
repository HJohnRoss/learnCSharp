string? firstName = null;

Console.Write("Enter your first name: ");

firstName = Console.ReadLine();

if (firstName == null)
{
    Console.WriteLine("firstName is invalid");
    return;
}

if (firstName.ToLower() == "tim")
{
    Console.WriteLine("Welcome proffessor Tim");
}
else
{
    Console.WriteLine($"Welcome student {firstName}");
}
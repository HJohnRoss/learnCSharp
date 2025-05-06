// 2 variables for name and age
// 1 methods for gathering name and age data
// 1 method for checking if the student is an adult

using System.Runtime.InteropServices;

string? name = null;
int? age = null;
string? ageString = null;

getData();
if(name == null)
{
    Console.WriteLine("Invalid name");
    return;
}
if(ageString == null)
{
    Console.WriteLine("Invalid age");
    return;
}
else
{
    age = int.Parse(ageString);
}

printData();

void getData()
{
    Console.Write("Enter your name: ");
    name = Console.ReadLine();


    Console.Write("Enter your age: ");
    ageString = Console.ReadLine();
}

void printData()
{
    if(age < 21)
    {
        Console.WriteLine($"{name} is a student. you can be a professor in {21 - age} years");
        return;
    }
    else if (name.ToLower() == "tom" || name.ToLower() == "sue")
    {
        Console.WriteLine($"{name} is a proffessor. you are {age} years old");
        return;
    }
    else
    {
        Console.WriteLine($"{name} are old enough to be a proffessor!");
    }
}
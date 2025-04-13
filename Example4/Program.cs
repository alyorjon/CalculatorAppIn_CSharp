/*
Starts and Ends: Ask the user to input a string. Check if the string starts with "A" or ends with "Z" using StartsWith and EndsWith.
*/
Console.WriteLine("Enter a string: ");
string? inputString = Console.ReadLine();
if (inputString != null)
{
    if (inputString.StartsWith("A") && inputString.EndsWith("Z"))
    {
        Console.WriteLine("The string starts with 'A' and ends with 'Z'.");
    }
    else if (inputString.StartsWith("A"))
    {
        Console.WriteLine("The string starts with 'A'.");
    }
    else if (inputString.EndsWith("Z"))
    {
        Console.WriteLine("The string ends with 'Z'.");
    }
    else
    {
        Console.WriteLine("The string does not start with 'A' or end with 'Z'.");
    }
}
else
{
    Console.WriteLine("Invalid input. Please enter a valid string.");
}
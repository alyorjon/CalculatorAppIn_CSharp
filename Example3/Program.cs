/*
Character Check: Write a program that checks if a given character is a vowel or consonant using if-else.
*/

Console.WriteLine("Enter a character: ");
string? character = Console.ReadLine();
char ch = Convert.ToChar(character);
if (char.TryParse(character, out char result))
{
    if (char.IsLetter(ch))
    {
        if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' ||
            ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
        {
            Console.WriteLine("The character is a vowel.");
        }
        else
        {
            Console.WriteLine("The character is a consonant.");
        }
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a letter.");
    }
}
else
{
    Console.WriteLine("Invalid input. Please enter a valid character.");
}
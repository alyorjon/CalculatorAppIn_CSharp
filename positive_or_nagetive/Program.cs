/*Positive or Negative: Write a program that asks the user to enter a number. Use if-else to determine if the number is positive, negative, or zero.*/

Console.WriteLine("Enter a number: ");
string? number = Console.ReadLine();
int num = Convert.ToInt32(number);
if (int.TryParse(number, out int result))
{
    if (num > 0 && num%2==0)
    {
        Console.WriteLine("The number is positive and add.");
    }
    else if (num > 0 && num%2!=0)
    {
        Console.WriteLine("The number is positive and odd.");
    }
    else if (num == 0)
    {
        Console.WriteLine("The number is zero.");
    }
    else
    {
        Console.WriteLine("The number is negative.");
    }
}
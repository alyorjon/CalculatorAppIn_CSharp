/*
Day of the Week: Use switch-case to display the name of the day (e.g., Monday for 1, Tuesday for 2). Handle invalid inputs.*/

Console.WriteLine("Enter a number between 1 and 7: ");
string? dayNumber = Console.ReadLine();
int day = Convert.ToInt32(dayNumber);
switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
    default:
        Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
        break;
}
Console.WriteLine("Enter \"first\" number: "); /*Escape character*/
int firstInput=int.Parse(Console.ReadLine());
Console.WriteLine("Enter second number: ");
int secondInput=int.Parse(Console.ReadLine());
Console.WriteLine("Enter operator (+, -, *, /): ");
string operatorInput=Console.ReadLine();    
Console.WriteLine(firstInput+secondInput);
Console.WriteLine(firstInput-secondInput);
Console.WriteLine(firstInput*secondInput);
Console.WriteLine(firstInput/secondInput);
Console.WriteLine(firstInput%secondInput);
// Console.WriteLine(firstInput+secondInput);
Console.WriteLine($"{firstInput} datas{secondInput}");

Console.WriteLine("Input your name: ");
// string name=Console.ReadLine();
// Console.WriteLine($"Hello {name}, welcome to the calculator program!");
// int charPosition=name.IndexOf("i");
// Console.WriteLine($"The position of 'i' in your name is: {charPosition}");

bool isTrue=true;
bool isFalse=false;
Console.WriteLine(isTrue && isFalse); // false
Console.WriteLine(isTrue || isFalse); // true


/* If statement */
if (firstInput > secondInput)
{
    Console.WriteLine("First number is greater than second number");
}
else if (firstInput < secondInput)
{
    Console.WriteLine("First number is less than second number");
}
else
{
    Console.WriteLine("Both numbers are equal");
}


/* if else in ternary operator */
int maxNumber = (firstInput > secondInput) ? firstInput : secondInput;
Console.WriteLine($"The maximum number is: {maxNumber}");

/* calculate the age of a person  who participate army*/
Console.WriteLine("Enter your birth year: ");
int birthYear=int.Parse(Console.ReadLine());
int currentYear=DateTime.Now.Year;
int currentMonth=DateTime.Now.Month;
int currentDay=DateTime.Now.Day;
Console.WriteLine($"Current date is: {currentDay}/{currentMonth}/{currentYear}");
int age=currentYear-birthYear;
Console.WriteLine($"Your age is: {age}");
Console.WriteLine("You are eligible to join the army: " + (age >= 18 ? "Yes" : "No"));

if (age<18)
{
    Console.WriteLine("You are not eligible to join the army");
}
else if (age>=18 && age<27)
{
    Console.WriteLine("You are eligible to join the army");
}
else
{
    Console.WriteLine("You are not eligible to join the army");
}

/* Switch statement */
switch (operatorInput)
{
    case "+":
        Console.WriteLine($"The result is: {firstInput + secondInput}");
        break;
    case "-":
        Console.WriteLine($"The result is: {firstInput - secondInput}");
        break;
    case "*":
        Console.WriteLine($"The result is: {firstInput * secondInput}");
        break;
    case "/":
        Console.WriteLine($"The result is: {firstInput / secondInput}");
        break;
    default:
        Console.WriteLine("Invalid operator");
        break;
}
/* show us the result of week day */
Console.WriteLine("Enter the number of the day of the week (1-7): ");
int dayOfWeek=int.Parse(Console.ReadLine());
switch (dayOfWeek)
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
        Console.WriteLine("Invalid day of the week");
        break;
}
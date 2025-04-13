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
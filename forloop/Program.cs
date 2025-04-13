/*
for loop in C#
for (initialization; condition; increment/decrement)
{
    // code to be executed
}
*/
for (int i=0;i<10;i++)
{
    Console.WriteLine("Hello World!");
}
Console.WriteLine("The loop has ended.");


/*
foreach loop in C#
foreach (dataType variable in collection)
{
    // code to be executed
}
// Example: Iterating through an array
*/
foreach (int number in new int[] { 1, 2, 3, 4, 5 })
{
    Console.WriteLine(number);
}
Console.WriteLine("The loop has ended.");
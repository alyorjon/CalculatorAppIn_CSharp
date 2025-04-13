/*Word Counter: Write a program that counts the number of words in a given sentence using Split.*/
Console.WriteLine("Enter a sentence: ");
string? sentence = Console.ReadLine();
if (sentence != null)
{
    string[] words = sentence.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
    int wordCount = words.Length;
    Console.WriteLine($"The number of words in the sentence is: {wordCount}");
}
else
{
    Console.WriteLine("Invalid input. Please enter a valid sentence.");
}
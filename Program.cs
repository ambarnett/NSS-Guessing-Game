using System;

int secNum = 42;
int count = 3;

Console.WriteLine("Try to guess the secret number!");
Console.Write("Enter a number: ");
string input = Console.ReadLine();
for (int i = 0; i <= 2; i++)
{
    int parsedInput = int.Parse(input);
    if (parsedInput == secNum)
    {
        Console.WriteLine("You guessed it!");
        return;
    }
    else
    {
        Console.WriteLine("Are you stupid?");
        Console.Write($"{count} tries remaining. Guess again...: ");
        input = Console.ReadLine();
        count--;
    }
}
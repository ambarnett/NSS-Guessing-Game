using System;
namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random num = new Random();
            int secNum = num.Next(1, 100);
            int count = 0;
            int difficulty = 0;
            Console.WriteLine("Select a difficulty level: ");
            Console.WriteLine("Enter 1 for Easy");
            Console.WriteLine("Enter 2 for Medium");
            Console.WriteLine("Enter 3 if you have problems");
            Console.WriteLine("Enter 7 for unlimited power");
            int diffSelection = int.Parse(Console.ReadLine());

            if (diffSelection == 1)
            {
                difficulty = 7;
                count = 7;
                Console.WriteLine("You selected Easy.");
            }
            else if (diffSelection == 2)
            {
                difficulty = 5;
                count = 5;
                Console.WriteLine("You selected Medium.");
            }
            else if (diffSelection == 3)
            {
                difficulty = 3;
                count = 3;
                Console.WriteLine("You have problems.");
            }
            else if (diffSelection == 7)
            {
                difficulty = int.MaxValue;
                count = int.MaxValue;
                Console.WriteLine("UNLIMITED POWER!");
            }
            else
            {
                Console.WriteLine("That's not a correct selection.");
                return;
            }

            Console.WriteLine("Try to guess the secret number!");
            Console.Write("Enter a number: ");
            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < difficulty; i++)
            {
                if (input > secNum)
                {
                    Console.WriteLine("To high...?");
                    Console.Write($"{count} tries remaining. Guess again...: ");
                    input = int.Parse(Console.ReadLine());
                    --count;
                }
                else if (input < secNum)
                {
                    Console.WriteLine("To low...");
                    Console.Write($"{count} tries remaining. Guess again...: ");
                    input = int.Parse(Console.ReadLine());
                    --count;
                }
                else if (input != secNum)
                {
                    Console.WriteLine("Are you stupid?");
                    Console.Write($"{count} tries remaining. Guess again...: ");
                    input = int.Parse(Console.ReadLine());
                    --count;
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    return;
                }
            }
        }
    }
}
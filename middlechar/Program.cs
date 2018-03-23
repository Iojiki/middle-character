using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Please enter a line of text");
        string testWord = Console.ReadLine();
        if (testWord.Length == 0)
        {
            Console.WriteLine(String.Empty);
            //So program doesn't immediatly end
            Console.ReadLine();
        }
        else if ((testWord.Length % 2) == 0)
        {
            int middleOne = ((testWord.Length) / 2) - 1;
            int middleTwo = ((testWord.Length) / 2);

            string evenPair = (testWord[middleOne]).ToString() + (testWord[middleTwo]).ToString();
            Console.WriteLine(evenPair);
            //So program doesn't immediatly end
            Console.ReadLine();

        }
        else
        {
            int middleChar = (testWord.Length - 1) / 2;
            char letter = testWord[middleChar];

            Console.WriteLine(letter);
            //So program doesn't immediatly end
            Console.ReadLine();
        }

    }
}

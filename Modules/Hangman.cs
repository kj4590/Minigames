using Minigames.Interfaces;

namespace Minigames.Modules;

public class Hangman : IModule
{
    public string Name => "Hangman";

    private string word = "";
    private Dictionary<char, int> revealedWord = new();
    private int attempts;

    public void Run()
    {
        word = GetRandomWord();           
        revealedWord = new();
        attempts = 15;

        Console.WriteLine("Hangman Game Starting...");

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Welcome to Hangman!");
            Console.WriteLine($"Attempts left: {attempts}\n");

            DisplayWord();

            Console.Write("\nEnter a letter: ");
            string? input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
                continue;

            char guess = char.ToLower(input[0]);

            ProcessGuess(guess);  

            if (CheckWin())
            {
                Console.WriteLine("\nYou won!");
                break;
            }

            if (attempts <= 0)
            {
                Console.WriteLine($"\nYou lost! The word was: {word}");
                break;
            }
        }
    }
    private string GetRandomWord()
    {
        var words = File.ReadAllLines("Data/words.txt");

        Random random = new Random();
        return words[random.Next(words.Length)].ToLower();
    }

    public void DisplayWord()
    {
        for (int i = 0; i < word.Length; i++)
        {
            char c = word[i];

            int revealed = revealedWord.ContainsKey(c) ? revealedWord[c] : 0;

            int countSoFar = 0;
            for (int j = 0; j <= i; j++)
            {
                if (word[j] == c)
                    countSoFar++;
            }

            if (revealed >= countSoFar)
                Console.Write(c + " ");
            else
                Console.Write("_ ");
        }

        Console.WriteLine();
    }

    public void ProcessGuess(char guess)
    {
        if (word.Contains(guess))
        {
            if (!revealedWord.ContainsKey(guess))
                revealedWord[guess] = 0;

            int totalOccurrences = word.Count(x => x == guess);

            if (revealedWord[guess] < totalOccurrences)
            {
                revealedWord[guess]++;
            }
        }
        else
        {
            attempts--;
        }
    }

    public bool CheckWin()
    {
        foreach (char c in word)
        {
            int totalOccurrences = word.Count(x => x == c);
            int revealed = revealedWord.ContainsKey(c) ? revealedWord[c] : 0;

            if (revealed < totalOccurrences)
            {
                return false;
            }
        }

        return true;
    }
}

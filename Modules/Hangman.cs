using System;
using System.Collections.Generic;
using Minigames.Interfaces;
using Minigames.DTOs;
using Minigames.Helpers;
using Minigames.Models;
using Minigames.Exceptions;
namespace Minigames.Modules;

public class Hangman : IModule
{
    // defining the different class variables: list, dictionary, integer, string
    public string Name => "Hangman";
    private User user;
    private string word = "";
    private readonly Dictionary<char, int> revealedWord = new();
    private readonly List<char> lettersHistory = new();
    private int numberOfAttempts;


    public Hangman(User user)
    {
        this.user = user;
    }

    public void Run()
    {
        lettersHistory = clear();
        // Using helper method to get a random word form a test file.
        word = WordHelper.GetRandomWord();
        revealedWord = clear();
        // number of attempts is initialized inside the loop , so that it can reset each time a game restarts
        numberOfAttempts = 15;

        Console.WriteLine("Hangman Game Starting...");
        Console.WriteLine("Welcome to Hangman!");

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Repeated words must be guessed more than once ");
            Console.WriteLine($"Attempts left: {numberOfAttempts}\n");
            Console.WriteLine($"Letters guessed: {string.Join(" ", lettersHistory)}\n");

            DisplayWord();

            Console.Write("\nEnter a letter: ");

            try
            {
                // DTO used to transfer validated input from helper to game logic
                GuessDto guessDto = InputHelper.GetLetterInput();

                lettersHistory.Add(guessDto.Letter);
                ProcessGuess(guessDto);
            }
            catch (InvalidInputException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
                continue;
            }

            if (CheckWin())
            {
                StatsHelper.Update(user.Stats.Hangman, true);
                Console.WriteLine("\nYou won!");
                break;
            }

            if (numberOfAttempts <= 0)
            {
                StatsHelper.Update(user.Stats.Hangman, false);
                Console.WriteLine($"\nYou lost! The word was: {word}");
                break;
            }
        }
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

    private void ProcessGuess(GuessDto guess)
    {
        Console.WriteLine();
        if (word.Contains(guess.Letter))
        {
            if (!revealedWord.ContainsKey(guess.Letter))
                revealedWord[guess.Letter] = 0;

            int totalOccurrences = word.Count(x => x == guess.Letter);

            if (revealedWord[guess.Letter] < totalOccurrences)
            {
                revealedWord[guess.Letter]++;
            }
        }
        else
        {
            numberOfAttempts--;
        }
    }

    private bool CheckWin()
    {
        foreach (char c in word)
        {
            int totalOccurrences = word.Count(x => x == c);
            //Using ternary to check if letter is in revealedWord. If it is present, get the value else return zero
            int revealed = revealedWord.ContainsKey(c) ? revealedWord[c] : 0;  

            if (revealed < totalOccurrences)
            {
                return false;
            }
        }

        return true;
    }

}

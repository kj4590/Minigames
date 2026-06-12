using Minigames.DTOs;
using Minigames.Exceptions;

namespace Minigames.Helpers;

public static class InputHelper
{
    public static GuessDto GetLetterInput()
    {
        string? input = Console.ReadLine();

        if (string.IsNullOrEmpty(input) || input.Length != 1)
            throw new InvalidInputException("Enter exactly one letter.");

        char guess = char.ToLower(input[0]);

        if (!char.IsLetter(guess))
            throw new InvalidInputException("Only letters allowed.");

        return new GuessDto(guess);
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Text.RegularExpressions;

namespace Minigames.Helpers;

public static class ExpressionHelper
{
    public static int? ValidateAndEvaluate(string? expression, List<int> allowedNumbers, int target)
    {
        if (string.IsNullOrWhiteSpace(expression))
        {
            Console.WriteLine("Expression cannot be empty!");
            return null;
        }

        if (!Regex.IsMatch(expression, @"^[0-9+\-*/\s()]+$"))
        {
            Console.WriteLine("Invalid characters in expression!");
            return null;
        }

        var matches = Regex.Matches(expression, @"\d+");

        List<int> numbersUsed = new List<int>();

        foreach (Match match in matches)
        {
            numbersUsed.Add(int.Parse(match.Value));
        }

        List<int> tempNumbers = new List<int>(allowedNumbers);

        foreach (int number in numbersUsed)
        {
            if (!tempNumbers.Contains(number))
            {
                Console.WriteLine($"Invalid number used: {number}");
                return null;
            }
            // ensures each number is used once
            tempNumbers.Remove(number);
        }

        int result;

        try
        {
            var eval = new DataTable().Compute(expression, null);
            result = Convert.ToInt32(eval);
        }
        catch
        {
            Console.WriteLine("Invalid mathematical expression!");
            return null;
        }

        int difference = Math.Abs(target - result);

        Console.WriteLine($"\nResult: {result}");
        Console.WriteLine($"Difference from target: {difference}");

        if (difference == 0)
        {
            Console.WriteLine(" Exact match!");
        }

        return difference;
    }
}
using System;
using System.Collections.Generic;
using Minigames.Interfaces;
using Minigames.Helpers;
using Minigames.DTOs;
using Minigames.Models;
namespace Minigames.Modules;

public class ExpressionGuess : IModule
{
    public string Name => "ExpressionGuess";
    private User user;

    public ExpressionGuess(User user)
    {
        this.user = user;
    }
    public void Run()
    {

        List<int> numbers = new() { 2, 5, 8, 10, 25, 50 };
        int target = 532;

        Console.WriteLine($"Target: {target}");
        Console.WriteLine($"Numbers: {string.Join(", ", numbers)}");

        Console.Write("\nEnter your expression: ");
        string? expression = Console.ReadLine();

        int? difference = ExpressionHelper.ValidateAndEvaluate(expression, numbers, target);

        if (difference.HasValue)
        {
            StatsHelper.Update(user.Stats.Numbers, difference.Value);
            if (difference == 0)
            {
                Console.WriteLine("Perfect match");
            } else if (Math.abs(difference) <= 10 )
            {
                Console.WriteLine("You were quite close");
            } else
            {
                Console.WriteLine("Nice try");
            }
        }
    }
}
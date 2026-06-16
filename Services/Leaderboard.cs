using Minigames.Models;
using Minigames.DTOs;

namespace Minigames.Services;

public class Leaderboard
{
    private List<User> users;

    public Leaderboard(List<User> users)
    {
        this.users = users;
    }

    // Returns top players for Hangman (based on wins)

   public List<LeaderboardDto> GetHangmanLeaderboard()
    {
        return users
            .OrderByDescending(u => u.Stats.Hangman.TimesWon)
            .Take(3)
            .Select(u => new LeaderboardDto(
                u.Name,
                u.Stats.Hangman.TimesWon,
                "Wins"
            ))
                .ToList();
    }

    // Returns top players for ExpressionGuess Game (based on best difference)
    public List < LeaderboardDto > GetNumbersLeaderboard()
    {
        return users
            .Where(u => u.Stats.Numbers.TimesPlayed > 0)
            .OrderBy(u => u.Stats.Numbers.BestDifference)
            .Take(3)
            .Select(u => new LeaderboardDto(
                u.Name,
               u.Stats.Numbers.BestDifference,
               "Best Difference"
            ))
            .ToList();
    }

    public List<LeaderboardDto> GetOverallLeaderboard()
    {
        return users
            .OrderByDescending(u => u.Stats.Hangman.TimesWon)
            .ThenBy(u => u.Stats.Numbers.BestDifference)
            .Take(3)
            .Select(u => new LeaderboardDto(
                u.Name,
                u.Stats.Hangman.TimesWon,
                "Combined Score"
            ))
            .ToList();
    }
}
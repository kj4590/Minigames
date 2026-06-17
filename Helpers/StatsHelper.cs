using Minigames.Models;

namespace Minigames.Helpers;

// Helper class responsible for updating game statistics.
public static class StatsHelper
{
    public static void Update(HangmanStats stats, bool won)
    {
        stats.TimesPlayed++;

        if (won)
        {
            stats.TimesWon++;
        }
    }
    public static void Update(NumbersStats stats, int difference)
    {
        stats.TimesPlayed++;

        if (difference < stats.BestDifference)
        {
            stats.BestDifference = difference;
        }
    }
}
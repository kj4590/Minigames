namespace Minigames.Models;

public class GameStats
{
    public int TimesPlayed { get; set; }
    public int TimesWon { get; set; }

    //stats for expression matching game
    public int NumbersGamesPlayed { get; set; }
    public int BestNumbersDifference { get; set; } = int.MaxValue;
}
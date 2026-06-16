namespace Minigames.Models;

public class GameStats
{
    public HangmanStats Hangman { get; set; } = new HangmanStats();
    public NumbersStats Numbers { get; set; } = new NumbersStats();
}
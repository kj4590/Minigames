namespace Minigames.Models;

public class User
{
    public string Name { get; set; } = "";
    public GameStats Stats { get; set; } = new GameStats();
}

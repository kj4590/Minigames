namespace Minigames.Helpers;

public static class WordHelper
{
    public static string GetRandomWord()
    {
        var words = File.ReadAllLines("Data/words.txt");

        Random random = new Random();
        return words[random.Next(words.Length)].ToLower();
    }
}
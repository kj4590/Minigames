using System.Text.Json;
using System.IO;
using Minigames.Models;

namespace Minigames.Helpers;

public static class UserDataHelper
{
    private static string filePath = "Data/users.json";

    public static List<User> LoadUsers()
    {
        // Create file if it doesn't exist
        if (!File.Exists(filePath))
        {
            Directory.CreateDirectory("Data");
            File.WriteAllText(filePath, "[]"); 
        }

        try
        {
            string json = File.ReadAllText(filePath);

            return JsonSerializer.Deserialize<List<User>>(json)
                   ?? new List<User>();
        }
        catch
        {
            return new List<User>();
        }
    }

    public static void SaveUsers(List<User> users)
    {
        Directory.CreateDirectory("Data");

        string json = JsonSerializer.Serialize(users, new JsonSerializerOptions
        {
            WriteIndented = true
        });

        File.WriteAllText(filePath, json);
    }
}

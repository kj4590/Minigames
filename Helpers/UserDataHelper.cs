using System.Text.Json;
using Minigames.Models;

namespace Minigames.Helpers;

public static class UserDataHelper
{
    private static string filePath = "Data/users.json";

    // read users from file, if file doesn't exist return empty list
    public static List<User> LoadUsers()
    {
        if (!File.Exists(filePath))
            return new List<User>();

        string json = File.ReadAllText(filePath);

        return JsonSerializer.Deserialize<List<User>>(json)
               ?? new List<User>();
    }

    // add a new user to the list and save it to the file
    public static void SaveUsers(List<User> users)
    {
        string json = JsonSerializer.Serialize(users, new JsonSerializerOptions
        {
            WriteIndented = true
        });

        File.WriteAllText(filePath, json);
    }
}
using Minigames.Interfaces;
using Minigames.Modules;
using Minigames.Services;
using Minigames.Helpers;
using Minigames.Enums;
using Minigames.Models;


namespace Minigames;

class Program
{
    static void Main(string[] args)
    {
        // Load users from file
        List<User> users = UserDataHelper.LoadUsers();

        Console.Write("Leaderboard: ");

        Leaderboard leaderboard = new Leaderboard(users);

        var topPlayers = leaderboard.GetTopPlayersDto(3);

        foreach (var player in topPlayers)
        {
            Console.WriteLine($"{player.Name} - {player.Wins} wins");
        }

        Console.Write("Enter your name: ");
        string? name = Console.ReadLine();

        /* Using LINQ method FirstOrDefault & lambda expression to return first user occurence match
            or null if not found */
        User currentUser = users.FirstOrDefault(u => u.Name == name);

        if (currentUser == null)
        {
            //Search for user in list
            currentUser = new User
            {
                Name = name
            };
            // Add the new user if user does not exists to the list and save it
            users.Add(currentUser);
        }

        while (true)
        {
            Console.Clear();

            Console.WriteLine($"Welcome Player: {currentUser.Name}, Please select an option:");

            Console.WriteLine("1. Hangman");
            Console.WriteLine("2. Expression Guess");
          //  Console.WriteLine("3.  Personality test");
            Console.WriteLine("0. Exit");
            Console.Write("\nSelect an option: ");


            string? input = Console.ReadLine();

            if (int.TryParse(input, out int choice))
            {
                MenuOption option = (MenuOption)choice;

                if (option == MenuOption.Exit)
                {
                    UserDataHelper.SaveUsers(users);
                    Console.WriteLine("Exiting...");
                    return;
                }

                IModule? module = option switch
                {
                    MenuOption.Hangman => new Hangman(currentUser),
                    MenuOption.ExpressionGuess => new ExpressionGuess(currentUser),
                   // MenuOption.ImpatientCalculator => new ImpatientCalculator(),
                    _ => null
                };

                if (module is null)
                {
                    Console.WriteLine("Invalid option");
                }
                else
                {
                    module.Run();
                    //save user gamestats after game
                    UserDataHelper.SaveUsers(users);
                }
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
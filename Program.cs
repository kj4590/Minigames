using Minigames.Interfaces;
using Minigames.Modules;
using Minigames.Enums;
using Minigames.Models;


namespace Minigames;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string? name = Console.ReadLine();

        User currentUser = new User
        {
            Name = string.IsNullOrEmpty(name) ? "Guest" : name
        };
        while (true)
        {
            Console.Clear();

            Console.WriteLine("1. Hangman");
            Console.WriteLine("2. Personality test");
            Console.WriteLine("3. Impatient Calculator");
            Console.WriteLine("0. Exit");
            Console.Write("\nSelect an option: ");


            string? input = Console.ReadLine();

            if (int.TryParse(input, out int choice))
            {
                MenuOption option = (MenuOption)choice;

                if (option == MenuOption.Exit)
                {
                    Console.WriteLine("Exiting...");
                    return;
                }

                IModule? module = option switch
                {
                    MenuOption.Hangman => new Hangman(currentUser),
                    //MenuOption.PersonalityTest => new PersonalityTest(),
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
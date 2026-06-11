using Minigames.Interfaces;
using Minigames.Modules;

namespace Minigames;

class Program
{
    static void Main(string[] args)
    {
        List<IModule> modules = new List<IModule>();

        modules.Add(new Hangman());

        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Interactive Console Hub ===\n");

            for (int i = 0; i < modules.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {modules[i].Name}");
            }

            Console.WriteLine("0. Exit");
            Console.Write("\nSelect an option: ");

            string? input = Console.ReadLine();

            if (int.TryParse(input, out int choice))
            {
                if (choice == 0)
                    break;

                if (choice > 0 && choice <= modules.Count)
                {
                    modules[choice - 1].Run();
                }
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
public class NumbersGame : IModule
{
    public string Name => "ExpressionGuess";

    public void Run()
    {
        List<int> numbers = new() { 2, 5, 8, 10, 25, 50 };
        int target = 532;

        Console.WriteLine($"Target: {target}");
        Console.WriteLine($"Numbers: {string.Join(", ", numbers)}");

        string? expression = Console.ReadLine();

        ExpressionHelper.ValidateAndEvaluate(expression, numbers, target);
    }
}
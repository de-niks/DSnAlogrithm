using Greedy;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        NumberOfCoins numberOfCoins = new NumberOfCoins();
        numberOfCoins.CoinChange(new int[] { 1, 2, 5 }, 11);

    }
}
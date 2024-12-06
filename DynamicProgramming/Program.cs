using DynamicProgramming;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
       // NumbrOfCoins numbrOfCoins = new NumbrOfCoins();
       // numbrOfCoins.CoinChange(new int[] {1,3,4,5 }, 7);

        NumberOfCoinsBottomUp numberOfCoinsBottomUp = new NumberOfCoinsBottomUp();
        numberOfCoinsBottomUp.CoinChange(new int[] { 1, 3, 4, 5 }, 7);

    }
}
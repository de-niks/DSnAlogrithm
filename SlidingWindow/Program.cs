using SlidingWindow;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        MaxSlidingWindow maxSlidingWindow = new MaxSlidingWindow();
        maxSlidingWindow.MaxWindow(new int[] { 1, 2, 1, 0, 4, 2, 6 }, 3);
    }
}
using Intervals;

internal class Program
{
    private static void Main(string[] args)
    {
        IntervalWork intervalWork = new IntervalWork();
        //[1,2],[3,5],[6,7],[8,10],[12,16]
        var input = new List<int[]>();
        input.Add(new int[] { 1, 2 });
        input.Add(new int[] { 2, 4 });
        input.Add(new int[] { 1, 4 });
        // input.Add(new int[] { 8, 10 });
        //input.Add(new int[] { 12, 16 });
        intervalWork.InsertInterval(input.ToArray(), new int[] { 4, 8 });
        //intervalWork.RemoveIntervals(input.ToArray());

    }
}
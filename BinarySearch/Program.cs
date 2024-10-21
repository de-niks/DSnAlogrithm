using BinarySearch;

internal class Program
{
    private static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");
        //SearchArray searchArray = new SearchArray();
        //searchArray.BinarySearchAnArray(new int[] { -1, 0, 3, 5, 9, 12 }, 9);



        /*var input = new List<int[]>();
        input.Add(new int[] { 1, 2, 4, 8 });
        input.Add(new int[] { 10, 11, 12, 13 });
        input.Add(new int[] { 14, 20, 30, 40 });
        int[][] jaggedArray = [
            [1, 2, 4, 8 ],
            [10, 11, 12, 13],
            [14, 20, 30, 40]
            ];

        Search2DMatrix search2DMatrix = new Search2DMatrix();
        search2DMatrix.SearchMatrix(jaggedArray, 15);*/

        //KokoEatingbananas kokoEatingbananas = new KokoEatingbananas();

        //kokoEatingbananas.MinEatingSpeed(new int[] { 25, 10, 23, 4 }, 5);

        FindMinimumInRoatatedArray minimumInRoatatedArray = new FindMinimumInRoatatedArray();
        minimumInRoatatedArray.FindMin(new int[] { 3, 4, 5, 6, 1, 2 });


    }
}
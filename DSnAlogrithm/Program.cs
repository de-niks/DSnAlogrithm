
using DSnAlogrithm;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        //  int[] arr = { 1,3,5,8,9,11,15,17};
        //  InserstionSort sort = new InserstionSort();
        // sort.Sort(arr, arr.Length);

        //  MergeSort sort = new MergeSort();
        // sort.Sort();

        //FindArraySum find = new FindArraySum();

        //find.TwoSumWithHashTableIndices(new int[] { 3, 4, 5, 6 }, 7);
        //find.TwoSumWithHashTable(arr, 14);

        Sorting sorting = new Sorting();

        //sorting.IsValidAnagram("pat", "tap");

        // int[] a1 = new int[] { 2, 3, 3, 5, 5, 6, 7, 7, 8, 12 };
         //int[] a2 = new int[] { 5, 5, 6, 8, 8, 9, 10, 10 };

         IntersectionnUnion intersectionn = new IntersectionnUnion();


        // string[] strings = new string[] { "act", "pots", "tops", "cat", "stop", "hat" };

        //sorting.GroupAnagrams(strings);

      //  intersectionn.FindIntersectionOfThreeSortedArrays(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 5, 7, 9 }, new int[] { 1, 3, 5, 5, 8 });

        WaterTrapping waterTrapping = new WaterTrapping();

        //waterTrapping.Trap(new int[] { 4, 2, 0, 3, 2, 5 });

        TopKFrequentElements topKFrequentElements = new TopKFrequentElements();
        topKFrequentElements.TopKFrequent(new int[] { 1, 1, 1, 2, 2, 3 }, 2);

        //topKFrequentElements.TopKFrequent(new int[] { 7,7 }, 1);

    }


    private static void SelectionSort(int[]arr)
    {
        int lt = arr.Length;

        for (int i = 0; i <lt - 1; i++)
        {
            int minVal = arr[i];
            int minIdx = i;


            for (int x = i + 1; x < lt - 1; x++)
            {
                if (arr[x] < minVal)
                { 
                    minVal = arr[x];
                    minIdx = x;
                }
            }

            Swap(arr, i, minIdx);

        }

        
    }

    private static void Swap(int[] arr, int i, int minIdx)
    {
        if (i == minIdx)
            return;

        int temp = arr[i];
        arr[i] = arr[minIdx];
        arr[minIdx] = temp;

        
    }
}
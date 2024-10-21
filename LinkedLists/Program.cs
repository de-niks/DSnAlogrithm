using LinkedLists;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        LC82_Remove_Duplicates_from_Sorted_List_II obj = new LC82_Remove_Duplicates_from_Sorted_List_II();
        ListNode node = new ListNode(1, new ListNode(1, null));
        obj.DeleteDuplicates(node);
    }
}
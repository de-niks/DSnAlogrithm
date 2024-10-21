using LinkedLists;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        //LC82_Remove_Duplicates_from_Sorted_List_II obj = new LC82_Remove_Duplicates_from_Sorted_List_II();
        //ListNode node = new ListNode(1, new ListNode(1, null));
        //obj.DeleteDuplicates(node);

       

        ListNode node1 = new ListNode(1, new ListNode(2, new ListNode(3,new ListNode(4,new ListNode(5,new ListNode(6, new ListNode(7,new ListNode(8, new ListNode(9,new ListNode(10,new ListNode(11, null)))))))))));

        LC1474_Delete_M_Nodes_After_N_Nodes lC1474_Delete_M_Nodes_After_N_Nodes = new LC1474_Delete_M_Nodes_After_N_Nodes();
        lC1474_Delete_M_Nodes_After_N_Nodes.DeleteNodes(node1, 3, 1);


    }
}
namespace LinkedList;

public partial class Solution
{
    public void DeleteNode(ListNode node)
    {
        var next = node.next;
        node.val = next.val;
        node.next = next.next;
    }
}
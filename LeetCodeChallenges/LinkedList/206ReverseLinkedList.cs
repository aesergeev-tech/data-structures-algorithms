namespace LinkedList;

public partial class Solution
{
    public static ListNode ReverseList(ListNode head)
    {
        ListNode prev = null;
        var curr = head;

        while (curr != null)
        {
            var nextNode = curr.next;
            curr.next = prev;
            prev = curr;
            curr = nextNode;
        }

        return prev;
    }
}
namespace LinkedList;

public partial class Solution
{
    public ListNode ReverseBetween(ListNode head, int left, int right)
    {
        if (head == null || left == right) return head;

        var dummy = new ListNode(0);
        dummy.next = head;
        var prev = dummy;

        for (var i = 0; i < left - 1; ++i)
        {
            prev = prev.next;
        }

        var current = prev.next;

        for (var i = 0; i < right - left; ++i)
        {
            var nextNode = current.next;
            current.next = nextNode.next;
            nextNode.next = prev.next;
            prev.next = nextNode;
        }

        return dummy.next;
    }
}
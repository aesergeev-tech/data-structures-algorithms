namespace LinkedList;

public partial class Solution
{
    public ListNode SwapPairs(ListNode head)
    {
        if (head == null) return null;
        if (head.next == null) return head;

        ListNode prev = null;
        var curr = head;
        head = curr.next;

        while (curr != null && curr.next != null)
        {
            var nxt = curr.next;
            curr.next = nxt.next;
            nxt.next = curr;

            if (prev != null)
            {
                prev.next = nxt;
            }

            prev = curr;
            curr = curr.next;
        }


        return head;
    }
}
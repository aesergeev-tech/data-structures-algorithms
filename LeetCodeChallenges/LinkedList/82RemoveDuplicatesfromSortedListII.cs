namespace LinkedList;

public partial class Solution
{
    public ListNode DeleteDuplicates82(ListNode head)
    {
        if (head == null || head.next == null) return head;

        ListNode prev = null;
        var curr = head;

        while (curr != null && curr.next != null)
        {
            if (curr.val != curr.next.val)
            {
                prev = curr;
                curr = curr.next;
            }
            else
            {
                while (curr.next != null && curr.val == curr.next.val)
                {
                    curr.next = curr.next.next;
                }

                if (prev != null)
                {
                    curr = curr.next;
                    prev.next = curr;
                }
                else
                {
                    head = curr.next;
                    curr = head;
                }
            }
        }

        return head;
    }
}
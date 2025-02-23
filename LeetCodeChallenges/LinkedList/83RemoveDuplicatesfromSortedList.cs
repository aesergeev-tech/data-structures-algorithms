namespace LinkedList;

public partial class Solution
{
    public ListNode DeleteDuplicates83(ListNode head)
    {
        if (head == null || head.next == null) return head;
        ListNode prev = null;
        var curr = head;

        while (curr.next != null)
        {
            if (curr.val != curr.next.val)
            {
                curr = curr.next;
            }
            else
            {
                curr.next = curr.next.next;
            }
        }

        return head;
    }
}
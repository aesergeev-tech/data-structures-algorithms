namespace LinkedList;

public partial class Solution
{
    public ListNode DoubleIt(ListNode head)
    {
        var multiplicator = 2;
        var current = head;
        ListNode prev = null;

        while (current != null)
        {
            var val = current.val * multiplicator;
            var carry = val / 10;
            current.val = val % 10;
            if (carry > 0)
            {
                if (prev != null)
                {
                    prev.val += 1;
                }
                else
                {
                    prev = new ListNode(1);
                    prev.next = current;
                    head = prev;
                }
            }

            prev = current;
            current = current.next;
        }

        return head;
    }
}
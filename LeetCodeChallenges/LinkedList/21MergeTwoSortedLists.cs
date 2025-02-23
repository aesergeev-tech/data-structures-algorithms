namespace LinkedList;

public partial class Solution
{
    public static ListNode MergeTwoLists(ListNode p1, ListNode p2)
    {
        var dummy = new ListNode();
        var current = dummy;

        while (p1 != null && p2 != null)
        {
            if (p1.val < p2.val)
            {
                current.next = p1;
                p1 = p1.next;
            }
            else
            {
                current.next = p2;
                p2 = p2.next;
            }

            current = current.next;
        }

        if (p1 != null)
        {
            current.next = p1;
        }
        else
        {
            current.next = p2;
        }

        return dummy.next;
    }
}
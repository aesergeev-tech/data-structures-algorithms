namespace LinkedList;

public partial class Solution
{
    public ListNode FindKThLast(ListNode head, int k)
    {
        ListNode prev = null;
        var slow = head;
        var fast = head;
        var count = 0;

        while (count < k)
        {
            count++;
            fast = fast.next;
        }


        while (fast != null)
        {
            fast = fast.next;
            prev = slow;
            slow = slow.next;
        }

        prev.next = null;

        return slow;
    }

    public ListNode RotateRight(ListNode head, int k)
    {
        if (head == null || head.next == null || k == 0) return head;

        var count = 0;
        var current = head;

        while (current != null)
        {
            count++;
            current = current.next;
        }

        k %= count;
        if (k == 0) return head;
        var kThLast = FindKThLast(head, k);
        var dummy = kThLast;

        while (kThLast.next != null)
        {
            kThLast = kThLast.next;
        }

        kThLast.next = head;
        return dummy;
    }
}
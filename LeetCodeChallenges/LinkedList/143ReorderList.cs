namespace LinkedList;

public partial class Solution
{
    public ListNode FindMiddleNode(ListNode head)
    {
        var fast = head;
        var slow = head;

        while (fast.next != null && fast.next.next != null)
        {
            fast = fast.next.next;
            slow = slow.next;
        }

        return slow;
    }

    public ListNode ReverseLIst(ListNode head)
    {
        var curr = head;
        ListNode prev = null;
        ListNode next = null;
        while (curr != null)
        {
            next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }

        return prev;
    }

    public void ReorderList(ListNode head)
    {
        var middleNode = FindMiddleNode(head);
        var nextToMiddle = middleNode.next;
        middleNode.next = null;

        var reversedSecondHalf = ReverseLIst(nextToMiddle);

        var current = head;
        ListNode result;
        while (current != null && reversedSecondHalf != null)
        {
            result = current.next;
            current.next = reversedSecondHalf;

            current = reversedSecondHalf;
            reversedSecondHalf = result;
        }
    }
}
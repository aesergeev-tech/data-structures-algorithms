namespace LinkedList;

public partial class Solution
{
    public ListNode MiddleNode(ListNode head)
    {
        if (head == null || head.next == null) return head;

        var slow = head;
        var fast = head;

        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        return slow;
    }
}
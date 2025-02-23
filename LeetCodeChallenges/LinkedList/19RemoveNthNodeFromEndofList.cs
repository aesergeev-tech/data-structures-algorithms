namespace LinkedList;

public partial class Solution
{
    private static ListNode GetNthNodeFromEnd(ListNode head, int n)
    {
        if (head.next == null)
        {
            return head;
        }

        var p1 = head;
        var p2 = head;

        for (var i = 0; i < n; i++)
        {
            if (p1 == null)
            {
                return null;
            }

            p1 = p1.next;
        }

        while (p1 != null)
        {
            p1 = p1.next;
            p2 = p2.next;
        }

        return p2;
    }

    private static void RemoveLastNode(ListNode head)
    {
        while (head.next.next != null)
        {
            head = head.next;
        }

        head.next = null;
    }

    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        if (head == null)
        {
            return null;
        }

        var nThNodeFromEnd = GetNthNodeFromEnd(head, n); //O(n)

        if (head == nThNodeFromEnd)
        {
            return head.next;
        }

        if (nThNodeFromEnd.next == null)
        {
            RemoveLastNode(head); // O(n)
        }
        else
        {
            DeleteNode(nThNodeFromEnd); // O(1)
        }

        //Overall time complexity is O(n)
        return head;
    }
}
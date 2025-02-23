namespace LinkedList;

public partial class Solution
{
    private static int Gcd(int a, int b)
    {
        while (b != 0)
        {
            var temp = b;
            b = a % b;
            a = temp;
        }

        return a;
    }

    public static ListNode InsertGreatestCommonDivisors(ListNode head)
    {
        var current = head;
        var prev = current;
        current = current.next;

        while (current != null)
        {
            var gcd = Gcd(prev.val, current.val);

            var newNode = new ListNode(gcd, current);
            prev.next = newNode;

            prev = current;
            current = current.next;
        }

        return head;
    }
}
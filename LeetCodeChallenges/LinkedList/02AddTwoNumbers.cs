namespace LinkedList;

public partial class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2, int carry = 0)
    {
        if (l1 == null && l2 == null && carry == 0) return null;

        var total = (l1?.val ?? 0) + (l2?.val ?? 0) + carry;
        carry = total / 10;
        return new ListNode(total % 10, AddTwoNumbers(l1?.next, l2?.next, carry));
    }
}
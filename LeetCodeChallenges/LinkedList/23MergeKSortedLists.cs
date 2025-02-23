namespace LinkedList;

public partial class Solution
{
    public ListNode MergeKLists(ListNode[] lists)
    {
        if (lists.Length == 0) return null;
        if (lists.Length == 1) return lists[0];
        var mid = (lists.Length - 1) / 2;
        var leftList = MergeKLists(lists[0..(mid + 1)]);
        var rightList = MergeKLists(lists[(mid + 1)..]);
        return Merge(leftList, rightList);
    }

    private ListNode Merge(ListNode l1, ListNode l2)
    {
        var dummy = new ListNode();
        var curr = dummy;
        while (l1 != null && l2 != null)
        {
            if (l1.val < l2.val)
            {
                curr.next = l1;
                l1 = l1.next;
                curr = curr.next;
            }
            else
            {
                curr.next = l2;
                l2 = l2.next;
                curr = curr.next;
            }
        }

        if (l1 != null) curr.next = l1;
        if (l2 != null) curr.next = l2;
        return dummy.next;
    }
}
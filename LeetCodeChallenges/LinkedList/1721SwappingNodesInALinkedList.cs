namespace LinkedList;

public partial class Solution {
    public ListNode SwapNodes(ListNode head, int k) {
        if(head?.next == null) return head; 
        var kThEnd = GetNthNodeFromEnd(head, k);
        
        var current = head; 
        var count = 1;
        while(count != k){
            count++;
            current = current.next;
        }
        var tmp = current.val;
        current.val = kThEnd.val;
        kThEnd.val = tmp;
        
        return head;
        
    }
}
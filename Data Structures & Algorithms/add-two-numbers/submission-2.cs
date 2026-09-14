/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode dummy = new ListNode(0, null);
        var tail = dummy;
        int remainder = 0;
        while(l1 != null && l2 != null)
        {
            int left = 0;
            int right = 0;

            if(l1 != null)
            {
                left = l1.val;
                l1 = l1.next;
            }

            if(l2 != null)
            {
                right = l2.val;
                l2 = l2.next;
            }

            tail.next = new ListNode((left + right) % 10 + remainder, null);
            tail = tail.next;
            remainder = (left + right) / 10;
        }
        
        if(remainder > 0)
        {
            tail.next = new ListNode(remainder, null);
            tail = tail.next;
        }
        
        return dummy.next;
    }
}

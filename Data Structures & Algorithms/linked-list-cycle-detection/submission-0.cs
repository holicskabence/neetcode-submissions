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
    public bool HasCycle(ListNode head) {
        if(head == null || head.next == null)
        {
            return false;
        }

        ListNode slow = head;
        ListNode fast = head.next;

        while(slow != null && fast != null)
        {
            if(slow == fast)
            {
                return true;
            }

            if(fast.next == null || fast.next.next == null)
            {
                return false;
            }

            slow = slow.next;
            fast = fast.next.next;
        }

        return false;
    }
}

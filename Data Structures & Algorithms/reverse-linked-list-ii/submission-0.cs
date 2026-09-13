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
    public ListNode ReverseBetween(ListNode head, int left, int right) {
        var dummy = new ListNode(0, head);
        var tail = dummy;
        int counter = 1;

        while(counter < left)
        {
            tail.next = head;
            tail = tail.next;
            head = head.next;
            counter++;
        }

        ListNode reversed = null;
        ListNode last = null;
        while(left <= counter && right >= counter)
        {
            reversed = new ListNode(head.val, reversed);

            if(last == null)
            {
                last = reversed;  
            }

            counter++;
            head = head.next;
        }

        tail.next = reversed;
        last.next = head;
        return dummy.next;
    }
}
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
    public ListNode ReverseList(ListNode head) {
        if(head == null)
        {
            return head;
        }

        if(head.next == null)
        {
            return head;
        }

        var result = new ListNode(head.val, null);
        var current = head.next;

        while(current.next != null)
        {
            var tmp = new ListNode(current.val, result);
            result = tmp;
            current = current.next;
        }

        return new ListNode(current.val, result);
    }
}

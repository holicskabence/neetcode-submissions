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
    public void ReorderList(ListNode head) {
        var numbers = new List<int>();
        ListNode current = head;
        while(current != null)
        {
            numbers.Add(current.val);
            current = current.next;
        }

        current = head;
        int left = 0;
        int right = numbers.Count - 1;

        while(left < right)
        {
            current.val = numbers[left];
            current = current.next;
            current.val = numbers[right];
            current = current.next;

            left++;
            right--;
        }

        if(left == right)
        {
            current.val = numbers[left];
        }
    }
}

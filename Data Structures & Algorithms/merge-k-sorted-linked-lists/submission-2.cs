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
    public ListNode MergeKLists(ListNode[] lists) {
        var queue = new PriorityQueue<ListNode, int>();

        foreach(var node in lists)
        {
            if(node != null)
            {
                queue.Enqueue(node, node.val);
            }
        }

        ListNode dummy = new ListNode();
        ListNode tail = dummy;

        while(queue.Count > 0)
        {
            var min = queue.Dequeue();
            tail.next = min;
            tail = tail.next;
            min = min.next;
            if(min != null)
            {
                queue.Enqueue(min, min.val);
            }
        }

        return dummy.next;
    }
}

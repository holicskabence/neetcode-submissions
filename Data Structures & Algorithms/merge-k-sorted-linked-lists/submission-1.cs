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
        ListNode dummy = new ListNode();
        ListNode tail = dummy;
        
        var valids = lists.Where(x => x != null).ToList();
        while(valids.Count > 0)
        {
            int minIndex = 0;
            for(int i = 1; i < valids.Count; i++)
            {
                if(valids[i].val < valids[minIndex].val)
                {
                    minIndex = i;
                }
            }

            tail.next = valids[minIndex];
            tail = tail.next;
            valids[minIndex] = valids[minIndex].next;
            valids = valids.Where(x => x != null).ToList();
        }
        
        return dummy.next;
    }
}

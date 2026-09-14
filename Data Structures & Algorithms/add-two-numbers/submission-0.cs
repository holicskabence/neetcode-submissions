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
        var left = new List<int>();
        while(l1 != null)
        {
            left.Add(l1.val);
            l1 = l1.next;
        }

        var right = new List<int>();
        while(l2 != null)
        {
            right.Add(l2.val);
            l2 = l2.next;
        }

        left.Reverse();
        right.Reverse();

        string result = (int.Parse(string.Join("", left)) + int.Parse(string.Join("", right))).ToString();
        ListNode reversed = null;

        for(int i = 0; i < result.Length; i++)
        {
            reversed = new ListNode(int.Parse(result[i].ToString()), reversed);
        }
        
        return reversed;
    }
}

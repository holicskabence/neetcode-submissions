/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public List<int> RightSideView(TreeNode root) {
        var result = new List<int>();

        if(root == null)
        {
            return result;
        }

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while(queue.Count > 0)
        {
            int count = queue.Count;
            while(count > 0)
            {
                var current = queue.Dequeue();
                if(current.left != null)
                {
                    queue.Enqueue(current.left);
                }

                if(current.right != null)
                {
                    queue.Enqueue(current.right);
                }

                count--;
                if(count == 0)
                {
                    result.Add(current.val);
                }
            }
        }

        return result;
    }
}

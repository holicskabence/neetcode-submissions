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
    public bool IsSameTree(TreeNode p, TreeNode q) {
        if(p == null && q == null)
        {
            return true;
        }

        if(((p == null && q != null) || (p != null && q == null)) || p.val != q.val)
        {
            return false;
        }

        bool leftSide = IsSameTree(p.left, q.left);
        bool rightSide = IsSameTree(p.right, q.right);

        return leftSide && rightSide;
    }
}

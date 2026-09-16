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
    public TreeNode MergeTrees(TreeNode root1, TreeNode root2) 
    {
        if(root1 == null)
        {
            return root2;
        }

        if(root2 == null)
        {
            return root1;
        }

        var left = MergeTrees(root1.left, root2.left);
        var right = MergeTrees(root1.right, root2.right); 

        int v1 = root1 != null ? root1.val : 0;
        int v2 = root2 != null ? root2.val : 0;

        return new TreeNode(v1 + v2, left, right);
    }
}
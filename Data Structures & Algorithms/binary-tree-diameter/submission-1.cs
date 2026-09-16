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
    public int DiameterOfBinaryTree(TreeNode root) {
       int height = 0;
       GetHeight(root, ref height);
       return height;
    }

    private int GetHeight(TreeNode node, ref int height)
    {
        if(node == null)
        {
            return 0;
        }

        int left = GetHeight(node.left, ref height);
        int right = GetHeight(node.right, ref height);

        height = Math.Max(height, right + left);
        return Math.Max(left, right) + 1;
    }
}

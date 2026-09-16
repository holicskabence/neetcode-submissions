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
        int 
    }

    private int GetHeight(TreeNode node, int height)
    {
        if(node == 0)
        {
            return 0;
        }

        int left = GetHeight(node.left, ref height);

        return height + 1;
    }
}

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
    public List<int> PreorderTraversal(TreeNode root) {
        if(root == null)
        {
            return new();
        }

        var result = new List<int>(){ root.val };
        var left = PreorderTraversal(root.left);
        var right = PreorderTraversal(root.right);
        return result.Concat(left).Concat(right).ToList();
    }
}
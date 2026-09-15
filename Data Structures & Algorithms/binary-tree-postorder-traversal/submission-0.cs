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
    public List<int> PostorderTraversal(TreeNode root) {
        if(root == null)
        {
            return new();
        }

        var left = PostorderTraversal(root.left);
        var right = PostorderTraversal(root.right);
        var result = left.Concat(right).ToList();
        result.Add(root.val);
        return result;
    }
}
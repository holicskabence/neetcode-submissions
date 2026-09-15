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
    public List<int> InorderTraversal(TreeNode root) {
         if(root == null)
         {
            return new List<int>();
         }

         var left = InorderTraversal(root.left);
         left.Add(root.val);
         var right = InorderTraversal(root.right);
         
         return left.Concat(right).ToList();
    }
}
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
    public TreeNode InsertIntoBST(TreeNode root, int val) {
        var current = root;
        while(current != null)
        {
            if(current.val > val)
            {
                if(current.left != null)
                {
                    current = current.left;
                }
                else
                {
                    current.left = new TreeNode(val);
                    break;
                }
            }
            else
            {
                if(current.right != null)
                {
                    current = current.right;
                }
                else
                {
                    current.right = new TreeNode(val);
                    break;
                }
            }
        }

        if(root == null)
        {
            root = new TreeNode(val);
        }

        return root;
    }
}
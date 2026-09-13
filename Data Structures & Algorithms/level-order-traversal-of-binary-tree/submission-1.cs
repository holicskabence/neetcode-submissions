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
    public List<List<int>> LevelOrder(TreeNode root) {
        var result = new List<List<int>>();

        if(root == null)
        {
            return result;
        }

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while(queue.Count > 0)
        {
            int levelCount = queue.Count;
            var level = new List<int>();

            for(int i = 0; i < levelCount; i++)
            {
                var current = queue.Dequeue();
                level.Add(current.val);

                if(current.left != null)
                {
                    queue.Enqueue(current.left);
                }

                if(current.right != null)
                {
                    queue.Enqueue(current.right);
                }
            }

            result.Add(level);
        }

        return result;
    }
}

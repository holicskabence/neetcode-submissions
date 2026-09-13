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
        if(root == null)
        {
            return new();
        }

        var result = new List<List<int>>();
        var queue = new Queue<TreeNode>();

        queue.Enqueue(root);
        int level = 0;
        int levelCount = 1;

        while(queue.Count > 0)
        {
            int nextCount = 0;
            result.Add(new List<int>());

            for(int i = 0; i < levelCount; i++)
            {
                var current = queue.Dequeue();
                result[level].Add(current.val);

                if(current.left != null){
                    queue.Enqueue(current.left);
                    nextCount++;
                }

                if(current.right != null){
                    queue.Enqueue(current.right);
                    nextCount++;
                }
            }
            
            levelCount = nextCount;
            level++;
        }

        return result;
    }
}

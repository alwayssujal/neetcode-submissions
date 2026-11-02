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
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        var curr = root;

        while (curr != null) {
            if (curr.val > p.val && curr.val > q.val) {
                //left
                curr = curr.left;
            }
            else if (curr.val < p.val && curr.val < q.val) {
                //right
                curr = curr.right;
            }
            else {
                return curr;
            }
        }
        return null;
    }
}

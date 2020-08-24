namespace LeetCode.CSharp_Problems
{

    //Definition for a binary tree node.
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class Sum_of_Left_Leaves
    {
        public virtual bool isLeaf(TreeNode root)
        {
            if (root == null)
            {
                return false;
            }
            if (root.left == null && root.right == null)
            {
                return true;
            }
            return false;
        }

        public int SumOfLeftLeaves(TreeNode root)
        {
            int sum = 0;
            if (root != null)
            {
                if (isLeaf(root.left))
                {
                    sum += root.left.val;
                }
                else
                {
                    sum += SumOfLeftLeaves(root.left);
                }
                sum += SumOfLeftLeaves(root.right);
            }
            return sum;
        }

    }
}

/*
 * Date: 24 Aug 2020
 * Sum of Left Leaves: https://leetcode.com/explore/challenge/card/august-leetcoding-challenge/552/week-4-august-22nd-august-28th/3435/
 * Find the sum of all left leaves in a given binary tree.

Example:

    3
   / \
  9  20
    /  \
   15   7

There are two left leaves in the binary tree, with values 9 and 15 respectively. Return 24.
*/

using System.Collections.Generic;

namespace DepthFirstSearch.DepthFirstSearch
{
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

    public class Solution
    {
        public IList<double> AverageOfLevels(TreeNode root)
        {
            var ret = new List<double>();
            // 开始遍历
            ret.Add(root.val);
            RecurveCalcChildren(new List<TreeNode>() { root }, ref ret);

            return ret;
        }

        private void RecurveCalcChildren(List<TreeNode> nodes, ref List<double> resultList)
        {
            var count = 0;
            double totalNum = 0;

            var nodeList = new List<TreeNode>();

            foreach (var node in nodes)
            {
                if (node.left != null)
                {
                    totalNum += node.left.val;
                    count++;
                    nodeList.Add(node.left);
                }

                if (node.right != null)
                {
                    totalNum += node.right.val;
                    count++;
                    nodeList.Add(node.right);
                }
            }

            if (count > 0)
            {
                resultList.Add(totalNum * 1.0 / count);

                RecurveCalcChildren(nodeList, ref resultList);
            }
        }
    }
}
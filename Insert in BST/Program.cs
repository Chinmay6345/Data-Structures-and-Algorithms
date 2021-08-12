using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insert_in_BST
{
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
    //TC-O(h) SC-O(1)
    public static class AppHelper
    {
        public static TreeNode Insert(TreeNode root,int x)
        {
            TreeNode temp = new TreeNode(x);
            TreeNode parent = null;
            TreeNode curr = root;
            while(curr!=null)
            {
                parent = curr;
                if (curr.val > x)
                    curr = curr.left;
                else if (curr.val < x)
                    curr = curr.right;
                return root;
            }
            if (parent == null) //empty tree
                return temp;
            if (parent.val > x)
                parent.left = temp;
            else
                parent.right = temp;
            return null;
        }
        //TC-O(h) SC-O(h)
        public static TreeNode RInsert(TreeNode root,int x)
        {
            if(root==null)
               return new TreeNode(x);
            if (root.val > x)
                root.left = RInsert(root.left, x);
            else
                root.right = RInsert(root.right, x);
            return null;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

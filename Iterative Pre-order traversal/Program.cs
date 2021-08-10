using System;
using System.Linq;
using System.Collections.Generic;
using Count_nodes_in_a_complete_Binary_Tree;


//https://leetcode.com/problems/binary-tree-preorder-traversal/submissions/
namespace Iterative_Pre_order_traversal
{
    public static class AppHelper
    {
        //O(n) O(h)
        public static void IterativeInorder(TreeNode root)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode curr = root;
            while(curr!=null || stack.Any())
            {
                while(curr!=null)
                {
                    stack.Push(curr);
                    curr = curr.left;
                }
                curr = stack.Pop();
                Console.Write(curr.val + " ");
                curr = curr.right;
            }
        }

        //O(n) =TC and SC
        public static void PreOrder(TreeNode root)
        {
            Stack<TreeNode> stck = new Stack<TreeNode>();
            TreeNode curr = root;
            if(curr==null)
            {
                return;
            }
            stck.Push(curr);
            while(stck.Any())
            {
                TreeNode p = stck.Pop();
                if(curr.right!=null)
                {
                    stck.Push(curr.right);
                }
                if (curr.left != null)
                {
                    stck.Push(curr.left);
                }
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }
    }
}

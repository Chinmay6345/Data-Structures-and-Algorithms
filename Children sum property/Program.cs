using System;
using Ttree_Traversals;
namespace Children_sum_property
{
    public static class AppHelper
    {
        public static bool IsChildrenSum(BinaryTree root)
        {
            if (root == null)
                return true;
            if (root.left == null && root.right == null)
                return true;
            int sum = 0;
            if (root.left != null) sum += root.left.key;
            if (root.right != null) sum += root.right.key;
            return (sum == root.key && IsChildrenSum(root.left) && IsChildrenSum(root.right));
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

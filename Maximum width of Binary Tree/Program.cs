using System;
using System.Collections.Generic;
using System.Linq;
using Ttree_Traversals;

namespace Maximum_width_of_Binary_Tree
{
    public static class AppHelper
    {
        public static Int32 MaxWidth(BinaryTree root)
        {
            if(root==null)
            {
                return 0;
            }
            Int32 res = 0;
            Queue<BinaryTree> q=new Queue<BinaryTree>();
            q.Enqueue(root);
            while(q.Any())
            {
                Int32 count = q.Count;
                res = Math.Max(res, count);
                for(Int32 i=0;i<count;i++)
                {
                    BinaryTree curr = q.Dequeue();
                    if(curr.left!=null)
                    {
                        q.Enqueue(curr.left);
                    }
                    if(curr.right!=null)
                    {
                        q.Enqueue(curr.right);
                    }
                }
            }
            return res;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

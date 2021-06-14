using System;


namespace Ttree_Traversals
{

    public class BinaryTree
    {
        BinaryTree left;
        BinaryTree right;
        Int32 key;

        public BinaryTree(Int32 value)
        {
            key = value;
        }

        public void InOrder(BinaryTree root)
        {
            if(root!=null)
            {
                InOrder(root.left);
                Console.Write(root.key + " ");
                InOrder(root.right);
            }
        }

        public void PreOrder(BinaryTree root)
        {
            if(root!=null)
            {
                Console.Write(root.key + " ");
                PreOrder(root.left);
                PreOrder(root.right);
            }
        }

        public void PostOrder(BinaryTree root)
        {
            if(root!=null)
            {
                PostOrder(root.left);
                PostOrder(root.right);
                Console.Write(root.key + " ");
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

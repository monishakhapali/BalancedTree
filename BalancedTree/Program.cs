using System;
using static BalancedTree.Program.BST;

namespace BalancedTree
{
    class Program
    {
        public static Node root;
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            BST bST = new BST();
            root = new Node(1);
            root.left = new Node(2);
            root.right = new Node(2);
            root.left.left = new Node(3);
            root.left.right = new Node(3);
            root.left.left.left = new Node(4);
            root.left.left.right = new Node(4);
            //root = new Node(3);
            //root.left = new Node(9);
            //root.right = new Node(20);
            //root.right.left = new Node(15);
            //root.right.right = new Node(7);
            Console.WriteLine(bST.IsBalanced(root));
            Console.ReadLine();
        }
        public class BST
        {
            public class Node
            {
                public int key;
                public Node left;
                public Node right;

                public Node()
                {
                }

                public Node(int item)
                {
                    key = item;
                    left = null;
                    right = null;
                }


            }

            public BST()
            {
                root = null;
            }

            public bool IsBalanced(Node root)
            {
                if (root == null)
                {
                    return true;
                }
                
                return Math.Abs(Depth(root.left) - Depth(root.right)) <= 1;
            }
            public int Depth(Node root)
            {
                if (root == null)
                {
                    return 0;
                }

                return (1 + Math.Max(Depth(root.left), Depth(root.right)));


            }

        }
    }
}

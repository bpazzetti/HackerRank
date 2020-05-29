using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h30DaysOfCode
{
    class Day23_BSTLevelOrderTraversal
    {
        class Node
        {
            public Node left, right;
            public int data;
            public Node(int data)
            {
                this.data = data;
                left = right = null;
            }
        }

        static void levelOrder(Node root)
        {
            //Write your code here
            Queue<Node> qu = new Queue<Node>();
            qu.Enqueue(root);
            string line = string.Empty;
            while (true)
            {
                if (qu.Count == 0)
                {
                    Console.WriteLine(line.Trim()); 
                    return; 
                }
                else
                {
                    Node current = qu.Dequeue();
                    line += current.data + " ";                    
                    if (current.left != null)
                        qu.Enqueue(current.left);
                    if (current.right != null)
                        qu.Enqueue(current.right);
                }
            }
            
        }

        static Node insert(Node root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            }
            else
            {
                Node cur;
                if (data <= root.data)
                {
                    cur = insert(root.left, data);
                    root.left = cur;
                }
                else
                {
                    cur = insert(root.right, data);
                    root.right = cur;
                }
                return root;
            }
        }
        public static void Main1(String[] args)
        {
            Node root = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                root = insert(root, data);
            }
            levelOrder(root);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BST
    {
        Node root = null;
        public BST()
        {

        }
        public void Add(int item)
        {
            Node node = new Node(item);
            if (root == null)
            {
                root = node;
                return;
            }
            Node current = root;
            while (current != null)
            {
                if (current.Data > node.Data)
                {
                    if (current.Left != null)
                    {
                        current.Left = current;
                        continue;
                    }
                    else if (current.Left == null)
                    {
                        current.Left = node;
                        return;
                    }
                }
                else if (current.Data < node.Data)
                {
                    if (current.Right != null)
                    {
                        current.Right = current;
                        continue;
                    }
                    else if (current.Right == null)
                    {
                        current.Right = node;
                        return;
                    }
                }
            }
            current.Left = node;
        }
        public bool Search (int searchData)
        {
            Node current = root;
            while (current != null)
            {
                if (current.Data.Equals(searchData))
                {
                    Console.WriteLine("Found");
                    return true;
                }
                else if (current.Data > searchData)
                {
                    if (current != null)
                    {
                        current.Left = current;
                        Console.WriteLine("Left");
                        continue;
                    }
                    continue;
                }
                else if (current.Data < searchData)
                {
                    if (current.Right != null)
                    {
                        current.Right = current;
                        Console.WriteLine("Right");
                        continue;
                    }
                    continue;
                }
            }
            return false;
        }
    }
}

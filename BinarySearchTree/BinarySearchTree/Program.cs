using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Program
    {
        static void Main()
        {
            BST BST = new BST();
            BST.Add(6);
            BST.Add(7);
            BST.Add(5);
            BST.Add(4);
            BST.Add(9);
            BST.Search(5);
        }
    }
}

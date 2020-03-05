using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tree_implementation
{
    /*
     * Tasks:
     * 1) Complete the implementation of the Node methods
     * 2) Print out the tree using the different tree traversal metods
     * 3) Test findNote() and deleteNode()
     *
     *
     */
    class Node
    {
        // Attributes
        public Node left;
        public Node right;
        public string item;
        public Node(string i)
        {
            this.left = null;
            this.right = null;
            this.item = i;
        }
        public int getFirstChar()
        {
            return (int)item[0];
        }
    }
    class Tree
    {
         public Node Root;
        //Methods
        public Tree(string root)
        {
            this.Root = new Node(root);
        }
        public void add(string value)
        {
            Node curNode = this.Root;
            while (curNode.left != null && curNode.right != null)
            {
                if (curNode.left.getFirstChar() < curNode.getFirstChar())
                {
                    curNode = curNode.left;
                }
                else if (curNode.right.getFirstChar() > curNode.getFirstChar())
                {
                    curNode = curNode.right;
                }
            }
            if ((int)value[0] < curNode.getFirstChar())
            {
                curNode.left = new Node(value);
            }
            else if ((int)value[0] > curNode.getFirstChar())
            {
                curNode.right = new Node(value);
            }
        }
        public Boolean findNode(string item)
        {
            return true;
        }
        public Boolean deleteNote(string item)
        {
            return true;
        }
        public void printPreOrder(Node node)
        {
            if (node != null)
            {
            Console.WriteLine("{0}, ", node.item);
            printPreOrder(node.left);
            printPreOrder(node.right); 
            }
        }
        public void printInOrder(Node node)
        {
            if (node != null)
            {
                printInOrder(node.left);
                Console.WriteLine("{0}, ", node.item);
                printInOrder(node.right);
            }
        }
        public void printPostOrder(Node node)
        {
            if (node != null)
            {
                printPreOrder(node.left);
                printPreOrder(node.right);
                Console.WriteLine("{0}, ", node.item);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Node root = null; 

            string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            Tree test = new Tree(months[0]);
            // process all the nodes on the array
            //
            for (int i = 1; i < months.Length - 1; i++)
            {
                test.add(months[i]);
            }
            // print out the tree using different traversal methods
            //
            test.printPreOrder(test.Root);
            test.printInOrder(test.Root);
            test.printPostOrder(test.Root);

            // Test the findNote() and deleteNode()
        }
    }
}


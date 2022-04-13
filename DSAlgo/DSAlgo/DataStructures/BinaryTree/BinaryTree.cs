using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAlgo.DataStructures.BinaryTree
{
    public class Node<T>
    {
        public T data;
        public Node<T> leftNode;
        public Node<T> rightNode;
    }
    public class BinaryTree<T>
    {
        private Node<T> root;

        public void Add(T data)
        {
            Node<T> newNode = new Node<T>();
            newNode.data = data;

            if (root == null)
            {
                root = newNode;
                return;
            }
            else
            {
                Add(root, newNode);
            }
        }

        private void Add(Node<T> root, Node<T> newNode)
        {
            if(root.leftNode == null)
            {
                root.leftNode = newNode;
                return;
            }
            else
            {

            }
        }
    }
}

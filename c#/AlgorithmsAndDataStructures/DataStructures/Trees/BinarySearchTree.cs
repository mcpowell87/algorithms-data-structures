using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsAndDataStructures.Algorithms.DataStructures.Trees
{
    public class BinarySearchTree
    {
        public int Value { get; set; }
        public BinarySearchTree Left { get; set; }
        public BinarySearchTree Right { get; set; }

        public BinarySearchTree(int value)
        {
            this.Value = value;
        }

        public void Insert(int value)
        {
            if (value >= this.Value)
            {
                if (this.Right != null)
                {
                    this.Right.Insert(value);
                }
                else
                {
                    this.Right = new BinarySearchTree(value);
                }
            }
            else if (value <= this.Value)
            {
                if (this.Left != null)
                {
                    this.Left.Insert(value);
                }
                else
                {
                    this.Left = new BinarySearchTree(value);
                }
            }
        }

        public BinarySearchTree Find(int value)
        {
            if (value == this.Value)
            {
                return this;
            }

            if (value >= this.Value && this.Right != null)
            {
                return this.Right.Find(value);
            }
            else if (value <= this.Value && this.Left != null)
            {
                return this.Left.Find(value);
            }

            return null;
        }

        public int Successor()
        {
            var root = this.Right;
            while (root.Left != null)
            {
                root = root.Left;
            }
            return root.Value;
        }

        public int Predecessor()
        {
            var root = this.Left;
            while (root.Right != null)
            {
                root = root.Right;
            }
            return root.Value;
        }

        public void Remove(int value)
        {
            Remove(this, value);
        }

        public BinarySearchTree Remove(BinarySearchTree root, int value)
        {
            if (root == null)
            {
                return null;
            }
            
            // Remove from right tree
            if (value > root.Value)
            {
                root.Right = Remove(root.Right, value);
            }
            // Remove from left tree
            else if (value < root.Value)
            {
                root.Left = Remove(root.Left, value);
            }
            // Remove the node
            else
            {
                // Node is leaf
                if (root.Left == null && root.Right == null)
                {
                    root = null;
                }
                // Node has right child
                else if (root.Right != null)
                {
                    root.Value = root.Successor();
                    root.Right = Remove(root.Right, root.Value);
                }
                // Node has left child
                else
                {
                    root.Value = root.Predecessor();
                    root.Left = Remove(root.Left, root.Value);
                }
            }

            return root;
        }
    }
}

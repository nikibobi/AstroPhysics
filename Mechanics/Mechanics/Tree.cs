using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AstroPhysics
{
    /// <summary>
    /// Represents a tree data structure
    /// </summary>
    /// <typeparam name="T">the type of the values in the
    /// tree</typeparam>
    class Tree<T>
    {
        // The root of the tree
        private TreeNode<T> root;

        /// <summary>
        /// Constructs the tree
        /// </summary>
        /// <param name="value">the value of the node</param>
        public Tree(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("Cannot insert null value!");
            }

            this.root = new TreeNode<T>(value);
        }

        /// <summary>
        /// Constructs the tree
        /// </summary>
        /// <param name="value">the value of the root node</param>
        /// <param name="children">the children of the root
        /// node</param>
        public Tree(T value, params Tree<T>[] children)
            : this(value)
        {
            foreach (Tree<T> child in children)
            {
                this.root.AddChildren(child.root);
            }
        }

        /// <summary>
        /// The root node or null if the tree is empty
        /// </summary>
        public TreeNode<T> Root
        {
            get
            {
                return this.root;
            }
        }

        /// <summary>
        /// Traverses and prints tree in Depth
        /// First Search (DFS) manner
        /// </summary>
        /// <param name="root">the root of the tree to be
        /// traversed</param>
        /// <param name="spaces">the spaces used for
        /// representation of the parent-child relation</param>
        private void PrintDFS(TreeNode<T> root, string spaces)
        {
            if (this.root == null)
            {
                return;
            }

            Console.WriteLine(spaces + root.Value);

            TreeNode<T> child = null;
            for (int i = 0; i < root.ChildrenCount; i++)
            {
                child = root.GetChild(i);
                PrintDFS(child, spaces + "   ");
            }
        }

        /// <summary>
        /// Traverses and prints the tree in
        /// Depth First Search (DFS) manner
        /// </summary>
        public void PrintDFS()
        {
            this.PrintDFS(this.root, string.Empty);
        }

        public IEnumerable<T> GetEnumeratorDFS()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TreeNode<T>> GetEnumeratorBFS()
        {
            Queue<TreeNode<T>> viseted = new Queue<TreeNode<T>>();
            viseted.Enqueue(this.root);
            while (viseted.Count > 0)
            {
                TreeNode<T> current = viseted.Dequeue();
                yield return current;
                for (int i = 0; i < current.ChildrenCount; i++)
                {
                    TreeNode<T> child = current.GetChild(i);
                    viseted.Enqueue(child);
                }
            }
        }
    }
}

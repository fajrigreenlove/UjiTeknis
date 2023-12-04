using System;
using System.Collections.Generic;

namespace MemoryLeakExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var rootNode = new TreeNode();
            int maxNodes = 10000;

            while (true)
            {
                // Create a new subtree of 10000 nodes  
                var newNode = new TreeNode();
                for (int i = 0; i < 10000; i++)
                {
                    var childNode = new TreeNode();
                    newNode.AddChild(childNode);
                }

                // Add the new subtree to rootNode
                rootNode.AddChild(newNode);

                // Trim the total number of nodes in the entire structure
                rootNode.LimitNodes(maxNodes);
            }
        }
    }

    class TreeNode
    {
        private readonly List<TreeNode> _children = new List<TreeNode>();

        public void AddChild(TreeNode child)
        {
            _children.Add(child);
        }

        public void LimitNodes(int maxNodes)
        {
            while (_children.Count > maxNodes)
            {
                var oldestNode = _children[0];
                _children.RemoveAt(0);
            }
        }
    }
}
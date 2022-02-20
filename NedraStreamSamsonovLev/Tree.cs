using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NedraStreamSamsonovLev
{
    public class Tree : ITree
    {
        private Node _root;
        private int MaxSum;
        public int Count { get; private set; }

        public Tree()
        {
            _root = new Node();
            Count = 0;
        }

        public void Add(int value)
        {
            var newNode = new Node() { Value = value };

            if (Count == 0)
            {
                _root = newNode;
                Count++;
                return;
            }              

            var currentNode = _root;
            while (true)
            {
                // Left 
                if (value < currentNode.Value)
                {                 
                    if (currentNode.LeftNode is null)
                    {
                        currentNode.LeftNode = newNode;
                        Count++;
                        return;
                    }                
                    currentNode = currentNode.LeftNode;
                }
                // Right
                else
                {
                    if (currentNode.RightNode is null)
                    {
                        currentNode.RightNode = newNode;
                        Count++;
                        return;
                    }
                    currentNode = currentNode.RightNode;
                }
            }
        }

        public bool HasValue(int value)
        {
            if (Count == 0)
                return false;

            var currentNode = _root;

            while (currentNode is not null)
            {
                // Left 
                if (value < currentNode.Value)
                {
                  currentNode = currentNode.LeftNode;
                }
                // Right
                else if (value > currentNode.Value)
                { 
                    currentNode = currentNode.RightNode;
                }
                else if (value == currentNode.Value)
                {
                    return true;
                }
            }

            return false;
        }

        public int GetMaxSum()
        {
            MaxSum = 0;
            Traverse(0, _root);

            return MaxSum;
        }

        private int Traverse(int sum, Node node)
        {
            
            int newSum = node.Value + sum;

            if (node.LeftNode is not null)
                newSum = Traverse(newSum, node.LeftNode);

            if (node.RightNode is not null)
                newSum = Traverse(newSum, node.RightNode);

            if (MaxSum <= newSum)
                MaxSum = newSum;
            
            return sum;       
        }

        private class Node
        {
            public int Value { get; set; }
            public Node? LeftNode { get; set; }
            public Node? RightNode { get; set; }
        }
    } 
}

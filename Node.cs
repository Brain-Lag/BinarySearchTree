using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    class Node
    {
        public int Data { get; init; }
        public Node Right { get; private set; }
        public Node Left { get; private set; }

        public Node(int data = 0, Node right = null, Node left = null)
        {
            this.Data = data;
            this.Right = right;
            this.Left = left;
        }

        public void SetLeft(Node node)
        {
            this.Left = node;
        }

        public void SetRight(Node node)
        {
            this.Right = node;
        }
    }
}

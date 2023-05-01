using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    class Tree
    {
        public Node Root { get; private set; }

        public void Add(int data)
        {
            this.Root = InsertData(this.Root,data);
        }

        private Node InsertData(Node parent, int data)
        {
            if (parent == null)
            {
                parent = new Node(data);
                return parent;
            }
            if (data < parent.Data)
            {
                parent.SetLeft(InsertData(parent.Left, data));
            }
            else if (data > parent.Data)
            {
                parent.SetRight(InsertData(parent.Right, data));
            }
            return parent;
        }

        public Node Search(int data)
        {
            return Search(this.Root, data);
        }

        public Node Search(Node parent, int data)
        {
            if (parent == null || data == parent.Data) return parent;

            if (data < parent.Data) return Search(parent.Left, data);

            else return Search(parent.Right, data);
        }

    }
}

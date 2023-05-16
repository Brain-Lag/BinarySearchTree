namespace BinarySearchTree;

internal class Tree
{
    public Node Root;

    public Tree()
    {
        Root = null;
    }

    public void Insert(int value)
    {
        Node newNode = new Node(value);

        if (Root == null)
        {
            Root = newNode;
            return;
        }

        Node currentNode = Root;
        Node parent;

        while (true)
        {
            parent = currentNode;

            if (value < currentNode.Value)
            {
                currentNode = currentNode.Left;

                if (currentNode == null)
                {
                    parent.Left = newNode;
                    return;
                }
            }
            else
            {
                currentNode = currentNode.Right;

                if (currentNode == null)
                {
                    parent.Right = newNode;
                    return;
                }
            }
        }
    }

    public void BreadthFirstSearch()
    {
        if (Root == null)
        {
            throw new ArgumentException( "Дерево пустое.");
            return;
        }

        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(Root);

        while (queue.Count > 0)
        {
            Node currentNode = queue.Dequeue();
            Console.Write(currentNode.Value + " ");

            if (currentNode.Left != null)
                queue.Enqueue(currentNode.Left);

            if (currentNode.Right != null)
                queue.Enqueue(currentNode.Right);
        }

        Console.WriteLine();
    }
}
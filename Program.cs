using BinarySearchTree;

class Program
{
    static void Main(string[] args)
    {
        Tree tree = new Tree();

        tree.Insert(8);
        tree.Insert(10);
        tree.Insert(3);
        tree.Insert(6);
        tree.Insert(1);
        tree.Insert(14);
        tree.Insert(4);
        tree.Insert(7);
        tree.Insert(13);

        Console.WriteLine("Поиск в ширину:");
        tree.BreadthFirstSearch();
    }
}
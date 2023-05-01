using System;
using System.Collections;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new Tree();
            tree.Add(2);
            tree.Add(3);
            tree.Add(1);
            tree.Search(1);
            tree.Search(4);
        }
    }
}

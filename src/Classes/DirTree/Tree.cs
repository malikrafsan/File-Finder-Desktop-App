using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FolderCrawler.Classes;

namespace FolderCrawler.Classes.DirTree
{
    class Tree
    {
        public Node root;

        public Tree(string dirname)
        {
            this.root = new Node(dirname, "directory");
        }

        public void Print()
        {
            PrintDepth(this.root, 1);
        }
        private static void PrintDepth(Node node, int depth)
        {
            Console.WriteLine(String.Join(" ", new string[depth]) + Utils.GetDirName(node.dirName));
            foreach (Node child in node.children)
            {
                PrintDepth(child, depth + 1);
            }
        }
    }
}

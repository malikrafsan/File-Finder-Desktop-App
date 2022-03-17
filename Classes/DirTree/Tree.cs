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
        public Node[] visited;
        public Node[] looked;

        public Tree(string dirname)
        {
            this.root = new Node(dirname, "directory");
        }

        public void print()
        {
            printDepth(this.root, 1);
        }
        private static void printDepth(Node node, int depth)
        {
            Console.WriteLine(String.Join(" ", new string[depth]) + Utils.getDirName(node.dirName));
            foreach (Node child in node.children)
            {
                printDepth(child, depth + 1);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}

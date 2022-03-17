using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderCrawler.Classes.DirTree
{
    class DirTree
    {
        public DirNode root;
        public DirNode[] visited;
        public DirNode[] looked;

        public DirTree(string dirname)
        {
            this.root = new DirNode(dirname, "directory");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderCrawler.Classes.DirTree
{
    class DirNode
    {
        public string dirName;
        public DirNode parent;
        public DirNode[] children;
        public string type; // "directory" or "file"

        public DirNode(string dirName, string type)
        {
            this.dirName = dirName;
            this.type = type;
        }

        public DirNode(string dirName, string type, DirNode parent)
        {
            this.dirName = dirName;
            this.type = type;
            this.parent = parent;
        }

        public static bool operator ==(DirNode a, DirNode b)
        {
            return a.dirName.Equals(b.dirName);
        }

        public static bool operator !=(DirNode a, DirNode b)
        {
            return !a.dirName.Equals(b.dirName);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is DirNode))
            {
                return false;
            } else
            {
                return this.dirName == ((DirNode) obj).dirName;
            }
        }

        public override int GetHashCode()
        {
            return this.dirName.GetHashCode();
        }

        public void addChildren(DirNode child)
        {
            if (this.type == "directory")
            {
                this.children.Append(child);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderCrawler.Classes.DirTree
{
    class Node
    {
        public string dirName;
        public Node parent;
        public Node[] children;
        public string type; // "directory" or "file"

        public Node(string dirName, string type)
        {
            this.dirName = dirName;
            this.type = type;
        }

        public Node(string dirName, string type, Node parent)
        {
            this.dirName = dirName;
            this.type = type;
            this.parent = parent;
        }

        public static bool operator ==(Node a, Node b)
        {
            return a.dirName.Equals(b.dirName);
        }

        public static bool operator !=(Node a, Node b)
        {
            return !a.dirName.Equals(b.dirName);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Node))
            {
                return false;
            } else
            {
                return this.dirName == ((Node) obj).dirName;
            }
        }

        public override int GetHashCode()
        {
            return this.dirName.GetHashCode();
        }

        public void addChildren(Node child)
        {
            if (this.type == "directory")
            {
                this.children.Append(child);
            }
        }
    }
}

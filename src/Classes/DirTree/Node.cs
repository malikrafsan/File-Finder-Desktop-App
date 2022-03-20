using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace FolderCrawler.Classes.DirTree
{
    class Node : IComparable<Node>
    {
        public string dirName;
        public Node parent;
        public List<Node> children;
        public string type; // "directory" or "file"

        public Node(string dirName, string type)
        {
            this.dirName = dirName;
            this.type = type;
            this.children = new List<Node>();
        }

        public Node(string dirName, string type, Node parent)
        {
            this.dirName = dirName;
            this.type = type;
            this.parent = parent;
            this.children = new List<Node>();
        }

        public int CompareTo(Node other)
        {
            return String.Compare(this.dirName, other.dirName);
        }

        public static bool operator <(Node a, Node b)
        {
            return String.Compare(a.dirName, b.dirName) == -1;
        }

        public static bool operator >(Node a, Node b)
        {
            return String.Compare(a.dirName, b.dirName) == 1;
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

        public void FindChildren()
        {
            if (this.type.Equals("file"))
            {
                return;
            }
            string[] dirs = Directory.GetDirectories(this.dirName);
            string[] files = Directory.GetFiles(this.dirName);
            
            foreach (string dir in dirs)
            {
                this.children.Add(new Node(dir, "directory", this));
            }
            foreach (string file in files)
            {
                this.children.Add(new Node(file, "file", this));
            }
            
            this.children.Sort();
            
        }

        public bool IsAncestorOf(Node node)
        {
            return node.dirName.Contains(this.dirName); 
        }

        public bool isDescendantOf(Node node)
        {
            return this.dirName.Contains(node.dirName);
        }
    }
}

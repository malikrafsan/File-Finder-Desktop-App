using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using FolderCrawler.Classes.DirTree;
using FolderCrawler.Classes;



namespace FolderCrawler.Classes.Crawler
{
    class Crawler
    {
        public Tree tree;
        public List<(Node[] visited, Node[] looked)> frames;

        public Crawler(string dirname)
        {
            this.tree = new Tree(dirname);
            this.frames = new List<(Node[] visited, Node[] looked)>();
        }

        public Tree DFS(string target)
        {
            HashSet<Node> visited = new HashSet<Node>();    // Array of visited nodes
            Stack<Node> looked = new Stack<Node>();         // Array of looked nodes (in path from startDir into curNode)
            bool flag;                                      // Flag if the node is fully searched
            Node curNode;                                   // Current Node 

            // Function to backtrack from the node
            void Backtrack()
            {
                looked.Pop();
                this.frames.Append((visited.ToArray(), looked.ToArray()));
            }

            // Function to move into node
            void MoveTo(Node node)
            {
                visited.Add(node);
                looked.Push(node);
                this.frames.Append((visited.ToArray(), looked.ToArray()));
            }

            // Initialize Search
            flag = false;
            curNode = this.tree.root;
            MoveTo(this.tree.root);

            do
            {
                // Get childern for current node
                curNode.FindChildren();
                // If target found, terminate search
                if (Utils.getDirName(curNode.dirName).Equals(target))
                {
                    break;
                }

                
                // If all children is already visited, backtrack until it's found possible search route
                while ((flag || curNode.type.Equals("file")) && curNode.parent is object)
                {
                    flag = curNode.children.Aggregate(true, (acc, x) => acc && visited.Contains(x));
                    curNode = curNode.parent;
                    Backtrack();
                }

                // Visit the first unvisited children from current node
                foreach (Node child in curNode.children)
                {
                    if (!visited.Contains(child))
                    {
                        curNode = child;
                        MoveTo(child);
                        break;
                    }
                }
            } while (!flag || curNode.parent is object);


            // If target isn't found, clear the looked array
            if (!Utils.getDirName(curNode.dirName).Equals(target))
            {
                looked.Clear();
                this.frames.Append((visited.ToArray(), looked.ToArray()));
            }

            // Set final state of tree
            this.tree.visited = visited.ToArray();
            this.tree.looked = looked.ToArray();

            return this.tree;
        }

        public Tree BFS(string target)
        {
            HashSet<Node> visited = new HashSet<Node>();    // Array of visited nodes
            Stack<Node> looked = new Stack<Node>();         // Array of looked nodes (in path from startDir into curNode)
            Queue<Node> queue = new Queue<Node>();          // Search Queue
            Node curNode;                                   // Current Node 

            // Function to backtrack from the node
            void Backtrack()
            {
                looked.Pop();
                this.frames.Append((visited.ToArray(), looked.ToArray()));
            }

            // Function to move into node
            void MoveTo(Node node)
            {
                visited.Add(node);
                looked.Push(node);
                this.frames.Append((visited.ToArray(), looked.ToArray()));
            }

            // Initialize Search
            queue.Enqueue(this.tree.root);

            do
            {
                if (!this.tree.root.Equals(queue.Peek()))
                {
                    // Backtrack until it's ancestor of next node
                    while (!looked.Peek().IsAncestorOf(queue.Peek()))
                    {
                        Backtrack();
                    }

                    // MoveTo until it's the parent of next node
                    if (queue.Peek().parent is object)
                    {
                        while (looked.Peek().IsAncestorOf(queue.Peek()) && !queue.Peek().parent.Equals(looked.Peek()))
                        {

                            foreach (Node child in looked.Peek().children)
                            {
                                if (child.IsAncestorOf(queue.Peek()))
                                {
                                    MoveTo(child);
                                    break;
                                }
                            }
                        }
                    }
                }
                


                // Get Next Node
                curNode = queue.Dequeue();
                

                // Move to next Node
                MoveTo(curNode);

                // Get the children of the node
                
                curNode.FindChildren();



                foreach (Node child in curNode.children)
                {
                    // Move to the child
                    MoveTo(child);
                    // Terminates if the child is the target
                    if (Utils.getDirName(child.dirName).Equals(target))
                    {
                        curNode = child;
                        break;
                    } else
                    // Else, add the directories into queue, then backtrack to current node
                    {
                        if (child.type.Equals("directory"))
                        {
                            queue.Enqueue(child);
                        }
                        Backtrack();
                    }
                }
            } while (!Utils.getDirName(curNode.dirName).Equals(target) && queue.Count > 0);

            // If target isn't found, clear the looked array
            if (!Utils.getDirName(curNode.dirName).Equals(target))
            {
                looked.Clear();
                this.frames.Append((visited.ToArray(), looked.ToArray()));
            }

            // Set final state of tree
            this.tree.visited = visited.ToArray();
            this.tree.looked = looked.ToArray();
            return this.tree;
        }
    }
}

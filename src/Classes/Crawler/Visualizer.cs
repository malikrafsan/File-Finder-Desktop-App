using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FolderCrawler.Classes;
using System.Windows.Forms;
using Microsoft.Msagl.GraphViewerGdi;
using Microsoft.Msagl.Drawing;

namespace FolderCrawler.Classes.Crawler
{
    class Visualizer
    {
        private DirTree.Tree tree;
        
        private (DirTree.Node[] visited, DirTree.Node[] looked, DirTree.Node[] result)[] frames;
        public Visualizer(DirTree.Tree tree, (DirTree.Node[] visited, DirTree.Node[] looked, DirTree.Node[] result)[] frames)
        {
            this.tree = tree;
            this.frames = frames;
        }

        public Visualizer(Crawler crawler)
        {
            this.tree = crawler.tree;
            this.frames = crawler.frames.ToArray();
        }

        public async void Visualize(Panel target, int delay, LayoutMethod layoutGraph)
        { 
            GViewer viewer = new GViewer();
            viewer.Dock = DockStyle.Fill;
            viewer.DrawingPanel.BackColor = System.Drawing.Color.FromArgb(13, 59, 102);
            viewer.CurrentLayoutMethod = layoutGraph;
            target.SuspendLayout();
            target.Controls.Clear();
            target.Controls.Add(viewer);
            target.ResumeLayout();
            foreach ((DirTree.Node[] visited, DirTree.Node[] looked, DirTree.Node[] result) frame in this.frames)
            {
                Graph temp = VisualizeTree(this.tree, frame);
                viewer.Graph = temp;
                await Task.Delay(delay);
            }
        }

        public Graph VisualizeTree(DirTree.Tree tree, (DirTree.Node[] visited, DirTree.Node[] looked, DirTree.Node[] result) frame)
        {
            Graph graph = new Graph();
            Node node = graph.AddNode(tree.root.dirName);
            node.LabelText = Utils.GetDirName(tree.root.dirName);
            if (frame.looked.Contains(tree.root))
            {
                node.Attr.Color = Color.Blue;
            }
            else if (frame.result.Contains(tree.root))
            {
                node.Attr.Color = Color.Green;
            }
            else if (frame.visited.Contains(tree.root))
            {
                node.Attr.Color = Color.Red;
            }
            VisualizeChildren(graph, tree.root, frame);
            return graph;
        }

        private void VisualizeChildren(Graph graph, DirTree.Node parent, (DirTree.Node[] visited, DirTree.Node[] looked, DirTree.Node[] result) frame)
        {
            if (parent.children.Count > 0)
            {
                foreach (DirTree.Node child in parent.children)
                {
                    Node node = graph.AddNode(child.dirName);
                    node.LabelText = Utils.GetDirName(child.dirName);
                    Edge edge = graph.AddEdge(parent.dirName, child.dirName);
                    if (frame.looked.Contains(child))
                    {
                        node.Attr.Color = Color.Blue;
                        edge.Attr.Color = Color.Blue;
                    } else if (frame.result.Contains(child))
                    {
                        node.Attr.Color = Color.Green;
                        edge.Attr.Color = Color.Green;
                    }
                    else if (frame.visited.Contains(child))
                    {
                        node.Attr.Color = Color.Red;
                        edge.Attr.Color = Color.Red;
                    } else
                    {
                        continue;
                    }
                    VisualizeChildren(graph, child, frame);
                }
            }
        }
    }
}

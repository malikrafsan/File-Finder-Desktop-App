using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Msagl.Drawing;
using Microsoft.Msagl.Core.Geometry.Curves;
using Microsoft.Msagl.Core.Layout;
using Microsoft.Msagl.DebugHelpers.Persistence;
using Microsoft.Msagl.Layout.Layered;

namespace FolderCrawler
{
    public partial class Form1 : Form
    {
        class SearchProps 
        {
            public string startDir;
            public string fileName;
            public bool findAll;
            public string method;

            public SearchProps()
            {
                startDir = "";
                fileName = "";
                findAll = false;
                method = "BFS";
            }
            public bool isReady()
            {
                return this.startDir != "" && this.fileName != "";
            }
            public string props()
            {
                return "startDir = " + this.startDir + "\nfileName = " + this.fileName + "\nfindAll = " + (this.findAll ? "True" : "FALSE") + "\nmethod = " + this.method;
            }
        }

        private SearchProps searchProps;
        private bool mouseDown;
        private Point offset;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            searchProps = new SearchProps();
            cBoxFindAll.Checked = this.searchProps.findAll;
            if (this.searchProps.method == "BFS")
            {
                rBtnBFS.Checked = true;
            } else
            {
                rBtnDFS.Checked = true;
            }
            this.viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.searchProps.fileName = txtFileName.Text;
        }

        private void cBoxFindAll_CheckedChanged(object sender, EventArgs e)
        {
            this.searchProps.findAll = cBoxFindAll.Checked;
        }

        private void circularButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void circularButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = (WindowState == FormWindowState.Normal) ? FormWindowState.Maximized : FormWindowState.Normal;
            int border = (WindowState == FormWindowState.Normal) ? 30 : 0;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, border, border));
        }

        private void circularButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void mouseDown_Event(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void mouseMove_Event(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void mouseUp_Event(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.searchProps.startDir = folderDlg.SelectedPath;
                txtStartDir.Text = this.searchProps.startDir;
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }
        }

        private void customRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.searchProps.method = (rBtnBFS.Checked) ? "BFS" : "DFS";
        }

        private void customRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.searchProps.method = (rBtnBFS.Checked) ? "BFS" : "DFS";
        }

        private void fillGraph(Microsoft.Msagl.Drawing.Graph graph, Classes.DirTree.Tree resTree)
        {
            //if (resTree)
            string[] arrParent = resTree.root.dirName.Split('\\');
            string parent = arrParent[arrParent.Length - 1]; 
            foreach (Classes.DirTree.Node lookedNode in resTree.visited) {
                string[] arrChild = lookedNode.dirName.Split('\\');
                string child = arrChild[arrChild.Length - 1];
                graph.AddEdge(parent, child);
            }
        }

        private Microsoft.Msagl.GraphViewerGdi.GViewer viewer;
        private Microsoft.Msagl.Drawing.Graph graph;

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            if (this.searchProps.isReady())
            {
                Classes.Crawler.Crawler c = new Classes.Crawler.Crawler(this.searchProps.startDir);

                Stopwatch sw = new Stopwatch();
                sw.Start();
                Classes.DirTree.Tree resultTree = (this.searchProps.method == "BFS") ? c.BFS(this.searchProps.fileName) : c.DFS(this.searchProps.fileName);
                sw.Stop();
                
                //create a graph object 
                this.graph = new Microsoft.Msagl.Drawing.Graph("graph");

                this.fillGraph(graph, resultTree);

                viewer.Graph = graph;
                pnlGraph.SuspendLayout();
                viewer.Dock = DockStyle.Fill;
                pnlGraph.Controls.Add(viewer);
                pnlGraph.ResumeLayout();
                //var g = new GeometryGraph();

                string[] files = Directory.GetFiles(this.searchProps.startDir);
                string[] dirs = Directory.GetDirectories(this.searchProps.startDir);

                string dirsString = "";
                foreach (string dir in dirs)
                {
                    dirsString += ("- " + dir + "\n");
                }
                string filesString = "";
                foreach (string file in files)
                {
                    filesString += ("- " + file + "\n");
                }

                lblTimeSpent.Text = "Time Spent: " + sw.ElapsedMilliseconds + " ms";

                resPnl.Controls.Clear();
                for (int i=0;i<files.Count();i++)
                {
                    LinkLabel linkLbl = new LinkLabel();
                    resPnl.Controls.Add(linkLbl);
                    linkLbl.Top = 10 + (20 * i);
                    linkLbl.Left = 5;
                    linkLbl.Text = files[i];
                    linkLbl.AutoSize = true;
                    linkLbl.BackColor = System.Drawing.Color.FromArgb(255, 107, 108);
                    linkLbl.Padding = new Padding(4,4,4,4);
                    linkLbl.Click += linkLabel_Click;
                }

                string str = "";
                foreach (string file in files)
                {
                    str += file + "\n";
                }
                MessageBox.Show(str);
            }
            else
            {
                MessageBox.Show("PLEASE FILL START DIRECTORY AND FILE NAME FIRST\n" + this.searchProps.props());
            }
        }

        private void linkLabel_Click(object sender, EventArgs e)
        {
            var linkLbl = (LinkLabel)sender;
            Process.Start(linkLbl.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

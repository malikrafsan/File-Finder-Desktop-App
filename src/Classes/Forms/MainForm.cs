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
    public partial class MainForm : Form
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
        private Microsoft.Msagl.GraphViewerGdi.LayoutMethod layoutGraph;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );
        public MainForm()
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
            layoutGraph = Microsoft.Msagl.GraphViewerGdi.LayoutMethod.MDS;
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


        public Microsoft.Msagl.GraphViewerGdi.GViewer viewer;

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            if (this.searchProps.isReady())
            {
                Classes.Crawler.Crawler c = new Classes.Crawler.Crawler(this.searchProps.startDir);
                Stopwatch sw = new Stopwatch();
                sw.Start();
                if (this.searchProps.method == "BFS")
                {
                    c.BFS(this.searchProps.fileName, this.searchProps.findAll);
                } else
                {
                    c.DFS(this.searchProps.fileName, this.searchProps.findAll);
                }
                sw.Stop();
                Classes.Crawler.Visualizer v = new Classes.Crawler.Visualizer(c);

                //create a graph object 

                v.Visualize(pnlGraph, Convert.ToInt32(Math.Round(this.delayInput.Value, 0)), this.layoutGraph);

                // display time spent

                this.lblTimeSpent.Text = "Time Spent: " + sw.ElapsedMilliseconds + " ms";

                resPnl.Controls.Clear();

                string[] results = c.GetResults(this.searchProps.fileName);

                for (int i=0;i<results.Length;i++)
                {
                    LinkLabel linkLbl = new LinkLabel();
                    resPnl.Controls.Add(linkLbl);
                    linkLbl.Top = 10 + (20 * i);
                    linkLbl.Left = 5;
                    linkLbl.Text = results[i];
                    linkLbl.AutoSize = true;
                    linkLbl.BackColor = System.Drawing.Color.FromArgb(255, 107, 108);
                    linkLbl.Padding = new Padding(4, 4, 4, 4);
                    linkLbl.Click += linkLabel_Click;
                }
            }
            else
            {
                MessageBox.Show("PLEASE FILL START DIRECTORY AND FILE NAME FIRST\n" + this.searchProps.props());
            }
        }

        private void linkLabel_Click(object sender, EventArgs e)
        {
            var linkLbl = (LinkLabel)sender;
            string[] arrChild = linkLbl.Text.Split('\\');
            string[] arrParent = new string[arrChild.Length-1];
            for (int i = 0; i < arrChild.Length - 1; i++)
            {
                arrParent[i] = arrChild[i];
            }
            string parent = string.Join("\\", arrParent);
            Process.Start(parent);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.comboBox1.SelectedIndex)
            {
                case 0:
                    this.layoutGraph = Microsoft.Msagl.GraphViewerGdi.LayoutMethod.SugiyamaScheme;
                    break;
                case 1:
                    this.layoutGraph = Microsoft.Msagl.GraphViewerGdi.LayoutMethod.MDS;
                    break;
                case 2:
                    this.layoutGraph = Microsoft.Msagl.GraphViewerGdi.LayoutMethod.Ranking;
                    break;
            }
        }
    }
}

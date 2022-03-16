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
using Microsoft.Msagl.Core.Geometry;
using Microsoft.Msagl.Core.Geometry.Curves;

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

        public Form1()
        {
            InitializeComponent();
            searchProps = new SearchProps();
            cBoxFindAll.Checked = this.searchProps.findAll;
            if (this.searchProps.method == "BFS")
            {
                rbtnBFS.Checked = true;
            } else
            {
                rbtnDFS.Checked = true;
            }
            //(this.searchProps.method == "BFS") ? (rbtnBFS.Checked = true) : (rbtnDFS.Checked = true);
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void txtStartDir_TextChanged(object sender, EventArgs e)
        {
            linkLabel1.Text = this.searchProps.startDir;
        }

        private void rbtnBFS_CheckedChanged(object sender, EventArgs e)
        {
            this.searchProps.method = (rbtnBFS.Checked) ? "BFS" : "DFS";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.searchProps.isReady())
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();

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

                MessageBox.Show(
                    "TODO SEARCH: \n" + this.searchProps.props() + "\n\n" + "DIRS 1ST DEPTH: \n" + dirsString + "\n" + "FILES 1ST DEPTH: \n" + filesString
                );

                sw.Stop();
                lblTimeSpent.Text = "Time Spent: " + sw.ElapsedMilliseconds + " ms";

            }
            else
            {
                MessageBox.Show("PLEASE FILL START DIRECTORY AND FILE NAME FIRST\n" + this.searchProps.props());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.searchProps.fileName = txtFileName.Text;
        }

        private void cBoxFindAll_CheckedChanged(object sender, EventArgs e)
        {
            this.searchProps.findAll = cBoxFindAll.Checked;
        }

        private void rbtnDFS_CheckedChanged(object sender, EventArgs e)
        {
            this.searchProps.method = (rbtnBFS.Checked) ? "BFS" : "DFS";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(this.searchProps.startDir);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

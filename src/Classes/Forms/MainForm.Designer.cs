
namespace FolderCrawler
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gradientPanel1 = new FolderCrawler.GradientPanel();
            this.pnlGraph = new System.Windows.Forms.Panel();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.delayInput = new System.Windows.Forms.NumericUpDown();
            this.resPnl = new System.Windows.Forms.Panel();
            this.lblTimeSpent = new System.Windows.Forms.Label();
            this.roundedButton2 = new FolderCrawler.RoundedButton();
            this.rBtnDFS = new FolderCrawler.CustomRadioButton();
            this.rBtnBFS = new FolderCrawler.CustomRadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.roundedButton1 = new FolderCrawler.RoundedButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxFindAll = new System.Windows.Forms.CheckBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.txtStartDir = new System.Windows.Forms.TextBox();
            this.lblStartDir = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.circularButton1 = new FolderCrawler.CircularButton();
            this.circularButton2 = new FolderCrawler.CircularButton();
            this.circularButton3 = new FolderCrawler.CircularButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gradientPanel1.SuspendLayout();
            this.pnlInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delayInput)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.AutoSize = true;
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(59)))), ((int)(((byte)(102)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(108)))));
            this.gradientPanel1.Controls.Add(this.pnlGraph);
            this.gradientPanel1.Controls.Add(this.pnlInput);
            this.gradientPanel1.Controls.Add(this.panel1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1200, 700);
            this.gradientPanel1.TabIndex = 5;
            // 
            // pnlGraph
            // 
            this.pnlGraph.BackColor = System.Drawing.Color.Transparent;
            this.pnlGraph.Location = new System.Drawing.Point(480, 93);
            this.pnlGraph.Name = "pnlGraph";
            this.pnlGraph.Size = new System.Drawing.Size(959, 722);
            this.pnlGraph.TabIndex = 2;
            // 
            // pnlInput
            // 
            this.pnlInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(117)))), ((int)(((byte)(203)))));
            this.pnlInput.Controls.Add(this.label4);
            this.pnlInput.Controls.Add(this.label3);
            this.pnlInput.Controls.Add(this.delayInput);
            this.pnlInput.Controls.Add(this.resPnl);
            this.pnlInput.Controls.Add(this.lblTimeSpent);
            this.pnlInput.Controls.Add(this.roundedButton2);
            this.pnlInput.Controls.Add(this.rBtnDFS);
            this.pnlInput.Controls.Add(this.rBtnBFS);
            this.pnlInput.Controls.Add(this.label2);
            this.pnlInput.Controls.Add(this.roundedButton1);
            this.pnlInput.Controls.Add(this.label1);
            this.pnlInput.Controls.Add(this.cBoxFindAll);
            this.pnlInput.Controls.Add(this.txtFileName);
            this.pnlInput.Controls.Add(this.lblFileName);
            this.pnlInput.Controls.Add(this.txtStartDir);
            this.pnlInput.Controls.Add(this.lblStartDir);
            this.pnlInput.Controls.Add(this.lblInput);
            this.pnlInput.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlInput.Location = new System.Drawing.Point(0, 70);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(449, 630);
            this.pnlInput.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(215, 300);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5);
            this.label4.Size = new System.Drawing.Size(39, 28);
            this.label4.TabIndex = 17;
            this.label4.Text = "ms";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 300);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5);
            this.label3.Size = new System.Drawing.Size(130, 28);
            this.label3.TabIndex = 16;
            this.label3.Text = "Visualizer Delay: ";
            // 
            // delayInput
            // 
            this.delayInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.delayInput.Location = new System.Drawing.Point(144, 302);
            this.delayInput.Name = "delayInput";
            this.delayInput.Size = new System.Drawing.Size(66, 26);
            this.delayInput.TabIndex = 15;
            // 
            // resPnl
            // 
            this.resPnl.AutoScroll = true;
            this.resPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(117)))), ((int)(((byte)(203)))));
            this.resPnl.Location = new System.Drawing.Point(1, 466);
            this.resPnl.Margin = new System.Windows.Forms.Padding(0);
            this.resPnl.Name = "resPnl";
            this.resPnl.Padding = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.resPnl.Size = new System.Drawing.Size(448, 164);
            this.resPnl.TabIndex = 14;
            // 
            // lblTimeSpent
            // 
            this.lblTimeSpent.AutoSize = true;
            this.lblTimeSpent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeSpent.ForeColor = System.Drawing.Color.White;
            this.lblTimeSpent.Location = new System.Drawing.Point(5, 389);
            this.lblTimeSpent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimeSpent.Name = "lblTimeSpent";
            this.lblTimeSpent.Padding = new System.Windows.Forms.Padding(5);
            this.lblTimeSpent.Size = new System.Drawing.Size(99, 28);
            this.lblTimeSpent.TabIndex = 4;
            this.lblTimeSpent.Text = "Time spent: ";
            // 
            // roundedButton2
            // 
            this.roundedButton2.BorderColor = System.Drawing.Color.Transparent;
            this.roundedButton2.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(108)))));
            this.roundedButton2.FlatAppearance.BorderSize = 0;
            this.roundedButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton2.Location = new System.Drawing.Point(9, 346);
            this.roundedButton2.Name = "roundedButton2";
            this.roundedButton2.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.roundedButton2.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.roundedButton2.OnHoverTextColor = System.Drawing.Color.Gray;
            this.roundedButton2.Size = new System.Drawing.Size(398, 40);
            this.roundedButton2.TabIndex = 13;
            this.roundedButton2.Text = "Search";
            this.roundedButton2.TextColor = System.Drawing.Color.White;
            this.roundedButton2.UseVisualStyleBackColor = true;
            this.roundedButton2.Click += new System.EventHandler(this.roundedButton2_Click);
            // 
            // rBtnDFS
            // 
            this.rBtnDFS.AutoSize = true;
            this.rBtnDFS.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(210)))), ((int)(((byte)(111)))));
            this.rBtnDFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnDFS.ForeColor = System.Drawing.Color.White;
            this.rBtnDFS.Location = new System.Drawing.Point(186, 259);
            this.rBtnDFS.MinimumSize = new System.Drawing.Size(0, 21);
            this.rBtnDFS.Name = "rBtnDFS";
            this.rBtnDFS.Size = new System.Drawing.Size(68, 22);
            this.rBtnDFS.TabIndex = 12;
            this.rBtnDFS.TabStop = true;
            this.rBtnDFS.Text = "DFS";
            this.rBtnDFS.UnCheckColor = System.Drawing.Color.White;
            this.rBtnDFS.UseVisualStyleBackColor = true;
            this.rBtnDFS.CheckedChanged += new System.EventHandler(this.customRadioButton2_CheckedChanged);
            // 
            // rBtnBFS
            // 
            this.rBtnBFS.AutoSize = true;
            this.rBtnBFS.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(210)))), ((int)(((byte)(111)))));
            this.rBtnBFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnBFS.ForeColor = System.Drawing.Color.White;
            this.rBtnBFS.Location = new System.Drawing.Point(11, 259);
            this.rBtnBFS.MinimumSize = new System.Drawing.Size(0, 21);
            this.rBtnBFS.Name = "rBtnBFS";
            this.rBtnBFS.Size = new System.Drawing.Size(67, 22);
            this.rBtnBFS.TabIndex = 11;
            this.rBtnBFS.TabStop = true;
            this.rBtnBFS.Text = "BFS";
            this.rBtnBFS.UnCheckColor = System.Drawing.Color.White;
            this.rBtnBFS.UseVisualStyleBackColor = true;
            this.rBtnBFS.CheckedChanged += new System.EventHandler(this.customRadioButton1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 417);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(83, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "File Path: ";
            // 
            // roundedButton1
            // 
            this.roundedButton1.BorderColor = System.Drawing.Color.Transparent;
            this.roundedButton1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(108)))));
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton1.Location = new System.Drawing.Point(4, 92);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.roundedButton1.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.roundedButton1.OnHoverTextColor = System.Drawing.Color.Gray;
            this.roundedButton1.Size = new System.Drawing.Size(145, 30);
            this.roundedButton1.TabIndex = 5;
            this.roundedButton1.Text = "Change Directory";
            this.roundedButton1.TextColor = System.Drawing.Color.White;
            this.roundedButton1.UseVisualStyleBackColor = true;
            this.roundedButton1.Click += new System.EventHandler(this.roundedButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Input Metode Pencarian";
            // 
            // cBoxFindAll
            // 
            this.cBoxFindAll.AutoSize = true;
            this.cBoxFindAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(117)))), ((int)(((byte)(203)))));
            this.cBoxFindAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxFindAll.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxFindAll.ForeColor = System.Drawing.Color.White;
            this.cBoxFindAll.Location = new System.Drawing.Point(8, 186);
            this.cBoxFindAll.Name = "cBoxFindAll";
            this.cBoxFindAll.Padding = new System.Windows.Forms.Padding(5);
            this.cBoxFindAll.Size = new System.Drawing.Size(154, 34);
            this.cBoxFindAll.TabIndex = 6;
            this.cBoxFindAll.Text = "Find all occurence";
            this.cBoxFindAll.UseVisualStyleBackColor = false;
            this.cBoxFindAll.CheckedChanged += new System.EventHandler(this.cBoxFindAll_CheckedChanged);
            // 
            // txtFileName
            // 
            this.txtFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileName.Location = new System.Drawing.Point(8, 160);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(398, 26);
            this.txtFileName.TabIndex = 5;
            this.txtFileName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.ForeColor = System.Drawing.Color.White;
            this.lblFileName.Location = new System.Drawing.Point(7, 133);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(121, 20);
            this.lblFileName.TabIndex = 4;
            this.lblFileName.Text = "Input File Name";
            // 
            // txtStartDir
            // 
            this.txtStartDir.Enabled = false;
            this.txtStartDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartDir.Location = new System.Drawing.Point(6, 63);
            this.txtStartDir.Name = "txtStartDir";
            this.txtStartDir.Size = new System.Drawing.Size(400, 26);
            this.txtStartDir.TabIndex = 2;
            // 
            // lblStartDir
            // 
            this.lblStartDir.AutoSize = true;
            this.lblStartDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDir.ForeColor = System.Drawing.Color.White;
            this.lblStartDir.Location = new System.Drawing.Point(5, 41);
            this.lblStartDir.Name = "lblStartDir";
            this.lblStartDir.Size = new System.Drawing.Size(170, 20);
            this.lblStartDir.TabIndex = 1;
            this.lblStartDir.Text = "Choose Start Directory";
            // 
            // lblInput
            // 
            this.lblInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInput.ForeColor = System.Drawing.Color.White;
            this.lblInput.Location = new System.Drawing.Point(0, 0);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(449, 30);
            this.lblInput.TabIndex = 0;
            this.lblInput.Text = "Input";
            this.lblInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.circularButton1);
            this.panel1.Controls.Add(this.circularButton2);
            this.panel1.Controls.Add(this.circularButton3);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 70);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(61)))), ((int)(((byte)(66)))));
            this.pictureBox1.Image = global::FolderCrawler.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // circularButton1
            // 
            this.circularButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.circularButton1.BackColor = System.Drawing.Color.Red;
            this.circularButton1.FlatAppearance.BorderSize = 0;
            this.circularButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularButton1.Location = new System.Drawing.Point(1154, 13);
            this.circularButton1.Name = "circularButton1";
            this.circularButton1.Size = new System.Drawing.Size(32, 32);
            this.circularButton1.TabIndex = 2;
            this.circularButton1.Text = "X";
            this.circularButton1.UseVisualStyleBackColor = false;
            this.circularButton1.Click += new System.EventHandler(this.circularButton1_Click);
            // 
            // circularButton2
            // 
            this.circularButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.circularButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(210)))), ((int)(((byte)(111)))));
            this.circularButton2.FlatAppearance.BorderSize = 0;
            this.circularButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularButton2.Location = new System.Drawing.Point(1108, 13);
            this.circularButton2.Name = "circularButton2";
            this.circularButton2.Size = new System.Drawing.Size(32, 32);
            this.circularButton2.TabIndex = 3;
            this.circularButton2.Text = "▭";
            this.circularButton2.UseVisualStyleBackColor = false;
            this.circularButton2.Click += new System.EventHandler(this.circularButton2_Click);
            // 
            // circularButton3
            // 
            this.circularButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.circularButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(139)))), ((int)(((byte)(244)))));
            this.circularButton3.FlatAppearance.BorderSize = 0;
            this.circularButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circularButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularButton3.Location = new System.Drawing.Point(1062, 14);
            this.circularButton3.Name = "circularButton3";
            this.circularButton3.Size = new System.Drawing.Size(32, 32);
            this.circularButton3.TabIndex = 4;
            this.circularButton3.Text = "-";
            this.circularButton3.UseVisualStyleBackColor = false;
            this.circularButton3.Click += new System.EventHandler(this.circularButton3_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(61)))), ((int)(((byte)(66)))));
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1200, 70);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Folder Crawler";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown_Event);
            this.lblTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove_Event);
            this.lblTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp_Event);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.gradientPanel1.ResumeLayout(false);
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delayInput)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.TextBox txtStartDir;
        private System.Windows.Forms.Label lblStartDir;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.CheckBox cBoxFindAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTimeSpent;
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Panel panel1;
        private CircularButton circularButton3;
        private CircularButton circularButton2;
        private CircularButton circularButton1;
        private System.Windows.Forms.Label lblTitle;
        private RoundedButton roundedButton1;
        private CustomRadioButton rBtnBFS;
        private RoundedButton roundedButton2;
        private CustomRadioButton rBtnDFS;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel resPnl;
        private System.Windows.Forms.Panel pnlGraph;
        private System.Windows.Forms.NumericUpDown delayInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}


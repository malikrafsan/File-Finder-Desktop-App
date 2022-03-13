
namespace FolderCrawler
{
    partial class Form1
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.rbtnDFS = new System.Windows.Forms.RadioButton();
            this.rbtnBFS = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxFindAll = new System.Windows.Forms.CheckBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtStartDir = new System.Windows.Forms.TextBox();
            this.lblStartDir = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.pnlInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1132, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Folder Crawler";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlInput
            // 
            this.pnlInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInput.Controls.Add(this.button2);
            this.pnlInput.Controls.Add(this.rbtnDFS);
            this.pnlInput.Controls.Add(this.rbtnBFS);
            this.pnlInput.Controls.Add(this.label1);
            this.pnlInput.Controls.Add(this.cBoxFindAll);
            this.pnlInput.Controls.Add(this.txtFileName);
            this.pnlInput.Controls.Add(this.lblFileName);
            this.pnlInput.Controls.Add(this.button1);
            this.pnlInput.Controls.Add(this.txtStartDir);
            this.pnlInput.Controls.Add(this.lblStartDir);
            this.pnlInput.Controls.Add(this.lblInput);
            this.pnlInput.Location = new System.Drawing.Point(4, 55);
            this.pnlInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(533, 579);
            this.pnlInput.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(11, 362);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 33);
            this.button2.TabIndex = 10;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rbtnDFS
            // 
            this.rbtnDFS.AutoSize = true;
            this.rbtnDFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDFS.Location = new System.Drawing.Point(267, 319);
            this.rbtnDFS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnDFS.Name = "rbtnDFS";
            this.rbtnDFS.Size = new System.Drawing.Size(64, 24);
            this.rbtnDFS.TabIndex = 9;
            this.rbtnDFS.TabStop = true;
            this.rbtnDFS.Text = "DFS";
            this.rbtnDFS.UseVisualStyleBackColor = true;
            this.rbtnDFS.CheckedChanged += new System.EventHandler(this.rbtnDFS_CheckedChanged);
            // 
            // rbtnBFS
            // 
            this.rbtnBFS.AutoSize = true;
            this.rbtnBFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnBFS.Location = new System.Drawing.Point(13, 319);
            this.rbtnBFS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnBFS.Name = "rbtnBFS";
            this.rbtnBFS.Size = new System.Drawing.Size(63, 24);
            this.rbtnBFS.TabIndex = 8;
            this.rbtnBFS.TabStop = true;
            this.rbtnBFS.Text = "BFS";
            this.rbtnBFS.UseVisualStyleBackColor = true;
            this.rbtnBFS.CheckedChanged += new System.EventHandler(this.rbtnBFS_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 282);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Input Metode Pencarian";
            // 
            // cBoxFindAll
            // 
            this.cBoxFindAll.AutoSize = true;
            this.cBoxFindAll.BackColor = System.Drawing.SystemColors.Control;
            this.cBoxFindAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxFindAll.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cBoxFindAll.Location = new System.Drawing.Point(11, 236);
            this.cBoxFindAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBoxFindAll.Name = "cBoxFindAll";
            this.cBoxFindAll.Size = new System.Drawing.Size(168, 24);
            this.cBoxFindAll.TabIndex = 6;
            this.cBoxFindAll.Text = "Find all occurence";
            this.cBoxFindAll.UseVisualStyleBackColor = false;
            this.cBoxFindAll.CheckedChanged += new System.EventHandler(this.cBoxFindAll_CheckedChanged);
            // 
            // txtFileName
            // 
            this.txtFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileName.Location = new System.Drawing.Point(11, 190);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(508, 26);
            this.txtFileName.TabIndex = 5;
            this.txtFileName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.Location = new System.Drawing.Point(9, 162);
            this.lblFileName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(126, 20);
            this.lblFileName.TabIndex = 4;
            this.lblFileName.Text = "Input File Name";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(8, 112);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Change Directory";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtStartDir
            // 
            this.txtStartDir.Enabled = false;
            this.txtStartDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartDir.Location = new System.Drawing.Point(8, 78);
            this.txtStartDir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStartDir.Name = "txtStartDir";
            this.txtStartDir.Size = new System.Drawing.Size(508, 26);
            this.txtStartDir.TabIndex = 2;
            this.txtStartDir.TextChanged += new System.EventHandler(this.txtStartDir_TextChanged);
            // 
            // lblStartDir
            // 
            this.lblStartDir.AutoSize = true;
            this.lblStartDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDir.Location = new System.Drawing.Point(7, 50);
            this.lblStartDir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartDir.Name = "lblStartDir";
            this.lblStartDir.Size = new System.Drawing.Size(181, 20);
            this.lblStartDir.TabIndex = 1;
            this.lblStartDir.Text = "Choose Start Directory";
            // 
            // lblInput
            // 
            this.lblInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInput.Location = new System.Drawing.Point(-1, 1);
            this.lblInput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(533, 37);
            this.lblInput.TabIndex = 0;
            this.lblInput.Text = "Input";
            this.lblInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 640);
            this.Controls.Add(this.pnlInput);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtStartDir;
        private System.Windows.Forms.Label lblStartDir;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.CheckBox cBoxFindAll;
        private System.Windows.Forms.RadioButton rbtnBFS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rbtnDFS;
    }
}


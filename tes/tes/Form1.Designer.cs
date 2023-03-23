using System.Collections.Generic;
using System;

namespace WinForm
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
            this.title = new System.Windows.Forms.Label();
            this.inputLabel = new System.Windows.Forms.Label();
            this.filenameLabel = new System.Windows.Forms.Label();
            this.fileNamePlace = new System.Windows.Forms.Label();
            this.openFileBtn = new System.Windows.Forms.Button();
            this.algoritmaLabel = new System.Windows.Forms.Label();
            this.SearchMethod = new System.Windows.Forms.GroupBox();
            this.dfsMultivisitbtn = new System.Windows.Forms.RadioButton();
            this.DFSbtn = new System.Windows.Forms.RadioButton();
            this.BFSbtn = new System.Windows.Forms.RadioButton();
            this.visualBtn = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.searchButtton = new System.Windows.Forms.Button();
            this.line = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.routeLabel = new System.Windows.Forms.Label();
            this.nodesLabel = new System.Windows.Forms.Label();
            this.stepsLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.routeText = new System.Windows.Forms.Label();
            this.timeText = new System.Windows.Forms.Label();
            this.stepsText = new System.Windows.Forms.Label();
            this.nodesText = new System.Windows.Forms.Label();
            this.sleepLabel = new System.Windows.Forms.Label();
            this.sleepInputBox = new System.Windows.Forms.NumericUpDown();
            this.msSleep = new System.Windows.Forms.Label();
            this.TSPcheckBox = new System.Windows.Forms.CheckBox();
            this.SearchMethod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.line)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sleepInputBox)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.LimeGreen;
            this.title.Location = new System.Drawing.Point(198, 20);
            this.title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(661, 55);
            this.title.TabIndex = 1;
            this.title.Text = "TREASURE HUNT SOLVER";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputLabel
            // 
            this.inputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.inputLabel.AutoSize = true;
            this.inputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.inputLabel.Location = new System.Drawing.Point(-103, 94);
            this.inputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(65, 26);
            this.inputLabel.TabIndex = 5;
            this.inputLabel.Text = "Input";
            // 
            // filenameLabel
            // 
            this.filenameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.filenameLabel.AutoSize = true;
            this.filenameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filenameLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.filenameLabel.Location = new System.Drawing.Point(-102, 205);
            this.filenameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.filenameLabel.Name = "filenameLabel";
            this.filenameLabel.Size = new System.Drawing.Size(137, 31);
            this.filenameLabel.TabIndex = 7;
            this.filenameLabel.Text = "File Name";
            // 
            // fileNamePlace
            // 
            this.fileNamePlace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.fileNamePlace.AutoSize = true;
            this.fileNamePlace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fileNamePlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileNamePlace.ForeColor = System.Drawing.Color.Black;
            this.fileNamePlace.Location = new System.Drawing.Point(-98, 257);
            this.fileNamePlace.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fileNamePlace.MaximumSize = new System.Drawing.Size(300, 17);
            this.fileNamePlace.MinimumSize = new System.Drawing.Size(300, 17);
            this.fileNamePlace.Name = "fileNamePlace";
            this.fileNamePlace.Size = new System.Drawing.Size(300, 17);
            this.fileNamePlace.TabIndex = 14;
            this.fileNamePlace.Text = "e.g maze.txt";
            // 
            // openFileBtn
            // 
            this.openFileBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.openFileBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.openFileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openFileBtn.ForeColor = System.Drawing.Color.Chartreuse;
            this.openFileBtn.Location = new System.Drawing.Point(-99, 283);
            this.openFileBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.openFileBtn.MaximumSize = new System.Drawing.Size(98, 28);
            this.openFileBtn.MinimumSize = new System.Drawing.Size(98, 28);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(98, 28);
            this.openFileBtn.TabIndex = 15;
            this.openFileBtn.Text = "Open File";
            this.openFileBtn.UseVisualStyleBackColor = false;
            this.openFileBtn.Click += new System.EventHandler(this.openFileBtn_Click);
            // 
            // algoritmaLabel
            // 
            this.algoritmaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.algoritmaLabel.AutoSize = true;
            this.algoritmaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.algoritmaLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.algoritmaLabel.Location = new System.Drawing.Point(-103, 367);
            this.algoritmaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.algoritmaLabel.Name = "algoritmaLabel";
            this.algoritmaLabel.Size = new System.Drawing.Size(128, 31);
            this.algoritmaLabel.TabIndex = 16;
            this.algoritmaLabel.Text = "Algoritma";
            // 
            // SearchMethod
            // 
            this.SearchMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.SearchMethod.AutoSize = true;
            this.SearchMethod.Controls.Add(this.dfsMultivisitbtn);
            this.SearchMethod.Controls.Add(this.DFSbtn);
            this.SearchMethod.Controls.Add(this.BFSbtn);
            this.SearchMethod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SearchMethod.ForeColor = System.Drawing.Color.Transparent;
            this.SearchMethod.Location = new System.Drawing.Point(-99, 407);
            this.SearchMethod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchMethod.MaximumSize = new System.Drawing.Size(210, 130);
            this.SearchMethod.MinimumSize = new System.Drawing.Size(210, 130);
            this.SearchMethod.Name = "SearchMethod";
            this.SearchMethod.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchMethod.Size = new System.Drawing.Size(210, 130);
            this.SearchMethod.TabIndex = 17;
            this.SearchMethod.TabStop = false;
            // 
            // dfsMultivisitbtn
            // 
            this.dfsMultivisitbtn.AutoSize = true;
            this.dfsMultivisitbtn.Font = new System.Drawing.Font("Corbel", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dfsMultivisitbtn.ForeColor = System.Drawing.Color.DarkRed;
            this.dfsMultivisitbtn.Location = new System.Drawing.Point(4, 52);
            this.dfsMultivisitbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dfsMultivisitbtn.Name = "dfsMultivisitbtn";
            this.dfsMultivisitbtn.Size = new System.Drawing.Size(233, 41);
            this.dfsMultivisitbtn.TabIndex = 3;
            this.dfsMultivisitbtn.TabStop = true;
            this.dfsMultivisitbtn.Text = "DFS (Multivisit)";
            this.dfsMultivisitbtn.UseVisualStyleBackColor = true;
            // 
            // DFSbtn
            // 
            this.DFSbtn.AutoSize = true;
            this.DFSbtn.Font = new System.Drawing.Font("Corbel", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DFSbtn.ForeColor = System.Drawing.Color.DarkRed;
            this.DFSbtn.Location = new System.Drawing.Point(4, 17);
            this.DFSbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DFSbtn.Name = "DFSbtn";
            this.DFSbtn.Size = new System.Drawing.Size(89, 41);
            this.DFSbtn.TabIndex = 1;
            this.DFSbtn.TabStop = true;
            this.DFSbtn.Text = "DFS";
            this.DFSbtn.UseVisualStyleBackColor = true;
            // 
            // BFSbtn
            // 
            this.BFSbtn.AutoSize = true;
            this.BFSbtn.Font = new System.Drawing.Font("Corbel", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BFSbtn.ForeColor = System.Drawing.Color.DarkRed;
            this.BFSbtn.Location = new System.Drawing.Point(4, 87);
            this.BFSbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BFSbtn.Name = "BFSbtn";
            this.BFSbtn.Size = new System.Drawing.Size(87, 41);
            this.BFSbtn.TabIndex = 2;
            this.BFSbtn.TabStop = true;
            this.BFSbtn.Text = "BFS";
            this.BFSbtn.UseVisualStyleBackColor = true;
            // 
            // visualBtn
            // 
            this.visualBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.visualBtn.BackColor = System.Drawing.Color.Red;
            this.visualBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visualBtn.ForeColor = System.Drawing.Color.Transparent;
            this.visualBtn.Location = new System.Drawing.Point(-2, 686);
            this.visualBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.visualBtn.MaximumSize = new System.Drawing.Size(135, 41);
            this.visualBtn.MinimumSize = new System.Drawing.Size(135, 41);
            this.visualBtn.Name = "visualBtn";
            this.visualBtn.Size = new System.Drawing.Size(135, 41);
            this.visualBtn.TabIndex = 18;
            this.visualBtn.Text = "Visualize";
            this.visualBtn.UseVisualStyleBackColor = false;
            this.visualBtn.Click += new System.EventHandler(this.visualBtn_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.outputLabel.Location = new System.Drawing.Point(335, 94);
            this.outputLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(83, 26);
            this.outputLabel.TabIndex = 19;
            this.outputLabel.Text = "Output";
            // 
            // searchButtton
            // 
            this.searchButtton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.searchButtton.BackColor = System.Drawing.Color.Red;
            this.searchButtton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButtton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchButtton.Location = new System.Drawing.Point(728, 686);
            this.searchButtton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchButtton.MaximumSize = new System.Drawing.Size(135, 41);
            this.searchButtton.MinimumSize = new System.Drawing.Size(135, 41);
            this.searchButtton.Name = "searchButtton";
            this.searchButtton.Size = new System.Drawing.Size(135, 41);
            this.searchButtton.TabIndex = 20;
            this.searchButtton.Text = "Search!";
            this.searchButtton.UseVisualStyleBackColor = false;
            this.searchButtton.Click += new System.EventHandler(this.searchButtton_Click);
            // 
            // line
            // 
            this.line.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.line.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.line.Location = new System.Drawing.Point(316, 94);
            this.line.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.line.MaximumSize = new System.Drawing.Size(1, 650);
            this.line.MinimumSize = new System.Drawing.Size(1, 650);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(1, 650);
            this.line.TabIndex = 21;
            this.line.TabStop = false;
            this.line.Click += new System.EventHandler(this.line_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // routeLabel
            // 
            this.routeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.routeLabel.AutoSize = true;
            this.routeLabel.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.routeLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.routeLabel.Location = new System.Drawing.Point(334, 594);
            this.routeLabel.Name = "routeLabel";
            this.routeLabel.Size = new System.Drawing.Size(87, 29);
            this.routeLabel.TabIndex = 22;
            this.routeLabel.Text = "Route :";
            // 
            // nodesLabel
            // 
            this.nodesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.nodesLabel.AutoSize = true;
            this.nodesLabel.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nodesLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.nodesLabel.Location = new System.Drawing.Point(1051, 633);
            this.nodesLabel.Name = "nodesLabel";
            this.nodesLabel.Size = new System.Drawing.Size(90, 29);
            this.nodesLabel.TabIndex = 23;
            this.nodesLabel.Text = "Nodes :";
            // 
            // stepsLabel
            // 
            this.stepsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.stepsLabel.AutoSize = true;
            this.stepsLabel.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stepsLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.stepsLabel.Location = new System.Drawing.Point(1051, 594);
            this.stepsLabel.Name = "stepsLabel";
            this.stepsLabel.Size = new System.Drawing.Size(93, 29);
            this.stepsLabel.TabIndex = 24;
            this.stepsLabel.Text = "Steps   :";
            // 
            // timeLabel
            // 
            this.timeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.timeLabel.Location = new System.Drawing.Point(334, 633);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(181, 29);
            this.timeLabel.TabIndex = 25;
            this.timeLabel.Text = "Execution time :";
            // 
            // routeText
            // 
            this.routeText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.routeText.AutoSize = true;
            this.routeText.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.routeText.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.routeText.Location = new System.Drawing.Point(427, 594);
            this.routeText.Name = "routeText";
            this.routeText.Size = new System.Drawing.Size(21, 29);
            this.routeText.TabIndex = 26;
            this.routeText.Text = "-";
            // 
            // timeText
            // 
            this.timeText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.timeText.AutoSize = true;
            this.timeText.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeText.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.timeText.Location = new System.Drawing.Point(521, 633);
            this.timeText.Name = "timeText";
            this.timeText.Size = new System.Drawing.Size(92, 29);
            this.timeText.TabIndex = 27;
            this.timeText.Text = "0,00 ms";
            // 
            // stepsText
            // 
            this.stepsText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.stepsText.AutoSize = true;
            this.stepsText.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stepsText.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.stepsText.Location = new System.Drawing.Point(1150, 594);
            this.stepsText.Name = "stepsText";
            this.stepsText.Size = new System.Drawing.Size(25, 29);
            this.stepsText.TabIndex = 28;
            this.stepsText.Text = "0";
            // 
            // nodesText
            // 
            this.nodesText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.nodesText.AutoSize = true;
            this.nodesText.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nodesText.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.nodesText.Location = new System.Drawing.Point(1150, 633);
            this.nodesText.Name = "nodesText";
            this.nodesText.Size = new System.Drawing.Size(25, 29);
            this.nodesText.TabIndex = 29;
            this.nodesText.Text = "0";
            // 
            // sleepLabel
            // 
            this.sleepLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.sleepLabel.AutoSize = true;
            this.sleepLabel.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sleepLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.sleepLabel.Location = new System.Drawing.Point(-97, 594);
            this.sleepLabel.Name = "sleepLabel";
            this.sleepLabel.Size = new System.Drawing.Size(122, 29);
            this.sleepLabel.TabIndex = 32;
            this.sleepLabel.Text = "Sleep time";
            // 
            // sleepInputBox
            // 
            this.sleepInputBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.sleepInputBox.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sleepInputBox.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.sleepInputBox.Location = new System.Drawing.Point(40, 594);
            this.sleepInputBox.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.sleepInputBox.Name = "sleepInputBox";
            this.sleepInputBox.Size = new System.Drawing.Size(93, 33);
            this.sleepInputBox.TabIndex = 33;
            // 
            // msSleep
            // 
            this.msSleep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.msSleep.AutoSize = true;
            this.msSleep.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msSleep.ForeColor = System.Drawing.Color.DarkRed;
            this.msSleep.Location = new System.Drawing.Point(149, 594);
            this.msSleep.Name = "msSleep";
            this.msSleep.Size = new System.Drawing.Size(43, 29);
            this.msSleep.TabIndex = 34;
            this.msSleep.Text = "ms";
            // 
            // TSPcheckBox
            // 
            this.TSPcheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TSPcheckBox.AutoSize = true;
            this.TSPcheckBox.Font = new System.Drawing.Font("Corbel", 22.2F, System.Drawing.FontStyle.Bold);
            this.TSPcheckBox.ForeColor = System.Drawing.Color.DarkRed;
            this.TSPcheckBox.Location = new System.Drawing.Point(181, 424);
            this.TSPcheckBox.Name = "TSPcheckBox";
            this.TSPcheckBox.Size = new System.Drawing.Size(88, 41);
            this.TSPcheckBox.TabIndex = 35;
            this.TSPcheckBox.Text = "TSP";
            this.TSPcheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.TSPcheckBox);
            this.Controls.Add(this.msSleep);
            this.Controls.Add(this.sleepInputBox);
            this.Controls.Add(this.sleepLabel);
            this.Controls.Add(this.nodesText);
            this.Controls.Add(this.stepsText);
            this.Controls.Add(this.timeText);
            this.Controls.Add(this.routeText);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.stepsLabel);
            this.Controls.Add(this.nodesLabel);
            this.Controls.Add(this.routeLabel);
            this.Controls.Add(this.line);
            this.Controls.Add(this.searchButtton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.visualBtn);
            this.Controls.Add(this.SearchMethod);
            this.Controls.Add(this.algoritmaLabel);
            this.Controls.Add(this.openFileBtn);
            this.Controls.Add(this.fileNamePlace);
            this.Controls.Add(this.filenameLabel);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.title);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Treasure Hunt Solver";
            this.SearchMethod.ResumeLayout(false);
            this.SearchMethod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.line)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sleepInputBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label title;
        internal System.Windows.Forms.Label inputLabel;
        internal System.Windows.Forms.Label filenameLabel;
        internal System.Windows.Forms.Label fileNamePlace;
        internal System.Windows.Forms.Button openFileBtn;
        internal System.Windows.Forms.Label algoritmaLabel;
        internal System.Windows.Forms.GroupBox SearchMethod;
        internal System.Windows.Forms.RadioButton DFSbtn;
        internal System.Windows.Forms.RadioButton BFSbtn;
        internal System.Windows.Forms.Button visualBtn;
        internal System.Windows.Forms.Label outputLabel;
        internal System.Windows.Forms.Button searchButtton;
        internal System.Windows.Forms.PictureBox line;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label routeLabel;
        private System.Windows.Forms.Label nodesLabel;
        private System.Windows.Forms.Label stepsLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label routeText;
        private System.Windows.Forms.Label timeText;
        private System.Windows.Forms.Label stepsText;
        private System.Windows.Forms.Label nodesText;
        private System.Windows.Forms.Label sleepLabel;
        private System.Windows.Forms.NumericUpDown sleepInputBox;
        private System.Windows.Forms.Label msSleep;
        private System.Windows.Forms.CheckBox TSPcheckBox;
        internal System.Windows.Forms.RadioButton dfsMultivisitbtn;
    }
}


namespace tes
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
            this.DFSbtn = new System.Windows.Forms.RadioButton();
            this.BFSbtn = new System.Windows.Forms.RadioButton();
            this.visualBtn = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.searchButtton = new System.Windows.Forms.Button();
            this.line = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SearchMethod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.line)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("ROG Fonts", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.LimeGreen;
            this.title.Location = new System.Drawing.Point(186, 25);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(1038, 72);
            this.title.TabIndex = 1;
            this.title.Text = "TREASURE HUNT SOLVER";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // inputLabel
            // 
            this.inputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.inputLabel.AutoSize = true;
            this.inputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.inputLabel.Location = new System.Drawing.Point(9, 116);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(82, 32);
            this.inputLabel.TabIndex = 5;
            this.inputLabel.Text = "Input";
            this.inputLabel.Click += new System.EventHandler(this.inputLabel_Click);
            // 
            // filenameLabel
            // 
            this.filenameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.filenameLabel.AutoSize = true;
            this.filenameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filenameLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.filenameLabel.Location = new System.Drawing.Point(11, 252);
            this.filenameLabel.Name = "filenameLabel";
            this.filenameLabel.Size = new System.Drawing.Size(173, 39);
            this.filenameLabel.TabIndex = 7;
            this.filenameLabel.Text = "File Name";
            this.filenameLabel.Click += new System.EventHandler(this.filenameLabel_Click);
            // 
            // fileNamePlace
            // 
            this.fileNamePlace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.fileNamePlace.AutoSize = true;
            this.fileNamePlace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fileNamePlace.Font = new System.Drawing.Font("RomanD", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileNamePlace.ForeColor = System.Drawing.Color.Black;
            this.fileNamePlace.Location = new System.Drawing.Point(16, 316);
            this.fileNamePlace.MaximumSize = new System.Drawing.Size(400, 20);
            this.fileNamePlace.MinimumSize = new System.Drawing.Size(400, 20);
            this.fileNamePlace.Name = "fileNamePlace";
            this.fileNamePlace.Size = new System.Drawing.Size(400, 20);
            this.fileNamePlace.TabIndex = 14;
            this.fileNamePlace.Text = "e.g maze.txt";
            this.fileNamePlace.Click += new System.EventHandler(this.fileNamePlace_Click);
            // 
            // openFileBtn
            // 
            this.openFileBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.openFileBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.openFileBtn.Font = new System.Drawing.Font("Monospac821 BT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openFileBtn.ForeColor = System.Drawing.Color.Chartreuse;
            this.openFileBtn.Location = new System.Drawing.Point(15, 348);
            this.openFileBtn.MaximumSize = new System.Drawing.Size(130, 35);
            this.openFileBtn.MinimumSize = new System.Drawing.Size(130, 35);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(130, 35);
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
            this.algoritmaLabel.Location = new System.Drawing.Point(9, 452);
            this.algoritmaLabel.Name = "algoritmaLabel";
            this.algoritmaLabel.Size = new System.Drawing.Size(161, 39);
            this.algoritmaLabel.TabIndex = 16;
            this.algoritmaLabel.Text = "Algoritma";
            this.algoritmaLabel.Click += new System.EventHandler(this.algoritmaLabel_Click);
            // 
            // SearchMethod
            // 
            this.SearchMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.SearchMethod.AutoSize = true;
            this.SearchMethod.Controls.Add(this.DFSbtn);
            this.SearchMethod.Controls.Add(this.BFSbtn);
            this.SearchMethod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SearchMethod.ForeColor = System.Drawing.Color.Transparent;
            this.SearchMethod.Location = new System.Drawing.Point(15, 501);
            this.SearchMethod.MaximumSize = new System.Drawing.Size(150, 150);
            this.SearchMethod.MinimumSize = new System.Drawing.Size(150, 150);
            this.SearchMethod.Name = "SearchMethod";
            this.SearchMethod.Size = new System.Drawing.Size(150, 150);
            this.SearchMethod.TabIndex = 17;
            this.SearchMethod.TabStop = false;
            this.SearchMethod.Enter += new System.EventHandler(this.SearchMethod_Enter);
            // 
            // DFSbtn
            // 
            this.DFSbtn.AutoSize = true;
            this.DFSbtn.Font = new System.Drawing.Font("Corbel", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DFSbtn.ForeColor = System.Drawing.Color.DarkRed;
            this.DFSbtn.Location = new System.Drawing.Point(6, 21);
            this.DFSbtn.Name = "DFSbtn";
            this.DFSbtn.Size = new System.Drawing.Size(106, 49);
            this.DFSbtn.TabIndex = 1;
            this.DFSbtn.TabStop = true;
            this.DFSbtn.Text = "DFS";
            this.DFSbtn.UseVisualStyleBackColor = true;
            this.DFSbtn.CheckedChanged += new System.EventHandler(this.DFSbtn_CheckedChanged);
            // 
            // BFSbtn
            // 
            this.BFSbtn.AutoSize = true;
            this.BFSbtn.Font = new System.Drawing.Font("Corbel", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BFSbtn.ForeColor = System.Drawing.Color.DarkRed;
            this.BFSbtn.Location = new System.Drawing.Point(6, 76);
            this.BFSbtn.Name = "BFSbtn";
            this.BFSbtn.Size = new System.Drawing.Size(104, 49);
            this.BFSbtn.TabIndex = 2;
            this.BFSbtn.TabStop = true;
            this.BFSbtn.Text = "BFS";
            this.BFSbtn.UseVisualStyleBackColor = true;
            this.BFSbtn.CheckedChanged += new System.EventHandler(this.BFSbtn_CheckedChanged);
            // 
            // visualBtn
            // 
            this.visualBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.visualBtn.BackColor = System.Drawing.Color.Red;
            this.visualBtn.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visualBtn.ForeColor = System.Drawing.Color.Transparent;
            this.visualBtn.Location = new System.Drawing.Point(143, 766);
            this.visualBtn.MaximumSize = new System.Drawing.Size(180, 50);
            this.visualBtn.MinimumSize = new System.Drawing.Size(180, 50);
            this.visualBtn.Name = "visualBtn";
            this.visualBtn.Size = new System.Drawing.Size(180, 50);
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
            this.outputLabel.Location = new System.Drawing.Point(481, 116);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(106, 32);
            this.outputLabel.TabIndex = 19;
            this.outputLabel.Text = "Output";
            this.outputLabel.Click += new System.EventHandler(this.outputLabel_Click);
            // 
            // searchButtton
            // 
            this.searchButtton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.searchButtton.BackColor = System.Drawing.Color.Red;
            this.searchButtton.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButtton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchButtton.Location = new System.Drawing.Point(894, 766);
            this.searchButtton.MaximumSize = new System.Drawing.Size(180, 50);
            this.searchButtton.MinimumSize = new System.Drawing.Size(180, 50);
            this.searchButtton.Name = "searchButtton";
            this.searchButtton.Size = new System.Drawing.Size(180, 50);
            this.searchButtton.TabIndex = 20;
            this.searchButtton.Text = "Search!";
            this.searchButtton.UseVisualStyleBackColor = false;
            this.searchButtton.Click += new System.EventHandler(this.searchButtton_Click);
            // 
            // line
            // 
            this.line.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.line.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.line.Location = new System.Drawing.Point(456, 116);
            this.line.MaximumSize = new System.Drawing.Size(1, 700);
            this.line.MinimumSize = new System.Drawing.Size(1, 700);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(1, 700);
            this.line.TabIndex = 21;
            this.line.TabStop = false;
            this.line.Click += new System.EventHandler(this.line_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1482, 953);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SearchMethod.ResumeLayout(false);
            this.SearchMethod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.line)).EndInit();
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
    }
}


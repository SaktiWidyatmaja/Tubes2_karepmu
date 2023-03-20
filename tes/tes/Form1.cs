using System.Security.Cryptography;
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DFS;
using System.Reflection.Emit;

namespace tes
{
    public partial class Form1 : Form
    {
        private int row = 0;
        private int col = 0;
        private char[,] map = new char[0, 0];
        private int[] start = new int[2];
        private string path = "";
        private static int[,] mapInt = new int[0, 0];
        private static List<Tuple<int, int>> goalStates = new List<Tuple<int, int>>();

        public Form1()
        {
            InitializeComponent();
        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void inputLabel_Click(object sender, EventArgs e)
        {

        }

        private void filenameLabel_Click(object sender, EventArgs e)
        {

        }

        private void fileNamePlace_Click(object sender, EventArgs e)
        {

        }

        private System.Windows.Forms.OpenFileDialog openFile1 = new OpenFileDialog();
        private void openFileBtn_Click(object sender, EventArgs e)
        {
            this.openFile1.InitialDirectory = @"C:\";
            this.openFile1.Title = "Search File";

            this.openFile1.CheckFileExists = true;
            this.openFile1.CheckPathExists = true;

            this.openFile1.DefaultExt = "txt";
            this.openFile1.Filter = "txt files (*.txt)|*.txt";
            this.openFile1.FilterIndex = 2;
            this.openFile1.RestoreDirectory = true;

            this.openFile1.ReadOnlyChecked = true;
            this.openFile1.ShowReadOnly = true;

            if (this.openFile1.ShowDialog() == DialogResult.OK)
            {
                fileNamePlace.Text = openFile1.FileName;
            }
        }

        private void algoritmaLabel_Click(object sender, EventArgs e)
        {

        }

        private void SearchMethod_Enter(object sender, EventArgs e)
        {

        }

        private void DFSbtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BFSbtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void outputLabel_Click(object sender, EventArgs e)
        {

        }

        private void searchButtton_Click(object sender, EventArgs e)
        {
            if (DFSbtn.Checked == true)
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                Console.WriteLine("search with DFS");
                DFSMazeSolver solver = new DFSMazeSolver(mapInt, goalStates);
                path = solver.Solve(start[0], start[1], path);

                string routetext = "";
                for (int i = 0; i < path.Length; i++)
                {
                    routetext += path[i];
                    if (i != path.Length - 1)
                    {
                        routetext += " - ";
                    }
                }

                routeText.Text = routetext;
                stepsText.Text = path.Length.ToString();
                nodesText.Text = solver.nodeCount.ToString();
                // routeText.Refresh();

                stopwatch.Stop();

                TimeSpan elapsed = stopwatch.Elapsed;
                timeText.Text = elapsed.TotalMilliseconds.ToString();
                timeText.Text += " ms";

            }
        }

        private void visualBtn_Click(object sender, EventArgs e)
        {
            Map();
        }

        private void line_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            this.openFile1.InitialDirectory = @"C:\";
            this.openFile1.Title = "Search File";

            this.openFile1.CheckFileExists = true;
            this.openFile1.CheckPathExists = true;

            this.openFile1.DefaultExt = "txt";
            this.openFile1.Filter = "txt files (*.txt)|*.txt";
            this.openFile1.FilterIndex = 2;
            this.openFile1.RestoreDirectory = true;

            this.openFile1.ReadOnlyChecked = true;
            this.openFile1.ShowReadOnly = true;
        }


        private void InitializeImageMatrix(char route, int rows, int cols)
        {
            PictureBox[,] imageMatrix = new PictureBox[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    var pictureBox = new PictureBox();

                    pictureBox.Location = new Point(j * 4 + 1253, i * 4 - 201);
                    pictureBox.Size = new Size(3, 3);

                    if (route == 'K')
                    {
                        pictureBox.BackColor = Color.Black;
                    }
                    else if (route == 'R')
                    {
                        pictureBox.BackColor = Color.Black;
                    }
                    else if (route == 'T')
                    {
                        pictureBox.BackColor = Color.Black;
                    }

                    // set other properties of the picture box as needed

                    imageMatrix[i, j] = pictureBox;
                    Controls.Add(pictureBox);
                }
            }
        }

        private int[,] ConvertMapToInt(char[,] map, int row, int col, int[] start)
        {
            mapInt = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (map[i, j] == 'X')
                    {
                        mapInt[i, j] = 1;
                    }
                    else
                    {
                        if (map[i, j] == 'K')
                        {
                            start[0] = i;
                            start[1] = j;
                        }
                        else if (map[i, j] == 'T')
                        {
                            goalStates.Add(new Tuple<int, int>(i, j));
                        }
                        mapInt[i, j] = 0;
                    }
                    
                }
            }
            return mapInt;
        }

        private char[,] ConvertMap(string textFile, int row, int col)
        {
            // Read a text file line by line.
            string[] lines = System.IO.File.ReadAllLines(textFile);

            this.row = lines.Length;
            this.col = lines[0].Split(' ').Length;

            int k;

            char[,] map = new char[row, col];

            for (int i = 0; i < row; i++)
            {
                k = 0;
                for (int j = 0; j < col; j++)
                {
                    if (lines[i][k] == ' ')
                    {
                        k++;
                    }
                    map[i, j] = lines[i][k];
                    Console.Write(map[i, j]);
                    k++;
                }

                Console.Write("\n");
            }

            return map;
        }

        private void Map()
        {
            string[] lines = System.IO.File.ReadAllLines(openFile1.FileName);

            this.row = lines.Length;
            this.col = lines[0].Split(' ').Length;
            this.map = ConvertMap(openFile1.FileName, this.row, this.col);

            int[] start = new int[2];
            int[,] MapInt = ConvertMapToInt(this.map, this.row, this.col, this.start);

            PictureBox[,] imageMatrix = new PictureBox[this.row, this.col];

            for (int i = 0; i < this.row; i++)
            {
                for (int j = 0; j < this.col; j++)
                {
                    var pictureBox = new PictureBox();

                    pictureBox.Location = new Point((j * 35) + 638, (i * 35) + 150);


                    if (this.map[i, j] == 'K')
                    {
                        pictureBox.BackColor = Color.Red;
                        pictureBox.Size = new Size(20, 20);
                    }
                    else if (this.map[i, j] == 'R')
                    {
                        pictureBox.BackColor = Color.White;
                        pictureBox.Size = new Size(20, 20);
                    }
                    else if (this.map[i, j] == 'T')
                    {
                        pictureBox.BackColor = Color.BlueViolet;
                        pictureBox.Size = new Size(20, 20);
                    }
                    else if (this.map[i, j] == 'X')
                    {
                        pictureBox.BackColor = Color.Black;
                        pictureBox.Size = new Size(20, 20);
                    }

                    // set other properties of the picture box as needed

                    imageMatrix[i, j] = pictureBox;
                    Controls.Add(pictureBox);
                }
            }
            PictureBox backGroundMap = new PictureBox();
            backGroundMap.BackColor = Color.Black;
            backGroundMap.Location = new Point(627, 124);
            backGroundMap.Size = new Size(680, 460);
            Controls.Add(backGroundMap);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timeText_Click(object sender, EventArgs e)
        {

        }
    }
}

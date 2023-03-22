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
using BFS;
using DFS;
using System.Reflection.Emit;
using System.Threading;
using System.IO;

namespace WinForm
{
    public partial class Form1 : Form
    {
        private int row = 0;
        private int col = 0;
        private static char[,] map = new char[0, 0];
        private int[] start = new int[2];
        private string path = "";
        private static int[,] mapInt = new int[0, 0];
        private static List<Tuple<int, int>> goalStates = new List<Tuple<int, int>>();
        private double duration = 0;

        private static PictureBox[,] imageMatrix = new PictureBox[0, 0];

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
                Console.WriteLine("search with DFS");

                if (TSPcheckBox.Checked)
                {
                    Console.WriteLine("TSP");
                    goalStates.Add(new Tuple<int, int>(start[0], start[1]));
                    goalStates.Add(new Tuple<int, int>(start[0], start[1]));
                }

                Stopwatch stopwatch = new Stopwatch();

                DFSMazeSolver solver = new DFSMazeSolver(mapInt, goalStates, start);

                stopwatch.Start();
                solver.Solve(start[0], start[1], path, Decimal.ToInt32(sleepInputBox.Value));
                path = solver.path;
                stopwatch.Stop();

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
                routeText.Refresh();


                TimeSpan elapsed = stopwatch.Elapsed;
                this.duration = elapsed.TotalMilliseconds / 1000;
                timeText.Text = this.duration.ToString();
                timeText.Text += " s";


                //for (int i = 0; i < this.row; i++)
                //{
                //    for (int j = 0; j < this.col; j++)
                //    {
                //        if (solver.visited[i, j])
                //        {
                //            if (imageMatrix[i, j].BackColor == Color.White)
                //            {
                //                imageMatrix[i, j].BackColor = Color.Green;
                //            } else if (imageMatrix[i,j].BackColor == Color.BlueViolet)
                //            {
                //                imageMatrix[i, j].BackColor = Color.Aqua;
                //            }
                //        }
                //    }
                //}
            }

            if (BFSbtn.Checked == true)
            {
                Console.WriteLine("search with BFS");

                Stopwatch stopwatch = new Stopwatch();
                string pathPlan = "";
                List<Tuple<int, int>> simpulHidup = new List<Tuple<int, int>>();
                simpulHidup.Add(new Tuple<int, int>(start[0], start[1]));
                // bool tsp;
                BFSMazeSolver solver = new BFSMazeSolver(mapInt, goalStates);

                stopwatch.Start();
                // if (toggletsp){
                //     tsp = true;
                // } else {
                //     tsp = false;
                // }
                // solver.Solve(simpulHidup[0], ref path, ref pathPlan, ref simpulHidup, tsp);
                solver.Solve(simpulHidup[0], ref path, ref pathPlan, ref simpulHidup, false, Decimal.ToInt32(sleepInputBox.Value));
                // path = solver.path;
                stopwatch.Stop();

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
                routeText.Refresh();


                TimeSpan elapsed = stopwatch.Elapsed;
                timeText.Text = (elapsed.TotalMilliseconds / 1000).ToString();
                timeText.Text += " s";


                //for (int i = 0; i < this.row; i++)
                //{
                //    for (int j = 0; j < this.col; j++)
                //    {
                //        if (solver.visited[i, j])
                //        {
                //            if (imageMatrix[i, j].BackColor == Color.White)
                //            {
                //                imageMatrix[i, j].BackColor = Color.Green;
                //            } else if (imageMatrix[i,j].BackColor == Color.BlueViolet)
                //            {
                //                imageMatrix[i, j].BackColor = Color.Aqua;
                //            }
                //        }
                //    }
                //}
            }
        }


        public static void outputRoute(int i, int j, bool isVisited, int sleepTime)
        {
            Console.WriteLine("update gui color");
            Application.DoEvents();
            if (isVisited)
            {
                if (imageMatrix[i, j].BackColor == Color.White)
                {
                    imageMatrix[i, j].BackColor = Color.Green;
                }
                else if (imageMatrix[i, j].BackColor == Color.BlueViolet)
                {
                    imageMatrix[i, j].BackColor = Color.FromArgb(255, 255, 192);
                }
                else if (imageMatrix[i, j].BackColor == Color.Red)
                {
                    imageMatrix[i, j].BackColor = Color.Pink;
                }
            }
            else
            {
                if (map[i, j] == 'R')
                {
                    imageMatrix[i, j].BackColor = Color.White;
                }
                else if (map[i, j] == 'T')
                {
                    imageMatrix[i, j].BackColor = Color.BlueViolet;
                }
            }
            Thread.Sleep(sleepTime);
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

                    // if (lines[i][k] != 'R' && lines[i][k] != 'T' && lines[i][k] != 'T' && lines[i][k] != 'K' && lines[i][k] != 'X') {
                        // throw new InvalidDataException("input invalid");
                    // }
                }

                Console.Write("\n");
            }

            return map;
        }

        private void Map()
        {
            string[] lines = System.IO.File.ReadAllLines(openFile1.FileName);


            try
            {
                //Kalau udah ada input file, hapus dulu semua data
                if (this.row != 0)
                {
                    for (int i = 0; i < row; i++)
                    {
                        for (int j = 0; j < col; j++)
                        {
                            Controls.Remove(imageMatrix[i, j]);
                        }
                    }
                    this.row = 0;
                    this.col = 0;
                    this.duration = 0;

                    map = new char[0, 0];
                    start = new int[2];
                    path = "";
                    mapInt = new int[0, 0];
                    goalStates = new List<Tuple<int, int>>();
                }

                PictureBox backGroundMap = new PictureBox();
                backGroundMap.BackColor = Color.Black;
                backGroundMap.Location = new Point(587, 124);
                backGroundMap.Size = new Size(880, 460);
                Controls.Add(backGroundMap);
                backGroundMap.SendToBack();

                this.row = lines.Length;
                this.col = lines[0].Split(' ').Length;
                map = ConvertMap(openFile1.FileName, this.row, this.col);

                int[,] MapInt = ConvertMapToInt(map, this.row, this.col, this.start);

                imageMatrix = new PictureBox[this.row, this.col];

                for (int i = 0; i < this.row; i++)
                {
                    for (int j = 0; j < this.col; j++)
                    {
                        var pictureBox = new PictureBox();

                        pictureBox.Location = new Point((j * 50) + 738, (i * 50) + 150);


                        if (map[i, j] == 'K')
                        {
                            pictureBox.BackColor = Color.Red;
                            pictureBox.Size = new Size(46, 46);
                        }
                        else if (map[i, j] == 'R')
                        {
                            pictureBox.BackColor = Color.White;
                            pictureBox.Size = new Size(46, 46);
                        }
                        else if (map[i, j] == 'T')
                        {
                            pictureBox.BackColor = Color.BlueViolet;
                            pictureBox.Size = new Size(46, 46);
                        }
                        else if (map[i, j] == 'X')
                        {
                            pictureBox.BackColor = Color.Black;
                            pictureBox.Size = new Size(46, 46);
                        }

                        // set other properties of the picture box as needed

                        imageMatrix[i, j] = pictureBox;
                        Controls.Add(imageMatrix[i, j]);
                        imageMatrix[i, j].BringToFront();
                    }
                }
            }
            catch (InvalidDataException e) {
                Console.WriteLine($"Error : Invalid Data Input");
                System.Windows.Forms.TextBox errorText = new System.Windows.Forms.TextBox();
                errorText.Text = "INPUT FILE INVALID!";
                errorText.Location = new Point(738, 200);
                errorText.BackColor = Color.Black;
                errorText.ForeColor = Color.Red;
                errorText.Anchor = AnchorStyles.Top;
                errorText.Anchor = AnchorStyles.Bottom;
                errorText.BringToFront();
            }

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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void sleepInputBox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}

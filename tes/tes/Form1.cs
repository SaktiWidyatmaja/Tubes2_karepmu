using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace tes
{
    public partial class Form1 : Form
    {
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

                    pictureBox.Location = new Point(j*4 + 1253, i*4 - 201);
                    pictureBox.Size = new Size(3, 3);

                    if (route == 'K') 
                    {
                        pictureBox.BackColor = Color.Black;
                    } 
                    else if (route == 'R')
                    {
                        pictureBox.BackColor = Color.Black;
                    } else if (route == 'T')
                    {
                        pictureBox.BackColor = Color.Black;
                    }

                    // set other properties of the picture box as needed

                    imageMatrix[i, j] = pictureBox;
                    Controls.Add(pictureBox);
                }
            }
        }

        static char[,] ConvertMap(string textFile, ref int row, ref int col)
        {
            // Read a text file line by line.
            string[] lines = System.IO.File.ReadAllLines(textFile);

            row = lines.Length;
            col = lines[0].Split(' ').Length;

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

            int row = lines.Length;
            int col = lines[0].Split(' ').Length;
            char[,] Map = ConvertMap(openFile1.FileName, ref row, ref col);

            PictureBox[,] imageMatrix = new PictureBox[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    var pictureBox = new PictureBox();

                    pictureBox.Location = new Point((j * 55) + 560, (i * 55) + 200);
                    

                    if (Map[i,j] == 'K')
                    {
                        pictureBox.BackColor = Color.Red;
                        pictureBox.Size = new Size(40, 40);
                    }
                    else if (Map[i, j] == 'R')
                    {
                        pictureBox.BackColor = Color.White;
                        pictureBox.Size = new Size(40, 40);
                    }
                    else if (Map[i, j] == 'T')
                    {
                        pictureBox.BackColor = Color.BlueViolet;
                        pictureBox.Size = new Size(40, 40);
                    }
                    else if (Map[i, j] == 'X')
                    {
                        pictureBox.BackColor = Color.Black;
                        pictureBox.Size = new Size(40, 40);
                    }

                    // set other properties of the picture box as needed

                    imageMatrix[i, j] = pictureBox;
                    Controls.Add(pictureBox);
                }
            }
            PictureBox backGroundMap = new PictureBox();
            backGroundMap.BackColor = Color.Black;
            backGroundMap.Location = new Point(540, 180);
            backGroundMap.Size = new Size(927, 494);
            Controls.Add(backGroundMap);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.Controls.Add(title);
        }
    }
}

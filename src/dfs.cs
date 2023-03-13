using System;
using System.Collections.Generic;
using System.IO;

namespace HelloWorld
{
    class Program
    {
        static char[,] ConvertMap(string textFile, ref int row, ref int col)
        {
            // Read a text file line by line.
            string[] lines = File.ReadAllLines(textFile);

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

        static void InitStorage(char[,] map, int row, int col, ref int[] start, ref List<Tuple<int, int>> goal, ref List<Tuple<int, int>> track)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (map[i, j] == 'K')
                    {
                        start[0] = i;
                        start[1] = j;
                    }
                    else if (map[i, j] == 'T')
                    {
                        goal.Add(Tuple.Create(i, j));
                    }
                    else if (map[i, j] == 'R')
                    {
                        track.Add(Tuple.Create(i, j));
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int row = 0;
            int col = 0;

            int[] start = new int[2];
            var goal = new List<Tuple<int, int>> { };
            var track = new List<Tuple<int, int>> { };
            char[,] map = ConvertMap("../test/maze1.txt", ref row, ref col);
            InitStorage(map, row, col, ref start, ref goal, ref track);


            // Console.WriteLine(map[0, 0]);
            // Console.WriteLine("Hello World!");
        }
    }
}
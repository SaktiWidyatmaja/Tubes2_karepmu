using System;

namespace HelloWorld
{
    class Program
    {
        static char[,] ConvertMap(string textFile)
        {
            // Read a text file line by line.
            string[] lines = File.ReadAllLines(textFile);

            int row = lines.Length;
            int col = lines[0].Split(' ').Length;

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

            // foreach (string line in lines)
            // {
            //     foreach (char x in line)
            //     {
            //         if (x == 'K')
            //         {
            //             Console.WriteLine("ini K");
            //         }
            //         else if (x == 'R')
            //         {
            //             Console.WriteLine("ini R");
            //         }
            //     }
            //     Console.WriteLine("pindah baris");
            // }


            return map;
        }

        static void Main(string[] args)
        {
            char[,] map = ConvertMap("../test/maze1.txt");
            // Console.WriteLine(map[0, 0]);
            // Console.WriteLine("Hello World!");
        }
    }
}
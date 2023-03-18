using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int[,] maze = {
            {0, 0, 0, 0},
            {1, 0, 1, 0},
            {1, 0, 0, 0},
            {1, 0, 1, 1}
        };

        List<Tuple<int, int>> goalStates = new List<Tuple<int, int>>();
        goalStates.Add(new Tuple<int, int>(1, 3));
        goalStates.Add(new Tuple<int, int>(2, 1));
        goalStates.Add(new Tuple<int, int>(3, 1));

        MazeSolver solver = new MazeSolver(maze, goalStates);
        solver.Solve(0, 0, "");
    }
}

// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main(string[] args)
//     {
//         int[,] maze = {
//             {0, 0, 0},
//             {0, 0, 0},
//             {0, 0, 0},
//             {0, 0, 0}
//         };

//         List<Tuple<int, int>> goalStates = new List<Tuple<int, int>>();
//         goalStates.Add(new Tuple<int, int>(1, 1));
//         goalStates.Add(new Tuple<int, int>(2, 1));
//         goalStates.Add(new Tuple<int, int>(3, 1));
//         goalStates.Add(new Tuple<int, int>(1, 2));

//         MazeSolver solver = new MazeSolver(maze, goalStates);
//         solver.Solve(0, 0, "");
//     }
// }
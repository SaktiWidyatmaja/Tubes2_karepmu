// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main(string[] args)
//     {
//         int[,] maze = {
//             {0, 0, 0, 0},
//             {1, 0, 1, 0},
//             {1, 0, 0, 0},
//             {1, 0, 1, 1}
//         };

//         List<Tuple<int, int>> goalStates = new List<Tuple<int, int>>();
//         goalStates.Add(new Tuple<int, int>(1, 3));
//         goalStates.Add(new Tuple<int, int>(2, 1));
//         goalStates.Add(new Tuple<int, int>(3, 1));

//         string path = "";
//         string pathPlan = "";
//         List<Tuple<int, int>> simpulHidup = new List<Tuple<int, int>>();
//         simpulHidup.Add(new Tuple<int, int>(0, 0));

//         MazeSolver solver = new MazeSolver(maze, goalStates);
//         BFSMazeSolver solverb = new BFSMazeSolver(maze, goalStates);
//         solver.Solve(0, 0, "");
//         // solverb.Solve(simpulHidup[0], ref path, ref pathPlan, ref simpulHidup, false);
//         solverb.Solve(simpulHidup[0], ref path, ref pathPlan, ref simpulHidup, true);
//     }
// }

using System;
using System.Collections.Generic;
using DFS;

class Program
{
    static void Main(string[] args)
    {
        int[,] maze = {
            {0, 0, 0, 0},
            {0, 0, 1, 0},
            {1, 0, 0, 0},
            {1, 0, 1, 1}
        };

        List<Tuple<int, int>> goalStates = new List<Tuple<int, int>>();
        // goalStates.Add(new Tuple<int, int>(0, 0));
        // goalStates.Add(new Tuple<int, int>(0, 0));
        goalStates.Add(new Tuple<int, int>(1, 3));
        goalStates.Add(new Tuple<int, int>(2, 1));
        // goalStates.Add(new Tuple<int, int>(3, 1));

        int[] start = new int[2];
        start[0] = 0;
        start[1] = 0;
        DFSMazeSolver solver = new DFSMazeSolver(maze, goalStates, start);
        solver.Solve(start[0], start[1], "", 0);
    }
}
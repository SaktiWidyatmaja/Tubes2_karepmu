// using System;
// using System.Collections;
// using System.Collections.Generic;
// using System.IO;

// namespace HelloWorld
// {
//     class Program
//     {
//         static char[,] ConvertMap(string textFile, ref int row, ref int col, ref int[] start)
//         {
//             // Read a text file line by line.
//             string[] lines = File.ReadAllLines(textFile);

//             row = lines.Length;
//             col = lines[0].Split(' ').Length;

//             int k;

//             char[,] map = new char[row, col];

//             for (int i = 0; i < row; i++)
//             {
//                 k = 0;
//                 for (int j = 0; j < col; j++)
//                 {
//                     if (lines[i][k] == ' ')
//                     {
//                         k++;
//                     }
//                     if (lines[i][k] == 'K')
//                     {
//                         start[0] = i;
//                         start[1] = j;
//                     }
//                     map[i, j] = lines[i][k];
//                     // Console.Write(map[i, j]);
//                     k++;
//                 }

//                 // Console.Write("\n");
//             }

//             return map;
//         }

//         static void InitStorage(char[,] map, int row, int col, ref int[] start, ref List<List<int>> goal, ref List<List<int>> track)
//         {
//             for (int i = 0; i < row; i++)
//             {
//                 for (int j = 0; j < col; j++)
//                 {
//                     if (map[i, j] == 'K')
//                     {
//                         start[0] = i;
//                         start[1] = j;
//                     }
//                     else if (map[i, j] == 'T')
//                     {
//                         var temp = new List<int> { i, j, 0 };
//                         goal.Add(temp);
//                         track.Add(temp);
//                     }
//                     else if (map[i, j] == 'R')
//                     {
//                         var temp = new List<int> { i, j, 0 };
//                         track.Add(temp);
//                     }
//                 }
//             }
//         }


//         static void getNeighbor(ref List<List<int>> neighbor, List<int> cell, List<List<int>> track, int row, int col)
//         {
//             // left right up down

//             // left (col - 1)
//             if (cell[1] - 1 > -1)
//             {
//                 var temp = new List<int> { cell[0], cell[1] - 1, 0 };
//                 neighbor.Add(temp);
//             }

//             // right (col + 1)
//             if (cell[1] + 1 < col)
//             {
//                 var temp = new List<int> { cell[0], cell[1] + 1, 0 };
//                 neighbor.Add(temp);
//             }

//             // up (row - 1)
//             if (cell[0] - 1 > -1)
//             {
//                 var temp = new List<int> { cell[0] - 1, cell[1], 0 };
//                 neighbor.Add(temp);
//             }

//             // down (row + 1)
//             if (cell[0] + 1 < row)
//             {
//                 var temp = new List<int> { cell[0] + 1, cell[1], 0 };
//                 neighbor.Add(temp);
//             }
//         }


//         static void searchPathDFS(ref List<char> path, List<int> cell, List<List<int>> goal, List<List<int>> track, int row, int col)
//         {
//             if (goal.Contains(cell))
//             {
//                 goal.Remove(cell);

//                 // semua goal udh dicapai
//                 if (goal.Count == 0)
//                 {
//                     Console.WriteLine("done");
//                 }
//                 else
//                 {
//                     Console.WriteLine("not yet");
//                     foreach (List<int> goalCell in goal)
//                     {
//                         if (goalCell[0] == cell[0] && goalCell[1] == cell[1])
//                         {
//                             goalCell[2] = 1; // status = visit in progress
//                         }
//                     }
//                 }
//             }
//             else
//             {
//                 Console.Write(cell[0]);
//                 Console.Write(cell[1]);
//                 Console.Write(cell[2]);
//                 Console.WriteLine();
//                 Console.Write(track[0][0]);
//                 Console.Write(track[0][1]);
//                 Console.Write(track[0][2]);
//                 Console.WriteLine();
//                 if (track.Contains(cell))
//                 {
//                     Console.WriteLine("here1");
//                     foreach (List<int> trackCell in track)
//                     {
//                         if (trackCell[0] == cell[0] && trackCell[1] == cell[1])
//                         {
//                             trackCell[2] = 1; // status = visit in progress
//                         }

//                         var neighbor = new List<List<int>> { };
//                         getNeighbor(ref neighbor, cell, track, row, col);

//                         Console.WriteLine("here2");
//                         foreach (List<int> n in neighbor)
//                         {
//                             // if status n = unvisited
//                             if (n[2] == 0)
//                             {
//                                 Console.WriteLine("here3");
//                                 searchPathDFS(ref path, n, goal, track, row, col);
//                             }
//                         }
//                         trackCell[2] = 0; // status = visited
//                     }
//                 }
//             }
//         }


//         bool solveMazeUtil(int[,] maze, int x, int y, int[,] sol)
//         {
//             // If (x, y is goal) return true
//             if (x == N - 1 && y == N - 1 && maze[x, y] == 1)
//             {
//                 sol[x, y] = 1;
//                 return true;
//             }

//             // Check if maze[x,y] is valid
//             if (isSafe(maze, x, y) == true)
//             {
//                 // Check if the current block is already part of solution path.    
//                 if (sol[x, y] == 1)
//                     return false;

//                 // Mark x, y as part of solution path
//                 sol[x, y] = 1;

//                 // Move forward in x direction 
//                 if (solveMazeUtil(maze, x + 1, y, sol))
//                     return true;

//                 // If moving in x direction doesn't give 
//                 // solution then Move down in y direction 
//                 if (solveMazeUtil(maze, x, y + 1, sol))
//                     return true;

//                 // If moving in y direction doesm't give
//                 // solution then Move backward in x direction 
//                 if (solveMazeUtil(maze, x - 1, y, sol))
//                     return true;

//                 // If moving in backwards in x direction doesn't give 
//                 // solution then Move upwards in y direction 
//                 if (solveMazeUtil(maze, x, y - 1, sol))
//                     return true;

//                 // If none of the above movements works then 
//                 // BACKTRACK: unmark x, y as part of solution 
//                 // path 
//                 sol[x, y] = 0;
//                 return false;
//             }
//             return false;

//         }

//         static bool solveDFS(char[,] map, ref Stack<Tuple<int, int>> path, ref HashSet<Tuple<int, int>> visited, int[] start, int row, int col)
//         {

//             int[,] sol = new int[row, col];
//             if (solveMazeUtil(map, start[0], start[1], sol) == false)
//             {
//                 Console.Write("No path found");
//                 return false;
//             }

//             // printSolution(sol);
//             return true;

//         }

//         static void Main(string[] args)
//         {
//             int row = 0;
//             int col = 0;

//             int[] start = new int[2];
//             // var goal = new List<Tuple<int, int>> { };
//             // var track = new List<Tuple<int, int>> { };

//             char[,] map = ConvertMap("../test/maze1.txt", ref row, ref col, ref start);

//             // keep track of the path
//             Stack<Tuple<int, int>> path = new Stack<Tuple<int, int>>();

//             // keep track of visited cell
//             HashSet<Tuple<int, int>> visited = new HashSet<Tuple<int, int>>();

//             // bool foundGoal = false;

//             solveDFS(map, ref path, ref visited, start, row, col);


//             // InitStorage(map, row, col, ref start, ref goal, ref track);

//             // var visited = new List<List<int>> { };
//             // var expandNode = new List<List<int>> { };

//             // Stack existNode = new Stack();

//             // var path = new List<char> { };
//             // var firstcell = new List<int> { start[0], start[1], 0 }; ;
//             // // flag desc:
//             // // 0 : unvisited
//             // // 1 : visit in progress
//             // // 2 : visited
//             // Console.WriteLine("tes");
//             // searchPathDFS(ref path, firstcell, goal, track, row, col);
//             // Console.WriteLine("testing");

//             // Console.WriteLine(map[0, 0]);
//             // Console.WriteLine("Hello World!");
//         }
//     }
// }

using System;
using System.Collections.Generic;

public class MazeSolver
{
    private int[,] maze; // a 2D array representing the maze
    private bool[,] visited; // a 2D array keeping track of visited cells
    private int numRows; // number of rows in the maze
    private int numCols; // number of columns in the maze
    private List<Tuple<int, int>> goalStates; // list of goal states in the maze
    private int numGoalsVisited; // number of goal states visited in current path
    private int pathCount;

    public MazeSolver(int[,] maze, List<Tuple<int, int>> goalStates)
    {
        this.maze = maze;
        this.numRows = maze.GetLength(0);
        this.numCols = maze.GetLength(1);
        this.visited = new bool[numRows, numCols];
        this.goalStates = goalStates;
        this.numGoalsVisited = 0;
        this.pathCount = 0;
    }

    public void Solve(int startRow, int startCol, string path)
    {
        if (pathCount == 1)
        {
            return;
        }

        // Mark current cell as visited
        visited[startRow, startCol] = true;

        // Check if current cell is a goal state
        if (IsGoalState(startRow, startCol))
        {
            // Increment number of goals visited and add path to current goal state to paths list
            numGoalsVisited++;
        }

        // Check if all goal states have been visited
        if (numGoalsVisited == goalStates.Count)
        {
            Console.WriteLine("Path that visited all goal states: " + path);
            pathCount += 1;
            return;
        }

        // Check all possible moves from current cell
        if (CanMove(startRow, startCol - 1)) // move left
        {
            Solve(startRow, startCol - 1, path + "L");
        }
        if (CanMove(startRow, startCol + 1)) // move right
        {
            Solve(startRow, startCol + 1, path + "R");
        }
        if (CanMove(startRow - 1, startCol)) // move up
        {
            Solve(startRow - 1, startCol, path + "U");
        }
        if (CanMove(startRow + 1, startCol)) // move down
        {
            Solve(startRow + 1, startCol, path + "D");
        }

        // BACKTRACKING

        // Mark current cell as unvisited 
        visited[startRow, startCol] = false;

        // Decrement number of goals visited (if necessary)
        if (IsGoalState(startRow, startCol))
        {
            numGoalsVisited--;
        }

    }

    private bool IsGoalState(int row, int col)
    {
        foreach (Tuple<int, int> goalState in goalStates)
        {
            if (row == goalState.Item1 && col == goalState.Item2)
            {
                return true;
            }
        }
        return false;
    }

    private bool CanMove(int row, int col)
    {
        // Check if cell is within maze boundaries
        if (row < 0 || row >= numRows || col < 0 || col >= numCols)
        {
            return false;
        }
        // Check if cell is not a wall and has not been visited
        if (maze[row, col] == 1 || visited[row, col])
        {
            return false;
        }
        return true;
    }
}
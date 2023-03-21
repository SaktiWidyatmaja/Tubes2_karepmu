using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using WinForm;

namespace DFS
{
    public class DFSMazeSolver
    {
        private int[,] maze; // a 2D array representing the maze
        public bool[,] visited; // a 2D array keeping track of visited cells
        private int numRows; // number of rows in the maze
        private int numCols; // number of columns in the maze
        private List<Tuple<int, int>> goalStates; // list of goal states in the maze
        private int numGoalsVisited; // number of goal states visited in current path
        private bool isFound;
        public int nodeCount;
        public string path;

        public DFSMazeSolver(int[,] maze, List<Tuple<int, int>> goalStates)
        {
            this.maze = maze;
            this.numRows = maze.GetLength(0);
            this.numCols = maze.GetLength(1);
            this.visited = new bool[numRows, numCols];
            this.goalStates = goalStates;
            this.numGoalsVisited = 0;
            this.isFound = false;
            this.nodeCount = 0;
            this.path = "";
        }

        public void Solve(int startRow, int startCol, string path, int sleepTime)
        {

            if (isFound)
            {
                return;
            }

            // Mark current cell as visited
            visited[startRow, startCol] = true;
            Form1.outputRoute(startRow, startCol, true, sleepTime);
            Console.WriteLine("currentpath " + path);
            nodeCount++;

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
                Console.WriteLine("Nodes : " + nodeCount);
                this.path = path;
                isFound = true;
                return;
            }

            // Check all possible moves from current cell
            if (CanMove(startRow, startCol - 1)) // move left
            {
                Solve(startRow, startCol - 1, path + "L", sleepTime);
                if (isFound)
                {
                    return;
                }
            }
            if (CanMove(startRow, startCol + 1)) // move right
            {
                Solve(startRow, startCol + 1, path + "R", sleepTime);
                if (isFound)
                {
                    return;
                }
            }
            if (CanMove(startRow - 1, startCol)) // move up
            {
                Solve(startRow - 1, startCol, path + "U", sleepTime);
                if (isFound)
                {
                    return;
                }
            }
            if (CanMove(startRow + 1, startCol)) // move down
            {
                Solve(startRow + 1, startCol, path + "D", sleepTime);
                if (isFound)
                {
                    return;
                }
            }

            // BACKTRACKING

            // Mark current cell as unvisited 
            visited[startRow, startCol] = false;
            Form1.outputRoute(startRow, startCol, false, sleepTime);
            Console.WriteLine("backtrack " + path);
            nodeCount++;

            // Decrement number of goals visited (if necessary)
            if (IsGoalState(startRow, startCol))
            {
                numGoalsVisited--;
            }
            return;
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
}
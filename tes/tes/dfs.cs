using System;
using System.Collections.Generic;

namespace DFS
{
    public class DFSMazeSolver
    {
        private int[,] maze; // a 2D array representing the maze
        private bool[,] visited; // a 2D array keeping track of visited cells
        private int numRows; // number of rows in the maze
        private int numCols; // number of columns in the maze
        private List<Tuple<int, int>> goalStates; // list of goal states in the maze
        private int numGoalsVisited; // number of goal states visited in current path
        private bool isFound;
        public int nodeCount;
        private string path;

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

        public string Solve(int startRow, int startCol, string path)
        {

            if (isFound)
            {
                return this.path;
            }

            // Mark current cell as visited
            visited[startRow, startCol] = true;
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
                return this.path;
            }

            // Check all possible moves from current cell
            if (CanMove(startRow, startCol - 1)) // move left
            {
                Solve(startRow, startCol - 1, path + "L");
                if (isFound)
                {
                    return this.path;
                }
            }
            if (CanMove(startRow, startCol + 1)) // move right
            {
                Solve(startRow, startCol + 1, path + "R");
                if (isFound)
                {
                    return this.path;
                }
            }
            if (CanMove(startRow - 1, startCol)) // move up
            {
                Solve(startRow - 1, startCol, path + "U");
                if (isFound)
                {
                    return this.path;
                }
            }
            if (CanMove(startRow + 1, startCol)) // move down
            {
                Solve(startRow + 1, startCol, path + "D");
                if (isFound)
                {
                    return this.path;
                }
            }

            // BACKTRACKING

            // Mark current cell as unvisited 
            visited[startRow, startCol] = false;
            nodeCount++;

            // Decrement number of goals visited (if necessary)
            if (IsGoalState(startRow, startCol))
            {
                numGoalsVisited--;
            }
            return this.path;
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
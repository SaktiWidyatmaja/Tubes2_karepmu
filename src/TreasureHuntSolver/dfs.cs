using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WinForm;

namespace DFS
{
    public class DFSMazeSolver
    {
        private int[,] maze; // a 2D array representing the maze
        public bool[,] visited; // a 2D array keeping track of visited cells
        public int[,] visitCount; // a 2D array keeping track of how many times a cell is visited
        private int numRows; // number of rows in the maze
        private int numCols; // number of columns in the maze
        private List<Tuple<int, int>> goalStates; // list of goal states in the maze (treasures)
        private int numGoalsVisited; // number of goal states visited in current path
        private List<Tuple<int, int>> goalsVisited; // list of goals' cell visited already
        private bool isFound; // found the path/route
        private int[] startState; // start cell
        private int startCount; // how many times start cell is visited (for tsp)
        public int nodeCount; // heeping track of visited nodes
        public string path; // string for path/route that visited all goals/treasures

        // ctor
        public DFSMazeSolver(int[,] maze, List<Tuple<int, int>> goalStates, int[] start)
        {
            this.maze = maze;
            this.numRows = maze.GetLength(0);
            this.numCols = maze.GetLength(1);
            this.visited = new bool[numRows, numCols];
            this.visitCount = new int[numRows, numCols];
            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numCols; j++)
                {
                    visitCount[i, j] = 0;
                }
            }
            this.goalStates = goalStates;
            this.numGoalsVisited = 0;
            this.goalsVisited = new List<Tuple<int, int>> { };
            this.isFound = false;
            this.startState = start;
            this.startCount = 0;
            this.nodeCount = 0;
            this.path = "";
        }

        // dfs multivisit
        public void SolveMultivisit(int startRow, int startCol, string path, int sleepTime)
        {
            // if already found the path, stop the searching
            if (isFound)
            {
                return;
            }

            // increment visitCount for current cell
            visitCount[startRow, startCol]++;
            Form1.outputRoute(startRow, startCol, visitCount[startRow, startCol], sleepTime);
            Console.WriteLine("currentpath " + path);
            nodeCount++;

            // Check if current cell is a goal state
            if (IsGoalState(startRow, startCol))
            {
                if (!goalsVisited.Contains(new Tuple<int, int>(startRow, startCol)))
                {
                    // Increment number of goals visited and add path to current goal state to paths list
                    numGoalsVisited++;
                    goalsVisited.Add(new Tuple<int, int>(startRow, startCol));
                }
            }

            // Check if all goal states have been visited
            if (numGoalsVisited == goalStates.Count)
            {
                Console.WriteLine("Path that visited all goal states: " + path);
                Console.WriteLine("Nodes : " + nodeCount);
                this.path = path;
                isFound = true; // path is found
                return; // stop the searching
            }

            // heuristic method: compare visitCount for all valid adjacent cells
            List<Tuple<char, int, int, int>> precedence = new List<Tuple<char, int, int, int>> { };

            if (isValidCell(startRow + 1, startCol)) // down
            {
                precedence.Add(new Tuple<char, int, int, int>('D', visitCount[startRow + 1, startCol], startRow + 1, startCol));
            }
            if (isValidCell(startRow - 1, startCol)) // up
            {
                precedence.Add(new Tuple<char, int, int, int>('U', visitCount[startRow - 1, startCol], startRow - 1, startCol));
            }
            if (isValidCell(startRow, startCol + 1)) // right
            {
                precedence.Add(new Tuple<char, int, int, int>('R', visitCount[startRow, startCol + 1], startRow, startCol + 1));
            }
            if (isValidCell(startRow, startCol - 1)) // left
            {
                precedence.Add(new Tuple<char, int, int, int>('L', visitCount[startRow, startCol - 1], startRow, startCol - 1));
            }

            // order by visitCount (ascending)
            precedence = precedence.OrderByDescending(t => t.Item2).ToList();
            
            Console.WriteLine("order:");
            for (int i = precedence.Count - 1; i >= 0; i--)
            {
                Console.Write(precedence[i].Item1 + " ");
                Console.WriteLine(precedence[i].Item2);
            }

            // solve for every valid adjacent cell (order by ascending visitCount)
            for (int i = precedence.Count - 1; i >= 0; i--)
            {
                SolveMultivisit(precedence[i].Item3, precedence[i].Item4, path + precedence[i].Item1, sleepTime);
                // if already found the path, stop the searching
                if (isFound)
                {
                    return;
                }
            }
            return;
        }

        // dfs (normal)
        public void Solve(int startRow, int startCol, string path, int sleepTime)
        {
            // if already found the path, stop the searching
            if (isFound)
            {
                return;
            }

            // Mark current cell as visited
            visited[startRow, startCol] = true;
            if (IsStartState(startRow, startCol))
            {
                startCount++;
            }
            Form1.outputRoute(startRow, startCol, 1, sleepTime);
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
            Form1.outputRoute(startRow, startCol, 0, sleepTime);
            Console.WriteLine("backtrack " + path);
            nodeCount++;

            // Decrement number of goals visited (if necessary)
            if (IsGoalState(startRow, startCol))
            {
                numGoalsVisited--;
            }
            return;
        }

        // check if a cell is a goal state
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

        // check if a cell is a start state
        private bool IsStartState(int row, int col)
        {
            return (row == startState[0] && col == startState[1]);
        }

        // check if a cell is a valid cell (for multivisit dfs)
        private bool isValidCell(int row, int col)
        {
            // Check if cell is within maze boundaries
            if (row < 0 || row >= numRows || col < 0 || col >= numCols)
            {
                return false;
            }
            // Check if cell is not a wall and not a start state
            if (maze[row, col] == 1 || IsStartState(row, col))
            {
                return false;
            }
            return true;
        }

        // check if a cell is a valid cell (for normal dfs)
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
                if (IsStartState(row, col) && startCount != 2 && numGoalsVisited == goalStates.Count - 1)
                {
                    return true;
                }
                return false;
            }
            return true;
        }
    }
}
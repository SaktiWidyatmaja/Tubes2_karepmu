using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;
using System.Threading.Tasks;
using WinForm;


namespace BFS
{
    public class BFSMazeSolver
    {
        private int[,] maze; // a 2D array representing the maze
        private bool[,] visited; // a 2D array keeping track of visited cells
        public int[,] visitCount;
        private int numRows; // number of rows in the maze
        private int numCols; // number of columns in the maze
        private List<Tuple<int, int>> goalStates; // list of goal states in the maze   
        private int numGoalsVisited; // number of goal states visited in current path
        private int pathCount;
        public int nodeCount;
        public string path;
        private string[,] nodePath;

        public BFSMazeSolver(int[,] maze, List<Tuple<int, int>> goalStates)
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
            this.pathCount = 0;
            this.nodeCount = 0;
            this.path = "";
            this.nodePath = new string[numRows, numCols];
        }
        public void Solve(Tuple<int, int> startNode, ref string[] treasurePath, ref List<Tuple<int, int>> simpulHidup, bool tsp, int sleepTime)
        {
            int startRow = simpulHidup[0].Item1;
            int startCol = simpulHidup[0].Item2;

            simpulHidup.RemoveAt(0);

            if (pathCount == 1 || goalStates.Count == 0)
            {
                return;
            }

            nodeCount++;

            // Check if current cell is a goal state
            if (IsGoalState(startRow, startCol))
            {
                if (tsp){
                    Console.WriteLine("tsp");
                } else {
                    Console.WriteLine("no tsp");
                }
                Console.WriteLine(nodePath[startRow, startCol]);
                Console.WriteLine("size: " + treasurePath.GetLength(0));
                Console.WriteLine(numGoalsVisited);
                treasurePath[numGoalsVisited] = nodePath[startRow, startCol];
                
                // Increment number of goals visited and add path to current goal state to paths list
                numGoalsVisited++;
                goalStates.Remove(new Tuple<int,int> (startRow, startCol));

                // Mengubah semua node menjadi belum dikunjungi
                for (int i = 0; i < numRows; i++)
                {
                    for (int j = 0; j < numCols; j++)
                    {
                        visited[i, j] = false;
                        nodePath[i, j] = "";
                    }
                }

                simpulHidup.Clear();
                simpulHidup.Add(new Tuple<int, int>(startRow, startCol));
                Solve(startNode, ref treasurePath, ref simpulHidup, tsp, sleepTime);
            }

            if (pathCount != 1) {
                // Mark current cell as visited
                visited[startRow, startCol] = true;
                visitCount[startRow, startCol]++;
                Form1.outputRoute(startRow, startCol, visitCount[startRow, startCol], sleepTime);
                Console.WriteLine("currentpath " + path);

                if (goalStates.Count == 0)
                {
                    path = "";
                    for (int i = 0; i < numGoalsVisited; i++) {
                        path += treasurePath[i];
                    }
                    Console.WriteLine("Path that visited all goal states: " + path);
                    if (tsp)
                    {
                        goalStates.Add(startNode);

                        // Mengubah semua node menjadi belum dikunjungi
                        for (int i = 0; i < numRows; i++)
                        {
                            for (int j = 0; j < numCols; j++)
                            {
                                visited[i, j] = false;
                                nodePath[i, j] = "";
                            }
                        }

                        pathCount = 0;
                        simpulHidup.Clear();
                        tsp = false;
                        simpulHidup.Add(new Tuple<int, int>(startRow, startCol));
                        Solve(simpulHidup[0], ref treasurePath, ref simpulHidup, tsp, sleepTime);
                        return;
                    }
                    else
                    {
                        pathCount += 1;
                        return;
                    }
                }

                // Check all possible moves from current cell
                if (CanMove(simpulHidup, startRow, startCol - 1)) // move left
                {
                    Console.Write(startRow);
                    Console.Write(" ");
                    Console.WriteLine(startCol - 1);
                    nodePath[startRow, startCol - 1] = nodePath[startRow, startCol] + "L";
                    simpulHidup.Add(new Tuple<int, int>(startRow, startCol - 1));
                }
                if (CanMove(simpulHidup, startRow, startCol + 1)) // move right
                {
                    Console.Write(startRow);
                    Console.Write(" ");
                    Console.WriteLine(startCol + 1);
                    
                    nodePath[startRow, startCol + 1] = nodePath[startRow, startCol] + "R";
                    simpulHidup.Add(new Tuple<int, int>(startRow, startCol + 1));
                }
                if (CanMove(simpulHidup, startRow - 1, startCol)) // move up
                {
                    Console.Write(startRow - 1);
                    Console.Write(" ");
                    Console.WriteLine(startCol);
                    
                    nodePath[startRow - 1, startCol] = nodePath[startRow, startCol] + "U";
                    simpulHidup.Add(new Tuple<int, int>(startRow - 1, startCol));
                }
                if (CanMove(simpulHidup, startRow + 1, startCol)) // move down
                {
                    Console.Write(startRow + 1);
                    Console.Write(" ");
                    Console.WriteLine(startCol);
                    
                    nodePath[startRow + 1, startCol] = nodePath[startRow, startCol] + "D";
                    simpulHidup.Add(new Tuple<int, int>(startRow + 1, startCol));
                }

                Solve(startNode, ref treasurePath, ref simpulHidup, tsp, sleepTime);

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

        private bool CanMove(List<Tuple<int,int>> simpulHidup,int row, int col)
        {
            // Check if cell is within maze boundaries or have been added to simpulHidup
            if (row < 0 || row >= numRows || col < 0 || col >= numCols || simpulHidup.Any(s => s.Item1 == row && s.Item2 == col))
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
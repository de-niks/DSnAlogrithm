using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    internal class PathToMaxGold
    {
        public int GetMaximumGold(int[][] grid)
        {
            int maximumGold = 0;

            for (int row = 0; row < grid.Length; row++)
            {
                for (int column = 0; column < grid[0].Length; column++)
                {
                    if (grid[row][column] != 0)
                    {
                        maximumGold = Math.Max(maximumGold, DFS(grid, row, column));
                    }
                }
            }

            return maximumGold;

        }

        private int DFS(int[][] grid, int row, int column)
        {
            // identify the bounds 
            // rows and column are not out of bounds // element is visited
            if (row < 0 || row >= grid.Length || column < 0 || column >= grid[0].Length || grid[row][column] == 0)
            {
                return 0;
            }

            int currentCapturedGold = grid[row][column];
            grid[row][column] = 0;// mark as visited

            int maxGoldinDFS = 0;

            /// travel in all direction 
            maxGoldinDFS = Math.Max(maxGoldinDFS, currentCapturedGold + DFS(grid, row + 1, column));
            maxGoldinDFS = Math.Max(maxGoldinDFS, currentCapturedGold + DFS(grid, row - 1, column));
            maxGoldinDFS = Math.Max(maxGoldinDFS, currentCapturedGold + DFS(grid, row, column + 1));
            maxGoldinDFS = Math.Max(maxGoldinDFS, currentCapturedGold + DFS(grid, row, column - 1));

            grid[row][column] = currentCapturedGold;    //backtrack 

            return maxGoldinDFS;    

        }


    }
}

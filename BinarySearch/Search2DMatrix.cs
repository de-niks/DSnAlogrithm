using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    internal class Search2DMatrix
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            int ROWS = matrix.Length;
            int COLS = matrix[0].Length;    

            int top = 0;
            int bottom = ROWS - 1;
            int row = 0;

            while (top <= bottom)
            {

                row = (top + bottom) / 2;

                if (target > matrix[row][COLS - 1])
                {
                    top = row + 1;
                }
                else if (target < matrix[row][0])
                {
                    bottom = row - 1;
                }
                else
                    break;
            }

            if (!(top <= bottom))
            {
                return false;
            }

            int lp = 0;
            int rp = COLS - 1;
            int mp = 0;
            while (lp <= rp)
            {
                mp = (lp + rp) / 2;

                if (target > matrix[row][mp])
                    lp = row + 1;
                else if (target < matrix[row][mp])
                    rp = row - 1;
                else
                    return true;
            }

            return false;


        }
    }
}

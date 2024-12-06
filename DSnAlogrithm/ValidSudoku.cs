using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSnAlogrithm
{
    internal class ValidSudoku
    {
        public static bool IsValidSudoku(char[][] board)
        {
            /// rows 
            for(int row = 0; row < 9; row++)
            {
                HashSet<char> seen = new HashSet<char>();
                for (int i = 0; i < 9; i++)
                {
                    if (board[row][i] == '.')
                        continue;

                    if (seen.Contains(board[row][i]))
                        return false;

                    seen.Add(board[row][i]);
                }

            }

            //columns
            for (int col = 0; col < 9; col++)
            {
                HashSet<char> seen = new HashSet<char>();
                for (int i = 0; i < 9; i++)
                {
                    if (board[i][col] == '.')
                        continue;

                    if (seen.Contains(board[i][col]))
                        return false;

                    seen.Add(board[i][col]);
                }

            }

            ///Square 
            for (int square = 0; square < 9; square++)
            {
                HashSet<char> seen = new HashSet<char>();
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        int row = (square / 3) * 3 + i;
                        int col = (square % 3) * 3 + j;

                        if (board[row][col] == '.')
                            continue;

                        if (seen.Contains(board[row][col]))
                            return false;

                        seen.Add(board[row][col]);

                    }
                }
            
            }

            return true;



            }
    }
}

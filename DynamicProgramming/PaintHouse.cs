using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    internal class PaintHouse
    {
        public int MinCost(int[][] costs)
        {
            int[] table = new int[3];
            int n = costs.Length;

            table [0] = 0;
            table [1] = 0;
            table [2] = 0;
            for (int i = 1; i < n; i++)
            {
                int[] temp = new int[3];
                temp[0] = costs[i][0] + Math.Min(table[1], table[2]);
                temp[1] = costs[i][1] + Math.Min(table[0], table[2]);
                temp[2] = costs[i][2] + Math.Min(table[0], table[1]);

                table = temp;
            }

            return table.Min();
        }
    }
}

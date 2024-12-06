using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    internal class ClimbingStairs
    {
        public static int ClimbStairsDFS(int n)
        {
            return DFS(n, 0);
        }

        private static int DFS(int n, int i)
        {
            if (i >= n)
                return (i == n) ? 1 : 0;


            return DFS(n, i + 1) + DFS(n, i + 2);
        }


        public static int ClimbStairs(int n)
        {
            if (n <= 2)
                return n;

            int[] table = new int[n + 1];

            table[1] = 1;
            table[2] = 2;

            for (int i = 3; i < n; i++)
                table[i] = table[i - 1] + table[i - 2];
            
            return table[n];
            
        }

        public static int ClimbStair(int n)
        {
            int one = 1;
            int two = 1;

            for (int i = 0; i < n - 1; i++)
            { 
                int temp = one;
                one  = one + two;
                two = temp;
            }

            return one;

        }


        public int MinCostClimbingStairs(int[] cost)
        {
            int n = cost.Length;
            int[] table = new int[n + 1];

            for (int i = 2; i <= n; i++)
            {
                table[i] = Math.Min(table[i - 1] + cost[i - 1], table[i - 2] + cost[i - 2]);
            }

            return table[n];
        }
    }
}

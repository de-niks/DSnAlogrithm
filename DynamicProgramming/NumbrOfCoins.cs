using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    /// <summary>
    /// Top down DFS
    /// </summary>
    internal class NumbrOfCoins
    {
        /// <summary>
        /// Memo to track amount being calculated or not 
        /// </summary>
        Dictionary<int , int > memo = new Dictionary<int , int>();
        public int CoinChange(int[] coins, int amount)
        {
            var result = DFS(coins, amount);

            return result == int.MaxValue ? -1 : result;

        }

        private int DFS(int[] coins, int amount)
        {
            if(amount == 0)
                return 0;

            if(memo.ContainsKey(amount))
                return memo[amount];

            int res = int.MaxValue;

            foreach (int coin in coins)
            {
                if (amount - coin >= 0)
                {
                    int resDFS = DFS(coins, amount - coin);
                    if (resDFS != int.MaxValue)
                    {
                        res = Math.Min(res, 1 + resDFS);
                    }
                }

            }
            memo[amount] = res;

            return res;
        }

       
    }
}

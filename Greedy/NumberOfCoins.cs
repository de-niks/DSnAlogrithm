using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greedy
{
    internal class NumberOfCoins
    {
        /// <summary>
        /// Greedy approach fails here 
        /// </summary>
        /// <param name="coins"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        public int CoinChange(int[] coins, int amount)
        {
            int numberOfCoins = 0;
            int remainAmount = amount;
            Array.Sort(coins);
            foreach (int coin in coins)
            {
                var quotient = remainAmount / coin;
                numberOfCoins += quotient;
                remainAmount = remainAmount % coin;
            }

            return numberOfCoins;
        }
    }


}

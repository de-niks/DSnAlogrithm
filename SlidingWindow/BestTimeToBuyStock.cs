using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlidingWindow
{
    internal class BestTimeToBuyStock
    {
        public int MaxProfit(int[] prices)
        {
            int lp = 0; // Buy  
            int rp = 1; // sell

            int maxProfit = 0;

            while (rp < prices.Length)
            {
                // profitable transaction?
                if (prices[lp] < prices[rp])
                {
                    int profit = prices[rp] - prices[lp];
                    maxProfit = Math.Max(maxProfit, profit);
                }
                else
                    lp = rp; // since we found a new low

                rp++;

            }

            return maxProfit;

        }
    }
}

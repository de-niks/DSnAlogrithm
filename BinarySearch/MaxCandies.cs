using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BinarySearch
{
    /// <summary>
    /// 2226. Maximum Candies Allocated to K Children
    /// You are given a 0-indexed integer array candies. Each element in the array denotes a pile of candies of size candies[i]. 
    /// You can divide each pile into any number of sub piles, but you cannot merge two piles together.
    /// You are also given an integer k.You should allocate piles of candies to k children such that each child gets the same number 
    /// of candies.Each child can take at most one pile of candies and some piles of candies may go unused.
    /// Return the maximum number of candies each child can get.
    /// </summary>
    internal class MaxCandies
    {
        public int MaximumCandies(int[] candies, long k)
        {
            int lp = 1;
            int rp = candies.Max();

            while (lp <= rp)
            {
                int m = (rp + lp) / 2;

                if (CanDistribute(m))
                {
                    lp = m + 1;
                }
                else
                {
                    rp = m - 1;
                }



            }

            bool CanDistribute(int m)
            {
                var children = 0L;
                foreach (var pile in candies)
                {
                    if ((children += pile / m) >= k)
                    {
                        return true;
                    }
                }
                return false;
            }

            return rp;
        }

       


    }
}

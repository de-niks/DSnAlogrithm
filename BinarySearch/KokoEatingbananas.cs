using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    internal class KokoEatingbananas
    {
        public int MinEatingSpeed(int[] piles, int h)
        {

            int lp = 1;
            int rp = piles.Max();

            int result = rp;


            while (lp <= rp)
            { 
                int k = (rp + lp)/2;

                long totaltime = 0;

                foreach (int pile in piles)
                {
                    totaltime += (int)Math.Ceiling((double)pile / k);
                }

                if (totaltime <= h)
                {
                    result = k;
                    rp = k - 1;
                }
                else
                {
                    lp = k + 1;
                }
            
            }

            return result;

        }
    }
}

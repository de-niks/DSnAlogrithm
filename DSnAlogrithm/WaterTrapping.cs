using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSnAlogrithm
{
    internal class WaterTrapping
    {
        public int Trap(int[] height)
        {
            if(height == null || height.Length == 0)
                return 0;


            int lp = 0;
            int rp = height.Length - 1;

            int lpMaxht = height[lp];
            int rpMaxht = height[rp];

            int result = 0; 

            while (lp < rp)
            {
                if (lpMaxht < rpMaxht)
                {
                    lp++;
                    lpMaxht = Math.Max(lpMaxht, height[lp]);
                    result += lpMaxht - height[lp];

                }
                else
                {
                    rp--;
                    rpMaxht = Math.Max(rpMaxht, height[rp]);
                    result += rpMaxht - height[rp];
                
                }
            }

            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSnAlogrithm
{
    internal class MaxProductSubArray
    {
        public int MaxProduct(int[] nums)
        {
            int res = nums[0];

            for (int i = 0; i < nums.Length; i++)
            {
                int curr = nums[i];
                res = Math.Max(res, curr);

                for (int j = i + 1; j < nums.Length; j++)
                { 
                    curr *= nums[j];
                    res = Math.Max(res, curr);
                }

            }

            return res;
        }

      
    }
}

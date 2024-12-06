using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    internal class MaxSubArraySum
    {
        public int MaxSubArray(int[] nums)
        {
            int res = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int curr = 0;

                for (int j=i; j < nums.Length; j++)
                {
                    curr *= nums[j];

                    res = Math.Max(res, curr);

                }
            }

            return res;
        }
    }
}

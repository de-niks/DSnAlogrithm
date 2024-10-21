using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    internal class FindMinimumInRoatatedArray
    {
        public int FindMin(int[] nums)
        {

            int lp = 0;
            int rp = nums.Length - 1;
            while (lp <= rp)
            {
                if (nums[lp] <= nums[rp])
                {
                    return nums[lp];
                }

                int mid = (lp + rp) / 2;
                if (nums[mid] >= nums[lp])
                {
                    lp = mid + 1;
                }
                else
                {
                    rp = mid;

                }

            }

            return 0;

        }
    }
}

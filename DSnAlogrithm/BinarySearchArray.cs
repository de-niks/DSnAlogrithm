using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSnAlogrithm
{
    internal class BinarySearchArray
    {
        public int Search(int[] nums, int target)
        {
            int lp = 0;
            int rp = nums.Length - 1;

            while (lp <= rp)
            {
                int mid = (lp + rp) / 2;

                if (nums[mid] == target)
                {
                    return mid;
                }

                if (nums[mid] > target)
                    rp = mid - 1;
                else
                {
                    lp = mid + 1;
                }


            }

            return -1;

        }
    }
}

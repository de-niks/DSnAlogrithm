using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    internal class SearchArray
    {
        public int BinarySearchAnArray(int[] nums, int target)
        {
            int lp = 0;
            int rp = nums.Length -1;

            while (lp < rp)
            {
                int mp = lp + ((rp - lp) / 2);

                if (nums[mp] < target)
                    lp++;
                else if (nums[mp] > target)
                    rp--;
                else
                    return mp;
            }

            return -1;
        }
    }
}

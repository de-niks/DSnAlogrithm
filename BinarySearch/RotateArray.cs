using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    internal class RotateArray
    {
        public void Rotate(int[] nums, int k)
        {
            int n = nums.Length;
            k = k % n;
            Reverse(nums, k, n - 1);
            Reverse(nums, 0, k - 1);
            Reverse(nums, k, n - 1);

        }

        private void Reverse(int[] nums, int lp, int rp)
        {
            while (lp < rp)
            {
                int temp = nums[lp];
                nums[lp] = nums[rp];
                nums[rp] = temp;
                lp++;
                rp--;
            }
        
        }

    }
}

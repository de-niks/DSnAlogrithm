using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSnAlogrithm
{
    internal class FirstMissingPositive
    {
        public static int FirstMissingPositiveNumber(int[] nums)
        {
            HashSet<int> res = new HashSet<int>();

            for(int i = 0; i <  nums.Length; i++)
            {
                if (nums[i] > 0)
                    res.Add(nums[i]);

            }

            for(int i = 1; ;i++)
            {
                if(!res.Contains(i))
                    return i;
            }


        }

        public static int MissingNumber(int[] nums)
        {
            HashSet<int> res = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                res.Add(nums[i]);
            }

            for (int i = 1; ; i++)
            {
                if (!res.Contains(i))
                    return i;
            }


        }
    }
}

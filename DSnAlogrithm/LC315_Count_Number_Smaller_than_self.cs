using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSnAlogrithm
{
    internal class LC315_Count_Number_Smaller_than_self
    {
        /// <summary>
        /// TC: n(logn)
        /// SC : o(n)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public IList<int> CountSmallerI(int[] nums)
        {

            List<int> result = new List<int>();
            result.Add(nums[nums.Length - 1]);

            nums[nums.Length - 1] = 0;

            for (int i = nums.Length -2; i >= 0; i--)
            {

                int idx = FindInsertionIndex(result, nums[i]);
                 nums[i] = idx;
            }

            return nums;
        }

        private int FindInsertionIndex(List<int> list, int target)
        {
            int lp = 0;
            int rp = list.Count - 1;
            while (lp <= rp)
            {
                int mid = (lp + rp) / 2;
                if (list[mid] < target)
                    lp = mid + 1;
                else
                    rp = mid - 1;
            }

            list.Insert(lp, target);
            return lp;
        }



    }
}

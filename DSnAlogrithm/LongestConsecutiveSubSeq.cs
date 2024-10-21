using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSnAlogrithm
{
    internal class LongestConsecutiveSubSeq
    {
        public int LongestConsecutive(int[] nums)
        {
            HashSet<int> hashSet = new HashSet<int>(nums);

            int result = 1;
            foreach (int x in hashSet)
            {
                if (hashSet.Contains(x - 1)) continue;
                int max = 1;

                while (hashSet.Contains(x + max))
                {
                    max++;
                }

                result = Math.Max(max, result);

            }
            return result;

        }
    }
}

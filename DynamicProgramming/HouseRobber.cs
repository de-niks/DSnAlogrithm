using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    internal class HouseRobber
    {
        public int Rob(int[] nums)
        {

            if(nums.Length  == 0) 
                return 0;
            if(nums.Length == 1)
                return nums[0];

            int[] table = new int[nums.Length];

            table[0] = nums[0];
            table[1] = nums[1];

            for(int i = 2; i<nums.Length; i++)
            {
                table[i] = Math.Max(table[i - 2] + nums[i], nums[i - 1]);
            }

            return table[nums.Length - 1];

        }
    }
}

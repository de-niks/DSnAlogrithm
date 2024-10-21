using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    internal class FindDuplicate
    {
        public int FindDuplicateNumber(int[] nums)
        {
            int hare = 0;
            int tortoise = 0;

            while (true)
            {
                hare = nums[nums[hare]];
                tortoise = nums[tortoise];

                // cycle detected
                if (hare == tortoise)
                {
                    int newTortoise = 0;

                    // start newTortoise pointer
                    while (newTortoise != tortoise)
                    {
                        newTortoise = nums[newTortoise];
                        tortoise = nums[tortoise];
                    }

                    return tortoise;
                }
            }

           
        }
    }
}

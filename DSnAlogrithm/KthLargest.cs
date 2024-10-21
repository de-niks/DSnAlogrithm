using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSnAlogrithm
{
    public class KthLargest
    {
       /// <summary>
       /// 
       /// </summary>
       /// <param name="nums"></param>
       /// <param name="k"></param>
       /// <returns></returns>
        public int FindKthLargestUsingPriorityQueue(int[] nums, int k)
        { 
            PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>();

            foreach (int num in nums)
            {
                minHeap.Enqueue(num, num);

                if(minHeap.Count > k)
                    minHeap.Dequeue();
            }

            return minHeap.Peek();
        
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int FindKthLargetUsingSorting(int[] nums, int k)
        { 
            Array.Sort(nums);
            return nums[nums.Length - k];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int FindKthLargestUsingQuickSelect(int[] nums, int k)
        { 
            k = nums.Length - k;
            int lp = 0;
            int rp = nums.Length - 1;

            while (lp < rp)
            {
                int pivot = DoPartition(nums, lp, rp);

                if (pivot < k)
                    lp++;
                else if (pivot > k)
                    rp--;
                else
                    break;
            }

            return nums[k];
        
        }

        private int DoPartition(int[] nums, int lp, int rp)
        {
            int pivot = nums[rp];
            int swapP = lp;

            for (int i = lp; i < rp; i++)
            {
                if (nums[i] < pivot)
                {
                    int temp = nums[swapP];
                    nums[swapP++] = nums[i];
                    nums[i] = temp;

                }
            }

            nums[rp] = nums[swapP];
            nums[swapP] = pivot;

            return swapP;
        }


    }
}

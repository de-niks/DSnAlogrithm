using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlidingWindow
{
    internal class MaxSlidingWindow
    {
        public int[] MaxWindow(int[] nums, int k)
        {
            /*int lp = 0;
            int rp = 0;
            List<int> result = new List<int>();

            while (rp < nums.Length)
            {
                if (rp + 1 >= k)
                {
                    List<int> intermittent = new List<int>();
                    for (int i = 0; i < k; i++)
                    {
                        intermittent.Add(nums[lp + i]);
                    }

                    result.Add(intermittent.Max());

                    lp++;

                }

                rp++;
            }

            return result.ToArray();*/

            int lp = 0;
            int rp = 0;
            int lt = nums.Length;
            int[] output = new int[lt - k + 1];
            

            LinkedList<int> deque = new LinkedList<int>();

            while (rp < lt)
            {

                while (deque.Count > 0 && nums[deque.Last.Value] < nums[rp])
                {
                    deque.RemoveLast();
                }

                deque.AddLast(rp);

                if (lp > deque.Last.Value)
                {
                    deque.RemoveFirst();
                }

                if (rp + 1 >= k)
                {
                    output[lp] = nums[deque.First.Value];
                    lp = lp + 1;
                }

                rp = rp + 1;
            }

            return output;

        }


    }
}

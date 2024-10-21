using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSnAlogrithm
{
    internal class TopKFrequentElements
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            foreach (int num in nums)
            {
                if (map.ContainsKey(num))
                {
                    map[num]++;
                }
                else
                {
                    map[num] = 1;
                }
            }

            PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b - a));

            foreach (int key in map.Keys)
            {
                minHeap.Enqueue(map[key],key);

            }
           
            int[] result = new int[k];

            for (int i = 0; i < k; i++)
                result[i] = minHeap.Dequeue();



            return result;


        }
    }
}

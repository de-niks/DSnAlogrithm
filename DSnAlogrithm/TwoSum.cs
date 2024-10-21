using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSnAlogrithm
{
    internal class FindArraySum
    {
        /// <summary>
        /// this is 2 pointer pass with TC O(nlogn) 
        /// </summary>
        /// <param name="array"></param>
        /// <param name="target"></param>
        public void FindTwoSumForSortedArray(int[] array, int target)
        {

            int lp = 0;
            int rp = array.Length - 1;
            List<List<int>> result = new List<List<int>>();
           
            while (lp < rp)
            {
                int sum = array[lp] + array[rp];


                if (sum < target)
                    lp++;
                else if (sum > target)
                    rp--;
                else if (sum == target)
                {
                    
                   
                   result.Add(new List<int>() { array[lp], array[rp] });
                   rp--;
                }

              

                

            }

            if (result.Count == 0)
                result.Add(new List<int>() { -1, -1 });
        }

        public void TwoSumWithHashTable(int[]array, int target)
        {
            List<List<int>> result = new List<List<int>>();

            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();

           for(int i = 0; i <array.Length; i++)
            {
                var required = target - array[i];

                if(keyValuePairs.ContainsKey(required))
                {
                    result.Add(new List<int>() { array[i], required });
                }
                keyValuePairs[array[i]] = i;
               
            }

           if(result.Count == 0)
                result.Add(new List<int>() { -1,-1});



        }

        public void TwoSumWithHashTableIndices(int[] nums, int target)
        {
            List<List<int>> result = new List<List<int>>();

            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var required = target - nums[i];

                if (keyValuePairs.ContainsKey(required))
                {

                   // return new int[] { keyValuePairs[required], i };
                   
                }
                keyValuePairs[nums[i]] = i;

            }

            if (result.Count == 0)
                result.Add(new List<int>() { -1, -1 });



        }

        public int[] TwoSumForSortedArrayWOExtraSpace(int[] numbers, int target)
        {

            int lp = 0;
            int rp = numbers.Length - 1;
         

            while (lp < rp)
            {
                int sum = numbers[lp] + numbers[rp];


                if (sum < target)
                    lp++;
                else if (sum > target)
                    rp--;
                else if (sum == target)
                {
                    return new int[] { lp, rp };
                }


            }

            return new int[] { 0 };
        }
    }
}

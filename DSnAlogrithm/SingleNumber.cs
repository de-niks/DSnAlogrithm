using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSnAlogrithm
{
    internal class SingleNumber
    {
        public int FindSingleNumber(int []nums)
        { 
            if(nums.Length < 1)
                return -1;

            Dictionary<int,int> dict = new Dictionary<int,int>();

            foreach (int n in nums)
            { 
                if(!dict.ContainsKey(n))
                    dict.Add(n, 1);
                else dict[n]++;
            }

            foreach (int key in dict.Keys)
            {
                if (dict[key] == 1)
                    return key;
            }

            return -1;
        }
    }
}

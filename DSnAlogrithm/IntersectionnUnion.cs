using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSnAlogrithm
{
    internal class IntersectionnUnion
    {
       /// <summary>
       /// 
       /// </summary>
       /// <param name="array1"></param>
       /// <param name="array2"></param>
        public void FindIntersectionOfTwoSortedArrays(int[] array1, int[] array2)
        {
            int lp = 0;
            int rp = 0;
            HashSet<int> intersection = new HashSet<int>();
            while (lp < array1.Length && rp < array2.Length)
            {
                if (array1[lp] < array2[rp])
                    lp++;
                else if (array1[lp] > array2[rp])
                    rp++;
                else
                {
                    intersection.Add(array1[lp]);
                    lp++; rp++;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="array1"></param>
        /// <param name="array2"></param>
        public void FindIntersectionOfThreeSortedArrays(int[] array1, int[] array2, int[] array3)
        {
            Dictionary<int, int> intersection = new Dictionary<int, int>();

            List<int> ints = new List<int>();

            foreach (int a in array1)
            {
                if (!intersection.ContainsKey(a))
                {
                    intersection.Add(a, 1);
                }
                else
                {
                    intersection[a] += 1;
                }
            }

            foreach (int a in array2)
            {
                if (!intersection.ContainsKey(a))
                {
                    intersection.Add(a, 1);
                }
                else
                {
                    intersection[a] += 1;
                }

            }


            foreach (int a in array3)
            {
                if (!intersection.ContainsKey(a))
                {
                    intersection.Add(a, 1);
                }
                else
                {
                    intersection[a] += 1;
                }

                if (intersection[a] == 3)
                    ints.Add(a);

            }

        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DSnAlogrithm
{
    internal class MergeSort
    {
        public void Sort()
        {
            int[] arr = new int[] { 2, 3, 1, 8, 1, 5, 7, 11 };

            helper(arr, 0, arr.Length - 1);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="array"></param>
        /// <param name="l"></param>
        /// <param name="r"></param>
        private void helper(int[] array, int l, int r)
        {
            if (l < r)
            {
                int m = l + (r - l) / 2 + 1;

                helper(array, l, m - 1);
                helper(array, m, r);

                Merge(array, l, m, r);
            }
        }


        private void Merge(int[] array , int l , int m, int r)
        {
            int i, j, k;
            int lal = m - l;
            int ral = r - m + 1;

            int[]left = new int[lal];
            int[]right = new int[ral];

            for (i = 0; i < lal; i++)
            {
                left[i] = array[l + i];
            }

            for (i= 0; i < ral; i++)
            {
                right[i] = array[m + i];
            }
            i = 0;  j = 0; k = l;


            while (i < lal && j < ral)
            {
                if (left[i] <= right[j])
                {
                    array[k++] = left[i++];
                }

                else
                {
                    array[k++] = right[j++];
                }
            }

            //Left array is complete and copy remaining elements from right array
            if (i == lal)
            {
                
                for (int ii = j; ii < ral; ii++)
                {
                    array[k++] = right[ii];
                }
            }

            //right array is complete copy remaining from left arrary 
            if (j == ral)
            {
                for (int ii = i; ii < lal; ii++)
                { 
                    array[k++] = left[ii];
                
                }
            
            }



        }










       /* private void helper(int[] input, int start, int end)
        {
            // Leaf worker // No array division needed  
            if (start == end)
                return;

            int mid = (end - start) / 2;

            helper(input, start, mid);
            helper(input, mid + 1, end);

            // Two pointers
            int left = start;
            int right = mid + 1;

            // aux array to hol intermiddiate result
            int[] aux = new int[end - start + 1];

            // Start moving the pointers

            while ((left <= mid) && (right <= end)) {

                if (input[left] <= input[right])
                {
                    aux.Append(input[left]);
                    left++;
                }

                if (input[left] >= input[right])
                {
                    aux.Append(input[right]);
                    right++;
                }


            }
            while (left <= mid)
            {
                aux.Append(input[left]);
                left++;
            }

            while (right <= end)
            {
                aux.Append(input[right]);
                right++;
            }

            for (int k = start; k <= end; k++)
            {
                input.SetValue(aux.GetValue(k-start), k);
            }

        }*/
    }
}

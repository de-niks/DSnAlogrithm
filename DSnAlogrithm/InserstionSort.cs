using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSnAlogrithm
{
    internal class InserstionSort
    {

        public void Sort(int[] arr, int length)
        {

            for (int i = 0; i < length; i++)
            {
                int temp = arr[i];

                int sort_idx = i - 1;

                while (sort_idx >= 0 && arr[sort_idx] > temp)
                {
                    arr[sort_idx + 1] = arr[sort_idx];
                    sort_idx--;
                }

                arr[sort_idx + 1] = temp;

            }
        }
    }
}

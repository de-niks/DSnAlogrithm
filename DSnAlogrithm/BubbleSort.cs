using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSnAlogrithm
{
    internal class BubbleSort
    {
        public void Sort(int[] arr)
        {
            int lt = arr.Length;


            for (int i = 0; i < lt - 1; i++)
            {
                for ( int j = lt - 1; j > i ; j--)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        Swap(arr, j - 1, j);
                    }

                }
            }
        }

        public void Swap(int[] arr, int i, int j)
        {

            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;

        }
    }
}


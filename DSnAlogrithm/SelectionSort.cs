using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSnAlogrithm
{
    public class SelectionSort
    {
        public void Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length  -1 ; i++)
            {
                int minValue = arr[i];
                int min_idx = i;

                for (int j = i + 1; j < arr.Length - 1; j++)
                {
                    if (arr[j] < minValue)
                    { 
                        minValue = arr[j];
                        min_idx = j;
                    }
                
                }
                Swap(arr, i, min_idx);
            }
        }

        public void Swap(int[] arr, int i, int min_idx) {
            
            int temp = arr[i];
            arr[i] = arr[min_idx];
            arr[min_idx] = temp;
        
        }
    }
}

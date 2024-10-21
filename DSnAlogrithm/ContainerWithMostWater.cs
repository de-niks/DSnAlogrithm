using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSnAlogrithm
{
    internal class ContainerWithMostWater
    {
        public int MaxArea(int[] heights)
        {
            int result = 0;
            int area = 0;
            for (int i = 0; i < heights.Length; i++)
            {
                for (int j = i + 1; j < heights.Length; j++)
                {
                    area = (j - i) * Math.Min(heights[i], heights[j]);
                    result = Math.Max(result, area);
                }

            }

            return result;
        }

        public int MaxAreaWithTwoPointers(int[] height)
        {
            int result = 0;
            int area = 0;
            int lp = 0;
            int rp = height.Length - 1;

            while (lp < rp)
            {

                area = (rp - lp) * Math.Min(height[lp], height[rp]);
                result = Math.Max(result, area);

                if (height[lp] < height[rp])
                    lp++;
                else
                    rp--;
            }

            return result;
        }
    }
}

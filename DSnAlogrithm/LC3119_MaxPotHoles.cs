using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSnAlogrithm
{
    internal class LC3119_MaxPotHoles
    {
        public int MaxPotholes(string road, int budget)
        {
            var potHoles= new List<int>();
            int consecutiveHoles = 0;


            for(int i = 0; i<road.Length; i++)
            {
                if (road[i] == 'x')
                { 
                    consecutiveHoles++; 
                }
                else
                {
                    if(consecutiveHoles > 0)
                    {
                        potHoles.Add(consecutiveHoles);
                    }

                    consecutiveHoles=0;
                }
            }

            if (consecutiveHoles > 0)
                potHoles.Add(consecutiveHoles);

            potHoles.Sort((x, y) => y.CompareTo(x));

            int count = 0;
            foreach (int holes in potHoles)
            {
                if(holes + 1 >= budget)
                {
                    count += budget - 1;
                    return count;
                }
                else
                {
                    budget -= holes + 1;
                    count += holes;
                }
            }

            return count;
        }
    }
}

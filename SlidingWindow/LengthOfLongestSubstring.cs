using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlidingWindow
{
    internal class LengthOfLongestSubstring
    {
        public int LengthOfSubstring(string s)
        { 
            HashSet<char> charSet = new HashSet<char>();

            int lp = 0;

            int result = 0;

            for (int rp = 0; rp < s.Length; rp++)
            {
                while (charSet.Contains(s[rp]))
                {
                    charSet.Remove(s[lp]);
                    lp++;
                }

                charSet.Add(s[rp]);

                result = Math.Max(result, rp - lp + 1);
            }

            return result;
        }

        public int LengthOfLongestStringReplacement(string s, int k)
        {
            int result = 0;

            return result;

        }



    }
}

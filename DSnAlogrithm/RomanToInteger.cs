using System;   
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSnAlogrithm
{
    internal class RomanToInteger
    {
        public static int RomanToInt(string s)
        {
            var romanMap = new Dictionary<char, int> {
                { 'I', 1 },
                { 'V',5 },
                { 'X',10 },
                { 'L',50 },
                { 'C',100 },
                { 'D',500 },
                { 'M',1000 }
            };


            int res = 0;
            for (int idx = 0; idx < s.Length; idx++)
            {
                if (idx + 1 < s.Length && romanMap[s[idx]] < romanMap[s[idx + 1]])
                {
                    res -= romanMap[s[idx]];
                }
                else
                {
                    res += romanMap[s[idx]];
                }
            }

            return res;


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSnAlogrithm
{
    internal class GroupAnagrams
    {
        public List<List<string>> GroupAnagramsI(string[] strs)
        {

            Dictionary<string,List<string>> anagramDict = new Dictionary<string,List<string>>();

            foreach (string s in strs)
            {
                var count = new int[26];

                foreach(char ch in s)
                {
                    count[ch - 'a']++;
                }

                string key = string.Join(",", count);

                if(!anagramDict.ContainsKey(key))
                {
                    anagramDict[key] = new List<string>();
                }

                anagramDict[key].Add(s);

            }

            return new List<List<string>>(anagramDict.Values);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public bool IsAnagram(string s, string t)
        {
            if(s.Length != t.Length)
                return false;

            var asciiCount = new int[26];

            for (int i = 0; i < s.Length; i++)
            {
                asciiCount[s[i] - 'a']++;
                asciiCount[t[i] - 'a']--;
            }

            foreach (int n in asciiCount)
            { 
                if(n != 0)
                    return false;
            }

            return true;


        }
    }
}

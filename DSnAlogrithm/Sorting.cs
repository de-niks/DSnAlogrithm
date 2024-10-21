using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSnAlogrithm
{
    internal class Sorting
    {

        public void FindIfDuplicates(int[] array)
        { 
           HashSet<int> set = new HashSet<int>();
            bool hasDuplicate = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (set.Contains(array[i]))
                { 
                    hasDuplicate = true;
                    break;
                }

                set.Add(array[i]);

            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public bool IsValidAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;


            bool result = true;
            Dictionary<char , int> sdict = new Dictionary<char , int>();
            Dictionary<char, int> tdict = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (!sdict.ContainsKey(s[i]))
                    sdict.Add(s[i], 1);
                else
                    sdict[s[i]]++;


                if (!tdict.ContainsKey(t[i]))
                    tdict.Add(t[i], 1);

                else tdict[t[i]]++;

            }

            for (int i = 0; i < s.Length; i++)
            {
                if (sdict.ContainsKey(s[i]) && tdict.ContainsKey(s[i]))
                {
                    if (sdict[s[i]] != tdict[s[i]])
                        result = false;

                }
                else result = false;
            }


            return result;


        }

       

        public List<List<string>> GroupAnagrams(string[] strs)
        {
            var anagramDict = new Dictionary<string, List<string>>();

            foreach (string s in strs)
            {
                var count = new int[26];

                foreach (var c in s)
                {
                    count[c - 'a']++;
                }

                var key = string.Join(',', count);
                
                if(!anagramDict.ContainsKey(key))
                {
                    anagramDict[key] = new List<string>();
                }

                anagramDict[key].Add(s);

            }
           

            return new List<List<string>>(anagramDict.Values);

        }

        public bool IsPalindromicString(string s)
        { 
            int lp = 0;
            int rp = s.Length - 1;

            while (lp < rp)
            {
                if (!char.IsLetterOrDigit(s[lp]))
                    lp++;
                else if (!char.IsLetterOrDigit(s[rp]))
                    rp++;
                else
                {
                    if (char.ToLower(s[lp]) != char.ToLower(s[rp]))
                    {
                        return false;
                    }
                    lp++; rp--;
                }
            }

            return true;
        
        }


    }


}

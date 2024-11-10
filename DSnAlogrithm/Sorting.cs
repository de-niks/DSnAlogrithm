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
            Dictionary<char, int> sdict = new Dictionary<char, int>();
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

                if (!anagramDict.ContainsKey(key))
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public bool IsPalindromeNumber(int x)
        {
            string s = x.ToString();
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

        public bool IsPalindromeNumberII(int x)
        {

            if (x < 0)
            {
                return false;
            }

            int rem;
            int sum = 0;
            int temp = x;

            while (x > 0)
            {
                rem = x % 10;
                sum = sum * 10 + (rem);
                x = x / 10;
            }
            return (sum == temp);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string LongestPalindromeI(string s)
        {
            string result = string.Empty;
            int resultLength = 0;

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i; j < s.Length; j++)
                {
                    int lp = i;
                    int rp = j;

                    while (lp < rp && s[lp] == s[rp])
                    {
                        lp++;
                        rp--;
                    }


                    if(lp >= rp && resultLength < (j - i + 1))
                    {
                        result = s.Substring(i, j - i + 1);
                        resultLength = j - i + 1;
                    }

                }
            }

            return result;
        }


        public string LargestPalindromic(string num)
        {
            string result = string.Empty;

            Dictionary<int, int> digit_counts = new Dictionary<int, int>();

            foreach (char symb in num)
            {
                int number = symb - '0';

                if (digit_counts.ContainsKey(number))
                {
                    digit_counts[number]++;
                }
                else
                {
                    digit_counts[number] = 1;
                }
            }

            StringBuilder firstHalf = new StringBuilder();

            int center = -1;


            for (int i = 9; i > -1; i--)
            {
                if (digit_counts.ContainsKey(i))
                {
                    int frequency = digit_counts[i];

                    if (frequency >= 2)
                    {
                        for (int j = 0; j < frequency / 2; j++)
                        {
                            firstHalf.Append(i);
                        }
                    }


                    if (frequency % 2 != 0)
                    {
                        center = Math.Max(center, i);
                    }
                }

            }

            string finalString = firstHalf.ToString().TrimStart('0');
            string centerString = center == -1 ? "" : center.ToString();

            result = finalString + centerString  + new string(finalString.Reverse().ToArray());

            return result;

        }

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSnAlogrithm
{
    internal class ValidParantheses
    {
        public bool IsValid(string s)
        {
            while (s.Contains("()") || s.Contains("{}") || s.Contains("[]"))
            {
                s = s.Replace("()", "");
                s = s.Replace("{}", "");
                s = s.Replace("[]", "");

            }

            return s == "";
        }

        public bool IsValidI(string s)
        {
            Stack<char> charStack = new Stack<char>();
            Dictionary<char,char> keyValuePairs = new Dictionary<char, char> 
            {
                { '}','{'},
                { ')','('},
                { ']','['},
            };

            foreach (char ch in s)
            {
                if (keyValuePairs.ContainsKey(ch))
                {
                    if (charStack.Count > 0 && charStack.Peek() == keyValuePairs[ch])
                    {
                        charStack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                { 
                    charStack.Push(ch);
                }
            }

            return charStack.Count == 0;

        }
    }
}

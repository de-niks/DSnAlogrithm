using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSnAlogrithm
{
    internal class IntegerToRoman
    {
        public string IntToRoman(int num)
        {
            var romanDict = new Dictionary<int, string>
            {
                { 1000, "M" },
                { 900, "CM" },
                { 500, "D" },
                { 400, "CD" },
                { 100, "C" },
                { 90, "XC" },
                { 50, "L" },
                { 40, "XL" },
                { 10, "X" },
                { 9, "IX" },
                { 5, "V" },
                { 4, "IV" },
                { 1, "I" }
            };
            
            StringBuilder  sb = new StringBuilder();

            foreach (var symbol in romanDict)
            {
                if (num / symbol.Key != 0)
                {
                    var count = num / symbol.Key;

                    for (var i = 0; i < count; i++)
                    {
                        sb.Append(symbol.Value);
                    }

                    num %= symbol.Key;
                }

            }

            return sb.ToString();
        }
    }
}

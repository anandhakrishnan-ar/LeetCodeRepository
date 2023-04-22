using System;
using System.Collections.Generic;

namespace LongestCommonPrefix
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> prefix = new List<char>();
            string LongestCommonPrefix(string[] strs)
            {
                for (int i = 0; i < strs[0].Length; i++)
                {
                    for (int j = 0; j < strs.Length; j++)
                    {
                        if (strs[j].Length - 1 < i || strs[j][i] != strs[0][i])
                        {
                            return new string(prefix.ToArray());
                        }
                    }
                    prefix.Add(strs[0][i]);
                }
                return new string(prefix.ToArray());
            }
            string[] str = { "abb", "a", "ab" };
            Console.WriteLine(LongestCommonPrefix(str));
        }
    }
}

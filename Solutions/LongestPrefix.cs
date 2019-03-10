using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    class LongestPrefix
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0)
            {
                return "";
            }
            if (strs.Length == 1)
            {
                return strs[0];
            }
            var firstWord = strs[0];
            var prefix = string.Empty;
            var done = false;
            for (var i = 1; i < strs.Length; i++)
            {
                if (done || strs[i].Length == 0)
                {
                    prefix = string.Empty;
                    break;
                }
                var length = 0;
                if (string.IsNullOrEmpty(prefix))
                {
                    if (firstWord.Length < strs[i].Length)
                    {
                        length = firstWord.Length;
                    }
                    else
                    {
                        length = strs[i].Length;
                    }

                    for (var j = 0; j < length; j++)
                    {
                        if (firstWord[j].Equals(strs[i][j]))
                        {
                            prefix += firstWord[j];
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (string.IsNullOrEmpty(prefix))
                    {
                        done = true;
                    }
                }
                else
                {
                    if (strs[i].Length < prefix.Length)
                    {
                        length = strs[i].Length;
                    }
                    else
                    {
                        length = prefix.Length;
                    }
                    prefix = prefix.Substring(0, length);
                    for (var j = 0; j < length; j++)
                    {
                        if (!prefix[j].Equals(strs[i][j]))
                        {
                            prefix = prefix.Substring(0, j);
                            break;
                        }
                    }
                }
            }
            return prefix;
        }
    }
}


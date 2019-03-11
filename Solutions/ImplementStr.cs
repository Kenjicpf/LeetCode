using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class ImplementStr
    {
        public int StrStr(string haystack, string needle)
        {
            if(string.IsNullOrEmpty(needle))
            {
                return 0;
            }
            if(haystack.Length == 0 ||  needle.Length > haystack.Length)
            {
                return -1;
            }

            for(var i = 0; i <= haystack.Length - needle.Length; i++)
            {
                int j = 0;

                for(; j <needle.Length; j++)
                {
                    if (!haystack[i + j].Equals(needle[j]))
                    {
                        break;
                    }
                }
                if (j.Equals(needle.Length))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}

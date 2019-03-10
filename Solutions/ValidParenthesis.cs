using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class ValidParenthesis
    {
        public bool IsValid(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return true;
            }
            else if (s.Length == 1)
            {
                return false;
            }
            Dictionary<char, char> dic = getDic();
            Stack<char> stackChar = new Stack<char>();
            while (s.Length > 0)
            {
                if (!dic.ContainsKey(s[0]))
                {
                    if (stackChar.Count == 0)
                    {
                        return false;
                    }
                    if (dic[stackChar.Peek()].Equals(s[0])) {
                        s = s.Substring(1);
                        stackChar.Pop();
                    }else
                    {
                        return false;
                    }
                }
                else
                {
                    stackChar.Push(s[0]);
                    s = s.Substring(1);
                }
            }
            if (stackChar.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private Dictionary<char, char> getDic()
        {
            var dic = new Dictionary<char, char>();
            dic.Add('{', '}');
            dic.Add('[', ']');
            dic.Add('(', ')');

            return dic;
        }
    }
}

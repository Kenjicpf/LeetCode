
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class RemoveElement
    {
        public int RemoveElem(int[] nums, int val)
        {
            var cur = nums.Length - 1;
            if (nums.Contains(val))
            {
                for(var i = 0; i <= cur; i++)
                {
                    if (nums[i].Equals(val))
                    {
                        while (nums[i].Equals(nums[cur]))
                        {
                            cur--;
                            if(cur < i)
                            {
                                cur = i;
                                break;
                            }
                        }
                        if (!nums[i].Equals(nums[cur]))
                        {
                            nums[i] = nums[cur];
                            cur--;
                        }                     
                    }
                    if (i.Equals(cur))
                    {
                        if (!nums[i].Equals(val))
                        {
                            cur++;
                            break;
                        }
                    }
                }
                return nums.Take(cur).ToArray().Length;
            }
            return nums.Length;
        }
    }
}

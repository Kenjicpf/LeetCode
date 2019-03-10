using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class RemoveDuplicateSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            var  cur = 1;
            for(var i = 0; i < nums.Length; i++)
            {
                if(nums[i] > nums[i - 1])
                {
                    nums[cur] = nums[i];
                    cur++;
                }
            }
            return nums.Take(cur).ToArray().Length;
        }
    }
}

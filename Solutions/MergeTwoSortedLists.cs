using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    class MergeTwoSortedLists
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if(l1 == null)
            {
                return l2;
            }
            if(l2 == null)
            {
                return l1;
            }
            ListNode cur;
            if(l1.val < l2.val)
            {
                cur = l1;
                cur.next = MergeTwoLists(l1.next, l2);
            }
            else
            {
                cur = l2;
                cur.next = MergeTwoLists(l1, l2.next);
            }
            return cur;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
  }
}

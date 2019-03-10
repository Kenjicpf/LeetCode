using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new RemoveElement();
            Console.WriteLine(test.RemoveElem(new int[] { 4,5}, 5));
            Console.ReadLine();
        }
    }
}

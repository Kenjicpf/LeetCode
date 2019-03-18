using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class FindPrimeNumber
    {
        public int FindLastPrimeNumber(int n)
        {
            var primes = new List<int>();
            var number = 1;
            while (primes.Count < n)
            {
                if (number.Equals(2))
                {
                    primes.Add(number);
                    number++;
                }
                else if (number % 2 == 0)
                {
                    number++;
                }
                else
                {
                    if (primes.Count == 0)
                    {
                        number++;
                    }
                    var add = true;
                    for (var j = 0; j < primes.Count; j++)
                    {
                        if (number % primes[j] == 0)
                        {
                            number++;
                            add = false;
                            break;
                        }
                    }
                    if (add)
                    {
                        primes.Add(number);
                        number++;
                        add = false;
                    }
                }

            }

            return primes.Last();
        }
    }
}
